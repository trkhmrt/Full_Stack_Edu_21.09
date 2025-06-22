import React from 'react';
import {Link, useNavigate} from "react-router-dom";
import {RouteAddress} from "../routes/Routes.js";
import Navbar from "../components/Navbar.jsx";
import ProductArea from "../components/ProductArea.jsx";
import Hero from "../components/Hero.jsx";
import Stats from "../components/Stats.jsx";
import PopulerProducts from "../components/PopulerProducts.jsx";

const HomePage = () => {
    const navigate = useNavigate();
    const handleLogout = () => {
        localStorage.clear()
        navigate('/login')
    }

    return (
        <>
        <div className="text-black">

            <Hero/>
            <PopulerProducts/>
            <ProductArea/>
            <Stats/>


        </div>
        </>
    );
};

export default HomePage;