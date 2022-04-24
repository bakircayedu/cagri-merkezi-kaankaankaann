
namespace Ödev3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.musteriNoTxt = new System.Windows.Forms.TextBox();
            this.siraSorgula = new System.Windows.Forms.Button();
            this.aramaSifirlaBtn = new System.Windows.Forms.Button();
            this.notAramaBtn = new System.Windows.Forms.Button();
            this.notAramaTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lvBitmisGorusme = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notTxt = new System.Windows.Forms.TextBox();
            this.lvGorusme = new System.Windows.Forms.ListView();
            this.Temsilci = new System.Windows.Forms.ColumnHeader();
            this.MusteriNo2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.lvArama = new System.Windows.Forms.ListView();
            this.AramaNo = new System.Windows.Forms.ColumnHeader();
            this.MusteriTuru = new System.Windows.Forms.ColumnHeader();
            this.Zaman = new System.Windows.Forms.ColumnHeader();
            this.lvTemsilci = new System.Windows.Forms.ListView();
            this.TemsilciNo = new System.Windows.Forms.ColumnHeader();
            this.TemsilciTuru = new System.Windows.Forms.ColumnHeader();
            this.HatBosMu = new System.Windows.Forms.ColumnHeader();
            this.secilenCagriAlBtn = new System.Windows.Forms.Button();
            this.cagriBitirBtn = new System.Windows.Forms.Button();
            this.cagriAlBtn = new System.Windows.Forms.Button();
            this.aramaBtn = new System.Windows.Forms.Button();
            this.ticariRadioButton = new System.Windows.Forms.RadioButton();
            this.bireyselRadioButton = new System.Windows.Forms.RadioButton();
            this.gbMusteri = new System.Windows.Forms.GroupBox();
            this.testBtn = new System.Windows.Forms.Button();
            this.siralaBtn = new System.Windows.Forms.Button();
            this.gbMusteri.SuspendLayout();
            this.SuspendLayout();
            // 
            // musteriNoTxt
            // 
            this.musteriNoTxt.Location = new System.Drawing.Point(325, 57);
            this.musteriNoTxt.Name = "musteriNoTxt";
            this.musteriNoTxt.Size = new System.Drawing.Size(163, 27);
            this.musteriNoTxt.TabIndex = 44;
            // 
            // siraSorgula
            // 
            this.siraSorgula.Location = new System.Drawing.Point(325, 90);
            this.siraSorgula.Name = "siraSorgula";
            this.siraSorgula.Size = new System.Drawing.Size(163, 29);
            this.siraSorgula.TabIndex = 43;
            this.siraSorgula.Text = "Sıra Sorgula";
            this.siraSorgula.UseVisualStyleBackColor = true;
            this.siraSorgula.Click += new System.EventHandler(this.siraSorgula_Click);
            // 
            // aramaSifirlaBtn
            // 
            this.aramaSifirlaBtn.Location = new System.Drawing.Point(1030, 521);
            this.aramaSifirlaBtn.Name = "aramaSifirlaBtn";
            this.aramaSifirlaBtn.Size = new System.Drawing.Size(313, 29);
            this.aramaSifirlaBtn.TabIndex = 42;
            this.aramaSifirlaBtn.Text = "Aramayı Sıfırla";
            this.aramaSifirlaBtn.UseVisualStyleBackColor = true;
            this.aramaSifirlaBtn.Click += new System.EventHandler(this.aramaSifirlaBtn_Click);
            // 
            // notAramaBtn
            // 
            this.notAramaBtn.Location = new System.Drawing.Point(717, 521);
            this.notAramaBtn.Name = "notAramaBtn";
            this.notAramaBtn.Size = new System.Drawing.Size(313, 29);
            this.notAramaBtn.TabIndex = 41;
            this.notAramaBtn.Text = "Ara";
            this.notAramaBtn.UseVisualStyleBackColor = true;
            this.notAramaBtn.Click += new System.EventHandler(this.notAramaBtn_Click);
            // 
            // notAramaTxt
            // 
            this.notAramaTxt.Location = new System.Drawing.Point(717, 486);
            this.notAramaTxt.Multiline = true;
            this.notAramaTxt.Name = "notAramaTxt";
            this.notAramaTxt.Size = new System.Drawing.Size(626, 29);
            this.notAramaTxt.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(717, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Bitmiş Görüşmeler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1037, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Seçilen Görüşme Notları";
            // 
            // lvBitmisGorusme
            // 
            this.lvBitmisGorusme.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvBitmisGorusme.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvBitmisGorusme.FullRowSelect = true;
            this.lvBitmisGorusme.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvBitmisGorusme.HideSelection = false;
            this.lvBitmisGorusme.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvBitmisGorusme.Location = new System.Drawing.Point(717, 307);
            this.lvBitmisGorusme.MultiSelect = false;
            this.lvBitmisGorusme.Name = "lvBitmisGorusme";
            this.lvBitmisGorusme.Size = new System.Drawing.Size(626, 164);
            this.lvBitmisGorusme.TabIndex = 37;
            this.lvBitmisGorusme.UseCompatibleStateImageBehavior = false;
            this.lvBitmisGorusme.View = System.Windows.Forms.View.Details;
            this.lvBitmisGorusme.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvBitmisGorusme_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Temsilci No";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Arama No";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Başlangıç Zamanı";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Bitiş Zamanı";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Notlar";
            this.columnHeader6.Width = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(715, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Devam Eden Görüşmeler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Sıradaki Aramalar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Müşteri Temsilcileri";
            // 
            // notTxt
            // 
            this.notTxt.Location = new System.Drawing.Point(1037, 51);
            this.notTxt.Multiline = true;
            this.notTxt.Name = "notTxt";
            this.notTxt.Size = new System.Drawing.Size(304, 164);
            this.notTxt.TabIndex = 33;
            this.notTxt.TextChanged += new System.EventHandler(this.notTxt_TextChanged);
            // 
            // lvGorusme
            // 
            this.lvGorusme.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvGorusme.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Temsilci,
            this.MusteriNo2,
            this.columnHeader3});
            this.lvGorusme.FullRowSelect = true;
            this.lvGorusme.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvGorusme.HideSelection = false;
            this.lvGorusme.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvGorusme.Location = new System.Drawing.Point(715, 51);
            this.lvGorusme.MultiSelect = false;
            this.lvGorusme.Name = "lvGorusme";
            this.lvGorusme.Size = new System.Drawing.Size(304, 164);
            this.lvGorusme.TabIndex = 32;
            this.lvGorusme.UseCompatibleStateImageBehavior = false;
            this.lvGorusme.View = System.Windows.Forms.View.Details;
            this.lvGorusme.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvDevamEdenGorusmeler_ItemSelectionChanged);
            // 
            // Temsilci
            // 
            this.Temsilci.Text = "Temsilci No";
            this.Temsilci.Width = 100;
            // 
            // MusteriNo2
            // 
            this.MusteriNo2.Text = "Arama No";
            this.MusteriNo2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Başlangıç Zamanı";
            this.columnHeader3.Width = 100;
            // 
            // lvArama
            // 
            this.lvArama.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvArama.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AramaNo,
            this.MusteriTuru,
            this.Zaman});
            this.lvArama.FullRowSelect = true;
            this.lvArama.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvArama.HideSelection = false;
            this.lvArama.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvArama.Location = new System.Drawing.Point(357, 307);
            this.lvArama.MultiSelect = false;
            this.lvArama.Name = "lvArama";
            this.lvArama.Size = new System.Drawing.Size(304, 164);
            this.lvArama.TabIndex = 31;
            this.lvArama.UseCompatibleStateImageBehavior = false;
            this.lvArama.View = System.Windows.Forms.View.Details;
            this.lvArama.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvArama_ItemSelectionChanged);
            // 
            // AramaNo
            // 
            this.AramaNo.Text = "Arama No";
            this.AramaNo.Width = 100;
            // 
            // MusteriTuru
            // 
            this.MusteriTuru.Text = "Müşteri Türü";
            this.MusteriTuru.Width = 100;
            // 
            // Zaman
            // 
            this.Zaman.Text = "Zaman";
            this.Zaman.Width = 100;
            // 
            // lvTemsilci
            // 
            this.lvTemsilci.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TemsilciNo,
            this.TemsilciTuru,
            this.HatBosMu});
            this.lvTemsilci.FullRowSelect = true;
            this.lvTemsilci.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvTemsilci.HideSelection = false;
            this.lvTemsilci.Location = new System.Drawing.Point(32, 307);
            this.lvTemsilci.MultiSelect = false;
            this.lvTemsilci.Name = "lvTemsilci";
            this.lvTemsilci.Size = new System.Drawing.Size(304, 164);
            this.lvTemsilci.TabIndex = 30;
            this.lvTemsilci.UseCompatibleStateImageBehavior = false;
            this.lvTemsilci.View = System.Windows.Forms.View.Details;
            this.lvTemsilci.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvTemsilciler_ItemSelectionChanged);
            // 
            // TemsilciNo
            // 
            this.TemsilciNo.Text = "Temsilci No";
            this.TemsilciNo.Width = 100;
            // 
            // TemsilciTuru
            // 
            this.TemsilciTuru.Text = "Temsilci Türü";
            this.TemsilciTuru.Width = 100;
            // 
            // HatBosMu
            // 
            this.HatBosMu.Text = "Hat Boş Mu?";
            this.HatBosMu.Width = 100;
            // 
            // secilenCagriAlBtn
            // 
            this.secilenCagriAlBtn.Location = new System.Drawing.Point(32, 521);
            this.secilenCagriAlBtn.Name = "secilenCagriAlBtn";
            this.secilenCagriAlBtn.Size = new System.Drawing.Size(307, 29);
            this.secilenCagriAlBtn.TabIndex = 29;
            this.secilenCagriAlBtn.Text = "Seçilen Çağrıyı Al";
            this.secilenCagriAlBtn.UseVisualStyleBackColor = true;
            this.secilenCagriAlBtn.Click += new System.EventHandler(this.secilenCagriAlBtn_Click);
            // 
            // cagriBitirBtn
            // 
            this.cagriBitirBtn.Location = new System.Drawing.Point(715, 230);
            this.cagriBitirBtn.Name = "cagriBitirBtn";
            this.cagriBitirBtn.Size = new System.Drawing.Size(626, 29);
            this.cagriBitirBtn.TabIndex = 28;
            this.cagriBitirBtn.Text = "Çağrıyı Bitir";
            this.cagriBitirBtn.UseVisualStyleBackColor = true;
            this.cagriBitirBtn.Click += new System.EventHandler(this.cagriBitirBtn_Click);
            // 
            // cagriAlBtn
            // 
            this.cagriAlBtn.Location = new System.Drawing.Point(354, 521);
            this.cagriAlBtn.Name = "cagriAlBtn";
            this.cagriAlBtn.Size = new System.Drawing.Size(307, 29);
            this.cagriAlBtn.TabIndex = 27;
            this.cagriAlBtn.Text = "Sıradaki Çağrıyı Al";
            this.cagriAlBtn.UseVisualStyleBackColor = true;
            this.cagriAlBtn.Click += new System.EventHandler(this.cagriAlBtn_Click);
            // 
            // aramaBtn
            // 
            this.aramaBtn.Location = new System.Drawing.Point(141, 87);
            this.aramaBtn.Name = "aramaBtn";
            this.aramaBtn.Size = new System.Drawing.Size(163, 30);
            this.aramaBtn.TabIndex = 26;
            this.aramaBtn.Text = "Arama Yap";
            this.aramaBtn.UseVisualStyleBackColor = true;
            this.aramaBtn.Click += new System.EventHandler(this.aramaBtn_Click);
            // 
            // ticariRadioButton
            // 
            this.ticariRadioButton.AutoSize = true;
            this.ticariRadioButton.Location = new System.Drawing.Point(238, 57);
            this.ticariRadioButton.Name = "ticariRadioButton";
            this.ticariRadioButton.Size = new System.Drawing.Size(66, 24);
            this.ticariRadioButton.TabIndex = 25;
            this.ticariRadioButton.TabStop = true;
            this.ticariRadioButton.Text = "Ticari";
            this.ticariRadioButton.UseVisualStyleBackColor = true;
            // 
            // bireyselRadioButton
            // 
            this.bireyselRadioButton.AutoSize = true;
            this.bireyselRadioButton.Location = new System.Drawing.Point(141, 57);
            this.bireyselRadioButton.Name = "bireyselRadioButton";
            this.bireyselRadioButton.Size = new System.Drawing.Size(81, 24);
            this.bireyselRadioButton.TabIndex = 24;
            this.bireyselRadioButton.TabStop = true;
            this.bireyselRadioButton.Text = "Bireysel";
            this.bireyselRadioButton.UseVisualStyleBackColor = true;
            // 
            // gbMusteri
            // 
            this.gbMusteri.Controls.Add(this.aramaBtn);
            this.gbMusteri.Controls.Add(this.musteriNoTxt);
            this.gbMusteri.Controls.Add(this.ticariRadioButton);
            this.gbMusteri.Controls.Add(this.siraSorgula);
            this.gbMusteri.Controls.Add(this.bireyselRadioButton);
            this.gbMusteri.Location = new System.Drawing.Point(32, 28);
            this.gbMusteri.Name = "gbMusteri";
            this.gbMusteri.Size = new System.Drawing.Size(629, 187);
            this.gbMusteri.TabIndex = 45;
            this.gbMusteri.TabStop = false;
            this.gbMusteri.Text = "Müşteri Arayüzü";
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(32, 230);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(629, 29);
            this.testBtn.TabIndex = 46;
            this.testBtn.Text = "Test Verilerini Aktar";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // siralaBtn
            // 
            this.siralaBtn.Location = new System.Drawing.Point(32, 485);
            this.siralaBtn.Name = "siralaBtn";
            this.siralaBtn.Size = new System.Drawing.Size(629, 29);
            this.siralaBtn.TabIndex = 47;
            this.siralaBtn.Text = "Aramaları Sırala";
            this.siralaBtn.UseVisualStyleBackColor = true;
            this.siralaBtn.Click += new System.EventHandler(this.siralaBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 579);
            this.Controls.Add(this.siralaBtn);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.gbMusteri);
            this.Controls.Add(this.aramaSifirlaBtn);
            this.Controls.Add(this.notAramaBtn);
            this.Controls.Add(this.notAramaTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lvBitmisGorusme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notTxt);
            this.Controls.Add(this.lvGorusme);
            this.Controls.Add(this.lvArama);
            this.Controls.Add(this.lvTemsilci);
            this.Controls.Add(this.secilenCagriAlBtn);
            this.Controls.Add(this.cagriBitirBtn);
            this.Controls.Add(this.cagriAlBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbMusteri.ResumeLayout(false);
            this.gbMusteri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox musteriNoTxt;
        private System.Windows.Forms.Button siraSorgula;
        private System.Windows.Forms.Button aramaSifirlaBtn;
        private System.Windows.Forms.Button notAramaBtn;
        private System.Windows.Forms.TextBox notAramaTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvBitmisGorusme;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox notTxt;
        private System.Windows.Forms.ListView lvGorusme;
        private System.Windows.Forms.ColumnHeader Temsilci;
        private System.Windows.Forms.ColumnHeader MusteriNo2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lvArama;
        private System.Windows.Forms.ColumnHeader AramaNo;
        private System.Windows.Forms.ColumnHeader MusteriTuru;
        private System.Windows.Forms.ColumnHeader Zaman;
        private System.Windows.Forms.ListView lvTemsilci;
        private System.Windows.Forms.ColumnHeader TemsilciNo;
        private System.Windows.Forms.ColumnHeader TemsilciTuru;
        private System.Windows.Forms.ColumnHeader HatBosMu;
        private System.Windows.Forms.Button secilenCagriAlBtn;
        private System.Windows.Forms.Button cagriBitirBtn;
        private System.Windows.Forms.Button cagriAlBtn;
        private System.Windows.Forms.Button aramaBtn;
        private System.Windows.Forms.RadioButton ticariRadioButton;
        private System.Windows.Forms.RadioButton bireyselRadioButton;
        private System.Windows.Forms.GroupBox gbMusteri;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Button siralaBtn;
    }
}

