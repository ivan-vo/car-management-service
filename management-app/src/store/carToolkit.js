import { createSlice } from '@reduxjs/toolkit';
import axios from 'axios';

export function fetchCars() {
    return (dispatch) => {
        axios.get('http://localhost:5000/cars')
        .then(res => {dispatch(loadCars(res.data))})
    }
}
const carsSlice = createSlice({
    name:'carsSlice',
    initialState:{
        carsList:[]
    },
    reducers:{
        loadCars(state,action){
            state.carsList = action.payload
        }
    }
})
export default carsSlice.reducer;
export const { loadCars } = carsSlice.actions;