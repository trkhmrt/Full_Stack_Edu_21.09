import axios from 'axios'

const apiUrl = "http://localhost:5264"

export const BasketService = {
     getBasketByCustomerId: async (customerId) => {return await axios.get(`${apiUrl}/Basket/getActiveBasketByCustomerId/${customerId}`)},
     checkoutBasket: async (customerId) => {return await axios.get(`${apiUrl}/Basket/checkoutBasket/${customerId}`)},
     addProductToBasket: async (customerId,productId) => {return await axios.post(`${apiUrl}/Basket/addProductToBasket`,{customerId,productId,quantity:1})},
     removeProductFromBasket: async (basketDetailId) => {return await axios.post(`${apiUrl}/Basket/removeBasket`,{basketDetailId})},
     increaseQuantity: async (basketDetailId) => {return await axios.get(`${apiUrl}/Basket/increaseQuantity/${basketDetailId}`)},
     decreaseQuantity: async (basketDetailId) => {return await axios.get(`${apiUrl}/Basket/decreaseQuantity/${basketDetailId}`)},
}