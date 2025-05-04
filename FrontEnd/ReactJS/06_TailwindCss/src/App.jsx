import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'

function App() {


  return (
      <div className="flex-block bg-sky-600">
          <div className="bg-fuchsia-500 w-2/5">
              w-1/2
          </div>
          <div className="bg-green-500 w-3/5">
              w-1/2
          </div>
          <div className="bg-green-200 w-full">
              w-1/2
          </div>
          <div className="bg-green-300 w-8xl">
              w-1/2
          </div>
          <div className="bg-sky-300 size-24">
              w-1/2
          </div>
          <div
              className="flex bg-red-300  w-1/2 px-4 sm:py-10  md:py-50 sm:px-10 md:px-30  md:w-full md:bg-red-600 text-center text-black font-bold text-3xl items-center justify-center">
              <div className="bg-green-300 size-12 rounded-e-4xl border">

              </div>
              <button className="bg-cyan-500 shadow-lg shadow-cyan-500/50 rounded p-1 hover:cursor-pointer hover:bg-indigo-500 transition delay-150 duration-300 ease-in hover:-translate-y-1 hover:rotate-x-15 hover:-rotate-y-30">Subscribe</button>
          </div>
          <div className="flex flex-col-reverse divide-y-2 divide-y-reverse divide-gray-200">
              <div>01</div>
              <div>02</div>
              <div>03</div>
          </div>

          <div className="grid grid-cols-3 divide-x-4">
              <div>01</div>
              <div>02</div>
              <div>03</div>
          </div>


      </div>
  )
}

export default App
