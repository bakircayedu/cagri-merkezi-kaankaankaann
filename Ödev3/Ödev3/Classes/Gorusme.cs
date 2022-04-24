using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Ödev3.Classes
{
    public class Gorusme
    {
        public Arama arama { get; set; }
        public Temsilci temsilci { get; set; }
        public string gorusmeBaslangic { get; set; }
        public string notlar { get; set; }

        public Gorusme(Arama alinanArama, Temsilci musteriTemsilcisi)
        {
            this.arama = alinanArama;
            this.temsilci = musteriTemsilcisi;
            this.gorusmeBaslangic = DateTime.Now.ToLongTimeString();
            this.notlar = "";
        }
        public ListViewItem BilgileriAl()
        {
            string[] bilgiler = new string[] { temsilci.temsilciNo.ToString(), arama.aramaNo.ToString(), gorusmeBaslangic };
            ListViewItem listViewItem = new ListViewItem(bilgiler);
            return listViewItem;
        }
    }
}
