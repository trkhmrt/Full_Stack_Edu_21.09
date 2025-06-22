import React, {useEffect} from 'react';
import {BasketService} from "../services/BasketService.js";
import {PaymentService} from "../services/PaymentService.js";
import {useLocation, useNavigate} from "react-router-dom";
import {taxes} from "../constants/taxes.js";
import {RouteAddress} from "../routes/Routes.js";
const CheckOut = () => {


    const {state} = useLocation();
    console.log(state);
    useEffect(() => {
        const getCheckout = async () => {
            const response = await BasketService.checkoutBasket(1)
            console.log(response);
        }

        getCheckout()

    }, []);

    const navigate = useNavigate();



    const handlePayment = async () => {
        const paymentInfo = {
            basketId: state.basketId,
            customerId: state.customerId,
            amount: state.total,
        }

        const response = await PaymentService.createPayment(paymentInfo)

        if(response.data.paymentMessage == "Success") {
            navigate(RouteAddress.SuccessPaymentPage,{replace: true})
        }
        else if(response.data.paymentMessage== "Failed"){
            navigate(RouteAddress.FailedPaymentPage)
        }
    }



    return (
        <div className="min-h-screen bg-gray-50 py-8">
            <div className="max-w-7xl mx-auto px-4">
                <div className="flex flex-col items-center mb-10">
                    <h2 className="text-3xl font-bold text-gray-900 mb-2">Ödeme Ekranı</h2>
                    <div className="h-1 w-20 bg-green-500 rounded-full"></div>
                </div>


                <div className="grid grid-cols-1 lg:grid-cols-3 gap-8">
                    {/*Ödeme Bilgileri*/}
                    <div className="lg:col-span-2 space-y-6">
                        <div className="bg-white rounded-2xl shadow-md p-8 hover:shadow-lg transition-shadow">
                            <div className="flex items-center mb-6">
                                <div
                                    className="w-8 h-8 bg-green-100  rounded-full flex items-center justify-center mr-3">
                                    <svg className="w-5 h-5 text-green-500" fill="none" stroke="currentColor"
                                         viewBox="0 0 24 24">
                                        <path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2"
                                              d="M16 7a4 4 0 11-8 0 4 4 0 018 0zM12 14a7 7 0 00-7 7h14a7 7 0 00-7-7z"/>
                                    </svg>
                                </div>
                                <h3 className="text-xl font-semibold text-gray-900">Kişisel Bilgiler</h3>
                            </div>
                            <div className="grid grid-cols-1 md:grid-cols-2 gap-6">
                                <div className="space-y-2">
                                    <label className="text-sm font-medium text-gray-700">Ad soyad</label>
                                    <input
                                        className="w-full px-4 py-3 rounded-xl border border-gray-200 focus:ring-2 focus:ring-green-500 focus:border-transparent transition-all"
                                        placeholder="Tarık hamarat"
                                    />
                                </div>
                                <div className="space-y-2">
                                    <label className="text-sm font-medium text-gray-700">Email</label>
                                    <input
                                        className="w-full px-4 py-3 rounded-xl border border-gray-200 focus:ring-2 focus:ring-green-500 focus:border-transparent transition-all"
                                        placeholder="Tarık hamarat"
                                    />
                                </div>
                            </div>


                        </div>
                        <div className="bg-white rounded-2xl shadow-md p-8 hover:shadow-lg transition-shadow">
                            <div className="flex items-center mb-6">
                                <div
                                    className="w-8 h-8 bg-green-100  rounded-full flex items-center justify-center mr-3">
                                    <svg className="w-5 h-5 text-green-500" fill="none" stroke="currentColor"
                                         viewBox="0 0 24 24">
                                        <path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2"
                                              d="M3 10h18M7 15h1m4 0h1m-7 4h12a3 3 0 003-3V8a3 3 0 00-3-3H6a3 3 0 00-3 3v8a3 3 0 003 3z"/>
                                    </svg>
                                </div>
                                <h3 className="text-xl font-semibold text-gray-900">Ödeme Bilgileri</h3>
                            </div>
                            <div className="grid grid-cols-1 md:grid-cols-2 gap-6">
                                <div className="space-y-2">
                                    <label className="text-sm font-medium text-gray-700">Card Number</label>
                                    <input
                                        className="w-full px-4 py-3 rounded-xl border border-gray-200 focus:ring-2 focus:ring-green-500 focus:border-transparent transition-all"
                                        placeholder="Tarık hamarat"
                                    />
                                </div>
                                <div className="space-y-2">
                                    <label className="text-sm font-medium text-gray-700">İsim Soyisim</label>
                                    <input
                                        className="w-full px-4 py-3 rounded-xl border border-gray-200 focus:ring-2 focus:ring-green-500 focus:border-transparent transition-all"
                                        placeholder="Tarık hamarat"
                                    />
                                </div>
                                <div className="space-y-2">
                                    <label className="text-sm font-medium text-gray-700">CVV</label>
                                    <input
                                        className="w-full px-4 py-3 rounded-xl border border-gray-200 focus:ring-2 focus:ring-green-500 focus:border-transparent transition-all"
                                        placeholder="Tarık hamarat"
                                    />
                                </div>
                                <div className="space-y-2">
                                    <label className="text-sm font-medium text-gray-700">Son Kullanma Tarihi</label>
                                    <input
                                        className="w-full px-4 py-3 rounded-xl border border-gray-200 focus:ring-2 focus:ring-green-500 focus:border-transparent transition-all"
                                        placeholder="Tarık hamarat"
                                    />
                                </div>
                            </div>


                        </div>
                    </div>
                    {/*Ödeme Bilgileri*/}
                    {/*Sipariş Özeti Bilgileri*/}
                    <div className="lg:col-span-1">
                        <div className="bg-white rounded-2xl shadow-md p-8 top-4 hover:shadow-lg transition-shadow">
                            <div className="flex items-center mb-6">
                                <div
                                    className="bg-green-100 w-8- h-8 rounded-full flex items-center justify-center mr-3">
                                    <svg className="w-5 h-5 text-green-500" fill="none" stroke="currentColor"
                                         viewBox="0 0 24 24">
                                        <path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2"
                                              d="M16 11V7a4 4 0 00-8 0v4M5 9h14l1 12H4L5 9z"/>
                                    </svg>
                                </div>
                                <h3 className="text-xl font-semibold text-gray-900">Sipariş Özeti</h3>
                            </div>

                            <div className="space-y-4">
                                <div className="flex justify-between items-center py-4 border-b border-gray-300">
                                    <span className="text-gray-600">Ara Toplam</span>
                                    <span className="text-gray-900 font-medium">{state.subTotal}₺</span>
                                </div>
                                <div className="flex justify-between items-center py-4 border-b border-gray-300">
                                    <span className="text-gray-600">KDV</span>
                                    <span className="text-gray-900 font-medium">{taxes.KDV}₺</span>
                                </div>
                                <div className="flex justify-between items-center py-4  border-gray-300">
                                    <span className="text-2xl text-gray-600 font-semibold">Toplam </span>
                                    <span className="text-2xl text-gray-900 font-bold">{state.total}₺</span>
                                </div>
                            </div>
                            <button
                                className="w-full bg-green-500 mt-8 hover:bg-green-800 py-4 rounded-xl font-semibold transition-all hover:scale-[1.01]"
                                onClick={handlePayment}
                            >
                                Ödemeyi Tamamla
                            </button>


                        </div>


                    </div>
                    {/*Sipariş Özeti Bilgileri*/}
                </div>


            </div>
        </div>
    );
};

export default CheckOut;