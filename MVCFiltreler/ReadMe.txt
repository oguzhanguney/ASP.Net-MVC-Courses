
FİLTRELEME:
    -filtreler MVC de sunucuya gelen istekler gerçekleşmeden yada gerçekleştirdek sonra çalışan işlemlerdir.
    örneğin:uygulama içerisinde bir hata oluştuğunda hatanın kullanıcıya görünmesi istenebilir.bu durumda hata filtresi kullanırız.
            yada bir işleme yetki kontrolü olacaksa o işlem gerçekleşmeden işlemi gerçekleştirenin yetkisinin olup olmadıgı kontrol edilebilir.bu durumda yetki filtresi kullanırız.

Asp.net mvc de 4 çeşit yetki vardır. Bu yetkileri şöyle tanımlarız:
        1.Action filter:action metodunun çalışmasına göre belirlenir   (Iactin miras almalıdır.)
        2.Authorize filter:bu bir yetkilendirme filtresidir.
        3.Result filter:actionresult çalışmadan önce yada sonra çalışır.
        4.Exception filter: action yada controller da hata oldugunda çalışır.
    
    
        1.Action filter:(IActionFilterInterface miras almalıdır. bunun yanı sıra IResultInterface in kalıtımınıda aldıgı için sadece action filtreleme işlemlerinde Iactionfilter kullanmak daha mantıklı.)
            örneğin bir log alma işlemi yapalım.kullanıcının hangi action ile iletişime girdiğini böylelikle belirleyebiliriz.action çalışmaya başladıktan sonra yada bitirdikten sonra loglara bakabiliriz.
            varsayılan filtre sınıfı actionfilterattribute dür. bu sınıfta IActionFilterInterface in kalıtımını almıştır.
            ıactionfilter içerisinde 2 metot vardır.
                onactionexecuting :action çalışmadan hemen önce çalışır.
                onactionexecuted: action dan hemen sonra çalışır.

        öncelikle projeye işlem loglarını tutacagımız bir class ekleyelim.
        daha sonra filtreleri içinde tutacagımız klasörü oluşturalım.
        log bilgi türünden bir liste yapalım ve logverileri sınıfında tutalım.

        2.Result filter:result filtreleri bir action çalıştıktan sonra geri dönüş verisinin(view) derlenmeye başlamasından hemen önce yada sonlanmasından hemen sonra çalışan filtrelerdir.
            IResultFilter sınıfından kalıtım alır.
            örneğin action işlemlerinin sonucunda bir view döndürsün.action metodunun çalışmaya başladıgı andan viewin derlenme işleminin sonlanmasına kadar çalışan action ve result filtrelerinin sıralaması:
            öncelikle index çalışmaya başlamadan önce action çalışır.ve onactionexecuting tetiklenir. 
            ikinci olarak action çalışmayı durdurdugundan hemen sonra onactionexecuted tetiklenir.
            üçüncü olarak action ve filtreleri çalıştıktan sonra yani index ve filtreside çalıştıktan sonra view derlenmeye başlar.view derlenmeye başlamadan hemen önce result filtresindeki
            onresultexecuting çalışır. view derlenmesi tamamlandıktan sonrada onresultexecuted çalışır.

        3.Exception filter:projemizin çalışması sırasında oluşan hataları yakalayıp ,işlem yapılmasını sağlayan filtrelerdir.
            IExceptionFilter sınıfından kalıtım alır.
            hata filtrelerinde varsayılan filtre sınıfı handleerrorattribute dur.

            öncelikle hata nasıl yakalanır,hata yakalamak için ne yapmalıyız.mvc de hata oluştugu zaman kullanılan sayfa hangisidir bunu inleyecegiz.Hatacontroller ekleyelim.
            hata sayfasının çalışması için webconfig te system.web altında 	  <customErrors mode="On"></customErrors> tagi açacagız. default olarak off.
            artık uygulamamız hataya düştüğünde devam ettirince bizim hata sayfamıza gidip çalıştıracak.
            bu hata yakalama işlemini sağlayan app start altındaki filter config içerisindeki   filters.Add(new HandleErrorAttribute()); özelliğidir.
            şimdi biz bu hata sayfasında hatanın nerede oldugunu ve neyden kaynaklandıgını yazdırabilirim.error.cshtml sayfamıza @model system.web.mvc.handleerrorinfo yu eklemeliyiz.
            eğer error.cshtml i kullanmak istemiyorsak ve kendimize ait bir hata sayfası olulturmak istiyorsak shared klasörü içine bir view ekleyip oluşturalım.(hata.cshtml)
            bu yeni hata sayfasını kullanmak içinse controller a gidip hata oluştugunu düşündügümüz metodun üstüne handleerror attributunu yazmamız gerekiyor.

            şimdi log alma örnegimizle devam edelim .logattribıtes sınıfında bir hata oluştugunda hatanın kodlanmasını saglayan metodu yazalım.
            logbilgi classına gidelim hata oluştugunda yakalamak için hatamesaj prop oluşturalım.daha sonra logattribute gidip metodumuzu yazalım ve hatacontroller a log etiketi yapıştıralım.
            işlemleri yaptıktan sonra önce hata/index e gidelim daha sonra home/logkayıtları na gidelim.
