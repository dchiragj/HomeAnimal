import * as React from "react";
import { DATE_FORMAT, getOwnerById, getYMDFromDays, updateOwnersPetFeeding } from "../../services/ownersService";
import DetailItem from "./DetailItem";
import "./styles.css";
import { Owner } from "../../model/owner";
import moment from 'moment'

// const ownerDetail: any = [
//   {
//     id: "3",
//     name: "Owner 3",
//     dob: "2-1-2000",
//     age: 21,
//     address: "Tokyo",
//     phone: "253-881-504",
//     noOfPets: 6,
//     pets: {
//       cats: [
//         {
//           id: "7",
//           name: "cat 1",
//           noOfFeeding: 3,
//           dob: "5-4-2015",
//           age: 17,
//           levelOfTraining: 2,
//           catchingMouses: true,
//           breed: "xyz",
//           characteristics: "brown-big",
//           medicalCondition: "xyz",
//           vaccination: false,
//           gender: "Female",
//           colour: "black",
//         },
//         {
//           id: "8",
//           name: "cat 2",
//           noOfFeeding: 3,
//           dob: "5-4-2015",
//           age: 3,
//           levelOfTraining: 2,
//           catchingMouses: true,
//           breed: "xyz",
//           characteristics: "brown-big",
//           medicalCondition: "xyz",
//           vaccination: false,
//           gender: "Female",
//           colour: "black",
//         },
//       ],
//       dogs: [
//         {
//           id: "9",
//           name: "dog1",
//           noOfFeeding: 1,
//           dob: "7-5-2012",
//           age: 4,
//           levelOfTraining: 5,
//           supposedHeight: "5cm",
//           breed: "xyz",
//           characteristics: "brown-big",
//           medicalCondition: "xyz",
//           vaccination: false,
//           gender: "Female",
//           colour: "black",
//         },
//         {
//           id: "10",
//           name: "dog1",
//           noOfFeeding: 1,
//           dob: "7-5-2012",
//           age: 17,
//           levelOfTraining: 5,
//           supposedHeight: "5cm",
//           breed: "xyz",
//           characteristics: "brown-big",
//           medicalCondition: "xyz",
//           vaccination: false,
//           gender: "Female",
//           colour: "black",
//         },
//         {
//           id: "11",
//           name: "dog1",
//           noOfFeeding: 1,
//           dob: "7-5-2012",
//           age: 11,
//           levelOfTraining: 5,
//           supposedHeight: "5cm",
//           breed: "xyz",
//           characteristics: "brown-big",
//           medicalCondition: "xyz",
//           vaccination: false,
//           gender: "Female",
//           colour: "black",
//         },
//         {
//           id: "12",
//           name: "dog1",
//           noOfFeeding: 1,
//           dob: "7-5-2012",
//           age: 1,
//           levelOfTraining: 5,
//           supposedHeight: "5cm",
//           breed: "xyz",
//           characteristics: "brown-big",
//           medicalCondition: "xyz",
//           vaccination: false,
//           gender: "Female",
//           colour: "black",
//         },
//       ],
//     },
//     gender: "Male",
//   },
// ];

// interface IProps {
//   // item: Array<string>;
//   // ownerDetail: Array<any>;
// }
interface IState {
    tab: number;
    ownerDetail: Owner;
}

export default class Detail extends React.Component<any, IState> {
    constructor(props: any) {
        super(props);
        this.state = {
            tab: 1,
            ownerDetail: {} as Owner
        };
    }

    componentDidMount() {
        this.loadData();
    }

    loadData = async () => {
        const id = this.props.match.params.id;
        const result = await getOwnerById(id);
        if (result) {
            this.setState({ ownerDetail: result })
        }
    }

    updatePetFeeding = async (pet: any, type: string) => {
        const feedObj = {
            petId: pet.id,
            type
        }
        const result = await updateOwnersPetFeeding(feedObj)
        if (result) {
            this.setState({ ownerDetail: result })
        }
    };

    goBack = () => {
        this.props.history.goBack()
    }

