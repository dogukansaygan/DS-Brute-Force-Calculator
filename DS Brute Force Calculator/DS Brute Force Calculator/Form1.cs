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
                // E�er textbox i�eri�i bo� ise uyar� veriyor.
                MessageBox.Show("L�tfen ge�erli bir parola ve karakter k�mesi giriniz.");
            }
            else
            {
                // StopWatch ile se�ilen i�lemin ne kadar s�rede yap�ld��� hesaplan�yor.
                Stopwatch StopWatch = Stopwatch.StartNew();

                // A��k olan checkboxa g�re fonksiyonlardan birisi �al���yor.
                if (Md5Rd.Checked)
                {
                    MD5TestFunc();
                }
                else if (Sha256Rd.Checked)
                {
                    SHA256TestFunc();
                }

                // St�pwatch i�lemi sona erdi.
                StopWatch.Stop();

                // E�er i�lem 0 s�rede ger�ekle�ti ise uyar� veriyor, 0 hesaplanamaz.
                if (StopWatch.ElapsedMilliseconds == 0)
                {
                    if (Language)
                    {
                        MessageBox.Show("Hesaplama �ok h�zl� tamamland�, yeterli veri yok.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("The calculation was completed very quickly, there is not enough data.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // CharClac fonksiyonu ile olas� deneme say�s� �a�r�l�yor.
                    BigInteger IncomingValue = CharCalc();

                    // Burada s�re hesaplan�yor.
                    double Operations = Convert.ToInt32(NumberofOperations.Value);
                    double TimePerOperation = StopWatch.Elapsed.TotalMilliseconds / Operations;

                    double TotalTime = (double)IncomingValue * TimePerOperation;

                    string TimeUnit;
                    BigInteger TimeValue;

                    // S�reye g�re hangi zaman dilimi oldu�u belirleniyor ve ekrana yazd�r�l�yor.
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
                        TimeUnit = Language ? "G�n" : "Day";
                    }
                    else
                    {
                        TimeValue = (BigInteger)(TotalTime / 31536000000);
                        TimeUnit = Language ? "Y�l" : "Year";
                    }

                    TimeTxt.Text = Language
                        ? $"�ifrenin k�r�lmas� i�in tahmini s�re: {TimeValue} {TimeUnit}"
                        : $"Estimated time to crack the password: {TimeValue} {TimeUnit}";
                }
            }
        }


        private BigInteger CharCalc()
        {
            // Burada karakter say�s� ile karakter �e�itlili�i kullan�larak ger�ekle�tirebilecek maks i�lem say�s� bulunuyor.
            BigInteger Total = BigInteger.Pow(CharsTxtBx.Text.Length, PassTxtBx.Text.Length);

            return Total;
        }


        private void MD5TestFunc()
        {
            // MD5 d�n��t�rme kodu
            for (int i = 0; i < NumberofOperations.Value; i++)
            {
                using (MD5 md5 = MD5.Create())
                {
                    byte[] inputBytes = Encoding.UTF8.GetBytes(PassTxtBx.Text);
                    byte[] hashBytes = md5.ComputeHash(inputBytes);

                    // Buradan sonras� ger�ek�i bir sim�le i�in, kald�r�labilir.
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
            // SHA256 d�n��t�rme kodu
            for (int i = 0; i < NumberofOperations.Value; i++)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] inputBytes = Encoding.UTF8.GetBytes(PassTxtBx.Text);
                    byte[] hashBytes = sha256.ComputeHash(inputBytes);

                    // Buradan sonras� ger�ek�i bir sim�le i�in, kald�r�labilir.
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
            // Burada textbox i�eri�i her de�i�ti�in de metnin i�erisindeki farkl� karakteri buluyoruz.
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
            // Burada program�n varsay�lan ayarlar�na d�n�yoruz.
            PassTxtBx.Clear();
            CharsTxtBx.Text = "abc�defg�h�ijklmno�prs�tu�vyz0123456789!'^+%&/()=?_-\\][$#�>\"�*@{},.:;`|<>~ABC�DEFG�HI�JKLMNO�PRS�TUU�VYZ";
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
            // Dil de�i�tirme ��lemi
            Language = !Language;

            PassLbl.Text = Language ? "Parola:" : "Password:";
            CharsLbl.Text = Language ? "Karakterler:" : "Chars:";
            NumberofOperationsLbl.Text = Language ? "��lem say�s�:" : "Number of operations:";
            VarietyLbl.Text = Language ? "Karakter �e�itlili�i:" : "Character variety:";
            MethodsGrpBx.Text = Language ? "Methodlar" : "Methods";
            ModesGrpBx.Text = Language ? "Modlar" : "Modes";
            CalculateBtn.Text = Language ? "Tahmini s�reyi hesapla" : "Calculate the estimated time";
            ResetBtn.Text = Language ? "S�f�rla" : "Reset";
            LangBtn.Text = Language ? "EN" : "TR";

            // Dil de�i�me i�lemi s�ras�nda : ile iki par�aya ayr�l�yor.
            // : sonras� saklan�yor : �ncesi ile di�er dil ile de�i�tiriliyor.
            // Sonras�nda iki par�a birle�tiriliyor

            string[] TimeStr = TimeTxt.Text.Split(':');
            TimeTxt.Text = Language
                ? "�ifrenin k�r�lmas� i�in tahmini s�re:" + (TimeStr.Length > 1 ? TimeStr[1] : "")
                : "Estimated time to crack the password:" + (TimeStr.Length > 1 ? TimeStr[1] : "");
        }
    }
}