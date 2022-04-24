using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Ödev3.Classes
{
    // Müşteri, çağrı merkezini aradığında çalışacak.
    public class Arama
    {
        public int aramaNo { get; set; }
        public string musteriTuru { get; set; }
        public string aramaZamani { get; set; }

        public Arama(int musteriNo, string musteriTuru)
        {
            this.aramaNo = musteriNo;
            this.musteriTuru = musteriTuru;
            this.aramaZamani = DateTime.Now.ToLongTimeString();
        }
        public ListViewItem BilgileriAl()
        {
            string[] bilgiler = new string[] { aramaNo.ToString(), musteriTuru, aramaZamani.ToString() };
            ListViewItem listViewItem = new ListViewItem(bilgiler);
            return listViewItem;
        }
    }
}
