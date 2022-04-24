using Ödev3.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Kayıtları tutacak listeler ve arama sayısını tutacak AramaCount
        LinkedList<Arama> AramaLl = new LinkedList<Arama>();
        LinkedList<Temsilci> TemsilciLl = new LinkedList<Temsilci>();
        LinkedList<Gorusme> GorusmeLl = new LinkedList<Gorusme>();
        LinkedList<BitmisGorusme> BitmisGorusmeLl = new LinkedList<BitmisGorusme>();
        int AramaCount = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Uygulamada hata olmaması için kontroller düzenleniyor.
            secilenCagriAlBtn.Enabled = false;
            cagriAlBtn.Enabled = false;
            cagriBitirBtn.Enabled = false;
            notTxt.Enabled = false;
            bireyselRadioButton.Checked = true;

            // Dört temsilci listeye atanıyor
            TemsilciLl.InsertLast(new Temsilci(1, "Bireysel"));
            TemsilciLl.InsertLast(new Temsilci(2, "Bireysel"));
            TemsilciLl.InsertLast(new Temsilci(3, "Ticari"));
            TemsilciLl.InsertLast(new Temsilci(4, "Ticari"));
            Node<Temsilci> temsilci = TemsilciLl.First();
            while (temsilci != null)
            {
                lvTemsilci.Items.Add(temsilci.Value.BilgileriAl());
                temsilci = temsilci.Next;
            }
        }

        private void aramaBtn_Click(object sender, EventArgs e)
        {
            // Seçilen müşteri türüne göre yeni arama sınıfı oluşturulur ve arama listesine atanır.
            Arama arama;
            if (bireyselRadioButton.Checked)
                arama = new Arama(++AramaCount, "Bireysel");
            else
                arama = new Arama(++AramaCount, "Ticari");
            AramaLl.InsertLast(arama);
            lvArama.Items.Add(arama.BilgileriAl());

            // Sıradan çağrı alma butonu aktif hale gelir.
            cagriAlBtn.Enabled = true;
            MessageBox.Show("Sıraya Alındınız. Lütfen hattan ayrılmayınız. \nSıranızı öğrenmek için arama numaranız: " + AramaCount);
        }
        private void siraSorgula_Click(object sender, EventArgs e)
        {
            int sorgulancakAramaNo;
            try
            {
                sorgulancakAramaNo = Convert.ToInt32(musteriNoTxt.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Geçersiz karakter girdiniz.");
                return;
            }

            // Seçilen arama bulunur.
            Node<Arama> secilenArama = AramaLl.First();
            bool bulunduMu = false;
            for (int i = 0; i < AramaLl.Count; i++)
            {
                if (secilenArama.Value.aramaNo == sorgulancakAramaNo)
                {
                    bulunduMu = true;
                    break;
                }
                secilenArama = secilenArama.Next;
            }
            if (!bulunduMu)
            {
                MessageBox.Show("Girdiğiniz numaraya ait sırada arama bulunmamaktadır.");
                return;
            }

            // Seçilen aramadan önce yapılan aramaların müşteri türü, seçilen aramanın müşteri türü ile aynı ise sıra değişkeni bir arttırılır.
            int sira = 1;
            Node<Arama> arama = AramaLl.First();
            while (secilenArama != arama)
            {
                if (secilenArama.Value.musteriTuru == arama.Value.musteriTuru)
                {
                    sira++;
                }
                arama = arama.Next;
            }
            MessageBox.Show(sira + ". Sıradasınız.");
        }

        private void cagriAlBtn_Click(object sender, EventArgs e)
        {
            Node<Arama> secilenArama = AramaLl.First();
            Node<Temsilci> secilenTemsilci = TemsilciLl.First();

            for (int i = 0; i < AramaLl.Count; i++)
            {
                for (int j = 0; j < TemsilciLl.Count; j++)
                {
                    if (secilenTemsilci.Value.hatBostaMı)
                    {
                        if (secilenArama.Value.musteriTuru == secilenTemsilci.Value.temsilciTuru)
                        {
                            // Yeni görüşme, liste'ye atanır.
                            Gorusme gorusme = new Gorusme(secilenArama.Value, secilenTemsilci.Value);
                            GorusmeLl.InsertLast(gorusme);
                            lvGorusme.Items.Add(gorusme.BilgileriAl());

                            // Görüşme listesine giden arama, kayıtlardan silinir.
                            AramaLl.RemoveAt(i);
                            lvArama.Items.RemoveAt(i);

                            // Görüşmeye giden temsilcinin hattı, boş değil olarak değiştirilir.
                            secilenTemsilci.Value.hatBostaMı = false;
                            lvTemsilci.Items[j].SubItems[2].Text = "Boş Değil";

                            // Arama listesi boş ise çağrı alma butonları pasif olur.
                            if (AramaLl.Count == 0)
                                cagriAlBtn.Enabled = false;
                            // İşlem tamamlandıktan sonra fonksiyon bitirilir.
                            return;
                        }
                    }
                    // Bir çağrı, bir temsilciye uymuyor ise diğer temsilciye geçilir. 
                    secilenTemsilci = secilenTemsilci.Next;
                }
                // Bir çağrı, dört temsilciye de uymuyor ise diğer çağrıya geçilir.
                secilenArama = secilenArama.Next;
                // secilenTemsilci değişkeni, kontrol sırasında son boğuma ulaştığından tekrar baş boğuma atanır. 
                secilenTemsilci = TemsilciLl.First();
            }
        }
        private void secilenCagriAlBtn_Click(object sender, EventArgs e)
        {
            Arama secilenArama = AramaLl.Get(lvArama.SelectedIndices[0]).Value;
            Temsilci secilenTemsilci = TemsilciLl.Get(lvTemsilci.SelectedIndices[0]).Value;

            if (secilenArama.musteriTuru == secilenTemsilci.temsilciTuru)
            {
                if (secilenTemsilci.hatBostaMı)
                {
                    // Seçilen temsilci ve seçilen arama, yeni gorusme nesnesine atanarak gorusme listesine gider.
                    Gorusme gorusme = new Gorusme(secilenArama, secilenTemsilci);
                    GorusmeLl.InsertLast(gorusme);
                    lvGorusme.Items.Add(gorusme.BilgileriAl());

                    // Seçilen arama, kayıtlardan silinir
                    AramaLl.RemoveAt(lvArama.SelectedIndices[0]);
                    lvArama.Items.RemoveAt(lvArama.SelectedIndices[0]);

                    // Seçilen temsilcinin hattı, boş değil olarak değiştirilir.
                    secilenTemsilci.hatBostaMı = false;
                    lvTemsilci.SelectedItems[0].SubItems[2].Text = "Boş Değil";
                }
                else
                    MessageBox.Show("Seçtiğiniz müşteri hattı dolu.");
            }
            else
                MessageBox.Show("Seçtiğiniz müşteri ve temsilci türleri birbirinden farklı.");
        }
        private void cagriBitirBtn_Click(object sender, EventArgs e)
        {
            int secilenIndex = lvGorusme.SelectedIndices[0];
            Gorusme secilenGorusme = GorusmeLl.Get(secilenIndex).Value;

            // Biten görüşme, biten görüşme listesine gider.
            BitmisGorusme bitenGorusme = new BitmisGorusme(secilenGorusme, notTxt.Text);
            BitmisGorusmeLl.InsertLast(bitenGorusme);
            lvBitmisGorusme.Items.Add(bitenGorusme.BilgileriAl());

            // Biten görüşme, devam eden görüşme listesinden silinir.
            GorusmeLl.RemoveAt(secilenIndex);
            lvGorusme.Items.RemoveAt(secilenIndex);

            // Biten görüşmenin temsilci hattı, tekrar boş hale gelir.
            secilenGorusme.temsilci.hatBostaMı = true;
            lvTemsilci.FindItemWithText((secilenGorusme.temsilci.BilgileriAl().Text)).SubItems[2].Text = "Boş";
        }

        private void lvDevamEdenGorusmeler_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // Seçilmiş bir görüşme varsa kontroller aktif olur ve seçilen görüşmenin notu textbox'a yazdırılır.
            if (lvGorusme.SelectedItems.Count != 0)
            {
                notTxt.Enabled = true;
                cagriBitirBtn.Enabled = true;
                Gorusme secilenGorusme = GorusmeLl.Get(lvGorusme.SelectedIndices[0]).Value;
                notTxt.Text = secilenGorusme.notlar;
            }
            else
            {
                notTxt.Text = "";
                notTxt.Enabled = false;
                cagriBitirBtn.Enabled = false;
            }
        }

        private void notTxt_TextChanged(object sender, EventArgs e)
        {
            // Textbox'ta yapılan her değişiklik, seçilen görüşmenin notlarına atanır.
            if (lvGorusme.SelectedItems.Count != 0)
            {
                Gorusme secilenGorusme = GorusmeLl.Get(lvGorusme.SelectedIndices[0]).Value;
                secilenGorusme.notlar = notTxt.Text;
            }
        }

        private void notAramaBtn_Click(object sender, EventArgs e)
        {
            // Kelime bazında arama yapılarak anahtar kelimeyi içeren notları, bitmiş görüşme ListView'ine yazdırır. 
            lvBitmisGorusme.Items.Clear();
            string not;
            string[] kelimeler;
            string anahtarKelime = notAramaTxt.Text;
            Node<BitmisGorusme> gorusme = BitmisGorusmeLl.First();
            while (gorusme != null)
            {
                not = gorusme.Value.notlar;
                not = Regex.Replace(not, @"[^\w\d\s]", " "); // Noktalama işaretlerini boşluk karakteriyle değiştirir.
                not = not.ToLower();
                kelimeler = not.Split(" ");
                anahtarKelime = anahtarKelime.ToLower();

                if (kelimeler.Contains(anahtarKelime))
                {
                    lvBitmisGorusme.Items.Add(gorusme.Value.BilgileriAl());
                }
                gorusme = gorusme.Next;
            }
        }

        private void aramaSifirlaBtn_Click(object sender, EventArgs e)
        {
            // Bitmiş görüşme ListView'i, varsayılan haline getirir.
            lvBitmisGorusme.Items.Clear();
            Node<BitmisGorusme> gorusme = BitmisGorusmeLl.First();
            while (gorusme != null)
            {
                lvBitmisGorusme.Items.Add(gorusme.Value.BilgileriAl());
                gorusme = gorusme.Next;
            }
        }

        private void lvTemsilciler_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // Seçilen arama veya seçilen temsilci yok ise seçilen çağrı alma butonu pasif olur.
            if (lvArama.SelectedItems.Count == 0 || lvTemsilci.SelectedItems.Count == 0)
                secilenCagriAlBtn.Enabled = false;
            else
                secilenCagriAlBtn.Enabled = true;
        }

        private void lvArama_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // Seçilen arama veya seçilen temsilci yok ise seçilen çağrı alma butonu pasif olur.
            if (lvArama.SelectedItems.Count == 0 || lvTemsilci.SelectedItems.Count == 0)
                secilenCagriAlBtn.Enabled = false;
            else
                secilenCagriAlBtn.Enabled = true;
        }

        private void lvBitmisGorusme_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Bitmiş görüşme listesinde herhangi bir kaydın üzerine iki kere tıklandığında o kayıdın ayrtıntıları görüntülenir.
            BitmisGorusme secilen = BitmisGorusmeLl.Get(lvBitmisGorusme.SelectedIndices[0]).Value;
            MessageBox.Show(secilen.TumBilgileriAl());
        }

        // Rastgele değerlere sahip bir DateTime değişkeni gönderir.
        DateTime RandomTime()
        {
            Random r = new Random();
            DateTime start = new DateTime();
            start = start.AddHours(r.Next(0, 24));
            start = start.AddMinutes(r.Next(0, 60));
            start = start.AddSeconds(r.Next(0, 60));
            return start;
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            // Test verileri

            // Test verileri sadece bir kez kullanılabilir.
            testBtn.Enabled = false;
            cagriAlBtn.Enabled = true;
           
            // Rastgele tur ve zamana sahip olan 5 tane arama sınıfı oluşturur ve listeye ekler.
            Arama arama;
            int index;
            string[] turler = { "Bireysel", "Ticari" };
            for (int i = 0; i < 5; i++)
            {
                index = new Random().Next(0, 2);
                arama = new Arama(++AramaCount, turler[index]);
                arama.aramaZamani = RandomTime().ToLongTimeString();               
                AramaLl.InsertLast(arama);
            }

            lvArama.Items.Clear();
            Node<Arama> aramaNode = AramaLl.First();
            for (int i = 0; i < AramaLl.Count; i++)
            {
                lvArama.Items.Add(aramaNode.Value.BilgileriAl());
                aramaNode = aramaNode.Next;
            }



            // 3 tane bitmiş görüşmeyi listeye ekler
            DateTime randomTime1 = RandomTime();
            Arama arama1 = new Arama(++AramaCount, "Bireysel");
            Gorusme gorusme1 = new Gorusme(arama1, TemsilciLl.First().Value);
            BitmisGorusme bitmisGorusme1 = new BitmisGorusme(gorusme1, "Üzerime iki kere tıkla. ");            
            bitmisGorusme1.gorusmeBaslangic = randomTime1.ToLongTimeString();
            bitmisGorusme1.gorusmeBitis = randomTime1.AddMinutes(5).ToLongTimeString();
            lvBitmisGorusme.Items.Add(bitmisGorusme1.BilgileriAl());
            BitmisGorusmeLl.InsertLast(bitmisGorusme1);

            DateTime randomTime2 = RandomTime();
            Arama arama2 = new Arama(++AramaCount, "Ticari");
            Gorusme gorusme2 = new Gorusme(arama2, TemsilciLl.First().Next.Next.Value);
            BitmisGorusme bitmisGorusme2 = new BitmisGorusme(gorusme2, "Müşterinin talepleri yerine getirildi.");
            bitmisGorusme2.gorusmeBaslangic = randomTime2.ToLongTimeString();
            bitmisGorusme2.gorusmeBitis = randomTime2.AddMinutes(10).ToLongTimeString();
            lvBitmisGorusme.Items.Add(bitmisGorusme2.BilgileriAl());
            BitmisGorusmeLl.InsertLast(bitmisGorusme2);

            DateTime randomTime3 = RandomTime();
            Arama arama3 = new Arama(++AramaCount, "Bireysel");
            Gorusme gorusme3 = new Gorusme(arama3, TemsilciLl.First().Value);
            BitmisGorusme bitmisGorusme3 = new BitmisGorusme(gorusme3, "MüŞterİNin:telefonu:kapandı.");
            bitmisGorusme3.gorusmeBaslangic = randomTime3.ToLongTimeString();
            bitmisGorusme3.gorusmeBitis = randomTime3.AddMinutes(2).ToLongTimeString();
            lvBitmisGorusme.Items.Add(bitmisGorusme3.BilgileriAl());
            BitmisGorusmeLl.InsertLast(bitmisGorusme3);
        }

        private void siralaBtn_Click(object sender, EventArgs e)
        {
            // Aramalar, arama saatine göre küçükten büyüğe doğru sıralanır.
            int i, j;
            Arama moved;
            for (i = 1; i < AramaLl.Count; i++)
            {
                moved = AramaLl.Get(i).Value;
                j = i;
                while (j > 0 && Convert.ToDateTime(AramaLl.Get(j - 1).Value.aramaZamani) > Convert.ToDateTime(moved.aramaZamani))
                {
                    AramaLl.Get(j).Value = AramaLl.Get(j - 1).Value;
                    j--;
                }
                AramaLl.Get(j).Value = moved;
            }

            // ListView elemanları silinir ve yerine sıralanmış elemanlar eklenir.
            lvArama.Items.Clear();
            Node<Arama> arama1 = AramaLl.First();
            for (int k = 0; k < AramaLl.Count; k++)
            {
                lvArama.Items.Add(arama1.Value.BilgileriAl());
                arama1 = arama1.Next;
            }
        }
    }
}
    

