using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Ödev3.Classes
{
    public class Temsilci
    {
        public int temsilciNo { get; set; }
        public string temsilciTuru { get; set; }
        public bool hatBostaMı { get; set; }
        public Temsilci(int temsilciNo, string temsilciTuru)
        {
            this.temsilciNo = temsilciNo;
            this.temsilciTuru = temsilciTuru;
            this.hatBostaMı = true;
        }

        public ListViewItem BilgileriAl()
        {
            string HatBostaMiString;
            if (hatBostaMı)
                HatBostaMiString = "Boş";
            else
                HatBostaMiString = "Boş Değil";
            string[] bilgiler = new string[] { temsilciNo.ToString(), temsilciTuru, HatBostaMiString };
            ListViewItem listViewItem = new ListViewItem(bilgiler);
            return listViewItem;
        }
    }
}
