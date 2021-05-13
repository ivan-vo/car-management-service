import { configureStore } from '@reduxjs/toolkit';

import { combineReducers, createStore, applyMiddleware, compose } from 'redux'
import thunk from 'redux-thunk';

import { managersReducer,carsReducer } from './reducers/deals-reducer';

const ext = window.__REDUX_DEVTOOLS_EXTENSION__;

const devtoolMiddleware = 
  ext && process.env.NODE_ENV === 'development' ? ext() : f => f;

export const rootReducer = combineReducers({
    managers: managersReducer,
    cars: carsReducer
})

const store = createStore(
    rootReducer,
    compose(applyMiddleware(thunk),devtoolMiddleware)
    )
export default store