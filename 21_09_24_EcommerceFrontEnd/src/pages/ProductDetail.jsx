import React, {useEffect, useState} from 'react';
import {useParams} from "react-router-dom";
import {ProductService} from "../services/ProductService.js";
import {BasketService} from "../services/BasketService.js";

const ProductDetail = () => {

    const [product, setProduct] = useState({});
    const [isLoading, setIsLoading] = useState(false);
    const [productImages, setProductImages] = useState([]);
    const [bigPhotoIndex, setBigPhotoIndex] = useState(0);
    const customerId = JSON.parse(localStorage.getItem('customerInfo')).customerId;
    const {productId} = useParams();


    useEffect(() => {

        handleProductDetail()


    }, [])

    const handleProductDetail = async () => {
        const response = await ProductService.getProductDetails(productId);
        setProduct(response.data);
        console.log(response.data);
        setProductImages(response.data.imageUrls);

    }

    const handleAddProductToBasket = async (productId) => {
        const response = await BasketService.addProductToBasket(customerId, productId)
    }


    return (
        <div className="bg-gray-50 max-w-7xl mx-auto grid grid-cols-1 md:grid-cols-5 mt-10 rounded-xl">
            <div className="col-span-3">
                <div className="flex gap-x-6">
                    <div className="grid grid-cols-1 ">
                        {productImages.map((url,index) => (
                                <div className="size-24  border border-gray-300 rounded hover:cursor-pointer" key={index} onClick={()=>setBigPhotoIndex(index)}>
                                    <img src={url} className="object-contain w-full h-full" />
                                </div>
                            )
                        )}
                    </div>
                    <div className="col-span-1  h-100 w-100">
                        <img src={productImages[bigPhotoIndex]}
                             className="w-full h-full object-contain"/>
                    </div>
                </div>
            </div>
            <div className="col-span-2 bg-gray-50 flex flex-col text-black rounded-xl">
                <h1 className="font-bold text-3xl">{product.productName}</h1>
                <p>{product.productDescription}</p>
                <p className="">{product.productUnitPrice}₺</p>
                <button
                    className="bg-black text-white rounded-xl p-2 border border-black hover:bg-white hover:text-black transition transition-colors ">Sepete
                    Ekle
                </button>
            </div>

        </div>
    );
};

export default ProductDetail;