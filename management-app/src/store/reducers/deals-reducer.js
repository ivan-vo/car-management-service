import { combineReducers } from 'redux'
import { CARS_LOADED, MANAGERS_LOADED } from '../actions/deals-actions'

export function managersReducer(state = [], action) {
    switch (action.type) {
        case MANAGERS_LOADED:
            return action.payload
        default:
            return state;
    }
}
export function carsReducer(state = [], action) {
    switch (action.type) {
        case CARS_LOADED:
            return action.payload
        default:
            return state;
    }
}