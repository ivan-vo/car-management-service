import { combineReducers } from 'redux'
import { MANAGERS_LOADED } from '../actions/deals-actions'

function managersReducer(state = {}, action) {
    switch (action.type) {
        case MANAGERS_LOADED:
            return action.payload.managers.reduce((o, l) => ({...o, [l.idList] : l.countNotDoneTask}), {})
        default:
            return state;
    }
}

export default combineReducers({
    managers: managersReducer
})