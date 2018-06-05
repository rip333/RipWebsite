class TypeChart extends React.Component {
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

    getModifier(abilityType, abilityTypeRow) {
        if (abilityTypeRow.Double.indexOf(abilityType) > -1) {
            return <td class="double type-cell" key={abilityType + "Cell"}>2</td>;
        }
        if (abilityTypeRow.Half.indexOf(abilityType) > -1) {
            return <td class="half type-cell" key={abilityType + "Cell"}>1/2</td>;
        }
        if (abilityTypeRow.Zero.indexOf(abilityType) > -1) {
            return <td class="zero type-cell" key={abilityType + "Cell"}>0</td>;
        }
        return <td class="type-cell" key={abilityType + "Cell"}></td>;
    }

    abilityTypeCells(abilityTypeRow) {
        const abilityTypesCells = this.state.data.map(abilityType => (
             this.getModifier(abilityType.Type, abilityTypeRow)
        ));
        return abilityTypesCells;
    }

    typeChart() {
        const abilityTypesHeader = this.state.data.map(abilityType => (
            <th class={abilityType.Type+"-style"} key={abilityType.Type + "ColHeader"}>
                {abilityType.Type}
            </th>
        ));

        const abilityTypesRows = this.state.data.map(abilityType => (
            <tr key={abilityType.Type + "Row"}>
                <th class={abilityType.Type + "-style"} key={abilityType.Type + "RowHeader"}>{abilityType.Type}</th>
                {this.abilityTypeCells(abilityType)}
            </tr>
        ));
        return (
            <table id="typechart-table">
                <tbody>
                    <tr>
                        <th></th>
                        {abilityTypesHeader}
                    </tr>
                    {abilityTypesRows}
                </tbody>
            </table>
            );
    }

    render() {
        return (
            <div className="typechart" id="typechart">
                <div class="react-header">Type Chart</div>
                {this.typeChart()}
            </div>
        );
    }
}

ReactDOM.render(
    <TypeChart url="/Dnd/AbilityTypes" pollInterval={10000} />,
    document.getElementById('typechart-content')
);