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


	--    Haber sitemiz şöyle olsun:
		Ana Kategorilerimiz: Güncel haberler,Spor,Magazin 
		-güncel haberlerin bir alt kategorisi olmasın.
		-spor kategorisinin futbol basketbol voleybol şeklinde alt kategorisi olsun.futbol kategoriside bjk gs fb diye kategoriye ayrılsın.
		-yani baktıgımız zaman kırılım sayımız 3 oluyor :  spor-futbol-takım şimdi route config ayarlarında gerekli düzenlemeyi yapabiliriz.

		-haber sayfasının url si için : routeconfig

	--Rota kısıtlaması: 3 çeşit var bunlar sayesinde girilen değerin belirli sınırlar çerçevesinde girilmesini saglayabiliriz.yani url mizde sadece belirledigimiz formatta giriş olacak.

		1)Regular expression Rota kısıtlaması:
		metin düzenlemek veya belirledigimiz düzene uyan alt metin parçaları oluşturmak ve kontrol etmek için kullanılır.yani biz regex oluşturup bizim oluşturdugumuz bu düzenli ifadeye uyan
		metinler girilmesini saglayabiliriz.

		(.) Simgesi: metin içerisinde bir karakterin olup olmadıgını kontrol eder.nokta simgesinin oldugu yerde en fazla bir karakter olabilir. 
				exp:Oguzhan.Guney => Oguzhan Guney || OguzhanGuney  yani ya bir karakter gelecek yada karakter gelmeyecek .

		(+) Simgesi: kendinden önce gelen karakterin en az bir kere tekrarlanması gerektigini söyler.
				exp:Oguzhan+Guney => OguzhanGuney || OguzhannGuney .

		(?) Simgesi:kendinden önce gelen karakterin en fazla bir kere gelmesini sağlar.
				exp:Oguzhan?Guney => OguzhaGuney || OguzhanGuney

		(*) Simgesi: kendinden önce gelen karakterin sıfır veya daha fazla tekrarlanmasını sağlar.
				exp:Oguzhan*Guney => OguzhaGuney || OguzhanGuney || OguzhannnGuney ... yada tek karakter dedigimiz için (Oguz)*Han => Han || OguzHan || OguzOguzHan şeklinde de olabilir.

		[] Simgesi : köşeli parantez içindeki karakterlerden birinin gelecegini bildirir.
				exp: 200[0-9] => 2000 ,2001 .... 2009

		{} Simgesi : kendinden önceki karakter içine yazıldıgı kadar tekrar eder.
				exp: oguz{2} => oguzoguz

		(^) Simgesi: metnin başını ifade eder.
				exp: ^Oguzhan  metnin başında o var mı yok mu 

		($) Simgesi: metnin sonunda mıyız ifadesini belli eder
				
		(\s ve \S) Simgesi: boşlugu ifade eder
				exp: Oguzhan\sGuney => Oguzhan Guney   ---- Oguzhan\SGuney => OguzhanGuney

		(\w ve \W) Simgesi:String degeri ifade eder .Büyük harf olumsuzu.

		(\d) Simgesi: ondalik bir sayı gelecegini ifade eder



		Cep telefonları için düzenli bir ifade oluşturalım:
			--öncelikle cep telefonları 05 ile başlar .
				^[05][0-9][0-9] ([0-9]){7}$ böylelikle cep telefonu formatını düzenli ifade olarak ayarladık.
				şimdi düzenli ifade kullnarak route tanımlayalım.

		2)HttpMetotConstraint Rota Kısıtlaması:
		bu sınıfın yaptıgı iş aslında url nin post get put delete (CRUD)   işlemlerini yapan metotların olup olmayacagını belirtme işlemidir.
		mesela biz post olarak çalış diyorsak url e sadece post işlemi yapılır.
	
		3)Kullanıcı Tanımlı Rota Kısıtlaması:
		Bizim kendimize has oluşturdugumuz bir rota kısıtlaması oluyor.Bunu yapabilmek için IRouteConstraint interface ini miras alan bir sınıf kullanıyoruz.

		örnegin şöyle bir örnek düşünelim kategorileri veritabanında kontrol edelim eğer veritabanında varsa kategorimiz çalışşın yoksa çalışmasın.projeye bir RouteConstraints klasörü ekleyelim

