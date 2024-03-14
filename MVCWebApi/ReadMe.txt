--Api:bir programlama arayüzüdür.bir projenin farklı yazılım geliştiriciler için oluşturulan arayüzüdür diyebiliriz.farklı bir program geliştiriciler bizim programımızdan kullanmak istediği özellikleri ,verileri yada
vb şeyleri almak için başka bir geliştiriciye açmamız olarak adlandırabiliriz.

--şimdi bir kayıt oluşturalım ve bu kayıtları listeleyelim.öncelikle ürün classı ekleyelim.
--daha sonra webapi controller ekleyelim.
--öncelikle oluşturdugumuz ürün class ından bir liste yapalım ve bu listede verilerimizi girdilerim.
--uruncontroller ı çalıştırdıgımızda https://localhost:44381/api/Urun bu url ile başka programlar artık bizim apimize,ürünlerimizin detayına erişebilir.(xml formatta görüntülendi).
--şimdi başka bir mvc projesinden bu apideki ürünlere erişmeye çalışalım.
--boş bir mvc controller oluşturalım.(UrunlerController)
--jquery kullanacagımız için layout a <script src="~/Scripts/jquery-1.10.2.min.js"></script> ekleyelim.
--TumUrunler i çalıştırdıgımızda api mizi çekerek ürünlerimizi göstermiş olduk .


--şimdi bir id ye göre listeleme işlemi yapalım.yani artık id numarasını bildigimiz bir ürünü getirme işlemi yapacagız.
	1)öncelikle programımızda web apimizde geturun isminde bir ihttpactionresult dönen bir metot oluşturalım. parametresinide int id olarak verelim.(uruncontroller ekleyelim.)
	2)şimdi yazdıgımız bu apiyide kendi programımızda kullanalım.
	urunlercontroller a gidelim ve urungetir adında actionresult dönen bir metot tanımlayalım.


--şimdi IHttpActionResult metodundan bahsedecegiz.
1)neden kullanılır:web api uygulamamızda action metotlarında yaptıgımız işlemler sonucunda farklı degerler döndürmemiz gerekebilir.mesela ürün kaydetme işlemi sırasında eğer bir kullanıcının yetkisi yoksa
	yetki bilgisini dönderebiliriz.yada ürün listeleme kaydetme vb işlemler sırasında bir hata yoksa verileri geri dönderelim.yada ürün adına göre arama yaptıgımızda hiçbir ürün bulunamadıysa sistemde 
	arama kritlerlerine uygun ürün olmadıgına dair bir bilgi , yada işlem sırasında bir hata oluştugunda geriye hata bilgisini dönderebiliriz.aynı ürün iki defa kaydedilmeye çalışıldıgında çakışma yani
	conflig bilgisini dönderebiliriz.yada sistemde bir hata oldugunda (400 badrequest) hatasının bilgisini  dönderebiliriz.
	Bir action metotda geridönüş degeri olarak sadece veri degil,oluşan hatalara yada durumlara uygun yukarıdaki bilgileride döndürmemiz gerekebilir.
	
	-"Ok"  işlemin başarıyla tamanlandıgı durumdur.
	-"Not Found"  aranan bir verinin bulunamaması durumudur.(urun controller a gidip yazalım. firstordefaultu silelim.) daha sonra urungetir view a gidip error fonk ekleyelim.
	-"Unauthorized" kullanıcının işlem yetkisinin olmaması durumudur.örnegin bir ürün getirecek kişinin yetkisi yoksa unauthorized kullanabiliriz.

	--web apiyle birlikte post işlemini yapalım ve aynı veriyi iki kere kaydetme durumunu yanı conflict durumunu inceleyelim. uruncontroller a gidip post işlemi için actionu yazalım.
	--daha sonra urunlercontroller a gidelim ve bir action metot tanımlayalım.

