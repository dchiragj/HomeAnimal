import axios from "axios";
import * as React from "react";
import ListSection from "./ListSection";
import "./styles.css";

const temp: any = [
  {
    id: "3",
    name: "Owner 3",
    dob: "2-1-2000",
    age: 21,
    address: "Tokyo",
    phone: "253-881-504",
    noOfPets: 6,
    pets: {
      cats: [
        {
          id: "7",
          name: "cat 1",
          noOfFeeding: 3,
          dob: "5-4-2015",
          age: 17,
          levelOfTraining: 2,
          catchingMouses: true,
          breed: "xyz",
          characteristics: "brown-big",
          medicalCondition: "xyz",
          vaccination: false,
          gender: "Female",
          colour: "black",
        },
        {
          id: "8",
          name: "cat 2",
          noOfFeeding: 3,
          dob: "5-4-2015",
          age: 3,
          levelOfTraining: 2,
          catchingMouses: true,
          breed: "xyz",
          characteristics: "brown-big",
          medicalCondition: "xyz",
          vaccination: false,
          gender: "Female",
          colour: "black",
        },
      ],
      dogs: [
        {
          id: "9",
          name: "dog1",
          noOfFeeding: 1,
          dob: "7-5-2012",
          age: 4,
          levelOfTraining: 5,
          supposedHeight: "5cm",
          breed: "xyz",
          characteristics: "brown-big",
          medicalCondition: "xyz",
          vaccination: false,
          gender: "Female",
          colour: "black",
        },
        {
          id: "10",
          name: "dog1",
          noOfFeeding: 1,
          dob: "7-5-2012",
          age: 17,
          levelOfTraining: 5,
          supposedHeight: "5cm",
          breed: "xyz",
          characteristics: "brown-big",
          medicalCondition: "xyz",
          vaccination: false,
          gender: "Female",
          colour: "black",
        },
        {
          id: "11",
          name: "dog1",
          noOfFeeding: 1,
          dob: "7-5-2012",
          age: 11,
          levelOfTraining: 5,
          supposedHeight: "5cm",
          breed: "xyz",
          characteristics: "brown-big",
          medicalCondition: "xyz",
          vaccination: false,
          gender: "Female",
          colour: "black",
        },
        {
          id: "12",
          name: "dog1",
          noOfFeeding: 1,
          dob: "7-5-2012",
          age: 1,
          levelOfTraining: 5,
          supposedHeight: "5cm",
          breed: "xyz",
          characteristics: "brown-big",
          medicalCondition: "xyz",
          vaccination: false,
          gender: "Female",
          colour: "black",
        },
      ],
    },
    gender: "Male",
  },
];

// interface IProps {
//   // item: Array<string>;
//   // ownerDetail: Array<any>;
// }
interface IState {
  tab: number;
  temp: any;
}

export default class Detail extends React.Component<any, IState> {
  constructor(props: any) {
    super(props);
    this.state = {
      tab: 1,
      temp: temp[0],
    };
  }

    componentDidMount() {
        this.loadData();
    }

    loadData = async () => {
        const result = await axios.get('/owner/GetOwnersById?id=8fd45212-21c1-4bfe-9b4b-b65bf00b06c1')
        if (result) {
            console.log('result-detail', result)
            this.setState({ temp: result})
        }
    }

  feedPet = async(pet: any, animal: string) => {
    if (animal === "cat") {
      this.state.temp.pets.cats.forEach((item: any) => {
        item.id === pet.id && (item.noOfFeeding += 1);
      });
    } else if (animal === "dog") {
      this.state.temp.pets.dogs.forEach((item: any) => {
        item.id === pet.id && (item.noOfFeeding += 1);
      });
    }
   //   const result = await axios.post('/owner/UpdateCatNoOfFeeding', pet)
    //  if (result) {
     //     console.log('result', result)
    //  }
    this.forceUpdate();
    // this.setState({});
  };

  render() {
    const { tab, temp } = this.state;
    return (
      <div className="bg-dark p-2 p-md-3 p-lg-4" style={{ minHeight: "100%" }}>
        <div className="card ownerAndPets">
          <div className="card-header">
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
                  <ListSection keyName="Name" value={temp.name} />
                  <ListSection keyName="Date of birth" value={temp.dob} />
                  <ListSection keyName="Age" value={temp.age} />
                  <ListSection keyName="Address" value={temp.address} />
                  <ListSection keyName="Phone" value={temp.phone} />
                  <ListSection keyName="Number of Pets" value={temp.noOfPets} />
                </div>
              </>
            ) : (
              <div className="petsDetailsWrapper">
                <div className="row ml-0 mr-0 p-1">
                  <div className="col-sm-12 col-lg-6 col-md-12">
                    <h5>{temp.pets.cats.length} Cats</h5>
                    <div className="petsInfoWrapper">
                      {temp.pets.cats.map((cat: any) => {
                        return (
                          <div className="card my-3 border border-dark" key={cat.id}>
                            <div className="card-body p-0">
                              <ListSection keyName="Name" value={cat.name} />
                              <ListSection keyName="Number of Feedings" value={cat.noOfFeeding} />
                              <ListSection keyName="Date of Birth" value={cat.dob} />
                              <ListSection keyName="Age" value="2 Years 5 Months 4 Days" />
                              <ListSection keyName="Catching Mouses" value={String(cat.catchingMouses)} />
                              <ListSection keyName="Breed" value={cat.breed} />
                              <ListSection keyName="Characteristics" value={cat.characteristics} />
                              <ListSection keyName="Medical Condition" value={cat.medicalCondition} />
                              <ListSection keyName="Vaccination" value={String(cat.vaccination)} />
                              <ListSection keyName="Gender" value={cat.gender} />
                              <ListSection keyName="Colour" value={cat.colour} />
                            </div>
                            <div className="card-footer">
                              <button
                                className="btn btn-primary btn-lg btn-block"
                                onClick={() => {
                                  this.feedPet(cat, "cat");
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
                    <h5>{temp?.pets?.dogs.length} Dogs</h5>
                    <div className="petsInfoWrapper">
                      {temp.pets.dogs.map((dog: any) => {
                        return (
                          <div className="card my-3 border border-dark" key={dog.id}>
                            <div className="card-body">
                              <ListSection keyName="Name" value={dog.name} />
                              <ListSection keyName="Number of Feedings" value={dog.noOfFeeding} />
                              <ListSection keyName="Date of Birth" value={dog.dob} />
                              <ListSection keyName="Age" value="2 Years 5 Months 4 Days" />
                              <ListSection keyName="Level of Training" value={dog.levelOfTraining} />
                              <ListSection keyName="Supposed Height" value={dog.supposedHeight} />
                              <ListSection keyName="Breed" value={dog.breed} />
                              <ListSection keyName="Characteristics" value={dog.characteristics} />
                              <ListSection keyName="Medical Condition" value={dog.medicalCondition} />
                              <ListSection keyName="Vaccination" value={String(dog.vaccination)} />
                              <ListSection keyName="Gender" value={dog.gender} />
                              <ListSection keyName="Colour" value={dog.colour} />
                            </div>
                            <div className="card-footer">
                              <button
                                className="btn btn-primary btn-lg btn-block"
                                onClick={() => {
                                  this.feedPet(dog, "dog");
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
