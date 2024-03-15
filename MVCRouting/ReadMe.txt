--Routing:Kullanıcının internet tarayıcısı üzerinden sunucuya yaptığı sayfa isteğinin hangi controller sınıfındaki hangi action metodu çalıştıracagını tanımlayan yapıdır.
	--appstart klasörü altından routeconfig içerisinde route ayarı yapılır.

--route oluşturma: ex:haber sitesi . 
	haber sitesinde öncelikle bir anasayfa olacak  ve bu anasayfa tek bir sayfadan oluşup içeriği sürekli değişecek.sayfa sabit oldugunda route ayarı yapılırken doğrudan link tanımlanabilir.
	haber sayfasında ikinci olarak kategoriler üçüncü olarakta haberler olabilir.kategoriyi oluştururken site içerisinde birçok kategori olacagını düşünmemiz lazım.hatta bu kategorilerin altında başka
	kategorilerin de olacagını düşünelim. o yüzden kategori isimlerini route ayarları yaparken dinamik olarak yapmalıyız ve değişecegini hesaba katmalıyız.alt alta olacagını hesaba katmalıyız.
	aynı şekilde haber sayfaları içinde birden çok haber olacagı düşünülebilir.ayrıca bu haber sitesi örneği için bir haberin bir kategorisi oldugunu düşünelim.eğer haberin üst kategorileri varsa
	kategoriadı//kategoriadı şeklinde gidip	haber adını yerleştirebiliriz.üst kategorisi yoksada haber/kategoriadı/haberadı şeklinde tanımlayabiliriz.aynı işlemleri haber sitesinin arşivleme işlemleri 
	içinde yapabiliriz.arşiv sayfaalrında da kategorileri ve haberleri  arşivleyebiliriz.
	şimdi anasayfa için route oluşturalım.
