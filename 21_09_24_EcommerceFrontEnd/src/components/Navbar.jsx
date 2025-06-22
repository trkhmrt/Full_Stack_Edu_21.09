import React, {useState} from 'react';
import {Link} from "react-router-dom";
import {RouteAddress} from "../routes/Routes.js";

const Navbar = () => {

    const [isProfilMenuOpen, setIsProfilMenuOpen] = useState(false);
    const [burgerMenuisOpen, setBurgerMenuisOpen] = useState(false);
    return (
        <nav className="bg-white shadow-md sticky top-0 z-10 ">
            <div className="max-w-7xl mx-auto px-4 flex items-center justify-between h-20">
                {/*LOGO*/}
                <div>
                    <Link to="/">
                        <span
                            className="text-2xl font-bold text-emerald-500 hover:text-emerald-700 transition-colors duration-500">ECOMMERCE</span>
                    </Link>
                </div>
                {/*ARAMA ÇUBUĞU*/}
                <div className="md:flex md:items-center md:justify-center md:flex-1">
                    <div className="relative w-full max-w-lg text-black">
                        <input
                            type="text"
                            placeholder="Ürün ara..."
                            className="w-full pl-10 pr-4 py-2 rounded-full border border-gray-300"
                        />
                        <div className="absolute left-3 top-2.5">
                            <svg className="h-5 w-5 text-gray-400" fill="none" stroke="currentColor"
                                 viewBox="0 0 24 24">
                                <path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2"
                                      d="M21 21l-6-6m2-5a7 7 0 11-14 0 7 7 0 0114 0z"/>
                            </svg>
                        </div>
                    </div>
                    <div>

                    </div>
                </div>
                {/*MENU*/}
                <div className="items-center space-x-4 hidden md:flex">

                    <Link to={RouteAddress.Basket} className="text-black rounded-full hover:text-emerald-500">
                        {/*SEPET*/}
                        <div className="relative">
                            <svg className="h-8 w-8" fill="none" stroke="currentColor" viewBox="0 0 24 24">
                                <path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2"
                                      d="M16 11V7a4 4 0 00-8 0v4M5 9h14l1 12H4L5 9z"/>
                            </svg>
                            <span
                                className="absolute  -top-2 -right-1  px-2 py-1 text-white items-center justify-center text-xs leading-none  transform rounded-full bg-red-500">
                                    1
                                </span>
                        </div>
                    </Link>
                    {/*PROFIL*/}

                    <div className="relative text-black hover:cursor-pointer"
                         onClick={() => setIsProfilMenuOpen(!isProfilMenuOpen)} onMouseLeave={() => setIsProfilMenuOpen(false)}>
                        <div className="hover:text-emerald-500">
                            <svg className="h-8 w-8" fill="none" stroke="currentColor" viewBox="0 0 24 24">
                                <path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2"
                                      d="M16 7a4 4 0 11-8 0 4 4 0 018 0zM12 14a7 7 0 00-7 7h14a7 7 0 00-7-7z"/>
                            </svg>
                        </div>
                        {isProfilMenuOpen && (
                            <div
                                className="absolute -right-10  bg-white shadow-lg flex flex-col items-center justify-center p-10 space-y-3 rounded-xl">
                                <Link to="/Orders" className="hover:text-orange-500">Orders</Link>
                                <Link to="" className="hover:text-blue-500">Setting</Link>
                                <Link to="" className="hover:text-red-600">Logout</Link>
                            </div>
                        )}

                    </div>

                </div>
                <div className="md:hidden cursor-pointer realtive"
                     onClick={() => setBurgerMenuisOpen(!burgerMenuisOpen)}>
                    {burgerMenuisOpen ? (
                        <>
                            <img width="40" height="40" src="https://img.icons8.com/ios/50/close-window--v2.png"
                                 alt="close-window--v2"/>

                        <div className="absolute top-20 left-0 right-0  flex flex-col  items-center justify-center text-black bg-white max-w-7xl shadow-xl rounded-b-xl space-y-4">
                            <Link to="/" className="hover:text-orange-500">Home</Link>
                            <Link to="/Orders" className="hover:text-orange-500">Orders</Link>
                            <Link to="/" className="hover:text-orange-500">Settings</Link>
                            <Link to="/" className="hover:text-orange-500">Logout</Link>
                        </div>
                        </>
                        )
                        :
                        (
                        <svg xmlns="http://www.w3.org/2000/svg" x="0px" y="0px" width="40" height="40"
                        viewBox="0 0 48 48">
                        <path
                        d="M 5.5 9 A 1.50015 1.50015 0 1 0 5.5 12 L 42.5 12 A 1.50015 1.50015 0 1 0 42.5 9 L 5.5 9 z M 5.5 22.5 A 1.50015 1.50015 0 1 0 5.5 25.5 L 42.5 25.5 A 1.50015 1.50015 0 1 0 42.5 22.5 L 5.5 22.5 z M 5.5 36 A 1.50015 1.50015 0 1 0 5.5 39 L 42.5 39 A 1.50015 1.50015 0 1 0 42.5 36 L 5.5 36 z"></path>
                        </svg>
                        )
                    }

                </div>
            </div>
        </nav>
    );
};

export default Navbar;