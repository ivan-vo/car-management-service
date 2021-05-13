import React from 'react'
import { useEffect } from 'react';
import { useState } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { fetchManagers } from '../store/managerTollkit';
import { fetchCars } from '../store/carToolkit';
import { fetchCreateDeal } from '../store/dealToolkit';

export default function DealsForm() {
    const onSubmitHandler = (event) => {
        event.preventDefault();
        dispatch(fetchCreateDeal(date.value,selectedManager.value,slectedCar.value))
    }

    function useTextField(init, name) {
        const [value, setValue] = useState(init);
        return {
            value,
            name: name,
            onChange: (event) => setValue(event.target.value),
        }
    }
    const dispatch = useDispatch();

    useEffect(() => {
        dispatch(fetchManagers())
        dispatch(fetchCars())
    }, [])

    const managers = useSelector(state => state.managers);
    const cars = useSelector(state => state.cars);

    const selectedManager = useTextField("", "manager")
    const slectedCar = useTextField("", "car")

    const date = useTextField("","date");
    return (
        <div>
            <h1>Реєстрація продажу</h1>
            <form onSubmit={onSubmitHandler}>
                <select { ...selectedManager }>
                <option>-- Оберіть менеджера</option>
                    {
                        managers && managers.map(manager => 
                        <option key={manager.id} value={manager.id}>
                            {manager.first_name} {manager.surname}
                        </option>
                        )
                    }
                </select>
                <select {...slectedCar}>
                <option>-- Оберіть авто</option>
                    {
                        cars && cars.map(car => 
                        <option key={car.id} value={car.id}>
                            {car.brand} {car.model} [{car.color}]
                        </option>)
                    }
                </select>
                <input {...date} type="date" placeholder="2021, 2, 20" />
                <button type="submit">Add new deal</button>
            </form>
        </div>
    )
}
