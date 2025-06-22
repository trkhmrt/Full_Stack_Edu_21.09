import React, {useState} from 'react';
import {useNavigate} from "react-router-dom";
import {BasketService} from "../services/BasketService.js";

const ProductCard = ({product}) => {
    const [showDetailButton, setShowDetailButton] = useState(false);
    const customerId = JSON.parse(localStorage.getItem('customerInfo')).customerId;
    const navigate = useNavigate()
    const handleProductDetail = (productId) => {
        navigate(`/ProductDetail/${productId}`)
    }
    const handleAddProductToBasket = async (productId) => {
        const response = await BasketService.addProductToBasket(customerId,productId)
        console.log(response)
    }

    return (
        <div className="rounded-2xl bg-white shadow-lg flex flex-col p-4 max-w-xs min-w-xs group" onMouseEnter={()=>setShowDetailButton(true)} onMouseLeave={()=>setShowDetailButton(false)} >
            <div className=" w-full h-60 flex items-center justify-center relative">
                <img src={product.productImageUrl} className="w-full h-full object-contain"/>
                {showDetailButton && (
                    <div className="absolute bottom-0">
                        <button className=" bg-black text-white rounded-xl p-2 border border-black hover:bg-white hover:text-black transition transition-colors  hover:opacity-50" onClick={()=>handleProductDetail(product.productId)}>Ürünü İncele</button>
                    </div>
                )
                }
            </div>
            <div className="">
                <p className="font-bold text-lg">{product.productName}</p>
                <p>{product.productDescription}</p>
                <p className="font-bold text-lg">{product.productUnitPrice}₺</p>
            </div>
            <div className="">
                <button className="bg-black text-white rounded-xl p-2 border border-black hover:bg-white hover:text-black transition transition-colors"
                onClick={()=>handleAddProductToBasket(product.productId)}
                >Sepete Ekle

                </button>
            </div>
        </div>
    );
};

export default ProductCard;