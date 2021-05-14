import React, { useEffect, useState } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { fetchTopManager } from '../store/dealToolkit';

export default function TopManager() {
    const dispatch = useDispatch();
    useEffect(() => {
        dispatch(fetchTopManager())
    }, [])
    const count = useSelector(state => state.topManagerData.countDeals)
    const topManager = useSelector(state => state.topManagerData.topManager)
    return (
        <div>
            <h1>Топ менеджер</h1>
            <p>
                <span>{topManager.first_name} {topManager.surname} {topManager.last_name}</span>
                <br/>
                <span> [{count}] угод  за весь час </span>
                <br/>
                <span>з/п {topManager.salary} -  + (4 000грн бонуси)</span>
                <br/>
            </p>
        </div>
    )
}
