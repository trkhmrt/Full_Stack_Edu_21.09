import React, {useEffect} from 'react';
import {BasketService} from "../services/BasketService.js";

const CheckOut = () => {

    useEffect(() => {


        const getCheckout = async () => {
            const response = await BasketService.checkoutBasket(1)
            console.log(response);
        }

        getCheckout()

    }, []);

    return (
        <div>
            <h1>CHECKOUT SAYFASI</h1>
        </div>
    );
};

export default CheckOut;