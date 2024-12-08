    /*
         Birebir(One To One)
         Bire Çok (One To Many - Many To One)
         Çoka çok (Many to Many)
         
           Birebir(One To One)

        Kimlik Kartı - Vatandaş

        Herkesin Kendisine ait bir kimlik kartı 

        Vatandaşlık
        -----------

        Birebir İlişki
        ______________

        Kimlik ve kartı - Vatandaş  (Her vatandaşın bir kimlik kartı vartdır.Her kimlik kartıda tek bir vatandaşa özeldir.)

           1            -   3 
           2            -   4
           5            -   10
           

        Bire çok ilişki
        _______________

        Departmant - çalışan (Bir departmanın birden fazla çalışanı olabilir.Bir çalışanın sadece tek bir departmanı olabilir.)

            1    -    2
            1    -    3
            1    -    4
            
         
         Çoka çok İlişki Türü
        ______________________

        Sınıf ve Öğrenci (Bir sınıf birden fazla öğrenci barındırabilirken aynı zamanda bir öğrenci birden fazla sınıfta ders alabilir.) 
        ________________

        Sınıf_id   -   Öğrenci_id
           1              2
           1              7
           1              8
           1              10
           1              12
           2              2         
           2              3
           2              4      
         */