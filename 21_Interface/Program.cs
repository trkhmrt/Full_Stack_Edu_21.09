namespace _21_Interface;

class Program
{
    static void Main(string[] args)
    {
     
        /*
         Interface(Arayüz) 
         
         Interface kavramı abstractlarda olduğu gibi herhangi bir class'a arayüz uygulanmak istendiğinde kullanılır.
         
         -Interface içerisindeki bütün yapıları implement etmeniz gerekir.
         
         -Interface içerisinde sadece soyut yapılar bulunur.
         
         -Bir class birden fazla interface'i implement edebilir.
         
         -Newlenemezler.
             
         */
        
        
    }

    interface AracMetotlari
    {
        void Create();
        void Delete();
        void Update();
        void GetAll();
    }
    interface AracMetotlari2
    {
        void Create2();
        void Delete2();
        void Update2();
        void GetAll2();
        
    }
    
    class Sedan:AracMetotlari,AracMetotlari2
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void Create2()
        {
            throw new NotImplementedException();
        }

        public void Delete2()
        {
            throw new NotImplementedException();
        }

        public void Update2()
        {
            throw new NotImplementedException();
        }

        public void GetAll2()
        {
            throw new NotImplementedException();
        }
    }
}