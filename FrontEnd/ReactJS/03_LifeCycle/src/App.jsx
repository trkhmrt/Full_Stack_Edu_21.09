import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import Photo from "./Photo.jsx";

function App() {
  const [show, setShow] = useState(true)

  return (
    <>
        <button onClick={()=>setShow(!show)}>{show ? "GİZLE" : "GÖSTER"}</button>

        { show && (<Photo></Photo>)  }


    </>
  )
}

export default App
