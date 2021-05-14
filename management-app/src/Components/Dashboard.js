import React from 'react'
import { NavLink } from 'react-router-dom'

export default function Dashboard() {
    return (
        <nav>
            <ul>
                <li><NavLink to="/deals/created">Зареєструвати продаж</NavLink>  </li>
                <li><NavLink to="/menegers">Топ-менеджер</NavLink> </li>
            </ul>
        </nav>
    )
}
