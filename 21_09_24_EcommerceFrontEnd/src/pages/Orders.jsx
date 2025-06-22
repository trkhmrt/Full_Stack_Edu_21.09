import React, {useEffect, useState} from 'react';
import {OrderService} from "../services/OrderService.js";

const Orders = () => {
    const customerId = JSON.parse(localStorage.getItem('customerInfo')).customerId;
    const [customerOrders, setCustomerOrders] = useState([]);
    useEffect(() => {
        handleCustomerOrders()
    }, [])

    const handleCustomerOrders = async () => {
        const response = await OrderService.getAllCustomerOrders(customerId);
        setCustomerOrders(response.data);
        console.log(response.data);
    }


    return (
        <div className="text-black max-w-7xl mx-auto flex  justify-center mt-10 flex-col space-y-4">
            <h1 className="font-bold text-4xl">Orders</h1>

            <div className="flex flex-col">
                <div className="-m-1.5 overflow-x-auto">
                    <div className="p-1.5 min-w-full inline-block align-middle">
                        <div className="border border-gray-200 rounded-lg divide-y divide-gray-200">
                            <div className="py-3 px-4">
                                <div className="relative max-w-xs">
                                    <label className="sr-only">Search</label>
                                    <input type="text" name="hs-table-with-pagination-search"
                                           id="hs-table-with-pagination-search"
                                           className="py-1.5 sm:py-2 px-3 ps-9 block w-full border-gray-200 shadow-2xs rounded-lg sm:text-sm focus:z-10 focus:border-blue-500 focus:ring-blue-500 disabled:opacity-50 disabled:pointer-events-none"
                                           placeholder="Search for items"/>
                                    <div
                                        className="absolute inset-y-0 start-0 flex items-center pointer-events-none ps-3">
                                        <svg className="size-4 text-gray-400" xmlns="http://www.w3.org/2000/svg"
                                             width="24" height="24" viewBox="0 0 24 24" fill="none"
                                             stroke="currentColor" stroke-width="2" stroke-linecap="round"
                                             stroke-linejoin="round">
                                            <circle cx="11" cy="11" r="8"></circle>
                                            <path d="m21 21-4.3-4.3"></path>
                                        </svg>
                                    </div>
                                </div>
                            </div>
                            <div className="overflow-hidden">
                                <table className="min-w-full divide-y divide-gray-200">
                                    <thead className="bg-gray-50">
                                    <tr>

                                        <th scope="col"
                                            className="px-6 py-3 text-start text-xs font-medium text-gray-500 uppercase">Order
                                            Id
                                        </th>
                                        <th scope="col"
                                            className="px-6 py-3 text-start text-xs font-medium text-gray-500 uppercase">Order
                                            Date
                                        </th>
                                        <th scope="col"
                                            className="px-6 py-3 text-start text-xs font-medium text-gray-500 uppercase">Status
                                        </th>
                                        <th scope="col"
                                            className="px-6 py-3 text-end text-xs font-medium text-gray-500 uppercase">Detail
                                        </th>
                                        <th scope="col"
                                            className="px-6 py-3 text-end text-xs font-medium text-gray-500 uppercase">Canceled
                                        </th>
                                    </tr>
                                    </thead>
                                    <tbody className="divide-y divide-gray-200">

                                    {customerOrders.map((order, index) => (
                                        <tr key={index}>
                                            <td className="px-6 py-4 whitespace-nowrap text-sm font-medium text-gray-800">
                                                {order.orderId}
                                            </td>
                                            <td className="px-6 py-4 whitespace-nowrap text-sm text-gray-800">
                                                {order.orderDate}
                                            </td>
                                            <td className="px-6 py-4 whitespace-nowrap text-sm text-gray-800 flex">
                                                <div className="flex items-center">
                                                    {order.orderStatusName == "Sipariş Aktif" ?<div className="h-2.5 w-2.5 rounded-full bg-green-500 me-2"></div> :<div className="h-2.5 w-2.5 rounded-full bg-red-500 me-2"></div> }
                                                    {order.orderStatusName}

                                                </div>
                                        </td>
                                        <td className="px-6 py-4 whitespace-nowrap text-end text-sm font-medium">
                                                <button type="button"
                                                        className="inline-flex items-center gap-x-2 text-sm font-semibold rounded-lg border border-transparent text-blue-600 hover:text-blue-800 focus:outline-hidden focus:text-blue-800 disabled:opacity-50 disabled:pointer-events-none">Detail
                                                </button>
                                            </td>
                                            <td className="px-6 py-4 whitespace-nowrap text-end text-sm font-medium">
                                                <button type="button"
                                                        className="inline-flex items-center gap-x-2 text-sm font-semibold rounded-lg border border-transparent text-red-800 hover:text-red-600 focus:outline-hidden focus:text-red-600 disabled:opacity-50 disabled:pointer-events-none">Canceled
                                                </button>
                                            </td>




                                        </tr>
                                    ))}


                                    </tbody>
                                </table>
                            </div>
                            <div className="py-1 px-4">
                                <nav className="flex items-center space-x-1" aria-label="Pagination">
                                    <button type="button"
                                            className="p-2.5 min-w-10 inline-flex justify-center items-center gap-x-2 text-sm rounded-full text-gray-800 hover:bg-gray-100 focus:outline-hidden focus:bg-gray-100 disabled:opacity-50 disabled:pointer-events-none"
                                            aria-label="Previous">
                                        <span aria-hidden="true">«</span>
                                        <span className="sr-only">Previous</span>
                                    </button>
                                    <button type="button"
                                            className="min-w-10 flex justify-center items-center text-gray-800 hover:bg-gray-100 focus:outline-hidden focus:bg-gray-100 py-2.5 text-sm rounded-full disabled:opacity-50 disabled:pointer-events-none"
                                            aria-current="page">1
                                    </button>
                                    <button type="button"
                                            className="min-w-10 flex justify-center items-center text-gray-800 hover:bg-gray-100 focus:outline-hidden focus:bg-gray-100 py-2.5 text-sm rounded-full disabled:opacity-50 disabled:pointer-events-none">2
                                    </button>
                                    <button type="button"
                                            className="min-w-10 flex justify-center items-center text-gray-800 hover:bg-gray-100 focus:outline-hidden focus:bg-gray-100 py-2.5 text-sm rounded-full disabled:opacity-50 disabled:pointer-events-none">3
                                    </button>
                                    <button type="button"
                                            className="p-2.5 min-w-10 inline-flex justify-center items-center gap-x-2 text-sm rounded-full text-gray-800 hover:bg-gray-100 focus:outline-hidden focus:bg-gray-100 disabled:opacity-50 disabled:pointer-events-none"
                                            aria-label="Next">
                                        <span className="sr-only">Next</span>
                                        <span aria-hidden="true">»</span>
                                    </button>
                                </nav>
                            </div>
                        </div>
                    </div>
                </div>
            </div>


        </div>
    );
};

export default Orders;