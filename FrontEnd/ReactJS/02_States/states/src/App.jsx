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

    const deleteTodoFromList = (id) => {
       const filteredList = todos.filter(todo=>todo.id !== id)
        setTodos(filteredList)
    }

    const updateTodo = (id) => {


     const updatedTodo = todos.map(todo => todo.id === id ? {...todo,gorev:text} : todo)
        setTodos(updatedTodo)
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
            <div key={todo.id}>
            <li >{todo.gorev}-{todo.id}</li>
            <button style={{backgroundColor:"red"}} onClick={()=>deleteTodoFromList(todo.id)}>SİL</button>
                <button style={{backgroundColor:"orange"}} onClick={()=>updateTodo(todo.id)}>ID İLE GÜNCELLE</button>
            </div>
        ))}
        </ul>
    </>
  )
}

export default App
