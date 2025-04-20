import React from 'react';
import {useNavigate, useParams} from "react-router-dom";

const Product = () => {

    const products = [
        {"id":1,"marka":"nike","fiyat":100,"renk":"sarı","beden":"M"},
        {"id":2,"marka":"adidas","fiyat":200,"renk":"kırmızı","beden":"L"},
        {"id":3,"marka":"puma","fiyat":100,"renk":"turuncu","beden":"XS"}
    ]
    const {productId} = useParams();
    const navigate= useNavigate()

    const product = products.find(product => product.id === Number(productId))

    return (
        <div>
             <h1>ÜRÜN DETAY</h1>
              <p>{product.id}</p>
              <p>{product.marka}</p>
              <p>{product.renk}</p>
              <p>{product.beden}</p>
              <p>{product.fiyat}</p>
            <button onClick={()=>navigate("/basket",{state:product})}>Sepete Ekle</button>
        </div>
    );
};

export default Product;