export const MANAGERS_LOADED = 'managers/loaded';

export const loadManagers = () => async (dispatch) => {
    fetch('http://localhost:5000/managers')
        .then(res => res.json())
        .then(managers => dispatch({
            type: MANAGERS_LOADED,
            payload: managers
        }))
}