import React, {useEffect, useState} from 'react';
import {ProductService} from "../services/ProductService.js";
import {CategoryService} from "../services/CategoryService.js";
import {BasketService} from "../services/BasketService.js";
import {Link} from "react-router-dom";
import ProductCard from "./ProductCard.jsx";

const ProductArea = () => {
    const [allProducts, setAllProducts] = useState([]);
    const [products, setProducts] = useState([]);
    const [categories, setCategories] = useState([]);
    const [activeCategoryId, setActiveCategoryId] = useState(null);
    const customerId = JSON.parse(localStorage.getItem('customerInfo')).customerId;

    const [filteredProducts, setFilteredProducts] = useState([]);
    const [selectedCategoryId, setSelectedCategoryId] = useState('all');
    const [expandedCategories,setExpandedCategories] = useState({});



    useEffect(() => {


        const getProducts = async () => {
            const response = await ProductService.getProducts()
            setAllProducts(response.data)
            setProducts(response.data)
            console.log(response);
        }

        const getCategories = async () => {
            const response = await CategoryService.getAllCategories();
            setCategories(response.data)
            console.log(response);
        }

        getProducts()
        getCategories()
    }, []);

    const handleAddProductToBasket = async (productId) => {
        const response = await BasketService.addProductToBasket(customerId,productId)
    }
    const handleProductForSubCategory=(subCategoryName)=>{
            const filteredList = allProducts.filter((product) => product.subcategoryName === subCategoryName)
            setProducts(filteredList)
    }

    {/*Alt Kategorileri Göster*/}
    const toggleCategoryExpansion = (categoryId)=>{
        setExpandedCategories(prev => ({
            ...prev,[categoryId]: !prev[categoryId]
        }));
    }

    {/*Kategorilere göre ürünleri getir*/}
    const handleCategoryClick = (categoryId)=>{

        setActiveCategoryId(categoryId)
        setSelectedCategoryId(categoryId)

        const category = categories.find(cat=>cat.categoryId === categoryId)
        if(category){
            const filteredList = allProducts.filter((product)=>product.categoryName===category.categoryName)
            setProducts(filteredList)
        }
    }

    {/*Tüm kategorilere göre ürünleri getir*/}
    const  handleAllCategoriesClick = ()=>{
        setProducts(allProducts)
        setSelectedCategoryId('all')
        setActiveCategoryId(null)
    }


    function handleSubCategoryClick(subcategoryName) {
        const filteredList = allProducts.filter((product)=>product.subcategoryName === subcategoryName)
        setProducts(filteredList)
    }

    return (
        <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-7 gap-6 p-10">
          <div className="w-full">
              {/*Left SideBar*/}
              <div className="bg-white rounded-xl shadow-lg p-6 sticky top-4 overflow-y-auto">
                  <div className="flex items-center mb-6">
                    <div className="w-8 h-8 bg-green-100 rounded-full flex items-center justify-center mr-3">
                        <svg className="w-5 h-5 text-green-600" fill="none" stroke="currentColor"
                             viewBox="0 0 24 24">
                            <path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2"
                                  d="M4 6h16M4 10h16M4 14h16M4 18h16"/>
                        </svg>
                    </div>
                      <h2 className="text-xl font-semibold text-gray-900">Kategoriler</h2>
                  </div>
                  <div className="space-y-2">
                      {/*Tüm Kategoriler Buton*/}
                      <button
                      className={`w-full text-left px-4 py-3 rounded-xl flex items-center ${
                          selectedCategoryId === 'all' ? 'bg-green-100 text-green-700' : 'hover:bg-gray-50'
                      }`}
                      onClick={handleAllCategoriesClick}
                      >
                          <svg className="w-5 h-5 mr-3" fill="none" stroke="currentColor" viewBox="0 0 24 24">
                              <path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2"
                                    d="M19 11H5m14 0a2 2 0 012 2v6a2 2 0 01-2 2H5a2 2 0 01-2-2v-6a2 2 0 012-2m14 0V9a2 2 0 00-2-2M5 11V9a2 2 0 012-2m0 0V5a2 2 0 012-2h6a2 2 0 012 2v2M7 7h10"/>
                          </svg>
                          Tüm Kategoriler
                      </button>
                      {/*Tüm Kategoriler Buton*/}

                      {/*Kategoriler*/}

                      {categories.map((category,index) => (
                          <div key={index} className="space-y-1"
                               onClick={(e)=> {
                                   e.stopPropagation()
                                   toggleCategoryExpansion(category.categoryId)
                               }
                          }>
                              <button
                                className ={`w-full text-left px-4 py-3 rounded-xl flex items-center justify-between transition-colors${
                                    selectedCategoryId === category.categoryId ? 'bg-green-100 text-green-700' : 'hover:bg-gray-50'
                                }`}
                                onClick={()=>handleCategoryClick(category.categoryId)}


                              >
                                  <div className="flex items-center">
                                      <div className={`w-2 h-2 rounded-full mr-3 ${
                                          selectedCategoryId === category.categoryId ? 'bg-green-600' : 'bg-gray-400'
                                      }`}>

                                      </div>
                                      <span className="font-medium">{category.categoryName}</span>
                                  </div>
                                  {category.subCategoriesName && category.subCategoriesName.length > 0 && (
                                      <svg

                                          className={`w-5 h-5 transition-transform duration-300  ${
                                              expandedCategories[category.categoryId] ? 'rotate-180'  : ''
                                          }`}
                                          fill="none"
                                          stroke="currentColor"
                                          viewBox="0 0 24 24"
                                      >
                                          <path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2"
                                                d="M19 9l-7 7-7-7"/>
                                      </svg>
                                  ) }

                              </button>

                              {/*ALT KATEGORİLER*/}
                              {expandedCategories[category.categoryId] && category.subCategoriesName && category.subCategoriesName.length > 0 && (

                                  <div className="ml-6 space-y-1">
                                      {category.subCategoriesName.map((subCategory,index) =>
                                          (
                                              <button key={index}
                                               onClick={()=>handleSubCategoryClick(subCategory)}
                                                      className="w-full text-left px-4 py-3 rounded-xl flex items-center text-sm hover:bg-gray-50 transition-colors"
                                              >
                                                  <div className="w-1.5 h-1.5 rounded-full mr-3 bg-gray-400"></div>
                                                  <span>{subCategory}</span>
                                              </button>
                                          )
                                      )}
                                  </div>
                              ) }

                          </div>
                      ))}

                  </div>
              </div>
              {/*Left SideBar*/}

          </div>
            <div className="col-span-6">
                <div
                    className="grid xl:grid-cols-3  md:grid-cols-2 sm:grid-cols-1 grid-cols-1  gap-x-4 gap-y-6 bg-gray-50 rounded-xl h-auto w-auto place-items-center text-black p-4">
                    {products.map((product,index)=>(
                     <div key={index}>
                         <ProductCard product={product}/>
                     </div>
                    ))}
                </div>
            </div>
        </div>
    );
};

export default ProductArea;