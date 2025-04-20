import React from 'react';
import {useLocation} from "react-router-dom";

const Basket = () => {
    const {state} = useLocation()
    return (
        <div>
            <h1>Burası Sepet</h1>
            <p>{state.renk}</p>
            <p>{state.fiyat}</p>
        </div>
    );
};

export default Basket;