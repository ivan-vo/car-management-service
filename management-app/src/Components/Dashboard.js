import React from 'react'
import { NavLink } from 'react-router-dom'

export default function Dashboard() {
    return (
        <nav>
            <ul>
                <li><NavLink to="/cars">Cars</NavLink>  </li>
                <li><NavLink to="/menegers">Menegers</NavLink> </li>
            </ul>
        </nav>
    )
}
