import * as React from "react";
import { Owner } from "../../model/owner";
import "./styles.css";
import { getYearsFromDays } from '../../services/ownersService'

interface IProps {
    selectedOwnerIds: string[];
    ownersList: Owner[];
}
export default class ShowStatisticsModal extends React.Component<IProps, any> {
    constructor(props: IProps) {
        super(props)
        this.state = {}
    }

    totalPets = (): any => {
        const { ownersList = [] } = this.props;
        return ownersList.reduce((sum: number, item: Owner) => sum + Number(item.noOfPets), 0);
    };

    calculateAvgNoOfAnimals = (): any => {
        const { ownersList = [] } = this.props;
        const total_pets = this.totalPets();
        return Math.round(total_pets / ownersList.length);
    };

    getSelectedOwnersData = (): any => {
        const { ownersList = [], selectedOwnerIds = [] } = this.props;
        return ownersList.filter((o1: any) =>
            selectedOwnerIds.some((o2: string) => o1.id === o2)
        );
    };

    calculateAvgAgeOfSelectedOwnersAnimals = (): any => {
        const selectedOwners = this.getSelectedOwnersData();

        // * Extract pets array from selected owners data
        const selectedOwnersPets = selectedOwners?.map((item: Owner) => {
            return item.pets;
        });

        let cats: any[] = [];
        let dogs: any[] = [];
        let catsAndDogs = [cats, dogs];

        // * separate arrays for cats and dogs
        selectedOwnersPets.forEach((pet: any) => {
            cats.push(pet.cats);
            dogs.push(pet.dogs);
        });

        // * Calculation of age of selected owners pets
        return Math.round(
            catsAndDogs
                .flat(2)
                .map((age: any) => getYearsFromDays(age.age))
                .reduce((a, b) => a + b) / catsAndDogs.flat(2).length
        );
    };

    render() {
        const petsNo = this.totalPets();
        const average_no_of_animals = this.calculateAvgNoOfAnimals();
        const average_age_selected_owners_animals = this.calculateAvgAgeOfSelectedOwnersAnimals();
        return (
            <div className="mt-2">
                <button className="btn btn-primary btn-lg btn-block" data-toggle="modal" data-target="#statisticsModal">
                    Show Statistics
        </button>
                <div
                    className="modal fade"
                    id="statisticsModal" // tabindex="-1"
                    aria-labelledby="statisticsModalLabel"
                    aria-hidden="true"
                    data-backdrop="static"
                >
                    <div className="modal-dialog modal-dialog-centered">
                        <div className="modal-content">
                            <div className="modal-header">
                                <h5 className="modal-title" id="statisticsModalLabel">
                                    Statistics
                </h5>
                                <button type="button" className="close" data-dismiss="modal" aria-label="Close">
                                    <span aria-hidden="true">&times;</span>
                                </button>
                            </div>
                            <div className="modal-body p-2">
                                <ul className="list-group list-group-flush">
                                    <li className="list-group-item d-flex justify-content-between align-items-center">
                                        Number of All owners
                    <span className="badge badge-primary badge-pill">{this.props?.ownersList?.length}</span>
                                    </li>
                                    <li className="list-group-item d-flex justify-content-between align-items-center">
                                        Number of All Pets
                    <span className="badge badge-primary badge-pill">{petsNo}</span>
                                    </li>
                                    <li className="list-group-item d-flex justify-content-between align-items-center">
                                        Average Number of Animals per owner
                    <span className="badge badge-primary badge-pill">{average_no_of_animals}</span>
                                    </li>
                                    <li className="list-group-item d-flex justify-content-between align-items-center">
                                        Average age of selected owners Animals
                    <span className="badge badge-primary badge-pill">{average_age_selected_owners_animals}</span>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}
