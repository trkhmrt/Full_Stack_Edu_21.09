import {useState} from 'react';
import axios from 'axios';
import {useNavigate} from "react-router-dom";
import {RouteAddress} from "../routes/Routes.js";

const Login = () => {
    const [username, setUsername] = useState('');
    const [password, setPassword] = useState('');
    const [error, setError] = useState('');
    const navigate = useNavigate();
    const handeleLogin = async () => {
        try{
            const response = await axios.post('http://localhost:5264/Auth/customerLogin', {
                username,
                password
            })
            console.log(response);
            if(response.status === 200){
                localStorage.setItem('customerInfo', JSON.stringify(response.data));
                const info = JSON.parse(localStorage.getItem('customerInfo'));
                navigate(RouteAddress.HomePage)
                console.log(info);
            }
        }
        catch(e){
            if(e.response.status === 401){
                console.log(e.response.data)
                setError(e.response.data);
            }

        }




    }

    return (
        <div className="bg-blue-800 w-full h-screen flex justify-center items-center">
            <div
                className="flex flex-col justify-center items-center  bg-gray-800 border shadow-lg rounded-lg p-10 space-y-10">
                <h3>GİRİŞ YAP</h3>
                {error && <p className="text-red-500">{error}</p>}
                <div className="space-x-10">
                    <label>Username</label>
                    <input
                        className="focus:border-sky-500 focus:outline focus:outline-sky-500 border border-white rounded p-1"
                        onChange={(e) => setUsername(e.target.value)}
                        type="text"
                    />
                </div>
                <div className="space-x-10">
                    <label>Password</label>
                    <input
                        className="focus:border-sky-500 focus:outline focus:outline-sky-500 border border-white rounded p-1"
                        onChange={(e) => setPassword(e.target.value)}
                        type="password"
                    />
                </div>
                <div>
                    <button className="hover:cursor-pointer" onClick={handeleLogin}>Login</button>
                </div>
            </div>
        </div>
    );
};

export default Login;