import React from 'react';
import {Link} from "react-router-dom";
import {RouteAddress} from "../routes/Routes.js";

const HomePage = () => {
    return (
        <div>
            <h1>HOME PAGE</h1>
            <ul className="space-y-6">
                <li>
                    <Link to={RouteAddress.Basket}>BASKET</Link>
                </li>
                <li>
                    <Link to={RouteAddress.Products}>Products</Link>
                </li>
                <li>
                    MY PROFILE
                    <ul className="ml-10">
                        <li>
                            <Link to={RouteAddress.MyProfile}>MyProfile</Link>
                        </li>
                        <li>
                            <Link to={RouteAddress.Orders}>Orders</Link>
                        </li>
                        <li>
                            <Link to={RouteAddress.Orders}>Ready for Payment Basket</Link>
                        </li>
                    </ul>

                </li>
            </ul>

        </div>
    );
};

export default HomePage;