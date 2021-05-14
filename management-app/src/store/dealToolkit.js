import axios from "axios";
import { createSlice } from "@reduxjs/toolkit";

export const fetchCreateDeal = (values) => dispatch => {
    axios.post('http://localhost:5000/deals',{
        date: values.date,
        managerId: values.manager,
        carId: values.car
    })    
}
export const fetchTopManager = () => (dispatch) => {
    axios.get('http://localhost:5000/managers/top-manager')
    .then(res => {dispatch(loadTopManager(res.data))});
}
const dealsSlice = createSlice({
    name: 'deals',
    initialState: {
        topManager: {
            id: 0,
            first_name: '',
            surname: '',
            last_name: '',
            date_recruitment: '',
            sales: 0,
            salary: 0,
            deals: null
          },
        countDeals:0
    },
    reducers: {
        loadTopManager: (state, action) => action.payload,
    }
})
export default dealsSlice.reducer;
export const { loadTopManager } = dealsSlice.actions;

