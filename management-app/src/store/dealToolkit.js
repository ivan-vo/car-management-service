import axios from "axios"

export const createDeal = (date, manager, car) => dispatch => {
    fetch(`http://localhost:5000/deals`, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json;charset=utf-8'
        },
        body: JSON.stringify({date, managerId: manager, carId: car})
    })
}
export const fetchCreateDeal = (values) => dispatch => {
    axios.post('http://localhost:5000/deals',{
        date: values.date,
        managerId: values.manager,
        carId: values.car
    })    
}