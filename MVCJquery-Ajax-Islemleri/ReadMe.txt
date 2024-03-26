
Bu derste asp.net mvc ile jquery ajax işlemlerini inceleyecegiz.

	-web api ile birlikte verilere erişip, jquery kullanarak mvc ye web api üzerindeki verilere getirecegiz.

	Ajax nedir?
		-Bir sayfada yapılan değişiklerden sadece belirli bir kısmını sunucuya gönderilmesi işlemine ajax denir.
		-Ajax  js programlama dili ile xml teknolojisinin beraber çalışması sonucunda sayfa içersinde istenen parçaların, tüm sayfayı göndermeksizin, sunucuya gönderip sonucunu almaya yarayan teknolojidir.


	1)İlk olarak $.ajax() fonksiyonunu inceleyelim.
		-Jquery de asenkron olarak sunucuya gönderilecek ve alınacak veriler bu metot ile yapılır. ajax ile işlem yapılırken baglantı ayarları için 33 parametre kullanılabilir.
		-params:
			+url:işlemin yapılacagı sayfanın yada servisin linkini belirliyoryz.
			+type:servise yapılacak talebin türü (get,post,put,delete)
			+datatype:servisten dönen verinin türünü gösterir.(xml,text,js,text,html,json)
			+data:servise veri gönderilmesi durumunda gönderilecek verilerin tanımlanması durumudur.(yani degerleri  json tipinde yazıp data param ile gönderebiliriz.)
			+timeout:servisten gelecek yanıtın max gelme süresinin ms cinsinden tanımlandıgı parametre.
			+success:servisle yapılan veritransferi başarılıysa çalışan olayı tanımlar
			+error:veri transferi başarısız ise.
			+contenttype:servise veri gönderme sırasında gönderilecek verinin türünün tanımladıgı parametre .

		-ilk olarak bir ürün modeli oluşturalım ve  bu ürün modelini kullanan veriler elde edelim.
		-daha sonra bu modeli kullanan veriyi ekleyelim.
		-web apimizi oluşturarak bu ürünlere ulaşalım.
		-şimdi controllerımızdan web apiye erişip ürünlerimize erişim saglayacagız.

	2) $.getJSON() fonksiyonunu inceleyelim.
		-Httpget att sahip json türünden veri dönderen bir action ile yapılan veri alışverişi için getjson metodu kullanılabilir.
		-getjson ile sadece  httpget işlemi yapan actionlardan veri dönderebiliriz.


	3)$.post() fonksiyonu:
		-httppost att sahip json  türünden veri işlenen bir action ile yapılan veri alışverişi için kullanılır.
		-parametre olarak işlem yapılacak link ve actiona gönderilecek veri tanımlanır ve işlem başarılı ise done hatalı ise fail çalışır.