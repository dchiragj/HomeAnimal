import * as React from "react";
import "./styles.css";
import { getOwnerList } from "../../services/ownersService";
import ShowStatisticsModal from "../../components/ShowStatisticsModal";
import { Owner } from "../../model/owner";

interface IState {
    ownersList: Owner[];
    selectedOwnerIds: string[];
    showStatisticsBtn: boolean;
}

export default class Owners extends React.Component<any, IState> {
    constructor(props: any) {
        super(props);
        this.state = {
            ownersList: [],
            selectedOwnerIds: [],
            showStatisticsBtn: false,
        };
    }

    componentDidMount() {
        this.loadData();
    }

    loadData = async () => {
        const result: Owner[] = await getOwnerList();
        if (result) {
            const ownersList = result.map((item: any) => ({ ...item, checked: false }))
            this.setState({ ownersList });
        }
    };

    onClickOwner = (id: string) => {
        this.props.history.push(`/owner/details/${id}`)
    }

    onSelectOwner = (index: number): any => {
        let { ownersList = [], selectedOwnerIds } = this.state;
        ownersList[index].checked = !ownersList[index].checked;
        selectedOwnerIds = ownersList.filter((x: any) => x.checked).map((x: any) => x.id)
        const showStatisticsBtn = selectedOwnerIds.length > 0
        this.setState({ selectedOwnerIds, showStatisticsBtn })
    };

    render() {
        const { ownersList, showStatisticsBtn, selectedOwnerIds } = this.state;
        return (
            <div className="mainWrapper">
                <div className="backdrop"></div>
                <div className="container-fluid ">
                    <div className="row">
                        <div className="col-sm-12 col-md-12 col-lg-3"></div>
                        <div className="col-sm-12 col-md-12 col-lg-6 mt-3">
                            <div className="jumbotron">
                                <h1 className="display-4">Pets Owners</h1>
                                <p className="lead">
                                    List
                </p>
                                <hr className="my-4" />
                                <ul className="list-group list-group-flush border rounded">
                                    {ownersList && ownersList.map((item: any, index: number) => {
                                        return (
                                            <li className="list-group-item d-flex justify-content-between pointer" key={String(item.id)} onClick={() => { this.onClickOwner(String(item.id)) }}>
                                                <h5>{item.name}</h5>
                                                <label className="labelContainer mb-0" onClick={(e) => { e.stopPropagation() }}>
                                                    <input
                                                        type="checkbox"
                                                        value={item.id}
                                                        onChange={() => {
                                                            this.onSelectOwner(index);
                                                        }}
                                                    />
                                                    <span className="checkmark"></span>
                                                </label>
                                            </li>
                                        );
                                    })}
                                </ul>
                                {showStatisticsBtn && (
                                    <ShowStatisticsModal selectedOwnerIds={selectedOwnerIds} ownersList={ownersList} />
                                )}
                            </div>
                        </div>
                        <div className="col-sm-12 col-md-12 col-lg-3"></div>
                    </div>
                </div>
            </div>
        );
    }
}
