import { useState } from 'react'
import viteLogo from '/vite.svg'
import './App.css'
import Login from "./Login.jsx";
import HomePage from "./HomePage.jsx";
import {BrowserRouter, Route, Routes} from "react-router-dom";
import Product from "./Product.jsx";
import Basket from "./Basket.jsx";

function App() {
  const [count, setCount] = useState(0)

  return (
    <>
        <BrowserRouter>
            <Routes>
                <Route path="/"  element={<Login/>}></Route>
                <Route path="/homepage"  element={<HomePage/>}></Route>
                <Route path="/product/:productId"  element={<Product/>}></Route>
                <Route path="/basket"  element={<Basket/>}></Route>
            </Routes>
        </BrowserRouter>
    </>
  )
}

export default App
