
Bu Projede Area yapısını inceleyecegiz.
	Bir web sitesi birden fazla bölümden oluşabilir.Bu bölümler 
	Bir anasite olabilir-Tüm kullanıcıların web üzerinden erişip kullandığı bölüm,
	Bir forum sitesi olabilir;kullanıcıların soru sorup cevapları takip ettigi bir site ,bu Anasiteden farklı bir tasarıma sahip olabilir,
	Yada yönetim paneli olabilir; Site yöneticilerinin ve yazarların işlem yaptıkları alan.

	Şimdi bu 3 bölümü birden fazla projeyle geliştirebiliriz.Ama biz bu bütün projeleri tek bir proje çatısı altında geliştirmek istersek Area yapısını kullanırız.
	Area yapısında tüm bölümler Klasörlendirme,tasarım,yetkilendirme ve erişim konularında birbirinden farklı yapılarda ayarlanabilir.


	Şimdi İlk Area mızı oluşturalım.
		Forum ve yönetim panelini area oluşturarak kullanalım.
		projeye add-area  +Forum ,+AdminPanel
	Şimdi Arealar içerisindeki action lara erişim yöntemlerini inceleyelim.
		Forum areas a bir controller ekleyelim.(makaleler)
		Area lar içindeki bir actiona erişmek için url de Başına area adını eklememiz gerekir.
		
		Bir area oluşturuk daha sonra bu area nın ismini değiştirmek için Forumarearegistrationa gidip AreaName  özelliğini değiştirmemiz lazım. daha sonra klasör adınıda değiştirmeliyiz.