import React, {useEffect, useState} from 'react';
import {BasketService} from "../services/BasketService.js";
import products from "./Products.jsx";
import {taxes} from "../constants/taxes.js";
import {useNavigate} from "react-router-dom";

const Basket = () => {
    const [basketDetails, setBasketDetails] = useState([]);
    const [subTotal , setSubTotal] = useState(0);
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

    useEffect(() => {
        setSubTotal(basketDetails.reduce((TotalBasketPrice,basketProduct)=>TotalBasketPrice+basketProduct.basketQuantity * basketProduct.productPrice,0));
    },[basketDetails])

    const handlePrepareBasketForCheckout = async () => {
        navigate('/CheckOut')
    }

    const handleRemoveProductFromBasket = async (basketDetailId) => {
        await BasketService.removeProductFromBasket(basketDetailId)
        updateBasketDetailsList(basketDetailId)

    }

    const handleIncreaseQuantity = async (basketDetailId) => {
        await BasketService.increaseQuantity(basketDetailId)
        setBasketDetails(basketDetails.map((bd)=> bd.basketDetailId == basketDetailId ? {...bd,basketQuantity:bd.basketQuantity + 1}  : bd ))
    }

    const handleDecreaseQuantity = async (basketDetailId) => {
        await BasketService.decreaseQuantity(basketDetailId)
        setBasketDetails(basketDetails.map((bd)=> bd.basketDetailId == basketDetailId ? {...bd,basketQuantity:bd.basketQuantity -1}  : bd ).filter((product)=>product.basketQuantity > 0))
    }


    const updateBasketDetailsList=(basketDetailId)=>{
        const newBasketDetails = basketDetails.filter((basketDetail) => basketDetail.basketDetailId != basketDetailId)
        setBasketDetails(newBasketDetails)
    }


    return (
        <div>
            <h1>Basket</h1>
            <p>BasketId: {basketId}</p>
            <h1>ARA TOPLAM: {subTotal}₺</h1>
            <h1>KDV: {taxes.KDV}₺</h1>
            <h1>TOPLAM:{taxes.KDV + subTotal}</h1>
            <div className="flex flex-col space-y-10">
            {basketDetails.map((product,index)=>(
                <div key={index} className="rounded border bg-red-500 w-fit color-black p-10">
                    <h1>{product.productName}</h1>
                    <p>{product.productDescription}</p>
                    <p>{product.basketQuantity}</p>
                    <p>{product.productPrice}</p>
                    <p>{product.subCategoryName}</p>
                    <button className="hover:cursor-pointer border rounded-2xl p-4 hover:bg-white hover:text-black" onClick={()=>handleRemoveProductFromBasket(product.basketDetailId)}>Sil</button>
                    <button className="hover:cursor-pointer border rounded-2xl p-4 hover:bg-white hover:text-black" onClick={()=>handleIncreaseQuantity(product.basketDetailId)}>+</button>
                    <button className="hover:cursor-pointer border rounded-2xl p-4 hover:bg-white hover:text-black" onClick={()=>handleDecreaseQuantity(product.basketDetailId)}>-</button>
                </div>
            ))}
                <button onClick={handlePrepareBasketForCheckout} className="cursor-pointer">Ödemeye Geç</button>
            </div>

        </div>
    );
};

export default Basket;