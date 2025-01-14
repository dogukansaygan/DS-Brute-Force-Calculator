# Şifre Kırılma Süresi Hesaplayıcı

Bu program, belirlediğiniz bir parola ve karakter kümesi kullanarak, çeşitli şifreleme algoritmalarını (MD5 ve SHA256) temel alarak şifrenin kırılma süresini tahmin etmeye yönelik bir hesaplama yapar. Kullanıcıdan alınan parola ve karakter kümesi, belirli bir algoritma ile işlem yapılarak tahmini kırılma süresi hesaplanır ve kullanıcıya milisaniye, saniye, dakika, saat, gün ya da yıl cinsinden gösterilir.

## Özellikler
- **MD5 ve SHA256 Algoritmaları**: Şifrenin kırılma süresi, MD5 veya SHA256 algoritmalarından biriyle hesaplanabilir.
- **Kişiselleştirilebilir Karakter Kümesi**: Kullanıcılar, kırılacak parolanın karakter kümesini özgürce seçebilir.
- **Tahmini Kırılma Süresi**: Program, şifrenin kırılma süresini milisaniye, saniye, dakika, saat, gün veya yıl olarak gösterir.

## Kullanım

### Adım 1: Parola ve Karakter Kümesi Girişi
- **Parola**: Kırılacak şifreyi girin.
- **Karakter Kümesi**: Şifrede kullanılacak karakterlerin kümesini girin (örneğin, küçük harfler, büyük harfler, rakamlar ve özel karakterler gibi).

### Adım 2: Algoritma Seçimi
- **MD5**: MD5 algoritmasını kullanarak hesaplama yapar.
- **SHA256**: SHA256 algoritmasını kullanarak hesaplama yapar.

### Adım 3: Kırılma Süresi Hesaplama
- "Hesapla" butonuna tıkladığınızda, program belirtilen karakter kümesi ve algoritmayı kullanarak şifrenin kırılma süresini hesaplar.

### Adım 4: Sonuç
- Sonuç, şifrenin kırılma süresi olarak ekranda gösterilecektir. Bu süre milisaniye, saniye, dakika, saat, gün veya yıl olarak farklı birimlerde sunulabilir.

## Örnek Kullanım
1. Parola: `123456`
2. Karakter Kümesi: `0123456789`
3. Algoritma: `SHA256`
4. Kırılma Süresi: `Tahmini kırılma süresi: 5.32 Gün`

## Gereksinimler
- .NET Framework 4.7.2 veya daha yeni bir sürüm.
- Visual Studio veya benzeri bir C# geliştirme ortamı.

## Yükleme ve Çalıştırma
1. GitHub reposunu cloneniz veya zip dosyasını indiriniz.
2. Visual Studio ile projeyi açın.
3. Programı çalıştırarak şifre kırılma süresi hesaplamasını yapabilirsiniz.

## Katkı Sağlama
Katkılar, pull request ile kabul edilir. Lütfen önce bir issue açarak katkı sağlamak istediğiniz konuda konuşun. 

### Lisans
Bu proje MIT Lisansı altında lisanslanmıştır - [Lisans Dosyası](LICENSE).
