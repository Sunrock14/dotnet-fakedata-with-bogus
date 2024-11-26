# Sahte data üretme 
Bu proje yeni yazılan bir projenin gerçek verileri yakın verilerle çalışmasına katkı sağlamak için yazılmış harici bir yardımcı programdır.
ilgili veritabanını scaffold ile çekerek her model için uygun verileri seçim yararak verileri oluşturmak için gerekli hazırlığı yaptıktan sonra veriler üretilmeye hazır hale gelir.
üretilecek miktar verildikten sonra proje çalıştırılarak veri üretilmesi sağlanır.

### Statik veriler Hk.
Faker ile rastgele veriler üretilmektedir. Veritabanı duruma göre silinip tekrar üretilebilir. Böyle durumlarda elle eklenen statik veriler kaybolabilir.
Bu durumda FluentApi kullanılarak statik veriler sisteleme dinamik şekilde eklenebilir. 


