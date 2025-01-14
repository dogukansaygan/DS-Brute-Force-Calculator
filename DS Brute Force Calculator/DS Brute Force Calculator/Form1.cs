using System.Diagnostics;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace DS_Brute_Force_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PassTxtBx.Text) || string.IsNullOrEmpty(CharsTxtBx.Text))
            {
                // Eðer textbox içeriði boþ ise uyarý veriyor.
                MessageBox.Show("Lütfen geçerli bir parola ve karakter kümesi giriniz.");
            }
            else
            {
                // StopWatch ile seçilen iþlemin ne kadar sürede yapýldýðý hesaplanýyor.
                Stopwatch StopWatch = Stopwatch.StartNew();

                // Açýk olan checkboxa göre fonksiyonlardan birisi çalýþýyor.
                if (Md5Rd.Checked)
                {
                    MD5TestFunc();
                }
                else if (Sha256Rd.Checked)
                {
                    SHA256TestFunc();
                }

                // Stýpwatch iþlemi sona erdi.
                StopWatch.Stop();

                // Eðer iþlem 0 sürede gerçekleþti ise uyarý veriyor, 0 hesaplanamaz.
                if (StopWatch.ElapsedMilliseconds == 0)
                {
                    if (Language)
                    {
                        MessageBox.Show("Hesaplama çok hýzlý tamamlandý, yeterli veri yok.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("The calculation was completed very quickly, there is not enough data.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // CharClac fonksiyonu ile olasý deneme sayýsý çaðrýlýyor.
                    BigInteger IncomingValue = CharCalc();

                    // Burada süre hesaplanýyor.
                    double Operations = Convert.ToInt32(NumberofOperations.Value);
                    double TimePerOperation = StopWatch.Elapsed.TotalMilliseconds / Operations;

                    double TotalTime = (double)IncomingValue * TimePerOperation;

                    string TimeUnit;
                    BigInteger TimeValue;

                    // Süreye göre hangi zaman dilimi olduðu belirleniyor ve ekrana yazdýrýlýyor.
                    if (TotalTime < 1000)
                    {
                        TimeValue = (BigInteger)TotalTime;
                        TimeUnit = Language ? "Milisaniye" : "Milisecond";
                    }
                    else if (TotalTime < 60000)
                    {
                        TimeValue = (BigInteger)(TotalTime / 1000);
                        TimeUnit = Language ? "Saniye" : "Second";
                    }
                    else if (TotalTime < 3600000)
                    {
                        TimeValue = (BigInteger)(TotalTime / 60000);
                        TimeUnit = Language ? "Dakika" : "Minute";
                    }
                    else if (TotalTime < 86400000)
                    {
                        TimeValue = (BigInteger)(TotalTime / 3600000);
                        TimeUnit = Language ? "Saat" : "Hour";
                    }
                    else if (TotalTime < 31536000000)
                    {
                        TimeValue = (BigInteger)(TotalTime / 86400000);
                        TimeUnit = Language ? "Gün" : "Day";
                    }
                    else
                    {
                        TimeValue = (BigInteger)(TotalTime / 31536000000);
                        TimeUnit = Language ? "Yýl" : "Year";
                    }

                    TimeTxt.Text = Language
                        ? $"Þifrenin kýrýlmasý için tahmini süre: {TimeValue} {TimeUnit}"
                        : $"Estimated time to crack the password: {TimeValue} {TimeUnit}";
                }
            }
        }


        private BigInteger CharCalc()
        {
            // Burada karakter sayýsý ile karakter çeþitliliði kullanýlarak gerçekleþtirebilecek maks iþlem sayýsý bulunuyor.
            BigInteger Total = BigInteger.Pow(CharsTxtBx.Text.Length, PassTxtBx.Text.Length);

            return Total;
        }


        private void MD5TestFunc()
        {
            // MD5 dönüþtürme kodu
            for (int i = 0; i < NumberofOperations.Value; i++)
            {
                using (MD5 md5 = MD5.Create())
                {
                    byte[] inputBytes = Encoding.UTF8.GetBytes(PassTxtBx.Text);
                    byte[] hashBytes = md5.ComputeHash(inputBytes);

                    // Buradan sonrasý gerçekçi bir simüle için, kaldýrýlabilir.
                    StringBuilder sb = new StringBuilder();

                    foreach (byte b in hashBytes)
                    {
                        sb.Append(b.ToString("x2"));
                    }
                }
            }
        }

        private void SHA256TestFunc()
        {
            // SHA256 dönüþtürme kodu
            for (int i = 0; i < NumberofOperations.Value; i++)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] inputBytes = Encoding.UTF8.GetBytes(PassTxtBx.Text);
                    byte[] hashBytes = sha256.ComputeHash(inputBytes);

                    // Buradan sonrasý gerçekçi bir simüle için, kaldýrýlabilir.
                    StringBuilder sb = new StringBuilder();

                    foreach (byte b in hashBytes)
                    {
                        sb.Append(b.ToString("x2"));
                    }
                }
            }
        }

        private void PassTxtBx_TextChanged(object sender, EventArgs e)
        {
            // Burada textbox içeriði her deðiþtiðin de metnin içerisindeki farklý karakteri buluyoruz.
            LentghLbl.Text = "Lentgh: " + PassTxtBx.Text.Length.ToString();

            string Pass = PassTxtBx.Text;
            HashSet<char> UniqueChars = new HashSet<char>();

            foreach (char Char in Pass)
            {
                UniqueChars.Add(Char);
            }

            VarietyLbl.Text = "Character variety: " + UniqueChars.Count.ToString();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            // Burada programýn varsayýlan ayarlarýna dönüyoruz.
            PassTxtBx.Clear();
            CharsTxtBx.Text = "abcçdefgðhýijklmnoöprsþtuüvyz0123456789!'^+%&/()=?_-\\][$#£>\"é*@{},.:;`|<>~ABCÇDEFGÐHIÝJKLMNOÖPRSÞTUUÜVYZ";
            NumberofOperations.Value = 10000;
            Md5Rd.Checked = true;
            Sha256Rd.Checked = false;
            Mode1Rd.Checked = false;
            TimeTxt.Text = "Estimated time to crack the password:";
        }

        bool Language = false;
        // False = English
        // True = Turkish


        private void LangBtn_Click(object sender, EventArgs e)
        {
            // Dil deðiþtirme Ýþlemi
            Language = !Language;

            PassLbl.Text = Language ? "Parola:" : "Password:";
            CharsLbl.Text = Language ? "Karakterler:" : "Chars:";
            NumberofOperationsLbl.Text = Language ? "Ýþlem sayýsý:" : "Number of operations:";
            VarietyLbl.Text = Language ? "Karakter çeþitliliði:" : "Character variety:";
            MethodsGrpBx.Text = Language ? "Methodlar" : "Methods";
            ModesGrpBx.Text = Language ? "Modlar" : "Modes";
            CalculateBtn.Text = Language ? "Tahmini süreyi hesapla" : "Calculate the estimated time";
            ResetBtn.Text = Language ? "Sýfýrla" : "Reset";
            LangBtn.Text = Language ? "EN" : "TR";

            // Dil deðiþme iþlemi sýrasýnda : ile iki parçaya ayrýlýyor.
            // : sonrasý saklanýyor : öncesi ile diðer dil ile deðiþtiriliyor.
            // Sonrasýnda iki parça birleþtiriliyor

            string[] TimeStr = TimeTxt.Text.Split(':');
            TimeTxt.Text = Language
                ? "Þifrenin kýrýlmasý için tahmini süre:" + (TimeStr.Length > 1 ? TimeStr[1] : "")
                : "Estimated time to crack the password:" + (TimeStr.Length > 1 ? TimeStr[1] : "");
        }
    }
}