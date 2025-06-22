import axios from 'axios'

import {ApiConfiguration} from "./ApiConfiguration";

export const PaymentService = {
    createPayment: async (paymentInfo) =>  {return await axios.post(`${ApiConfiguration.Url}/payment/createPayment`,paymentInfo)}
}