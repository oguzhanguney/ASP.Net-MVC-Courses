
projemizi oluştururken authenticationu individual user olarak belirledik çünkü authorize işlemleri yapacagız.

--Authorize filter:
	Yetki filtreside denir.projede action ve controllerlara  rol ve kullanıcı bazında yetkilendirmenin yapılmasını sağlayan filtrelerdir.
	yetki filtresi için oluşturulan filtre sınıfı ıauthorizationfilterinterface inin kalıtımını almalıdır.
	controller ve action a tanımlanabilir.
	yetkilendirme işlemimiz  ıauthorizationfilterinterface içerisindeki bir metotla çalışır.bu metodun adıda homeauthorization .sisteme giriş yapan kullanıcının yetkisinin olup olmadıgını kontrol eder.
	parametre olarakda authorizationcontext nesnesi alır.bu nesne içinde route adı ve httpcontext barınır.
	varsayılan yetkilendirme sınıfı olan authorize sınıfımızda bulunmaktadır.
	authorize sınıfı action attribute olarak tanımlanırken 3 farklı parametre alabilir.
	(
	users:actiona yetkisi olacak kullancı bilgisini tanımlar .kişiler arasına virgül konularak yazılabilir
	rols:actiona yetkisi olacak kullanıcı rollerinin bilgisini tanımlar
	orders:attributeler arasındaki sıralamayı tanımlar.
	)

	home controller ı açalım contact actionu için bir yetkilendirme tanımlayalım
	sayfayı çalıştırdıgımızda contacta tıkladıgımızda üye ol sayfası açılıyor. register new user diyelim ve yetkili olan hesabı oluşturalım.
	kayıt işlemini yaptıktan sonra artık contact sayfasına erişim sağlayacagız.

	