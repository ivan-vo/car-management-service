export const MANAGERS_LOADED = 'managers/loaded';
export const CARS_LOADED = 'cars/loaded'

export const loadManagers = () => async (dispatch) => {
    fetch('http://localhost:5000/managers')
        .then(res => res.json())
        .then(managers => dispatch({
            type: MANAGERS_LOADED,
            payload: {
                managers
            }
        }))
}
export const loadCars = () => async (dispatch) => {
    fetch('http://localhost:5000/cars')
        .then(res => res.json())
        .then(cars => dispatch({
            type: CARS_LOADED,
            payload: {
                cars
            }
        }))
}