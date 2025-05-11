import React, {useEffect, useState} from 'react';
import {ProductService} from "../services/ProductService.js";
import {BasketService} from "../services/BasketService.js";
const Products = () => {

    const [products, setProducts] = useState([]);
    const customerId = JSON.parse(localStorage.getItem('customerInfo')).customerId;

    useEffect(() => {
        ProductService.getProducts()

        const getProducts = async () => {
            const response = await ProductService.getProducts()
            setProducts(response.data)
            console.log(response);
        }

        getProducts()
    }, []);

    const handleAddProductToBasket = async (productId) => {
        const response = await BasketService.addProductToBasket(customerId,productId)
    }


    return (
        <div className="">
            <h1>PRODUCTS</h1>
            <div className="grid md:grid-cols-4 sm:grid-cols-2 grid-cols-1 h-dvh gap-4 bg-gray-700">
            {products.map((product,index)=>(
                <div className="border rounded-xl flex flex-col  p-4 max-h-64" key={index}>
                    <p>{product.productName}</p>
                    <p>{product.productDescription}</p>
                    <p>{product.subcategoryName}</p>
                    <p>{product.productUnitPrice}</p>
                    <div className="flex space-x-4">
                        <button onClick={()=>handleAddProductToBasket(product.productId)} className="cursor-pointer"> Sepete Ekle</button>
                        <button>Favorilere Ekle</button>
                        <button>Ürünü İncele</button>
                    </div>

                </div>
            ))}
            </div>
        </div>
    );
};

export default Products;