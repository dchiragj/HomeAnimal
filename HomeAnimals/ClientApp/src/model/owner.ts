export interface Cat {
  id: string;
  name: string;
  noOfFeeding: number;
  dob: Date;
  age: number;
  catchingMouses: boolean;
  breed: string;
  characteristics: string;
  medicalCondition: string;
  vaccination: boolean;
  gender: string;
  colour: string;
}

export interface Dog {
  id: string;
  name: string;
  noOfFeeding: number;
  dob: Date;
  age: number;
  levelOfTraining: number;
  supposedHeight: string;
  breed: string;
  characteristics: string;
  medicalCondition: string;
  vaccination: boolean;
  gender: string;
  colour: string;
}

export interface OwnerPets {
  cats: Cat[];
  dogs: Dog[];
}

export interface Owner {
  id: string;
  name: string;
  dob: Date;
  age: number;
  address: string;
  phone: string;
  noOfPets: number;
  pets: OwnerPets;
  // only visibility variables
  checked?: boolean;
}
