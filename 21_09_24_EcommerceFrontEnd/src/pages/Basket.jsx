import React, {useEffect, useState} from 'react';
import {BasketService} from "../services/BasketService.js";
import products from "./Products.jsx";
import {useNavigate} from "react-router-dom";

const Basket = () => {
    const [basketDetails, setBasketDetails] = useState([]);
    const [basketId, setBasketId] = useState(0)
    const navigate = useNavigate();

    useEffect(() => {


        const getBasket = async () => {
            const response = await BasketService.getBasketByCustomerId(1)
            setBasketDetails(response.data.basketDetails)
            setBasketId(response.data.basketId)
            console.log(response.data);
        }
        getBasket()

    }, []);

    const handlePrepareBasketForCheckout = async () => {

        const response = await BasketService.approveBasket(basketId)
        navigate('/CheckOut')
    }



    return (
        <div>
            <h1>Basket</h1>
            <p>BasketId: {basketId}</p>
            <div className="flex flex-col space-y-10">
            {basketDetails.map((product,index)=>(
                <div key={index} className="rounded border bg-red-500 w-fit color-black p-10">
                    <h1>{product.productName}</h1>
                    <p>{product.productDescription}</p>
                    <p>{product.basketQuantity}</p>
                    <p>{product.productPrice}</p>
                    <p>{product.subCategoryName}</p>
                </div>
            ))}
                <button onClick={handlePrepareBasketForCheckout} className="cursor-pointer">Ödemeye Geç</button>
            </div>

        </div>
    );
};

export default Basket;