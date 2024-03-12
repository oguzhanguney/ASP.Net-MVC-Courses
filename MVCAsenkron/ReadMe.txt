﻿--Asenkron işlemler: controller içerisinde 2 şekilde yapılır.
--1. controller içerisinde asenkron işlemleri yapabilmek için controller sınıfının yerine async controller sınıfının kalıtımını alıp işlemleri öyle yapmak
--2. action metot içerisinde asenkron işlemleri yapabilmek için actionresult geri dönüş tipini async task liste içerisinde actionresult olarak tanımlamalıyız.
--örnek:birden fazla web servise baglanıp bu servislerden veri almamız ve bu verileri sayfa içerisinde görüntüleyelim.bu durumda sırasıyla veri almak yerine her bir veri almak için thread leri başlatabiliriz.
--böylece aynı anda bütün web servislerden veri alabiliriz.yani bir iş parcacıgına 1. web servisten veri al dedigimizde aynı anda 2. iş parcacıgına bir diger web servisten veri al diyebiliriz.
--bunlar asenkron işlemlere girer ve bunada asenkron programlama denir.C# bu işlemi async ve await anahtar sözcügü ile gerçekleştirirz.
--bir metodun asenkron oldugunu async anahtar kelimesi ile tanımlarız daha sonra tanımlanan metodun türünüde task listesi ,task yada void olarak tanımlarız. son olarak aseknron metot çağırılırken await anahtar kelimesini kullanırız.
--şimdi asenkron controller sınıfı ile bir işlem yapalım.

--2 asenkron türünü de gösterelim.
--1)öncelikle personel adında bir model oluşturalım.
-- asenkron controller ı oluşturduk. bir completed bir de async metotlarını oluşturalım.
--)actionda askenron işlemleri yapalım (Personelasenkroncontroller)