import axios from 'axios'

const apiUrl = "http://localhost:5264"

export const BasketService = {
     getBasketByCustomerId: async (customerId) => {return await axios.get(`${apiUrl}/Basket/getActiveBasketByCustomerId/${customerId}`)},
     approveBasket: async (basketId) => {return await axios.get(`${apiUrl}/Basket/approveBasket/${basketId}`)},
     checkoutBasket: async (customerId) => {return await axios.get(`${apiUrl}/Basket/checkoutBasket/${customerId}`)},
     addProductToBasket: async (customerId,productId) => {return await axios.post(`${apiUrl}/Basket/addProductToBasket`,{customerId,productId})},
}