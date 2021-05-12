export const MANAGERS_LOADED = 'managers/loaded';
export const CARS_LOADED = 'cars/loaded';

export const loadManagers = () => async (dispatch) => {
    fetch('http://localhost:5000/cars')
        .then(res => res.json())
        .then(cars => dispatch({
            type: MANAGERS_LOADED,
            payload: {
                cars
            }
        }))
}