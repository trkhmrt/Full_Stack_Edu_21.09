import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'

function App() {

 const [todos ,setTodos] = useState([])
 const [text ,setText] = useState("")


    const addTodoList = () =>{

     const newTodo = {
         id:Date.now(),
         gorev: text
     }

     setTodos([...todos,newTodo])

    }



  return (
    <>
        <h1>Merhaba ToDo App Uygulamasına Hoşgeldiniz.</h1>
        <input
        placeholder="Görev"
        value={text}
        onChange={(event)=>setText(event.target.value)}
        />
        <input
            placeholder="Öncelik"
        />
        <button onClick={addTodoList}>Görev Ekle</button>
        <ul>
        {todos.map((todo)=>(
            <li key={todo.id}>{todo.gorev}-{todo.id}</li>
        ))}
        </ul>
    </>
  )
}

export default App
