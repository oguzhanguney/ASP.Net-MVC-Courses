Bu projede web api temel oturum işlemlerini inceleyeceğiz.
	Temel oturum işlemlerine geçmeden önce authorization filter attr oluşturmamız lazım. bu attr göre temel oturum açma işlemlerini inceleyeceğiz.
	Add folder -MyFilter: bu klasör içerisine class: MyAuthor oluşturacagız.
	Projeye bir login class ı ekleyelim ve login işlemlerini burada gerçekleştirelim.

	Author  filter attr işlemlerimizi tamamladıktan sonra Veritabanı oluşturmaya geçelim.
		Bu veritabanında 2 tane tablomuz olacak.
			Personeller
			Yetkililer
		Sql Serveri açarak işlemlerimizi yapalım.
		SQl serverda tablolarımızı oluşturduktan sonra model classına ado.net ekleyelim.
		Artık web api ile veritabanına erişebilir.Auth ayarlarını sağlamlaştırabiliriz.