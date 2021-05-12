import { combineReducers, createStore, applyMiddleware } from 'redux'
import thunk from 'redux-thunk';

import managersReducers from './reducers/deals-reducer'

export const rootReducer = combineReducers({
    managers: managersReducers,
})

const store = createStore(
    rootReducer,
    applyMiddleware(thunk)
    )

export default store