using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Ödev3.Classes
{
    class BitmisGorusme
    {
        public Arama arama { get; set; }
        public Temsilci temsilci { get; set; }
        public string gorusmeBaslangic { get; set; }
        public string gorusmeBitis { get; set; }
        public string notlar { get; set; }

        public BitmisGorusme(Gorusme baslamisGorusme, string notlar)
        {
            this.arama = baslamisGorusme.arama;
            this.temsilci = baslamisGorusme.temsilci;
            this.gorusmeBaslangic = baslamisGorusme.gorusmeBaslangic;
            this.gorusmeBitis = DateTime.Now.ToLongTimeString();
            this.notlar = notlar;
        }
        public ListViewItem BilgileriAl()
        {
            string[] bilgiler = new string[] { temsilci.temsilciNo.ToString(), arama.aramaNo.ToString(), gorusmeBaslangic, gorusmeBitis, notlar };
            ListViewItem listViewItem = new ListViewItem(bilgiler);
            return listViewItem;
        }
        public string TumBilgileriAl()
        {
            string bilgi = "";
            bilgi += "Görüşme Türü: " + temsilci.temsilciTuru + Environment.NewLine +
                    "Temsilci No: " + temsilci.temsilciNo + Environment.NewLine +
                    "Arama No: " + arama.aramaNo + Environment.NewLine +
                    "Arama Saati: " + arama.aramaZamani + Environment.NewLine +
                    "Görüşme Başlangıç Saati: " + gorusmeBaslangic + Environment.NewLine +
                    "Görüşme Bitiş Saati: " + gorusmeBitis + Environment.NewLine +
                    "Görüşme Notları: " + notlar;
            return bilgi;
        }
    }
}
