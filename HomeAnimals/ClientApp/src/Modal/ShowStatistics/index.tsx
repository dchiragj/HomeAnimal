import * as React from "react";
import "./styles.css";

interface IProps {
    selectedOwnerIds: Array<string>;
    ownerDetail: Array<any>;
}
export default class ShowStatisticsModal extends React.Component<IProps, any> {
    noOfPets = (): any => {
        return this.props?.ownerDetail?.reduce((a, b) => a + Number(b.noOfPets), 0)
    };

    avgNoOfAnimals = (): any => {
        return Math.round(this.noOfPets() / this.props?.ownerDetail?.length);
    };

    selectedOwnersData = (): any => {
        return this.props.ownerDetail.filter((o1: any) =>
            this.props.selectedOwnerIds.some((o2: string) => o1.id === o2)
        );
    };

    avgAgeOfSelectedOwnersAnimals = (): any => {
        // * Extract pets array from selected owners data
        const pets = this.selectedOwnersData()?.map((petsAry: any) => {
            return petsAry.pets;
        });

        var cats: object[] = [];
        var dogs: object[] = [];
        var catsAndDogs = [cats, dogs];

        // * separate arrays for cats and dogs
        pets.forEach((pet: any) => {
            cats.push(pet.cats);
            dogs.push(pet.dogs);
        });

        // * Calculation of age of selected owners pets
        return Math.round(
            catsAndDogs
                .flat(2)
                .map((age: any) => age.age)
                .reduce((a, b) => a + b) / catsAndDogs.flat(2).length
        );
    };

    render() {
        const petsNo = this.noOfPets();
        const average_no_of_animals = this.avgNoOfAnimals();
        const average_age_selected_owners_animals = this.avgAgeOfSelectedOwnersAnimals();
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
                    <span className="badge badge-primary badge-pill">{this.props?.ownerDetail?.length}</span>
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
