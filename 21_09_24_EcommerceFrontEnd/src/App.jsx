import './App.css'
import Login from "./pages/Login.jsx";
import {BrowserRouter, Route, Routes} from "react-router-dom";
import HomePage from "./pages/HomePage.jsx";
import {RouteAddress} from "./routes/Routes";
import Basket from "./pages/Basket.jsx";
import Products from "./pages/Products.jsx";
import MyProfile from "./pages/MyProfile.jsx";
import Orders from "./pages/Orders.jsx";
import CheckOut from "./pages/CheckOut.jsx";
function App() {


  return (
    <>
      <BrowserRouter>
          <Routes>
              <Route path={RouteAddress.HomePage}  element={<HomePage/>}></Route>
              <Route path={RouteAddress.Login}  element={<Login/>}></Route>
              <Route path={RouteAddress.Basket}  element={<Basket/>}></Route>
              <Route path={RouteAddress.Products}  element={<Products/>}></Route>
              <Route path={RouteAddress.MyProfile}  element={<MyProfile/>}></Route>
              <Route path={RouteAddress.Orders}  element={<Orders/>}></Route>
              <Route path={RouteAddress.CheckOut}  element={<CheckOut/>}></Route>
          </Routes>
      </BrowserRouter>
    </>
  )
}

export default App
