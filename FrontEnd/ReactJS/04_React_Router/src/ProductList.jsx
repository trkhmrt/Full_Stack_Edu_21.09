import React from 'react';
import {Link} from "react-router-dom";

const ProductList = () => {

    const products = [
        {"id":1,"marka":"nike","fiyat":100},
        {"id":2,"marka":"adidas","fiyat":200},
        {"id":3,"marka":"puma","fiyat":100}
    ]

    return (
        <div>
            <ul>
                {products.map(product =>
                    <li key={product.id}>
                        <p>{product.marka}</p>
                        <p>{product.fiyat}</p>
                        <Link to={`/product/${product.id}`}>Ürün Detay</Link>
                    </li>
                )}
            </ul>
        </div>
    );
};

export default ProductList;