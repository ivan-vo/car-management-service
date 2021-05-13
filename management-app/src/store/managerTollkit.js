import { createAction, createReducer } from '@reduxjs/toolkit';
import axios from 'axios';

export const MANAGERS_LOADED = 'managers/loaded';

const initialState = [];

export const loadManagers = createAction(MANAGERS_LOADED);

export const managerReducer = createReducer(initialState, {
    [loadManagers] : (state, action) => (
        state = action.payload
    )
})

export function fetchManagers() {
    return (dispatch) => {
        axios.get('http://localhost:5000/managers')
        .then(res => {dispatch(loadManagers(res.data))})
    }
}
