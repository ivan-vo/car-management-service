import { combineReducers } from 'redux'
import { CARS_LOADED, MANAGERS_LOADED } from '../actions/deals-actions'

function managersReducer(state = [], action) {
    switch (action.type) {
        case MANAGERS_LOADED:
            return [ ...action.payload.managers] 
        default:
            return state;
    }
}
function carsReducer(state = [], action) {
    switch (action.type) {
        case CARS_LOADED:
            return [ ...action.payload.cars] 
        default:
            return state;
    }
}

export default combineReducers({
    managers: managersReducer,
    cars: carsReducer
})