    render() {
        const { tab, ownerDetail } = this.state;
        if (!ownerDetail) return <div>Loading...</div>
        return (
            <div className="bg-dark p-2 p-md-3 p-lg-4" style={{ minHeight: "100%" }}>

                <div className="card ownerAndPets">
                    <div className="card-header">
                        <div onClick={this.goBack} className="text-right"><a className="text-right btn btn-primary">{'Back'}</a></div>
                        <ul className="nav nav-tabs card-header-tabs">
                            <li
                                className="nav-item"
                                onClick={() => {
                                    this.setState({ tab: 1 });
                                }}
                            >
                                <span className={tab === 1 ? "active nav-link" : "nav-link"} role="button">
                                    Owner
                </span>
                            </li>
                            <li
                                className="nav-item"
                                onClick={() => {
                                    this.setState({ tab: 2 });
                                }}
                            >
                                <span className={tab === 2 ? "active nav-link" : "nav-link"} role="button">
                                    Pets
                </span>
                            </li>
                        </ul>
                    </div>
                    <div className="card-body p-0 p-lg-3 bodyWrapper">
                        {tab === 1 ? (
                            <>
                                <h5 className="card-title mb-4">Owner Detail</h5>
                                <div className="ownerInfoWrapper">
                                    <DetailItem label="Name" value={ownerDetail.name} />
                                    <DetailItem label="Date of birth" value={moment(ownerDetail.dob).format(DATE_FORMAT)} />
                                    <DetailItem label="Age" value={getYMDFromDays(ownerDetail.age)} />
                                    <DetailItem label="Address" value={ownerDetail.address} />
                                    <DetailItem label="Phone" value={ownerDetail.phone} />
                                    <DetailItem label="Number of Pets" value={ownerDetail.noOfPets} />
                                </div>
                            </>
                        ) : (
                            <div className="petsDetailsWrapper">
                                <div className="row ml-0 mr-0 p-1">
                                    <div className="col-sm-12 col-lg-6 col-md-12">
                                        <h5>{ownerDetail.pets.cats.length} Cats</h5>
                                        <div className="petsInfoWrapper">
                                            {ownerDetail.pets.cats.map((cat: any) => {
                                                return (
                                                    <div className="card my-3 border border-dark" key={cat.id}>
                                                        <div className="card-body p-0">
                                                            <DetailItem label="Name" value={cat.name} />
                                                            <DetailItem label="Number of Feedings" value={cat.noOfFeeding} />
                                                            <DetailItem label="Date of Birth" value={moment(cat.dob).format(DATE_FORMAT)} />
                                                            <DetailItem label="Age" value={getYMDFromDays(cat.age)} />
                                                            <DetailItem label="Catching Mouses" value={String(cat.catchingMouses)} />
                                                            <DetailItem label="Breed" value={cat.breed} />
                                                            <DetailItem label="Characteristics" value={cat.characteristics} />
                                                            <DetailItem label="Medical Condition" value={cat.medicalCondition} />
                                                            <DetailItem label="Vaccination" value={String(cat.vaccination)} />
                                                            <DetailItem label="Gender" value={cat.gender} />
                                                            <DetailItem label="Colour" value={cat.colour} />
                                                        </div>
                                                        <div className="card-footer">
                                                            <button
                                                                className="btn btn-primary btn-lg btn-block"
                                                                onClick={() => {
                                                                    this.updatePetFeeding(cat, "cat");
                                                                }}
                                                            >
                                                                Feed Cat
                              </button>
                                                        </div>
                                                    </div>
                                                );
                                            })}
                                        </div>
                                    </div>
                                    <div className="col-sm-12 col-lg-6 col-md-12">
                                        <h5>{ownerDetail?.pets?.dogs.length} Dogs</h5>
                                        <div className="petsInfoWrapper">
                                            {ownerDetail.pets.dogs.map((dog: any) => {
                                                return (
                                                    <div className="card my-3 border border-dark" key={dog.id}>
                                                        <div className="card-body">
                                                            <DetailItem label="Name" value={dog.name} />
                                                            <DetailItem label="Number of Feedings" value={dog.noOfFeeding} />
                                                            <DetailItem label="Date of Birth" value={moment(dog.dob).format(DATE_FORMAT)} />
                                                            <DetailItem label="Age" value={getYMDFromDays(dog.age)} />
                                                            <DetailItem label="Level of Training" value={dog.levelOfTraining} />
                                                            <DetailItem label="Supposed Height" value={dog.supposedHeight} />
                                                            <DetailItem label="Breed" value={dog.breed} />
                                                            <DetailItem label="Characteristics" value={dog.characteristics} />
                                                            <DetailItem label="Medical Condition" value={dog.medicalCondition} />
                                                            <DetailItem label="Vaccination" value={String(dog.vaccination)} />
                                                            <DetailItem label="Gender" value={dog.gender} />
                                                            <DetailItem label="Colour" value={dog.colour} />
                                                        </div>
                                                        <div className="card-footer">
                                                            <button
                                                                className="btn btn-primary btn-lg btn-block"
                                                                onClick={() => {
                                                                    this.updatePetFeeding(dog, "dog");
                                                                }}
                                                            >
                                                                Feed Dog
                              </button>
                                                        </div>
                                                    </div>
                                                );
                                            })}
                                        </div>
                                    </div>
                                </div>
                            </div>
                        )}
                    </div>
                </div>
            </div>
        );
    }
}
