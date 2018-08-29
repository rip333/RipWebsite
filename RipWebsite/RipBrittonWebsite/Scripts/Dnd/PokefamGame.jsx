class PokefamGame extends React.Component {
    constructor(props) {
        super(props);
        this.state = { data: [] };
    }

    loadFromServer() {
        const xhr = new XMLHttpRequest();
        xhr.open('get', this.props.url, true);
        xhr.onload = () => {
            const data = JSON.parse(xhr.responseText);
            this.setState({ data: data });
        };
        xhr.send();
    }
    componentDidMount() {
        this.loadFromServer();
        let right = document.getElementById('right-col');
        let left = document.getElementById('left-col');

        dragula([right, left]);
        //window.setInterval(() => this.loadFromServer(), this.props.pollInterval);
    }

    getCellAt(cellId) {
        return (
            <div className="pk-cell">{cellId}</div>
            );
    }

    render() {
        return (
            <div className="pokefam-game" id="typechart">
                <div id="pokefam-game-table" className="pk-container">
                    <div className="pk-col" id="left-col">
                        {this.getCellAt(1)}    
                        {this.getCellAt(2)}    
                        {this.getCellAt(3)}
                        {this.getCellAt(4)}
                    </div>
                    <div className="pk-col" id="right-col">
                        {this.getCellAt(5)}
                        {this.getCellAt(6)}
                        {this.getCellAt(7)}
                        {this.getCellAt(8)}
                    </div>
                  </div>
            </div>
        );
    }
}

ReactDOM.render(
    <PokefamGame url="/Dnd/AbilityTypes" pollInterval={10000} />,
    document.getElementById('pokefam-game-content')
);