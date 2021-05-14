import axios from 'axios';
import { createSlice } from "@reduxjs/toolkit";

export function fetchManagers() {
    return (dispatch) => {
        axios.get('http://localhost:5000/managers')
        .then(res => {dispatch(loadManagers(res.data))})
    }
}

const toolkitManagersSlice = createSlice({
    name: 'managers',
    initialState: {
        managersList : []
    },
    reducers: {
        loadManagers(state,action) {
            state.managersList = action.payload;
        }
    }
})
export default toolkitManagersSlice.reducer;
export const { loadManagers } = toolkitManagersSlice.actions;