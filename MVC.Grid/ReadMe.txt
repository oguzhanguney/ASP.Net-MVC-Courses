--ilk olarak code first yaklaşımı ile veritabanımızı oluşturmaya başlayalım.
--ilk önce yapacagımız şey veritabanında tabloları oluşturmak olacak.class ekleyerek bu işlemi yapalım.

--veritabanı tabloları oluşturduktan sonra sıra bunları veritabanı ile ilgili yönetecek databasecontext classını oluşturmaya.(models altına manager klasörü oluşturalım ve bu klasöre databasecontext sınıfı ekleyelim.)
--databasecontext i oluşturduk. şimdi webconfig ayarlarımızı yapalım. (connectionstring)
		<add name="DatabaseContext" providerName="System.Data.SqlClient" connectionString="Server=DESKTOP-BAPR309;Database=PersonelDB; Integrated Security=true;"/>

--bu işlemden sonra viewi oluşturdugumuz zaman veritabanımız oluşacak.önce bir controller oluşturalım.ve burada databasemizi oluşturalım.home controller
--index viewi çalıştırdıgımız zaman otomatik olarak veritabanımız oluşacak.

--veritabanımızı oluşturduktan sonra veritabanı üzerinde degisiklik yapmak istedigimizde codefirst sadece bunu kullanarak degisiklik yapmamıza izin vermeyecektir.bu degisikllikleri yapabilmemiz için migration 
--yapısını kullanmalıyız. öncellikle tools-nuget packet manager-package manager console açalım. 
-- enable-migrations yazalım.
--daha sonra models içine adresler diye bir class ekleyelim. adresleri oluşturduktan sonra databasecontexte gidelim.adresleri set edelim.
--adres classını databasecontexte set ettikten sonra packagemanager console update-database yazalım.


--veritabanı ve verileri ekledigimize göre sıra geldi bu verileri çekmeye.bu verileri çekerken bs yardımıyla daha düzenli bir şekilde çekelim. 
--şimdi bir layout sayfası oluşturalım ve bu sayfada da verilerimi listele actionu ile çekelim. layoutu oluşturalım .(views-shared klasörü oluşturalım.) bu klasöre de mvc 5 layout page ekleyelim
--layout sayfamıza bs min.css ve jquery min.css i ekleyelim. daha sonra listele actionu oluşturalım home controller da. 

--listele viewi oluşturduktan sonra çalıştıralım .şunu görecegiz 100 personel oldugu için herhangi bir sayfalandırma yapmadıgı için en aşağı kadar verileri sıraladı.
--biz burda grid.mvc ile bu personel listelemeyi daha düzenli bir şekilde yapacagız.
--bunun için projemize manage nuget packet-grid.mvc yi ekleyelim.
--layout sayfamıza eklemek için grid yapısı bootstrapi kulllandıgı için önce script dosyasından bs min.js yi ekleyelim.ardından grid.mvc min.js i ekleyelim.son olarak content altında gridmvc.css i de ekleyelim
--şimdi gridmvc controllerdan listeleme işlemi yapalım.
--gridmvc controllerımızı oluşturduktan sonra gerekli sayfalamayı ve gerekli özellikleri saglayalım. gridin listele view ine gidelim.