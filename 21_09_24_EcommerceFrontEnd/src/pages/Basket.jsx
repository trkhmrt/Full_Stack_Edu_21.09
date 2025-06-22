import React, {useEffect, useState} from 'react';
import {BasketService} from "../services/BasketService.js";
import products from "./Products.jsx";
import {taxes} from "../constants/taxes.js";
import {useNavigate} from "react-router-dom";
import {RouteAddress} from "../routes/Routes.js";

const Basket = () => {
    const [basketDetails, setBasketDetails] = useState([]);
    const [subTotal, setSubTotal] = useState(0);
    const [amount, setAmount] = useState(0);
    const [basketId, setBasketId] = useState(0)
    const [customerId, setCustomerId] = useState(0)
    const navigate = useNavigate();
    const LocalStorageCustomerId = JSON.parse(localStorage.getItem('customerInfo')).customerId;

    useEffect(() => {


        const getBasket = async () => {
            const response = await BasketService.getBasketByCustomerId(LocalStorageCustomerId)
            setBasketDetails(response.data.basketDetails || [])
            setBasketId(response.data.basketId)
            setCustomerId(response.data.basketCustomerId)
            console.log(response.data);
        }
        getBasket()

    }, []);

    useEffect(() => {
        setSubTotal(basketDetails.reduce((total, item) => total + item.productPrice * item.basketQuantity,0))
    },[basketDetails])

    const kdv = taxes.KDV
    const total = subTotal + kdv

    const handlePrepareBasketForCheckout = async () => {
        navigate('/CheckOut', {state: {subTotal: subTotal, basketId: basketId,total:total, customerId: customerId}})
    }

    const handleRemoveProductFromBasket = async (basketDetailId) => {
        await BasketService.removeProductFromBasket(basketDetailId)
        updateBasketDetailsList(basketDetailId)

    }

    const handleIncreaseQuantity = async (basketDetailId) => {
        await BasketService.increaseQuantity(basketDetailId)
        setBasketDetails(basketDetails.map((bd) => bd.basketDetailId == basketDetailId ? {
            ...bd,
            basketQuantity: bd.basketQuantity + 1
        } : bd))
    }

    const handleDecreaseQuantity = async (basketDetailId) => {
        await BasketService.decreaseQuantity(basketDetailId)
        setBasketDetails(basketDetails.map((bd) => bd.basketDetailId == basketDetailId ? {
            ...bd,
            basketQuantity: bd.basketQuantity - 1
        } : bd).filter((product) => product.basketQuantity > 0))
    }


    const updateBasketDetailsList = (basketDetailId) => {
        const newBasketDetails = basketDetails.filter((basketDetail) => basketDetail.basketDetailId != basketDetailId)
        setBasketDetails(newBasketDetails)
    }


    return (
        <div className="max-w-7xl mx-auto p-4 bg-white ">
            <h2 className="text-2xl font-bold text-black mb-4 text-center">SEPETİM</h2>
            {basketDetails.length > 0 ? (<div className="grid grid-cols-1 space-y-3 lg:grid-cols-3 lg:space-x-2">
                    <div className="lg:col-span-2">
                        <div className="bg-white rounded-lg shadow-sm">
                            {basketDetails.map((product, index) => (
                                <div key={index} className="flex items-center border last:border-b-0 space-y-10">
                                    <div className="w-24 h-24 flex ">
                                        <img className="w-full h-full object-contain rounded "
                                             src={product.productImageUrl}/>
                                    </div>
                                    <div className="ml-4 flex-grow">
                                        <h3 className="text-black">{product.productName}</h3>
                                        <p className="text-black">{product.productPrice.toFixed(2)}₺</p>
                                        <div className="flex items-center mt-2">
                                            <div className="flex items-center border border-black rounded ">
                                                <button
                                                    onClick={() => handleIncreaseQuantity(product.basketDetailId)}
                                                    className="px-3 py-1 border-r text-black  hover:bg-green-500 hover:text-white hover:cursor-pointer rounded">+
                                                </button>
                                                <span className="px-3 py-1"><p
                                                    className="text-black">{product.basketQuantity}</p></span>
                                                <button
                                                    onClick={() => handleDecreaseQuantity(product.basketDetailId)}
                                                    className="px-3 py-1 border-l text-black  hover:bg-red-500 hover:text-white hover:cursor-pointer rounded">-
                                                </button>
                                            </div>
                                        </div>
                                    </div>
                                    <button
                                        onClick={()=>handleRemoveProductFromBasket(product.basketDetailId)}
                                        className="border rounded p-1 mr-4 text-black hover:bg-red-500 hover:text-white hover:cursor-pointer">
                                        <svg xmlns="http://www.w3.org/2000/svg" className="h-5 w-5" fill="none"
                                             viewBox="0 0 24 24" stroke="currentColor">
                                            <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2}
                                                  d="M19 7l-.867 12.142A2 2 0 0116.138 21H7.862a2 2 0 01-1.995-1.858L5 7m5 4v6m4-6v6m1-10V4a1 1 0 00-1-1h-4a1 1 0 00-1 1v3M4 7h16"/>
                                        </svg>

                                    </button>

                                </div>
                            ))}
                        </div>
                    </div>
                    <div className="lg:col-span-1 text-black">
                        <div className=" rounded-lg shadow-sm p-6">
                            <h3 className="text-lg font-semibold mb-4">SİPARİŞ ÖZETİ</h3>
                            <div className="flex justify-between">
                                <span>Ara Toplam</span>
                                <span>{subTotal.toFixed(2)}₺</span>
                            </div>
                            <div className="flex justify-between">
                                <span>Kargo</span>
                                <span>Ücretsiz</span>
                            </div>
                            <div className="flex justify-between">
                                <span>KDV</span>
                                <span>{kdv}₺</span>
                            </div>
                            <div className="border-t pt-3 mt-3">
                                <div className="flex justify-between font-bold">
                                    <span>Toplam</span>
                                    <span>{total}₺</span>
                                </div>
                            </div>
                            <button
                                className="w-full mt-6 bg-green-500 hover:bg-green-600 text-white py-3 rounded-lg transition-colors"
                                onClick={handlePrepareBasketForCheckout}>ÖDEMEYE GEÇ
                            </button>
                            <div className="mt-4 text-sm text-gray-500">
                                <p>Güvenli ödeme</p>
                                <div className="flex space-x-2 mt-2">
                                    <svg className="h-8 w-8" viewBox="0 0 24 24" fill="none"
                                         xmlns="http://www.w3.org/2000/svg">
                                        <path
                                            d="M12 22C17.5228 22 22 17.5228 22 12C22 6.47715 17.5228 2 12 2C6.47715 2 2 6.47715 2 12C2 17.5228 6.47715 22 12 22Z"
                                            stroke="currentColor" strokeWidth="2"/>
                                        <path d="M8 12L11 15L16 9" stroke="currentColor" strokeWidth="2"
                                              strokeLinecap="round" strokeLinejoin="round"/>
                                    </svg>
                                    <svg className="h-8 w-8" viewBox="0 0 24 24" fill="none"
                                         xmlns="http://www.w3.org/2000/svg">
                                        <path
                                            d="M12 22C17.5228 22 22 17.5228 22 12C22 6.47715 17.5228 2 12 2C6.47715 2 2 6.47715 2 12C2 17.5228 6.47715 22 12 22Z"
                                            stroke="currentColor" strokeWidth="2"/>
                                        <path d="M8 12L11 15L16 9" stroke="currentColor" strokeWidth="2"
                                              strokeLinecap="round" strokeLinejoin="round"/>
                                    </svg>
                                    <svg className="h-8 w-8" viewBox="0 0 24 24" fill="none"
                                         xmlns="http://www.w3.org/2000/svg">
                                        <path
                                            d="M12 22C17.5228 22 22 17.5228 22 12C22 6.47715 17.5228 2 12 2C6.47715 2 2 6.47715 2 12C2 17.5228 6.47715 22 12 22Z"
                                            stroke="currentColor" strokeWidth="2"/>
                                        <path d="M8 12L11 15L16 9" stroke="currentColor" strokeWidth="2"
                                              strokeLinecap="round" strokeLinejoin="round"/>
                                    </svg>
                                </div>
                            </div>

                        </div>

                    </div>
                </div>)

                :

                (
                    <div className="flex flex-col items-center justify-center">
                        <svg className="w-24 h-24 text-gray-400 mb-4" fill="none" stroke="currentColor"
                             viewBox="0 0 24 24">
                            <path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2"
                                  d="M16 11V7a4 4 0 00-8 0v4M5 9h14l1 12H4L5 9z"/>
                        </svg>
                        <h3 className="text-xl font-semibold text-gray-600 ">Sepetiniz boş</h3>
                        <button onClick={() => navigate(RouteAddress.HomePage)}
                                className="max-w-3xl p-2 mt-4 bg-green-500 hover:bg-green-600 text-white rounded-md text-sm">Hemen
                            Alışverişe Başla
                        </button>


                    </div>)

            }

        </div>
    );
};

export default Basket;