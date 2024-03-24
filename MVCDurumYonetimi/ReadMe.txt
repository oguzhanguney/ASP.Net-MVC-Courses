Bu derste asp.net mvc deki durum yönetimi kavramını inceleyeceğiz.

	-Durum Yönetimi nedir?
		asp.net mvc ile durum yönetimi bir web uygulaması oluşturdugumuzu düşünelim.bu web uygulamalarında sunucu ve istemci arasında gerçekleşen iletişim sırasında bilgiler kalıcı degildir.
		örnegin sunucudan bir sayfa çağırdık istemiciyle ve birtakım işlemler yaptık bilgi oluşturduk.ardından başka bir sayfaya yönlenmek istedik.Eğer bu sayfadaki bilgileri kaybetmek istemiyorsak 
		bir yerde saklamamız gerekir.aksi takdirde başka sayfaya geçtigimiz vakit bu bilgelere ulaşamayız.işte bu saklama işlemini durum yönetimi kontrolleri sağlar.
		Durum yönetimi kontrolleri ikiye ayrılır:
		1)Sunucu tarafında tutulan (sunucu tabanlı durum yönetimi)
			-session state
			-application state
		2)İstemci tarafında tutulan (istemci tabanlı durum yönetimi)
			-cookies


		Şimdi Session Statelerden bahsedelim.
			-bir session oluşturmayı okumayı ve sessionu yok etme işlemlerini yapalım.controller ekleyerek başlayalım
			-Session sunucu tabanlı bir durum yönetimi olup veri saklama işlemleri için kullanılır ve saklanan verilere site içerisindeki tüm sayfalar içerisinden erişilebilmektedir.
			-Session başta üyelik işlemleri olmak üzere bir çok farklı işlemlerde kullanılabilir.mesela uygulamaya giriş yaptıgımızda bu giriş bilgilerini sessionda tutarsak  diger sayfalarda görme yetkisi
			 olup olmadıgı kontrol edebiliriz.yada birşey alacaksa session da tutulan kullanıcı bilgisine ulaşıp yetki kontrolü yapabiliriz.

			-Şimdi sessionların yaşam sürelerini belirleyelim.ve session başlatma ve bitirme işlemlerini gerçekleştirelim.
			 öncelikle bir ayar yapılmadıysa sessionların yaşam süresi 20 dk dir.bu süreyi ayarlamak için web config içerisinde sessionstate etiketini ayarlamamız gerekir.bu system.web içerisinde ayarlanır.
			 sessionları 60 dk ya ayarlayalım.böyle yaptıgımız zaman kullancı bilgilerini 60 dk boyunca sunucunun belleginde tutacagız demektir.buda performans kaybı yaşattırabilir.
			 o yüzden projelerimizde bu süreyi ayarlarken performans kaybı ve işlevsellik oranına dikkat etmemiz gerek.

			-şimdi sessionları başlatma ve bitiş işlemlerine bakalım.
			 örnegin sitemize giriş yapan kullanıcıları bulmak istiyoruz.bu kullanıcıları global.asax içerisine session start ve end metotlarını koymalıyız.ve merkezi bir noktada bir deger tanımlayıp
			 siteye giriş yapıldıgında session start içerisinde bu degeri 1 arttırız ve sessionend içerisinde 1 azaltarak o sitede kaç kullanıcı oldugunu bulabiliriz.

		Application state: 
			-bir proje içerisinde sabit degerlerin kullanılması gerekebilir.bir sayfada sabit bir deger tanımlayabiliriz ve bir başka sayfada bu degere ulaşmak isteyebiliriz.
			 uygulamanın geneline hitap eden nesneler için application stateler oluşturulmuştur.
			 sessiondan farkı bir kullanıcının session nesnesini başka bir kullanıcı göremez. ama application ile bu nesne tüm kullanıcılara gösterilebilir.
			 Yani bütün kullanıcıların görünümüne açık olmasıdır.Tüm kullanıcılara aktif olarak kaç kullanıcı oldugunu gösterme işlemi yapmıştık.
			 şimdi yeni bir metot oluşturalım.

		Cookies(çerezler):
			cooki tanımlaması okuması silmesi ve yaşam sürelerini inceleyelim.
			-aynı sessionlar gibi oturuma özel,kullanıcıya özel, nesnelerdir.tek farkı sunucu üzerinde degil istemci tarafında tutulur.yani tarayıcı içerisinde saklanır.
			kullanıcı cookileri tarayıcı üzerinde sildigi zaman silinmiş olur birdaha erişemez.
			bir cookie en fazla 4KB lık yer kaplar.
