
-- Web api yi biz dosyamızı veritabanına yüklemek,belirli bir dosyayı silmek yada dosyaları çağırma işlemleri için kullanacagız.


	1)UploadFile işlemi:
		öncelikle dosyalarımızı yüklemek için klasöre ihtiyacımız var biri file diğeri temp olacak.temp bir ara klasör dosyamız yüklenirken önce tempe yükleyecegiz.burda şifreleme algoritması ile
		şifrelenmiş şekilde yükleniyor.sonrada dosyamızı files klasörüne yükleyecegiz.
		Bunları ekledikten sonra bizim modelimizle controller arasında bağlantı kuracak bir sınıfa ihtiyacımız var.daha sonra bir api controller ekleyelim.

		veritabanı için model altına ado.net entity datamodel açıyoruz ve projemize bağlıyoruz.veritabanını daha önceden oluşturmuştuk zaten tablo baglantısını kurup bitiyoruz.


	2)Get All files işlemi:
		bu metot veritabanı içerisindeki bütün dosyaları getirmeyi sağlayacak.

	3)Delete file işlemi:
		bu metotda veritabanı içerisindeki seçilen bir dosyayı silme işlemini yapacagız.