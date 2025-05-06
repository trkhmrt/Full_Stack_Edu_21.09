import './App.css'
import Login from "./pages/Login.jsx";
import {BrowserRouter, Route, Routes} from "react-router-dom";
import HomePage from "./pages/HomePage.jsx";
import {RouteAddress} from "./routes/Routes";
function App() {


  return (
    <>
      <BrowserRouter>
          <Routes>
              <Route path={RouteAddress.HomePage}  element={<HomePage/>}></Route>
              <Route path={RouteAddress.Login}  element={<Login/>}></Route>
          </Routes>
      </BrowserRouter>
    </>
  )
}

export default App
