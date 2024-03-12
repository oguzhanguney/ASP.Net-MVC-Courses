--burada action attributelerinden httppost u görecegiz.
--burada bir personel silme işlemi yapacagız.öncesinde bir personel oluşturmalıyız ve ekranda göstermeliyiz.(models e gidip bir personel sınıfı oluşturalım.)
--modeli oluşturduktan sonra bir tane personel controller oluşturalım.


--şimdi httpget metodunu inceleyecegiz.bu attribute yi incelerken site içerisinde arama yapma örnegi üzerinden devam edecegiz. öncelikle view oluşturalım (personelcontroller)
--bu view de bir text ve submit inputumuz olsun .text içerisinde girilen degeri personeller içerisinde arama işlemi yapalım.


--Bind attribute: viewdan alınan verilerin kontrolünü yapmamızı saglar.yani hangi verilerin alınıp hangi verilerin alınmayacagını bind att ile ayarlayabiliyoruz.iki farklı kullanım yolu var.
--1.içerisinde include tanımlamak (include tanımlarsak verilerin hangi propertielerin alınacagını tanımlarız.)
--2.exclude tanımlamak.(exclude tanımlarsak verilerin hangi propertielerin alınmayacagını tanımlarız.) 
--hemen yeni bir personel ekleme action u ile başlayalım. go controller 



--outputcache attribute: önbellekleme yapmamıza yarar.önbelleklemeyi neden yaparız :projemizde dönen degerlerin önbellekten okunmasını istedigimizde bunu yapmamız lazım.
--önbellekleme nedir:bizim veri tabanıyla çalışan bir projemiz var ve proje içinde veritabanında aldıgımız gösterdigimiz degerlerin günde veya haftada degistigini varsayalım.haftada bir degisen işlem için
--her istek gittiginde gidip veritabanındaki verileri alıp geri döndermesi sistemi yorar.biz bunları önbellekte tutarsak sistem o gün içerisinde önbellekten okur.önbellek süresi biterse veritabanından tekrar okur
--ve önbellege alır.yani işlemler daha hızlı hale gelir.örnek olarak onbellek controller oluşturalım.



--RequireHttps attribute: https i zorunlu kılma özelliği.bazı durumlarda kritik verilerin gönderme işlemi oldugunda şifreleyerek göndermek zorunda oluruz çünkü gönderirken verilerimiz server da yakalanmasın ve görüntülenmesin
--mesela bankada bilgileri şifreleyerek göndermemiz gerekir.veriler yakalansa bile görüntülenemesin.bu özellikle bunu saglarız.eger bu attributeyi controller üzerinde yazarsak bütün action larda geçerli olur.
--eger kullandıgımız pc nin https ayarları yapılmadıysa debug modda çalışırken bunu kullanmamalıyız.release(yayınlanma) moda geldigimizde aktif hale getirmeliyiz.örnek:(OnlineIslemler controller)


