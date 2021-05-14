import { configureStore, getDefaultMiddleware } from '@reduxjs/toolkit';

import managersReducer  from './managerTollkit';
import carsReducer from './carToolkit';

const ext = window.__REDUX_DEVTOOLS_EXTENSION__;

const devtoolMiddleware =
  ext && process.env.NODE_ENV === 'development' ? ext() : f => f;

const middleware = getDefaultMiddleware({
  thunk: true,
  devtoolMiddleware
})

const store = configureStore({
  reducer: {
    managers: managersReducer,
    cars: carsReducer
  },
  middleware
})
export default store