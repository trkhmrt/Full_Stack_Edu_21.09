import axios from "axios";

import {ApiConfiguration} from "./ApiConfiguration";

export const OrderService = {
    getAllCustomerOrders: async (customerId) => {return await axios.get(`${ApiConfiguration.Url}/order/getAllOrdersByCustomerId/${customerId}`);},
}