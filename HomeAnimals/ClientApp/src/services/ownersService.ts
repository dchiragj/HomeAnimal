import axios from "axios";
import { Owner } from "../model/owner";
import moment from 'moment';

export const DATE_FORMAT = 'MM-DD-YYYY';

/**
 * @desc Get Owners List
 * @param {*}
 */
export const getOwnerList = async () => {
  try {
    const response: any = await axios.get(`/owner/GetAllOwners`);
    const data: Owner[] = response.data;
    return data;
  } catch (e) {
    throw e;
  } finally {
  }
};

/**
 * @desc Get Owner by id
 * @param {*}
 */
export const getOwnerById = async (id: string) => {
  try {
    const params = { id };
    const response: any = await axios.get(`/owner/GetOwnersById`, { params });
    const data: Owner = response.data;
    return data;
  } catch (e) {
    throw e;
  } finally {
  }
};

/**
 * @desc Update Owner Pets Feeding
 * @param {*}
 */
export const updateOwnersPetFeeding = async (obj: any) => {
  try {
      const response: any = await axios.post(`/owner/UpdateNoOfFeeding`, obj);
    const data = response.data;
    return data;
  } catch (e) {
    throw e;
  } finally {
  }
};


export const getYMDFromDays = (d: number) => {
    if (!d) return '';

    let duration = moment.duration(d, 'd');
    let years = duration.years();
    let months = duration.months();
    let days = duration.days();
    const YMD = String(years).padStart(2) + " years " + String(months).padStart(1) + " months " + String(days).padStart(1) + " days";
    return YMD;
}

export const getYearsFromDays = (d: number) => {
    if (!d) return 0;

    let duration = moment.duration(d, 'd');
    return duration.years()
}