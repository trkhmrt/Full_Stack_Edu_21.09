import './App.css'
import About from './About.jsx'
import {useState} from "react";
function App() {

    const [sayi,setSayi] = useState(0)

    //var sayi = 0
    const sayiArttir = ()=>{
        //sayi+=1
        setSayi(sayi+1)
    }
  return (
    <>
        {/* Componenet isimleri büyük harfle başlamalı.*/}
        <h1>MERHABA DÜNYA</h1>
        <p>{sayi}</p>
        <button onClick={sayiArttir}>Sayi Arttır</button>
        <About/>
    </>
  )
}

export default App
