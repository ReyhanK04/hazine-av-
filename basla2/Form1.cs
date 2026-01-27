using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Numerics;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace basla2
{
    public partial class Form1 : Form
    {
        private int gridSize = 15;  // Kare boyutu

        private int oyuncuSatir; // Oyuncunun baþlangýç satýrý
        private int oyuncuSutun; // Oyuncunun baþlangýç sütunu
        private Image oyuncuResmi; // Oyuncu resmi

        private Image arka_plan; //arka plan resmi

        //hareketsiz engeller
        //private int yesilDagSatir = 0; // yesil dagin baslangic satiri
        //private int yesilDagSutun = 0; // yesil dagin baslangic sutunu
        private Image yesil_dag;

        //private int agacSatir = 0; //  agac baslangic satiri
        //private int agacgSutun = 0; // agac baslangic sutunu
        private Image agac;

        //private int karliagacSatir = 0; // karliagac baslangic satiri
        //private int karliagacSutun = 0; // karliagac baslangic sutunu
        private Image karliagac;

        //private int karliDagSatir = 0; // karli dagin baslangic satiri
        //private int karliDagSutun = 0; // karli dagin baslangic sutunu
        private Image karli_dag;

        //private int duvarSatir = 0; // duvar baslangic satiri
        //private int duvarSutun = 0; // duvar baslangic sutunu
        private Image duvar; // duvar resmi

        //private int gulSatir = 0; // gul baslangic satiri
        //private int gulSutun = 0; // gul baslangic sutunu
        private Image gul; // gul resmi

        //private int kayaSatir = 0; // kaya baslangic satiri
        //private int kayaSutun = 0; // kaya baslangic sutunu
        private Image kaya; // kaya resmi

        //hareketli engeller
        private int kusSatir = 0; //kus baslangic satiri
        private int kusSutun = 0; //kus baslangic sutunu
        private Image kus; // kus resmi

        private int ariSatir = 0; //ari baslangic satiri
        private int ariSutun = 0; //ari baslangic sutunu
        private Image ari; //ari resmi

        private int shrekSatir = 0; //shrek baslangic satiri
        private int shrekSutun = 0; //shrek baslangic sutunu
        private Image shrek;

        //sandiklar
        //private int altinSandikSatir = 0; // altin sandik baslangic satiri
        //private int altinSandikSutun = 0; //altin sandik baslangic sutunu 
        private Image altin_sandik;//altin sandik

        //private int gumusSandikSatir = 0; // gumus sandik baslangic satiri
        //private int gumusSandikSutun = 0; //gumus sandik baslangic sutunu
        private Image gumus_sandik;//gumus sandik

        //private int zumrutSandikSatir = 0; // zumrut sandik baslangic satiri
        //private int zumrutSandikSutun = 0; //zumrut sandik baslangic sutunu
        private Image zumrut_sandik;//zumrut sandik

        //private int bakirSandikSatir = 0; // bakir sandik baslangic satiri
        //private int bakirSandikSutun = 0; //bakir sandik baslangic sutunu
        private Image bakir_sandik;//bakir sandik

        private Random random = new Random();


        private Point oyuncuKonumu = new Point();
        private List<Point> yesilDagKonumlari = new List<Point>();
        private List<Point> karliDagKonumlari = new List<Point>();
        private List<Point> duvarKonumlari = new List<Point>();
        private List<Point> gulKonumlari = new List<Point>();
        private List<Point> AgacKonumlari = new List<Point>();
        private List<Point> KarliAgacKonumlari = new List<Point>();
        private List<Point> kayaKonumlari = new List<Point>();

        private List<Point> ariKonumlari = new List<Point>();
        private List<Point> kusKonumlari = new List<Point>();
        private List<Point> shrekKonumlari = new List<Point>();
       

        private List<Point> altinSandikKonumlari = new List<Point>();
        private List<Point> gumusSandikKonumlari = new List<Point>();
        private List<Point> zumrutSandikKonumlari = new List<Point>();
        private List<Point> bakirSandikKonumlari = new List<Point>();

       // private Oyuncu oyuncu;
        public Form1()
        {
            InitializeComponent();


            // Oyuncu resmini dosyadan yükle
            oyuncuResmi = Image.FromFile("C:\\Users\\reyha\\source\\repos\\basla2\\basla2\\oyuncu.png");
            arka_plan = Image.FromFile("C:\\Users\\reyha\\source\\repos\\basla2\\basla2\\Ekran görüntüsü 2024-03-08 164234.png");

            yesil_dag = Image.FromFile("C:\\Users\\reyha\\source\\repos\\basla2\\basla2\\yesildag.png");
            karli_dag = Image.FromFile("C:\\Users\\reyha\\source\\repos\\basla2\\basla2\\karlidag.png");
            kaya = Image.FromFile("C:\\Users\\reyha\\source\\repos\\basla2\\basla2\\kaya.png");
            agac = Image.FromFile("C:\\Users\\reyha\\source\\repos\\basla2\\basla2\\agac.png");
            karliagac = Image.FromFile("C:\\Users\\reyha\\source\\repos\\basla2\\basla2\\karliagac.png");
            duvar = Image.FromFile("C:\\Users\\reyha\\source\\repos\\basla2\\basla2\\duvar.png");
            gul = Image.FromFile("C:\\Users\\reyha\\source\\repos\\basla2\\basla2\\gul.png");

            shrek = Image.FromFile("C:\\Users\\reyha\\source\\repos\\basla2\\basla2\\shrek.png");
            kus = Image.FromFile("C:\\Users\\reyha\\source\\repos\\basla2\\basla2\\kus.png");
            ari = Image.FromFile("C:\\Users\\reyha\\source\\repos\\basla2\\basla2\\ari.png");

            altin_sandik = Image.FromFile("C:\\Users\\reyha\\source\\repos\\basla2\\basla2\\altinsandik.png");
            gumus_sandik = Image.FromFile("C:\\Users\\reyha\\source\\repos\\basla2\\basla2\\gumussandik.png");
            zumrut_sandik = Image.FromFile("C:\\Users\\reyha\\source\\repos\\basla2\\basla2\\zümrüt.png");
            bakir_sandik = Image.FromFile("C:\\Users\\reyha\\source\\repos\\basla2\\basla2\\bakirsandik.png");

            // Klavye giriþlerini dinle
            KeyPreview = true;
            KeyDown += Form1_KeyDown;

        }

        // Formun Paint olayýný kullanarak resmi çizin
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (!button1.Visible)
            {
                 // Karelerin sol üst köþe koordinatlarýný hesaplayýn
                 int x = oyuncuSutun * gridSize;
                 int y = oyuncuSatir * gridSize;

                 // Oyuncu resmini bu karenin içine çizin
                 e.Graphics.DrawImage(oyuncuResmi, x, y, gridSize, gridSize);
               

                // Döngüyü tersten baþlatarak koleksiyonu güvenli bir þekilde deðiþtirelim
                for (int i = altinSandikKonumlari.Count - 1; i >= 0; i--)
                {
                    Point konum = altinSandikKonumlari[i];

                    int sandikX = konum.X * gridSize;
                    int sandikY = konum.Y * gridSize;

                    if ((oyuncuSutun >= konum.X && oyuncuSutun <= konum.X + 1 &&
    oyuncuSatir >= konum.Y && oyuncuSatir <= konum.Y + 1) ||
    (oyuncuSutun + 1 >= konum.X && oyuncuSutun + 1 <= konum.X + 1 &&
    oyuncuSatir >= konum.Y && oyuncuSatir <= konum.Y + 1) ||
    (oyuncuSutun >= konum.X && oyuncuSutun <= konum.X + 1 &&
    oyuncuSatir + 1 >= konum.Y && oyuncuSatir + 1 <= konum.Y + 1) ||
    (oyuncuSutun + 1 >= konum.X && oyuncuSutun + 1 <= konum.X + 1 &&
    oyuncuSatir + 1 >= konum.Y && oyuncuSatir + 1 <= konum.Y + 1))
                    {
                        // Oyuncu sandýðýn üzerine geldiðinde görünürlüðü kaybet
                        altinSandikKonumlari.RemoveAt(i);
                        Invalidate(); // Formu yeniden çiz
                        continue;
                    }

                    e.Graphics.DrawImage(altin_sandik, sandikX, sandikY, 2 * gridSize, 2 * gridSize);
                }
                for (int i = gumusSandikKonumlari.Count - 1; i >= 0; i--)
                {
                    Point konum = gumusSandikKonumlari[i];

                    int sandikX = konum.X * gridSize;
                    int sandikY = konum.Y * gridSize;

                    if ((oyuncuSutun >= konum.X && oyuncuSutun <= konum.X + 1 &&
    oyuncuSatir >= konum.Y && oyuncuSatir <= konum.Y + 1) ||
    (oyuncuSutun + 1 >= konum.X && oyuncuSutun + 1 <= konum.X + 1 &&
    oyuncuSatir >= konum.Y && oyuncuSatir <= konum.Y + 1) ||
    (oyuncuSutun >= konum.X && oyuncuSutun <= konum.X + 1 &&
    oyuncuSatir + 1 >= konum.Y && oyuncuSatir + 1 <= konum.Y + 1) ||
    (oyuncuSutun + 1 >= konum.X && oyuncuSutun + 1 <= konum.X + 1 &&
    oyuncuSatir + 1 >= konum.Y && oyuncuSatir + 1 <= konum.Y + 1))
                    {
                        // Oyuncu sandýðýn üzerine geldiðinde görünürlüðü kaybet
                        gumusSandikKonumlari.RemoveAt(i);
                        Invalidate(); // Formu yeniden çiz
                        continue;
                    }

                    e.Graphics.DrawImage(gumus_sandik, sandikX, sandikY, 2 * gridSize, 2 * gridSize);
                }
                for (int i = zumrutSandikKonumlari.Count - 1; i >= 0; i--)
                {
                    Point konum = zumrutSandikKonumlari[i];

                    int sandikX = konum.X * gridSize;
                    int sandikY = konum.Y * gridSize;

                    if ((oyuncuSutun >= konum.X && oyuncuSutun <= konum.X + 1 &&
    oyuncuSatir >= konum.Y && oyuncuSatir <= konum.Y + 1) ||
    (oyuncuSutun + 1 >= konum.X && oyuncuSutun + 1 <= konum.X + 1 &&
    oyuncuSatir >= konum.Y && oyuncuSatir <= konum.Y + 1) ||
    (oyuncuSutun >= konum.X && oyuncuSutun <= konum.X + 1 &&
    oyuncuSatir + 1 >= konum.Y && oyuncuSatir + 1 <= konum.Y + 1) ||
    (oyuncuSutun + 1 >= konum.X && oyuncuSutun + 1 <= konum.X + 1 &&
    oyuncuSatir + 1 >= konum.Y && oyuncuSatir + 1 <= konum.Y + 1))
                    {
                        // Oyuncu sandýðýn üzerine geldiðinde görünürlüðü kaybet
                        zumrutSandikKonumlari.RemoveAt(i);
                        Invalidate(); // Formu yeniden çiz
                        continue;
                    }

                    e.Graphics.DrawImage(zumrut_sandik, sandikX, sandikY, 2 * gridSize, 2 * gridSize);
                }
                for (int i = bakirSandikKonumlari.Count - 1; i >= 0; i--)
                {
                    Point konum = bakirSandikKonumlari[i];

                    int sandikX = konum.X * gridSize;
                    int sandikY = konum.Y * gridSize;

                    if ((oyuncuSutun >= konum.X && oyuncuSutun <= konum.X + 1 &&
    oyuncuSatir >= konum.Y && oyuncuSatir <= konum.Y + 1) ||
    (oyuncuSutun + 1 >= konum.X && oyuncuSutun + 1 <= konum.X + 1 &&
    oyuncuSatir >= konum.Y && oyuncuSatir <= konum.Y + 1) ||
    (oyuncuSutun >= konum.X && oyuncuSutun <= konum.X + 1 &&
    oyuncuSatir + 1 >= konum.Y && oyuncuSatir + 1 <= konum.Y + 1) ||
    (oyuncuSutun + 1 >= konum.X && oyuncuSutun + 1 <= konum.X + 1 &&
    oyuncuSatir + 1 >= konum.Y && oyuncuSatir + 1 <= konum.Y + 1))
                    {
                        // Oyuncu sandýðýn üzerine geldiðinde görünürlüðü kaybet
                        bakirSandikKonumlari.RemoveAt(i);
                        Invalidate(); // Formu yeniden çiz
                        continue;
                    }

                    e.Graphics.DrawImage(bakir_sandik, sandikX, sandikY, 2 * gridSize, 2 * gridSize);
                }
            }
        }

        private void engeller_Paint(object sender, PaintEventArgs e)
        {
            duvar_Engel duvarEngel = new duvar_Engel();
            duvarEngel.Paint(e.Graphics, gridSize, duvarKonumlari, duvar, button1.Visible);

            yesilDag_Engel yesilDagEngel = new yesilDag_Engel();
            yesilDagEngel.Paint(e.Graphics, gridSize, yesilDagKonumlari, yesil_dag, button1.Visible);

            karliDag_Engel karliDagEngel = new karliDag_Engel();
            karliDagEngel.Paint(e.Graphics, gridSize, karliDagKonumlari, karli_dag, button1.Visible);

            agac_Engel agacEngel = new agac_Engel();
            agacEngel.Paint(e.Graphics, gridSize, AgacKonumlari, agac, button1.Visible);

            karliAgac_Engel karliAgacEngel = new karliAgac_Engel();
            karliAgacEngel.Paint(e.Graphics, gridSize, KarliAgacKonumlari, karliagac, button1.Visible);

            gul_Engel gulEngel = new gul_Engel();
            gulEngel.Paint(e.Graphics, gridSize, gulKonumlari, gul, button1.Visible);

            kaya_Engel kayaEngel = new kaya_Engel();
            kayaEngel.Paint(e.Graphics, gridSize, kayaKonumlari, kaya, button1.Visible);

        }

        private void hareketliEngeller_Paint(object sender, PaintEventArgs e)
        {
            ari_Engel ariEngel = new ari_Engel();
            ariEngel.hareketli_Paint(e.Graphics, gridSize, ariSatir, ariSutun, ari, button1.Visible);

            kus_Engel kusEngel = new kus_Engel();
            kusEngel.hareketli_Paint(e.Graphics, gridSize, kusSatir, kusSutun, kus, button1.Visible);

            shrek_Engel shrekEngel = new shrek_Engel();
            shrekEngel.hareketli_Paint(e.Graphics, gridSize, shrekSatir, shrekSutun, shrek, button1.Visible);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black);

            g.DrawImage(arka_plan, 0, 0, satir * gridSize, satir * gridSize);

            // Karelerle ýzgarayý doldur
            for (int row = 0; row < satir; row++)
            {
                for (int col = 0; col < satir; col++)
                {
                    int x = row * gridSize;
                    int y = col * gridSize;
                    g.DrawRectangle(pen, x, y, gridSize, gridSize);
                }
            }

            Form1_Paint(this, e);

            /*yesilDag_Paint(this, e);
            karliDag_Paint(this, e);
            duvar_Paint(this, e);
            gul_Paint(this, e);
            agac_Paint(this, e);
            karliagac_Paint(this, e);
            kaya_Paint(this, e);*/
            engeller_Paint(this, e);

            //shrek_Paint(this, e);
            //kus_Paint(this, e);
            //ari_Paint(this, e);
            hareketliEngeller_Paint(this, e);

            // altinSandik_Paint(this, e);
            // gumusSandik_Paint(this, e);
            // zumrutSandik_Paint(this, e);
            //bakirSandik_Paint(this, e);

            // Yolu çiz
            DrawPath(playerPath, g);
          
        }

        //OYUNCUNUN HAREKETÝ VE GÝTTÝÐÝ YOLU ÇÝZMESÝ*******

        // Oyuncunun attýðý her adýmý kaydeden liste
        private List<Point> playerPath = new List<Point>();

        // Oyuncunun eski konumunu saklayacak deðiþkenler
        private int eskiSatir;
        private int eskiSutun;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
             // Oyuncunun eski konumunu kaydet
             eskiSatir = oyuncuSatir;
             eskiSutun = oyuncuSutun;

             // Ok tuþlarýna basýldýðýnda karakterin konumunu güncelle
             switch (e.KeyCode)
             {
                 case Keys.Up:
                     oyuncuSatir = Math.Max(oyuncuSatir - 1, 0);
                     break;
                 case Keys.Down:
                     oyuncuSatir = Math.Min(oyuncuSatir + 1, satir - 1);
                     break;
                 case Keys.Left:
                     oyuncuSutun = Math.Max(oyuncuSutun - 1, 0);
                     break;
                 case Keys.Right:
                     oyuncuSutun = Math.Min(oyuncuSutun + 1, satir - 1);
                     break;
             }

             // Oyuncunun yeni konumunu playerPath listesine ekle
             playerPath.Add(new Point(oyuncuSutun, oyuncuSatir)); 
           

            // Engellere çarpma kontrolü
            Rectangle oyuncuAlan = new Rectangle(oyuncuSutun * gridSize, oyuncuSatir * gridSize, gridSize, gridSize);

            foreach (Rectangle engelAlan in GetEngelAlanlari())
            {
                if (oyuncuAlan.IntersectsWith(engelAlan))
                {
                    // Engelle çarpýldý, eski konumuna geri dön
                    oyuncuSatir = eskiSatir;
                    oyuncuSutun = eskiSutun;
                    playerPath.RemoveAt(playerPath.Count - 1); // Son eklenen konumu kaldýr
                    return;
                }
            }

            // Yolu güncelle
            Invalidate();
        }

        private void DrawPath(List<Point> path, Graphics g)
        {
            if (path == null || path.Count < 2)
                return;

            Pen pen = new Pen(Color.Green, 4); // Çizgi rengi ve kalýnlýðýný ayarla

            for (int i = 0; i < path.Count - 1; i++)
            {
                Point start = GridToPixel(path[i].X, path[i].Y); // Baþlangýç noktasýný grid koordinatlarýndan piksel koordinatlarýna dönüþtür
                Point end = GridToPixel(path[i + 1].X, path[i + 1].Y); // Bitiþ noktasýný grid koordinatlarýndan piksel koordinatlarýna dönüþtür

                g.DrawLine(pen, start, end); // Çizgiyi çiz
            }
        }

      

        // Grid koordinatlarýný piksel koordinatlarýna dönüþtüren yardýmcý metot
        private Point GridToPixel(int x, int y)
        {
            int pixelX = x * gridSize; // Grid koordinatýný piksel koordinatýna dönüþtür
            int pixelY = y * gridSize; // Grid koordinatýný piksel koordinatýna dönüþtür
            return new Point(pixelX, pixelY);
        }

        private IEnumerable<Rectangle> GetEngelAlanlari()
        {
            List<Rectangle> engelAlanlari = new List<Rectangle>();

            // Örnek olarak, engel türlerinizin boyutlarýna uygun Rectangle'larý oluþturun ve listeye ekleyin

            foreach (Point engelKonumu in gulKonumlari)
            {
                Rectangle engelAlan = new Rectangle(engelKonumu.X * gridSize, engelKonumu.Y * gridSize, 3 * gridSize, 3 * gridSize);
                engelAlanlari.Add(engelAlan);
            }

            foreach (Point engelKonumu in yesilDagKonumlari)
            {
                Rectangle engelAlan = new Rectangle(engelKonumu.X * gridSize, engelKonumu.Y * gridSize, 10 * gridSize, 10 * gridSize);
                engelAlanlari.Add(engelAlan);
            }

            foreach (Point engelKonumu in karliDagKonumlari)
            {
                Rectangle engelAlan = new Rectangle(engelKonumu.X * gridSize, engelKonumu.Y * gridSize, 10 * gridSize, 10 * gridSize);
                engelAlanlari.Add(engelAlan);
            }
            foreach (Point engelKonumu in duvarKonumlari)
            {
                Rectangle engelAlan = new Rectangle(engelKonumu.X * gridSize, engelKonumu.Y * gridSize, 10 * gridSize, gridSize);
                engelAlanlari.Add(engelAlan);
            }
            foreach (Point engelKonumu in KarliAgacKonumlari)
            {
                Rectangle engelAlan = new Rectangle(engelKonumu.X * gridSize, engelKonumu.Y * gridSize, 3 * gridSize, 3 * gridSize);
                engelAlanlari.Add(engelAlan);
            }
            foreach (Point engelKonumu in AgacKonumlari)
            {
                Rectangle engelAlan = new Rectangle(engelKonumu.X * gridSize, engelKonumu.Y * gridSize, 3 * gridSize, 3 * gridSize);
                engelAlanlari.Add(engelAlan);
            }
            foreach (Point engelKonumu in kayaKonumlari)
            {
                Rectangle engelAlan = new Rectangle(engelKonumu.X * gridSize, engelKonumu.Y * gridSize, 3 * gridSize, 3 * gridSize);
                engelAlanlari.Add(engelAlan);
            }

            // Diðer engel türleri için de benzer þekilde devam edebilirsiniz.

            return engelAlanlari;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            HareketliKus();
            HareketliAri();
            HareketliShrek();

            Invalidate();
        }

        private int toplamHareketAdimi1 = 0;
        private int maksimumHareketAdimiKus = 5;
        private bool kusYukari = true;
        
        private void HareketliKus()
        {
            int hareketMiktari = 1; // Her adýmda kaç birim kare hareket edeceðini belirtir

            // Hareket ettiði alan kontrolü
            if ((kusSutun >= 0 && kusSutun + 2 <= satir) && (kusSatir >= 0 && kusSatir + 2 <= satir))
            {
                // Yukarý yönde hareket
                if (toplamHareketAdimi1 < maksimumHareketAdimiKus && kusYukari)
                {
                    kusSutun = Math.Max(kusSutun - hareketMiktari, 0);
                    toplamHareketAdimi1++;

                    if (toplamHareketAdimi1 == maksimumHareketAdimiKus)
                    {
                        // Yukarý hareket tamamlandý, aþaðý hareketi baþlat
                        kusYukari = false;
                    }
                }
                // Aþaðý yönde hareket
                else if (toplamHareketAdimi1 > 0 && !kusYukari)
                {
                    kusSutun = Math.Min(kusSutun + hareketMiktari, satir - 2);
                    toplamHareketAdimi1--;

                    if (toplamHareketAdimi1 == 0)
                    {
                        // Aþaðý hareket tamamlandý, yukarý hareketi baþlat
                        kusYukari = true;
                    }
                }
              
            }
        }
        private int toplamHareketAdimi2 = 0;
        private int maksimumHareketAdimiAri = 3;
        private bool ariSaga = true;
        private void HareketliAri()
        {
            int hareketMiktari = 1; // Her adýmda kaç birim kare hareket edeceðini belirtir

            // Hareket ettiði alan kontrolü
            if ((ariSutun >= 0 && ariSutun + 2 <= satir) && (ariSatir >= 0 && ariSatir + 2 <= satir))
            {
                // Saða yönde hareket
                if (toplamHareketAdimi2 < maksimumHareketAdimiAri && ariSaga)
                {
                    ariSatir = Math.Min(ariSatir + hareketMiktari, satir - 2);
                    toplamHareketAdimi2++;

                    if (toplamHareketAdimi2 == maksimumHareketAdimiAri)
                    {
                        // Saða hareket tamamlandý, sola hareketi baþlat
                        ariSaga = false;
                    }
                }
                // Sola yönde hareket
                else if (toplamHareketAdimi2 > 0 && !ariSaga)
                {
                    ariSatir = Math.Max(ariSatir - hareketMiktari, 0);
                    toplamHareketAdimi2--;

                    if (toplamHareketAdimi2 == 0)
                    {
                        // Sola hareket tamamlandý, saða hareketi baþlat
                        ariSaga = true;
                    }
                }
            }
        }
        private int toplamHareketAdimi3 = 0;
        private int maksimumHareketAdimiShrek = 4;
        private bool shrekSaga = true;

        private void HareketliShrek()
        {
            int hareketMiktari = 1; // Her adýmda kaç birim kare hareket edeceðini belirtir

            // Hareket ettiði alan kontrolü
            if ((shrekSutun >= 0 && shrekSutun + 2 <= satir) && (shrekSatir >= 0 && shrekSatir + 2 <= satir))
            {
                // Saða yönde hareket
                if (toplamHareketAdimi3 < maksimumHareketAdimiShrek && shrekSaga)
                {
                    shrekSatir = Math.Min(shrekSatir + hareketMiktari, satir - 2);
                    toplamHareketAdimi3++;

                    if (toplamHareketAdimi3 == maksimumHareketAdimiShrek)
                    {
                        // Saða hareket tamamlandý, sola hareketi baþlat
                        shrekSaga = false;
                    }
                }
                // Sola yönde hareket
                else if (toplamHareketAdimi3 > 0 && !shrekSaga)
                {
                    shrekSatir = Math.Max(shrekSatir - hareketMiktari, 0);
                    toplamHareketAdimi3--;

                    if (toplamHareketAdimi3 == 0)
                    {
                        // Sola hareket tamamlandý, saða hareketi baþlat
                        shrekSaga = true;
                    }
                }
            }
        }



        int satir;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            satir = Convert.ToInt32(textBox1.Text);

            int maxRow = 1000; // Maksimum satýr deðeri
            int minRow = 100;  // Minimum satýr deðeri

            if (satir < minRow || satir > maxRow)
            {
                MessageBox.Show("Satýr deðeri minimum " + minRow + " ve maksimum " + maxRow + " olmalýdýr.");
                return;
            }
            if (satir <= 1000 && satir >= 500)
            {
                gridSize = 2;
            }
            if (satir < 500 && satir >= 100)
            {
                gridSize = 10;
            }

            int yarimgenislik = this.ClientSize.Width / 2;

            // Kullanýcýnýn girdiði ýzgara boyutunu al
            if (int.TryParse(textBox1.Text, out int userInput) && userInput > 0)
            {
                oyuncuSatir = random.Next(satir);
                oyuncuSutun = random.Next(satir);

                string message = "Oyuncu konumu:\n" + "Satýr: " + oyuncuSatir + ", Sütun: " + oyuncuSutun + "\n\n";
                MessageBox.Show(message, "Oyuncu Konumu");
                // Diðer konum listelerini temizle
                yesilDagKonumlari.Clear();
                karliDagKonumlari.Clear();
                AgacKonumlari.Clear();
                KarliAgacKonumlari.Clear();
                gulKonumlari.Clear();
                duvarKonumlari.Clear();
                kayaKonumlari.Clear();

                altinSandikKonumlari.Clear();
                gumusSandikKonumlari.Clear();
                zumrutSandikKonumlari.Clear();
                bakirSandikKonumlari.Clear();

                // Diðer nesnelerin konumlarýný rastgele belirle

                yesilDagKonumlari.Clear();
                for (int i = 0; i < 4; i++)
                {
                    int x = random.Next(0, ((yarimgenislik / 2) / gridSize)) - 4;
                    int y = random.Next(satir - 8);

                    // Çakýþma kontrolü yap
                    while (AgacKonumlari.Concat(KarliAgacKonumlari).Concat(gulKonumlari).Concat(kayaKonumlari).Concat(altinSandikKonumlari)
                            .Concat(gumusSandikKonumlari).Concat(zumrutSandikKonumlari).Concat(bakirSandikKonumlari)
                            .Any(p => Math.Abs(p.X - x) <= 10 && Math.Abs(p.Y - y) <= 10) ||
                            yesilDagKonumlari.Concat(karliDagKonumlari).Concat(shrekKonumlari)
                            .Any(p => Math.Abs(p.X - x) <= 10 && Math.Abs(p.Y - y) <= 10) ||
                            kusKonumlari.Concat(ariKonumlari).Any(p => Math.Abs(p.X - x) <= 10 && Math.Abs(p.Y - y) <= 10) ||
                            duvarKonumlari.Any(p => Math.Abs(p.X - x) <= 10 && Math.Abs(p.Y - y) <= 10))
                    {
                        x = random.Next(0, ((yarimgenislik / 2) / gridSize)) - 4;
                        y = random.Next(satir - 8);

                        // Yeniden rastgele konum aldýktan sonra duvarlar ve diðer engellerle çakýþýp çakýþmadýðýný kontrol et
                        bool isIntersectingWithOtherObstacles = AgacKonumlari.Concat(KarliAgacKonumlari).Concat(gulKonumlari)
                            .Concat(kayaKonumlari).Concat(altinSandikKonumlari).Concat(gumusSandikKonumlari)
                            .Concat(zumrutSandikKonumlari).Concat(bakirSandikKonumlari)
                            .Any(p => Math.Abs(p.X - x) <= 10 && Math.Abs(p.Y - y) <= 10) ||
                            yesilDagKonumlari.Concat(karliDagKonumlari).Concat(shrekKonumlari)
                            .Any(p => Math.Abs(p.X - x) <= 10 && Math.Abs(p.Y - y) <= 10) ||
                            kusKonumlari.Concat(ariKonumlari).Any(p => Math.Abs(p.X - x) <= 10 && Math.Abs(p.Y - y) <= 10) ||
                            duvarKonumlari.Any(p => Math.Abs(p.X - x) <= 10 && Math.Abs(p.Y - y) <= 10);

                        if (!isIntersectingWithOtherObstacles) // Diðer engellerle çakýþmýyorsa döngüden çýk
                        {
                            break;
                        }
                    }

                    // Konumu ilgili listeye ekle
                    yesilDagKonumlari.Add(new Point(x, y));
                }

                karliDagKonumlari.Clear();
                for (int i = 0; i < 4; i++)
                {
                    int x = random.Next((yarimgenislik / gridSize) + 3, satir - 8);
                    int y = random.Next(satir - 8);
                    // Çakýþma kontrolü yap
                    while (AgacKonumlari.Concat(KarliAgacKonumlari).Concat(gulKonumlari).Concat(kayaKonumlari).Concat(altinSandikKonumlari)
                            .Concat(gumusSandikKonumlari).Concat(zumrutSandikKonumlari).Concat(bakirSandikKonumlari)
                            .Any(p => Math.Abs(p.X - x) <= 10 && Math.Abs(p.Y - y) <= 10) ||
                            yesilDagKonumlari.Concat(karliDagKonumlari).Concat(shrekKonumlari)
                            .Any(p => Math.Abs(p.X - x) <= 10 && Math.Abs(p.Y - y) <= 10) ||
                            kusKonumlari.Concat(ariKonumlari).Any(p => Math.Abs(p.X - x) <= 10 && Math.Abs(p.Y - y) <= 10) ||
                            duvarKonumlari.Any(p => Math.Abs(p.X - x) <= 10 && Math.Abs(p.Y - y) <= 10))
                    {
                        x = random.Next((yarimgenislik / gridSize) + 3, satir - 8);
                        y = random.Next(satir - 8);

                        // Yeniden rastgele konum aldýktan sonra duvarlar ve diðer engellerle çakýþýp çakýþmadýðýný kontrol et
                        bool isIntersectingWithOtherObstacles = AgacKonumlari.Concat(KarliAgacKonumlari).Concat(gulKonumlari)
                            .Concat(kayaKonumlari).Concat(altinSandikKonumlari).Concat(gumusSandikKonumlari)
                            .Concat(zumrutSandikKonumlari).Concat(bakirSandikKonumlari)
                            .Any(p => Math.Abs(p.X - x) <= 10 && Math.Abs(p.Y - y) <= 10) ||
                            yesilDagKonumlari.Concat(karliDagKonumlari).Concat(shrekKonumlari)
                            .Any(p => Math.Abs(p.X - x) <= 10 && Math.Abs(p.Y - y) <= 10) ||
                            kusKonumlari.Concat(ariKonumlari).Any(p => Math.Abs(p.X - x) <= 10 && Math.Abs(p.Y - y) <= 10) ||
                            duvarKonumlari.Any(p => Math.Abs(p.X - x) <= 10 && Math.Abs(p.Y - y) <= 10);

                        if (!isIntersectingWithOtherObstacles) // Diðer engellerle çakýþmýyorsa döngüden çýk
                        {
                            break;
                        }
                    }

                    karliDagKonumlari.Add(new Point(x, y));
                }

                AgacKonumlari.Clear();
                for (int i = 0; i < 4; i++)
                {
                    int x = random.Next(0, ((yarimgenislik / 2) / gridSize) - 1);
                    int y = random.Next(satir - 2);

                    // Çakýþma kontrolü yap
                    while (AgacKonumlari.Concat(KarliAgacKonumlari).Concat(gulKonumlari).Concat(kayaKonumlari).Concat(altinSandikKonumlari)
                            .Concat(gumusSandikKonumlari).Concat(zumrutSandikKonumlari).Concat(bakirSandikKonumlari)
                            .Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9) ||
                            yesilDagKonumlari.Concat(karliDagKonumlari).Concat(duvarKonumlari).Concat(shrekKonumlari)
                            .Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9) ||
                            kusKonumlari.Concat(ariKonumlari).Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9))
                    {
                        x = random.Next(0, ((yarimgenislik / 2) / gridSize)) - 1;
                        y = random.Next(satir - 2);
                    }
                    AgacKonumlari.Add(new Point(x, y));
                }

                KarliAgacKonumlari.Clear();
                for (int i = 0; i < 4; i++)
                {
                    int x = random.Next((yarimgenislik / gridSize) + 2, satir - 2);
                    int y = random.Next(satir - 2);
                    // Çakýþma kontrolü yap
                    while (AgacKonumlari.Concat(KarliAgacKonumlari).Concat(gulKonumlari).Concat(kayaKonumlari).Concat(altinSandikKonumlari)
                            .Concat(gumusSandikKonumlari).Concat(zumrutSandikKonumlari).Concat(bakirSandikKonumlari)
                            .Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9) ||
                            yesilDagKonumlari.Concat(karliDagKonumlari).Concat(duvarKonumlari).Concat(shrekKonumlari)
                            .Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9) ||
                            kusKonumlari.Concat(ariKonumlari).Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9))
                    {
                        x = random.Next((yarimgenislik / gridSize) + 2, satir - 2);
                        y = random.Next(satir - 2);
                    }

                    KarliAgacKonumlari.Add(new Point(x, y));
                }

                gulKonumlari.Clear();
                for (int i = 0; i < 4; i++)
                {
                    int x = random.Next(0, (yarimgenislik / 2) / gridSize);
                    int y = random.Next(satir - 2);

                    // Çakýþma kontrolü yap
                    while (AgacKonumlari.Concat(KarliAgacKonumlari).Concat(gulKonumlari).Concat(kayaKonumlari).Concat(altinSandikKonumlari)
                            .Concat(gumusSandikKonumlari).Concat(zumrutSandikKonumlari).Concat(bakirSandikKonumlari)
                            .Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9) ||
                            yesilDagKonumlari.Concat(karliDagKonumlari).Concat(duvarKonumlari).Concat(shrekKonumlari)
                            .Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9) ||
                            kusKonumlari.Concat(ariKonumlari).Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9))
                    {
                        x = random.Next(0, (yarimgenislik / 2) / gridSize);
                        y = random.Next(satir - 2);
                    }
                    gulKonumlari.Add(new Point(x, y));
                }

                duvarKonumlari.Clear();
                for (int i = 0; i < 12; i++)
                {
                    int x = random.Next(4, satir - 10);
                    int y = random.Next(4, satir);
                    // Çakýþma kontrolü yap
                    while (AgacKonumlari.Concat(KarliAgacKonumlari).Concat(gulKonumlari).Concat(kayaKonumlari).Concat(altinSandikKonumlari)
                            .Concat(gumusSandikKonumlari).Concat(zumrutSandikKonumlari).Concat(bakirSandikKonumlari)
                            .Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9) ||
                            yesilDagKonumlari.Concat(karliDagKonumlari).Concat(shrekKonumlari)
                            .Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9) ||
                            kusKonumlari.Concat(ariKonumlari).Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9) ||
                            duvarKonumlari.Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9))
                    {
                        x = random.Next(4, satir - 10);
                        y = random.Next(4, satir);

                        // Yeniden rastgele konum aldýktan sonra duvarlar ve diðer engellerle çakýþýp çakýþmadýðýný kontrol et
                        bool isIntersectingWithOtherObstacles = AgacKonumlari.Concat(KarliAgacKonumlari).Concat(gulKonumlari)
                            .Concat(kayaKonumlari).Concat(altinSandikKonumlari).Concat(gumusSandikKonumlari)
                            .Concat(zumrutSandikKonumlari).Concat(bakirSandikKonumlari)
                            .Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9) ||
                            yesilDagKonumlari.Concat(karliDagKonumlari).Concat(shrekKonumlari)
                            .Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9) ||
                            kusKonumlari.Concat(ariKonumlari).Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9) ||
                            duvarKonumlari.Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9);

                        if (!isIntersectingWithOtherObstacles) // Diðer engellerle çakýþmýyorsa döngüden çýk
                        {
                            break;
                        }
                    }

                    duvarKonumlari.Add(new Point(x, y));
                }

                kayaKonumlari.Clear();
                for (int i = 0; i < 4; i++)
                {
                    int x = random.Next(satir - 2);
                    int y = random.Next(satir - 2);
                    // Çakýþma kontrolü yap
                    while (AgacKonumlari.Concat(KarliAgacKonumlari).Concat(gulKonumlari).Concat(kayaKonumlari).Concat(altinSandikKonumlari)
                            .Concat(gumusSandikKonumlari).Concat(zumrutSandikKonumlari).Concat(bakirSandikKonumlari)
                            .Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9) ||
                            yesilDagKonumlari.Concat(karliDagKonumlari).Concat(duvarKonumlari).Concat(shrekKonumlari)
                            .Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9) ||
                            kusKonumlari.Concat(ariKonumlari).Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9))
                    {
                        x = random.Next(satir - 2);
                        y = random.Next(satir - 2);
                    }
                    kayaKonumlari.Add(new Point(x, y));
                }

                altinSandikKonumlari.Clear();
                for (int i = 0; i < 5; i++)
                {
                    int x = random.Next(satir - 2);
                    int y = random.Next(satir - 2);

                    // Çakýþma kontrolü yap
                    while (AgacKonumlari.Concat(KarliAgacKonumlari).Concat(gulKonumlari).Concat(kayaKonumlari).Concat(altinSandikKonumlari)
                            .Concat(gumusSandikKonumlari).Concat(zumrutSandikKonumlari).Concat(bakirSandikKonumlari)
                            .Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9) ||
                            yesilDagKonumlari.Concat(karliDagKonumlari).Concat(duvarKonumlari).Concat(shrekKonumlari)
                            .Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9) ||
                            kusKonumlari.Concat(ariKonumlari).Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9))
                    {
                        x = random.Next(satir - 2);
                        y = random.Next(satir - 2);
                    }

                    altinSandikKonumlari.Add(new Point(x, y));
                }

                gumusSandikKonumlari.Clear();
                for (int i = 0; i < 4; i++)
                {
                    int x = random.Next(satir - 2);
                    int y = random.Next(satir - 2);

                    // Çakýþma kontrolü yap
                    while (AgacKonumlari.Concat(KarliAgacKonumlari).Concat(gulKonumlari).Concat(kayaKonumlari).Concat(altinSandikKonumlari)
                            .Concat(gumusSandikKonumlari).Concat(zumrutSandikKonumlari).Concat(bakirSandikKonumlari)
                            .Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9) ||
                            yesilDagKonumlari.Concat(karliDagKonumlari).Concat(duvarKonumlari).Concat(shrekKonumlari)
                            .Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9) ||
                            kusKonumlari.Concat(ariKonumlari).Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9))
                    {
                        x = random.Next(satir - 2);
                        y = random.Next(satir - 2);
                    }
                    gumusSandikKonumlari.Add(new Point(x, y));
                }

                zumrutSandikKonumlari.Clear();
                for (int i = 0; i < 4; i++)
                {
                    int x = random.Next(satir - 2);
                    int y = random.Next(satir - 2);

                    // Çakýþma kontrolü yap
                    while (AgacKonumlari.Concat(KarliAgacKonumlari).Concat(gulKonumlari).Concat(kayaKonumlari).Concat(altinSandikKonumlari)
                            .Concat(gumusSandikKonumlari).Concat(zumrutSandikKonumlari).Concat(bakirSandikKonumlari)
                            .Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9) ||
                            yesilDagKonumlari.Concat(karliDagKonumlari).Concat(duvarKonumlari).Concat(shrekKonumlari)
                            .Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9) ||
                            kusKonumlari.Concat(ariKonumlari).Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9))
                    {
                        x = random.Next(satir - 2);
                        y = random.Next(satir - 2);
                    }
                    zumrutSandikKonumlari.Add(new Point(x, y));
                }

                bakirSandikKonumlari.Clear();
                for (int i = 0; i < 4; i++)
                {
                    int x = random.Next(satir - 2);
                    int y = random.Next(satir - 2);

                    // Çakýþma kontrolü yap
                    while (AgacKonumlari.Concat(KarliAgacKonumlari).Concat(gulKonumlari).Concat(kayaKonumlari).Concat(altinSandikKonumlari)
                            .Concat(gumusSandikKonumlari).Concat(zumrutSandikKonumlari).Concat(bakirSandikKonumlari)
                            .Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9) ||
                            yesilDagKonumlari.Concat(karliDagKonumlari).Concat(duvarKonumlari).Concat(shrekKonumlari)
                            .Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9) ||
                            kusKonumlari.Concat(ariKonumlari).Any(p => Math.Abs(p.X - x) <= 9 && Math.Abs(p.Y - y) <= 9))
                    {
                        x = random.Next(satir - 2);
                        y = random.Next(satir - 2);
                    }
                    bakirSandikKonumlari.Add(new Point(x, y));
                }

                // Shrek'in konumunu belirle ve çakýþma kontrolü yap
                do
                {
                    shrekSatir = random.Next(0, satir - 65);
                    shrekSutun = random.Next(0, satir - 65);
                } while (CheckCollision(shrekSatir, shrekSutun));

                // Kus'un konumunu belirle ve çakýþma kontrolü yap
                do
                {
                    kusSatir = random.Next(satir - 60, satir - 40);
                    kusSutun = random.Next(satir - 60, satir - 40);
                } while (CheckCollision(kusSatir, kusSutun));

                // Ari'nin konumunu belirle ve çakýþma kontrolü yap
                do
                {
                    ariSatir = random.Next(satir - 35, satir - 2);
                    ariSutun = random.Next(satir - 60, satir - 10);
                } while (CheckCollision(ariSatir, ariSutun));

                // Engellerin konumunu kontrol eden metot
                bool CheckCollision(int x, int y)
                {
                    // Hareketli engellerin her birinin konumunu kontrol et
                    foreach (Point point in kayaKonumlari.Concat(AgacKonumlari)
                                                           .Concat(KarliAgacKonumlari)
                                                           .Concat(gulKonumlari)
                                                           .Concat(altinSandikKonumlari)
                                                           .Concat(gumusSandikKonumlari)
                                                           .Concat(zumrutSandikKonumlari)
                                                           .Concat(bakirSandikKonumlari)
                                                           .Concat(yesilDagKonumlari)
                                                           .Concat(karliDagKonumlari)
                                                           .Concat(duvarKonumlari)
                                                           .Concat(shrekKonumlari)
                                                           .Concat(kusKonumlari)
                                                           .Concat(ariKonumlari))
                    {
                        // Eðer belirlenen konum baþka bir engelle çakýþýyorsa true döndür
                        if (Math.Abs(point.X - x) <= 9 && Math.Abs(point.Y - y) <= 9)
                        {
                            return true;
                        }
                    }
                    // Eðer çakýþma yoksa false döndür
                    return false;
                }

                Invalidate();  // Formu yeniden çiz
                               // Timer'ýn iþ parçacýðýný bir süre beklet (yavaþ hareket etmek için)
                //System.Threading.Thread.Sleep(50);


                Point enYakinAltinSandik = EnYakinSandik(altinSandikKonumlari, new Point(oyuncuSutun, oyuncuSatir));
                Point enYakinGumusSandik = EnYakinSandik(gumusSandikKonumlari, new Point(oyuncuSutun, oyuncuSatir));
                Point enYakinZumrutSandik = EnYakinSandik(zumrutSandikKonumlari, new Point(oyuncuSutun, oyuncuSatir));
                Point enYakinBakirSandik = EnYakinSandik(bakirSandikKonumlari, new Point(oyuncuSutun, oyuncuSatir));

                // Manhattan mesafesiyle en yakýn sandýðý bul
                Point enYakinSandik = EnKucukManhattan(enYakinAltinSandik, enYakinGumusSandik, enYakinZumrutSandik, enYakinBakirSandik, oyuncuSutun, oyuncuSatir);

                // Oyuncunun yeni konumunu belirle
                while (oyuncuKonumu != enYakinSandik)
                {
                    // Manhattan mesafesi hesapla
                    int deltaX = enYakinSandik.X - oyuncuKonumu.X;
                    int deltaY = enYakinSandik.Y - oyuncuKonumu.Y;

                    if (Math.Abs(deltaX) > Math.Abs(deltaY))
                    {
                        oyuncuKonumu.X += Math.Sign(deltaX);
                    }
                    else
                    {
                        oyuncuKonumu.Y += Math.Sign(deltaY);
                    }

                    // Yeni konumla pencereyi yenile
                    Invalidate();

                    // Timer'ýn iþ parçacýðýný bir süre beklet (yavaþ hareket etmek için)
                    //System.Threading.Thread.Sleep(50);
                }
                // Yeni konumu mesaj olarak göster
                MessageBox.Show("Oyuncunun yeni konumu: X - " + oyuncuKonumu.X + ", Y - " + oyuncuKonumu.Y);


                // En yakýn sandýk konumunu ve uzaklýðýný yazdýr
                message = "Oyuncunun en yakýn olduðu sandýk konumlarý:\n";
                message += "Altýn sandýk: Satýr - " + enYakinAltinSandik.X + ", Sütun - " + enYakinAltinSandik.Y + ", Uzaklýk: " + ManhattanMesafe(enYakinAltinSandik, oyuncuSutun, oyuncuSatir) + " kare\n";
                message += "Gümüþ sandýk: Satýr - " + enYakinGumusSandik.X + ", Sütun - " + enYakinGumusSandik.Y + ", Uzaklýk: " + ManhattanMesafe(enYakinGumusSandik, oyuncuSutun, oyuncuSatir) + " kare\n";
                message += "Zümrüt sandýk: Satýr - " + enYakinZumrutSandik.X + ", Sütun - " + enYakinZumrutSandik.Y + ", Uzaklýk: " + ManhattanMesafe(enYakinZumrutSandik, oyuncuSutun, oyuncuSatir) + " kare\n";
                message += "Bakýr sandýk: Satýr - " + enYakinBakirSandik.X + ", Sütun - " + enYakinBakirSandik.Y + ", Uzaklýk: " + ManhattanMesafe(enYakinBakirSandik, oyuncuSutun, oyuncuSatir) + " kare";

                // Mesaj kutusunda göster
                MessageBox.Show(message, "En Yakýn Sandýk Konumlarý");
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayý girin ve sýfýrdan büyük olsun.");
            }
            textBox1.Visible = false;
            button1.Visible = false;
            boyutgirlabel.Visible = false;

        }
        private int ManhattanMesafe(Point point1, int oyuncuSutun, int oyuncuSatir)
        {
            return Math.Abs(point1.X - oyuncuSutun) + Math.Abs(point1.Y - oyuncuSatir);
        }

        private Point EnKucukManhattan(Point point1, Point point2, Point point3, Point point4, int oyuncuSutun, int oyuncuSatir)
        {
            int mesafe1 = ManhattanMesafe(point1, oyuncuSutun, oyuncuSatir);
            int mesafe2 = ManhattanMesafe(point2, oyuncuSutun, oyuncuSatir);
            int mesafe3 = ManhattanMesafe(point3, oyuncuSutun, oyuncuSatir);
            int mesafe4 = ManhattanMesafe(point4, oyuncuSutun, oyuncuSatir);

            int enKucukMesafe = Math.Min(Math.Min(mesafe1, mesafe2), Math.Min(mesafe3, mesafe4));

            if (enKucukMesafe == mesafe1)
                return point1;
            else if (enKucukMesafe == mesafe2)
                return point2;
            else if (enKucukMesafe == mesafe3)
                return point3;
            else
                return point4;
        }

        private Point EnYakinSandik(List<Point> sandikKonumlari, Point oyuncuKonumu)
        {
            double enKisaUzaklik = double.MaxValue; // En kýsa uzaklýðý tutacak deðiþken
            Point enYakinSandikKonumu = Point.Empty; // En yakýn sandýk konumunu tutacak deðiþken

            foreach (Point sandikKonumu in sandikKonumlari)
            {
                // Oyuncunun konumu ve sandýk konumu arasýndaki mesafeyi hesapla (Manhattan mesafesi)
                int uzaklikX = Math.Abs(sandikKonumu.X - oyuncuKonumu.X);
                int uzaklikY = Math.Abs(sandikKonumu.Y - oyuncuKonumu.Y);
                int toplamUzaklik = uzaklikX + uzaklikY;

                // Eðer hesaplanan mesafe, þu ana kadar bulunan en kýsa mesafeden daha kýsa ise güncelle
                if (toplamUzaklik < enKisaUzaklik)
                {
                    enKisaUzaklik = toplamUzaklik;
                    enYakinSandikKonumu = sandikKonumu;
                }
            }

            return enYakinSandikKonumu;
        }


    }
}