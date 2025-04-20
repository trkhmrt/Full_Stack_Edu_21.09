import {useEffect, useState} from 'react'
import axios from 'axios'
import './App.css'

function App() {
  const [count, setCount] = useState(0)

  useEffect(() => {

    //postProducts()
    //getSingleProduct()
    //getProducts()


  }, []);

  function normalFunction(){
    console.log("1-Normal fonksyion Çalıştı")
  }

  async function asyncFunction(){
    console.log("2-Async metot başladı")
    await new Promise(resolve => setTimeout(resolve, 6000))
    console.log("3-Async metot bitti")
  }

  console.log("0-Uygulama başladı")

  normalFunction()
  asyncFunction()

  console.log("4-Kod bitti")


  const getProducts = async () => {
    const  response = await axios.get("https://fakestoreapi.com/products")
    console.log(response.data)
  }

  const getSingleProduct = async () => {
    const  response = await axios.get("https://fakestoreapi.com/products/1")
    console.log(response.data.title)
  }

  const postProducts = async () => {
    const newProduct = {
      "id": 20,
      "title": "Tabak",
      "price": 10.1,
      "description": "Yemek tabağı",
      "category": "yeme/içme",
      "image": "http://example.com"
    }
    const  responsePost = await axios.post("https://fakestoreapi.com/products",newProduct)
    console.log(responsePost)
  }
  {/*GÜNCELLEME İÇİN PUT KULLANILABİLİR.*/}

  return (
    <>
      <h1>APP COMPONENT</h1>
    </>
  )
}

export default App
