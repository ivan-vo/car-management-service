import React from 'react'
import { useEffect } from 'react';
import { useState } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { fetchManagers } from '../store/managerTollkit';
import { fetchCars } from '../store/carToolkit';
import { fetchCreateDeal } from '../store/dealToolkit';
const useForm = (...fields) => ({
    reset:(value) => fields.forEach(f => f.reset(value)),
    getValues: () => fields.reduce((init, field) => ({...init, [field.name]:field.value}),{}),
})

export default function DealsForm() {
    const dispatch = useDispatch();

    useEffect(() => {
        dispatch(fetchManagers())
        dispatch(fetchCars())
    }, [])

    function sendForm() {
        dispatch(fetchCreateDeal(form.getValues()));
        form.reset(0);
    }
    function checkFields() {
        if(date.value != 0 && selectedManager.value != 0 && slectedCar.value != 0){
            return true;
        }
        else{
            return false;
        }
    }
    function useTextField(init, name) {
        const [value, setValue] = useState(init);
        return {
            value,
            name: name,
            onChange: (event) => setValue(event.target.value),
            reset: (value) => setValue(value)
        }
    }
    const onSubmitHandler = (event) => {
        event.preventDefault();
        checkFields() && sendForm();
    }
    const managers = useSelector(state => state.managers);
    const cars = useSelector(state => state.cars);

    const selectedManager = useTextField(0, "manager")
    const slectedCar = useTextField(0, "car")
    const date = useTextField(0,"date");

    const form = useForm(selectedManager,slectedCar,date);

    return (
        <div>
            <h1>Реєстрація продажу</h1>
            <form onSubmit={onSubmitHandler}>
                <select { ...selectedManager }>
                <option value={0}>-- Оберіть менеджера</option>
                    {
                        managers && managers.map(manager => 
                        <option key={manager.id} value={manager.id}>
                            {manager.first_name} {manager.surname}
                        </option>
                        )
                    }
                </select>
                <select {...slectedCar}>
                <option value={0}>-- Оберіть авто</option>
                    {
                        cars && cars.map(car => 
                        <option key={car.id} value={car.id}>
                            {car.brand} {car.model} [{car.color}]
                        </option>)
                    }
                </select>
                <input {...date} type="date" placeholder="2021, 2, 20" />
                <button type="submit">Зареєструвати продаж</button>
            </form>
        </div>
    )
}
