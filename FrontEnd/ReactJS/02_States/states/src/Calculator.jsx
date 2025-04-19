import React, {useState} from 'react';
{/*
CALCULATOR
1.Sayı ve 2.Sayı için state tanımlanacak
yapılacak işlemleri butonlara ayıracaksınız
işlemleri parametre olarak bir metoda ileteceksiniz.Sayıları parametredeki işaret göre işleme sokacaksınız.Çıktıyıda ekranda yine bir state aracılığıyla göstereceksiniz.
*/}
const Calculator = () => {
    const [s1, setS1] = useState(0);
    const [s2, setS2] = useState(0);
    const [sonuc, setSonuc] = useState(0);

    const dortIslem = (islem) => {
        {/*const n1 = +s1
        const n2 = +s2
        işlemlerde n1 ve n2 kullanılacak.
        */}


        switch (islem) {
            case "+": setSonuc( Number(s1)+Number(s2));    break;
            case "-": setSonuc(s1-s2);    break;
            case "*": setSonuc(s1*s2);    break;
            case "/": setSonuc(s1/s2);    break;
        }
    }



    return (
        <div>
                <input type="number" onChange={(e)=>setS1(e.target.value)} placeholder="1.Sayı"/>
                <input type="number" onChange={(e)=>setS2(e.target.value)} placeholder="2.Sayı"/>
                <input value={sonuc} readOnly={true} placeholder="sonuc"/>
                <button onClick={()=>dortIslem("+")}>+</button>
                <button onClick={()=>dortIslem("-")}>-</button>
                <button onClick={()=>dortIslem("*")}>*</button>
                <button onClick={()=>dortIslem("/")}>/</button>
        </div>
    );
};

export default Calculator;