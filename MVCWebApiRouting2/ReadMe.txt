--bu projede attribute based routing işlemini inceleyecegiz.

--personel sınıfı oluşturarak başlayalım. ve controllerımızı oluşturalım.


--şimdi route prefix kullanımına bakacagız. route dan farklı olarak action üzerinde degil controller üzerinde çalışır.


--şimdi route kısıtlama (constraint) işlemini yapalım. yeni bir get(id) metodu oluşturalım
	birden fazla kısıtlama yapmak için : ile yazabiliriz min max datetime gibi.

--şimdi custom constraint işlemi yapalım.yani kendimize özel bir constraint classı oluşturacagız. bunun için bir klasör oluşturalım.constraints adını verelim.
	tüm işlemleri yaptıktan sonra artık alpha:ilkh diyerek kullanabiliriz.

--şimdi optional constraint:biz isteğe bağlı kısıtlama işlemi yapabiliyoruz.bu isteğe bağlı kısıtlama işlemi yaptıgımız zaman default bir value verebiliyoruz.