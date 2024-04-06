
Bu projede Web Api token işlemlerine başlayacağız.
	Öncelikle Code first ile bir veritabanı oluşturacagız.
	Code first ile oluşturacagımız için entity frameworkü indirelim.

	Bir kitap tablosu bulunduran Veritabanı oluşturacagız.Bunun içinde öncelikle Models-Kitap class
	Propları oluşturduktan sonra bunu bir Kütüphane servisi diye Servis içerisinde DbSet lerini ayarlamamız lazım.(DAL yerine Direk modelse KütüphaneServis classı ekleyelim.)
	KutuphaneServis ayarlarını ve Webconfig ayarlarını yaptıktan sonra migration ayarlarına geçebiliriz.
	Migration commands:
		1)Enable-Migrations -EnableAutomaticMigration
		2)add-migration CreateDb
		3)Update-Database

	Şimdi Owin Startup Sınıfını oluşturma işlemlerini inceleyecegiz.Bu sınıf ile birlikte Token oluşturmak için gerekli kodları yazacagız.
		Öncelikle Manage Nuget:
			1-Microsoft.AspNet.WebApi.Owin
			2-Microsoft.Owin.Host.SystemWeb
			3-Microsoft.Owin.Security.OAuth
		Bu kütüphaneleri ekledikten sonra App_Start altına bir tane Owin Startup class oluşturmalıyız.
		bu owin startup class içine namespace olarak using Microsoft.Owin.Security.OAuth; ekleyelim.

	Owin işlemlerini yapıp tokeni oluşturduktan sonra sıra CRUD işlemlerini yapmaya ve veritabanıyla baglantıyı kurmaya.
		Öncelikle bir controller oluşturalım.(webapi2-Kitap)
		birden çok action oluşturudugumuz için webapiconfig e gidip url yi düzenleyelim.


	Şimdi Postman eklentisini kullanarak oluşturdugumuz web apiye sorgu gönderme işlemeni inceleyecegiz.
		Apimiz Authorize şeklinde oldugu için bunla token oluşturmayı sonra bu tokeni kullanarakta GetKitaps metotlarını çalıştıracagız.
		Update-Package Newtonsoft.Json consola yazarak paketleri güncelliyoruz.Bu işlemden sonra artık postman kullanabiliriz.
		Projeyi çalıştırıp postmane girelim.
			GET metodunda https://localhost:44357/api/Kitap/GetKitaps linkini çalıştırdgımızda unauthorizated dönüşü alacagız.
			Post metodu kullanarak (/token) https://localhost:44357/token linki ile giriş yapabilecegiz.
				Header kısmında :
					ilk parametre Accept ikinci parametre olarak application/json parametresini giriyoruz.Daha sonra
					İlk parametre:content-type ikinci parametre  application/x-www-form-urlencoded
				Body kısmında:
					x-www-form-urlencoded seçiyoruz.
						Key: grant_type  value:password
						Key: username  value:OGS
						Key: password value:123
				Bu ayarları yaptıktan sonra send diyerek tokenimizi oluşturmuş olacagız.
				Daha sonra GEt metoduna geri dönüp 
				Headers:
					Key:Authorization Value:BEARER(token type) access tokeni yapıştırıyoruz.
				GET işlemini gerçekleştirdigimiz zaman böylelikle veritabanında bulunan kitap listesine erişmiş olduk.

