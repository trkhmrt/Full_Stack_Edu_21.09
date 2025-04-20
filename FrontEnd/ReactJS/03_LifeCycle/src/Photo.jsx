import React, {useEffect, useState} from 'react';

const Photo = () => {

    const [count, setCount] = useState(0)
    const [count2, setCount2] = useState(0)

    useEffect(() => {
        console.log("Photo componenti ilk renderda veya update'de çalışır.")
    });

    useEffect(() => {
        console.log("Sadece ilk renderda bir kez çalışır..")
    }, []);

    useEffect(() => {
        console.log("Sadece count2 için çalışır.")
    }, [count2]);

    useEffect(() => {
        return()=>{
            console.log("Photo componenti ekrandan kaldırıldığında çalışır.")
        }
    }, []);



    return (
        <div>
            <h1>Ben bir fotoğraf componentiyim</h1>
            <p>MERHABA</p>
            <p>Count1:{count}</p>
            <p>Count2:{count2}</p>
            <button onClick={()=>setCount(count+1)}>Count</button>
            <button onClick={()=>setCount2(count2+1)}>Count 2</button>
        </div>
    );
};

export default Photo;