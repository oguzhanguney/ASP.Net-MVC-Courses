﻿-Bu kısımda örnek üzerinden giderek controller yapısını inceleyecegiz.Örnegimiz bir üniversitenin öğrenci bilgi sistemi olacak.buna fakültesi,bölümlerini ekleyecegiz.
bunları eklerkende controller konusunu görecegiz.
-controller asp.net mvc nin yönetim mekanizmasıdır.view ile modeli haberleştiren bir classtır.controller eklerken aslında biz bir sınıf ekliyoruz ama farkı 
controller class ından miras alan bir sınıf.

-Şimdi projeyi oluşturma aşamasınaa geçelim.projemizde Öğrenciler, fakülteler,fakültenin bölümleri olacak bunun için ilk olarak modellerimizi oluşturalım.
-Fakülte modelimizi oluşturduktan sonra Db ile modelimiz arasında baglantı saglayacak,yönetecek bir class oluşturmamız lazım.Bunada context classı diyorduk.
DbContext ten miras alan bir context sınıfı oluşturmalıyız.projeye "DAL" adında bir klasör ekliyoruz.bu klasörün içerisine bir "OBSContext " adında class oluşturalım.
-OBSContext classımızı oluşturup kaydedelim.
-Burdan sonra ConnectionString ayarlarımızı yapalım. (web.config-> tag açarak tanımlamamızı yapalım.)
		(	<connectionStrings>
				<add name="OBSVeritabani" providerName="System.Data.SqlClient" connectionString="Data Source= DESKTOP-05HNBNM\SQLEXPRESS; Initial Catalog=OBSDB;
					 Integrated Security= true;"/>
			</connectionStrings>)

-Şimdi controller ı oluşturalım ve bu controller a DatabaseContext imizi çekerek database işlemlerimizi yapmış olacagız.(empty-fakultecontroller)
-bu controllera veritabanımızı baglayalım.(OBSContext veritabani(nesne adı)=new OBSContext();)
-daha sonra indexten bir view oluşturalım (boş ve layoutsuz)

-şimdi action türlerine bakacagız.(->fakultecontroller)

--Json result:burada json türünde bir veri gönderme veri gösterme işlemi yapacagız.öncelikli olarak json verilerini göndermek için json result türünde metot oluşturalım.ve json işlemi yapalım.(fakulte controller)

--Şimdi file result işlemlerini görecegiz.files adında bir klasör açalım ve içine bir txt atalım
--file result dönüş tipi yapıldıgı zaman returnununde filepathresult olması lazım.bu bizim serverimizdaki dosyayı indirmemize yada göstermemize yarayan dönüş tipi olacak.
--öncelikle boş bir controller oluşturalım (dosyalar controller)

--şimdi FileStreamResult :serverda var olmayan dosyayı biz oluşturup biz geri dönderecegiz.(dosya controller)

--Redirect to Route Result:bu metot farklı bir action metoda yönlendirme işlemi yapar.redirect metodunda içine aldıgı url ye yönlendiriyordu şimdi farklı bir action metoduna yönlendirme yapalım
--http post ekle metodunun üzerinde degisiklik yaparak ilerleyelim (fakulte controller) 
--Ekle metodu eski hali (
        public RedirectResult Ekle(Fakulte kayit)
        {
            //kaydı veritabanına eklememiz lazım bunun içinde:
            veritabani.Fakulteler.Add(kayit);
            veritabani.SaveChanges();
            return Redirect("https://www.youtube.com/channel/UCabuPeggpkGAuoPB74jfogg");
        })
        --gerekli işlemleri yaptıktan sonra ekle viewi çalıştıralım.



--Enable Migration(partial view döndürme): senaryomuz biz bir sayfada dropdown list oluşturalım ve dropdown list elemanlarını fakulteler isminden alalım sonra bir fakulteyi seçip butona tıkladıgımızda
--partial viewde olan bu fakulteye ait bölümleri getirelim.bunu yapmak için veritabanımızda bölümler tablosuna ihtiyacımız var.bunuda code first yardımı ile yaparken model klasörü altında bir class ekleyelim
--Bolum class ını oluşturalım .(bolum.cs)
--bolumu oluşturduktan sonra yapmamız gereken databasecontext imizde gidip datasetimizi oluşturmak.
--veritabanı ile ilişkilendirmeyi yapmak için migration özelligini açmamız gerekiyor.(view/other windows/package manager console
--enable-migrations yazalım.bu database ile modeli birleştiren özelliktir.yani kod olarak yazdıgımızı database olarak bize açıyor.
--bu işlemden sonra tekrar package manager i açalım ve update-database yazalım. böylelikle yazdıgımız kodlar sonucunda veritabanımızı güncelledik .


--Partial view Result:ornegimizi daha düzgün görmek için bölüm tablosuna ms sql den veri ekleyelim.
--bölümleri ekledigimize göre partial view i oluşturalım.önce bölümler diye controller ekleyelim.

--partial view döndürme işlemleriyle devam edelim.şimdi bir dropdown list tanımlayalım fakulte alsın ,fakulteye tıklandıktan sonra jquery ile bu partialview i oraya cagıralım.
--önce fakulte controllera gidelim


--şimdi javascript result türünde metot oluşturalım ve bu metodu başka bir viewda kullanalım.öncelikle bir tane text controller oluşturalım


--model ve action attributlerine başlıyoruz burada action name i görelim fakulte controller a gidelim