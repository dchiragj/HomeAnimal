import * as React from "react";
import "./styles.css";
import data from "./data.json";
import ShowStatisticsModal from "../../Modal/ShowStatistics";
import { Link } from "react-router-dom";
import Detail from "../Detail";
import axios from "axios";

interface IState {
    ownerDetail: any;
    selectedOwnerIds: Array<string>;
    showStatisticsBtn: boolean;
}

export default class Owners extends React.Component<any, IState> {
    constructor(props: any) {
        super(props);
        this.state = {
            ownerDetail: [],
            selectedOwnerIds: [],
            showStatisticsBtn: false,
        };
    }

    componentDidMount() {
        this.loadData();
    }

    loadData = async () => {
        const result = await axios.get('/owner/GetAllOwners')
        if (result) {
            console.log('result', result)
            this.setState({ ownerDetail: result.data });
        }
    };

    onSelectOwner = (id: string): any => {
        const { ownerDetail = [], selectedOwnerIds } = this.state;
        ownerDetail.forEach((item: any) => {
            if (item.id === id && item.checked) {
                item.checked = false;
                const ownersId = selectedOwnerIds;
                const index = ownersId.indexOf(id);
                selectedOwnerIds.splice(index, 1);
            } else if (item.id === id) {
                item.checked = true;
                selectedOwnerIds.push(id);
            }
        });
        this.setState({ showStatisticsBtn: selectedOwnerIds.length > 0 });
    };

    render() {
        const { ownerDetail, showStatisticsBtn, selectedOwnerIds } = this.state;
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
                                    {ownerDetail.map((item: any) => {
                                        return (
                                            <li className="list-group-item d-flex justify-content-between" key={item.id}>
                                                <Link
                                                    to={`/details?id=${item.id}`}
                                                >
                                                    {item.name}
                                                </Link>
                                                <label className="labelContainer mb-0">
                                                    <input
                                                        type="checkbox"
                                                        value={item.id}
                                                        onChange={() => {
                                                            this.onSelectOwner(String(item.id));
                                                        }}
                                                    />
                                                    <span className="checkmark"></span>
                                                </label>
                                            </li>
                                        );
                                    })}
                                </ul>
                                {showStatisticsBtn && (
                                    <ShowStatisticsModal selectedOwnerIds={selectedOwnerIds} ownerDetail={ownerDetail} />
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
