import React from 'react'
import { useEffect } from 'react';
import { useState } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { loadManagers } from '../store/actions/deals-actions';

export default function DealsForm() {
    const onSubmitHandler = (event) => {
        event.preventDefault();
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
    }, [])
    const dispatch = useDispatch();
    const managers = useSelector(state => state.managers);
    console.log(managers);
    const date = useTextField("","date");
    return (
        <div>
            <form onSubmit={onSubmitHandler}>
                <select name="manager">
                    <option selected value="s1">Іван</option>
                    <option value="s2">Степан</option>
                    <option value="s3">Макс</option>
                    <option value="s4">Толя</option>
                </select>
                <select name="car">
                    <option selected value="s1">BMV</option>
                    <option value="s2">Nissan</option>
                    <option value="s3">Mersedes</option>
                    <option value="s4">Opel</option>
                </select>
                <input {...date} type="date" placeholder="2021, 2, 20" />
                <button type="submit">Add new deal</button>
            </form>
        </div>
    )
}
