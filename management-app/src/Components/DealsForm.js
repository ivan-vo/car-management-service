import React from 'react'
import { useEffect } from 'react';
import { useState } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { loadCars, loadManagers } from '../store/actions/deals-actions';
import store from '../store/store';

export default function DealsForm() {
    const onSubmitHandler = (event) => {
        event.preventDefault();
        console.log(manager.value)
    }

    function useTextField(init, name) {
        const [value, setValue] = useState(init);
        return {
            value,
            name: name,
            onChange: (event) => setValue(event.target.value),
        }
    }
    useEffect(() => {
        dispatch(loadManagers())
        dispatch(loadCars())
    }, [])
    const dispatch = useDispatch();
    const managers = useSelector(state => state.tables.managers);
    const cars = useSelector(state => state.tables.cars);
    console.log(store.getState());
    const date = useTextField("","date");
    const manager = useTextField("", "manager")
    return (
        <div>
            <form onSubmit={onSubmitHandler} {...manager}>
                <select value='0'>
                    <option >Оберіть менеджера</option>
                    {
                        managers && managers.map(manager => <option key={manager.id} value={manager.id}>{manager.first_name} {manager.surname}</option>)
                    }
                </select>
                <select name="car">
                    <option selected value="s1">Оберіть продану машину</option>
                    {
                        cars && cars.map(car => <option key={car.id} value={car.id}>{car.brand} {car.model} {car.color}</option>)
                    }
                </select>
                <input {...date} type="date" placeholder="2021, 2, 20" />
                <button type="submit">Add new deal</button>
            </form>
        </div>
    )
}
