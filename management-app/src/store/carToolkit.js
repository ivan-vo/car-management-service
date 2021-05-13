import { createAction, createReducer } from '@reduxjs/toolkit';
import axios from 'axios';

export const CARS_LOADED = 'cars/loaded';

const initialState = [];

export const loadCars = createAction(CARS_LOADED);

export const carsReducer = createReducer(initialState, {
    [loadCars] : (state, action) => (
        state = action.payload
    )
})

export function fetchCars() {
    return (dispatch) => {
        axios.get('http://localhost:5000/cars')
        .then(res => {dispatch(loadCars(res.data))})
    }
}
