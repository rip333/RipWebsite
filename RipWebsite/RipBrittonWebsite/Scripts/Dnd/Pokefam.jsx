class Pokefam extends React.Component {
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
        //window.setInterval(() => this.loadFromServer(), this.props.pollInterval);
    }

    getModifier(abilityType, abilityTypeHeader) {
        if (abilityTypeHeader.Double[abilityType] != null) {
            return "2";
        }
        if (abilityTypeHeader.Half[abilityType] != null) {
            return "1/2";
        }
        if (abilityTypeHeader.Zero[abilityType] != null) {
            return "0";
        }
        return "";
    }

    abilityTypeCells(abilityTypeRow) {
        const abilityTypesCells = this.state.data.map(abilityType => (
            <td key={abilityType.Type + "Cell"}>{
                this.getModifier(abilityType.Type, abilityTypeRow)
            }</td>
        ));
        return abilityTypesCells;
    }

    render() {
        const abilityTypesHeader = this.state.data.map(abilityType => (
            <th key={abilityType.Type + "ColHeader"}>
                {abilityType.Type}
            </th>
        ));

        const abilityTypesRows = this.state.data.map(abilityType => (
            <tr key={abilityType.Type + "Row"}>
                <th key={abilityType.Type + "RowHeader"}>{abilityType.Type}</th>
                {this.abilityTypeCells(abilityType)}
            </tr>
        ));
        return (
            <div className="pokefam" id="pokefam">
                <h1>Pokefam</h1>
                <table>
                    <tbody>
                        <tr>
                        <th></th>
                            {abilityTypesHeader}
                        </tr>
                        {abilityTypesRows}
                   </tbody>
                </table>
            </div>
        );
    }
}

ReactDOM.render(
    <Pokefam url="/Dnd/AbilityTypes" pollInterval = {10000} />,
    document.getElementById('content')
);