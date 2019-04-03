namespace YapilacaklarListesi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnYeni = new System.Windows.Forms.ToolStripButton();
            this.btnDuzelt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btnKEs = new System.Windows.Forms.ToolStripButton();
            this.btnKopyala = new System.Windows.Forms.ToolStripButton();
            this.btnYapistir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnYardim = new System.Windows.Forms.ToolStripButton();
            this.menuDosya = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDuzelt = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSil = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUyHakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuYardim = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSil = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpBxYeGorev = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblYapLis = new System.Windows.Forms.Label();
            this.chcbxYapListesi = new System.Windows.Forms.CheckedListBox();
            this.lblTaLis = new System.Windows.Forms.Label();
            this.lstbxTamamListesi = new System.Windows.Forms.ListBox();
            this.txtYapLis = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpBxYeGorev.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnYeni,
            this.btnDuzelt,
            this.btnSil,
            this.toolStripSeparator,
            this.btnKEs,
            this.btnKopyala,
            this.btnYapistir,
            this.toolStripSeparator1,
            this.btnYardim});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDosya,
            this.menuTodo,
            this.menuHakkinda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnYeni
            // 
            this.btnYeni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYeni.Image = global::YapilacaklarListesi.Properties.Resources.plus_24_128;
            this.btnYeni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(23, 22);
            this.btnYeni.Text = "Yeni";
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnDuzelt
            // 
            this.btnDuzelt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDuzelt.Image = global::YapilacaklarListesi.Properties.Resources.new_24_128;
            this.btnDuzelt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDuzelt.Name = "btnDuzelt";
            this.btnDuzelt.Size = new System.Drawing.Size(23, 22);
            this.btnDuzelt.Text = "Düzelt";
            this.btnDuzelt.Click += new System.EventHandler(this.btnDuzelt_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // btnKEs
            // 
            this.btnKEs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKEs.Image = ((System.Drawing.Image)(resources.GetObject("btnKEs.Image")));
            this.btnKEs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKEs.Name = "btnKEs";
            this.btnKEs.Size = new System.Drawing.Size(23, 22);
            this.btnKEs.Text = "Kes";
            this.btnKEs.Click += new System.EventHandler(this.btnKEs_Click);
            // 
            // btnKopyala
            // 
            this.btnKopyala.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKopyala.Image = ((System.Drawing.Image)(resources.GetObject("btnKopyala.Image")));
            this.btnKopyala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(23, 22);
            this.btnKopyala.Text = "Kopyala";
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // btnYapistir
            // 
            this.btnYapistir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYapistir.Image = ((System.Drawing.Image)(resources.GetObject("btnYapistir.Image")));
            this.btnYapistir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYapistir.Name = "btnYapistir";
            this.btnYapistir.Size = new System.Drawing.Size(23, 22);
            this.btnYapistir.Text = "Yapıştır";
            this.btnYapistir.Click += new System.EventHandler(this.btnYapistir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnYardim
            // 
            this.btnYardim.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYardim.Image = ((System.Drawing.Image)(resources.GetObject("btnYardim.Image")));
            this.btnYardim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYardim.Name = "btnYardim";
            this.btnYardim.Size = new System.Drawing.Size(23, 22);
            this.btnYardim.Text = "Yardım";
            // 
            // menuDosya
            // 
            this.menuDosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCikis});
            this.menuDosya.Name = "menuDosya";
            this.menuDosya.Size = new System.Drawing.Size(51, 20);
            this.menuDosya.Text = "Dosya";
            // 
            // menuCikis
            // 
            this.menuCikis.Name = "menuCikis";
            this.menuCikis.Size = new System.Drawing.Size(180, 22);
            this.menuCikis.Text = "Çıkış";
            // 
            // menuTodo
            // 
            this.menuTodo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuYeni,
            this.menuDuzelt,
            this.toolStripMenuItem1,
            this.menuSil});
            this.menuTodo.Name = "menuTodo";
            this.menuTodo.Size = new System.Drawing.Size(48, 20);
            this.menuTodo.Text = "ToDo";
            // 
            // menuYeni
            // 
            this.menuYeni.Image = global::YapilacaklarListesi.Properties.Resources.plus_24_128;
            this.menuYeni.Name = "menuYeni";
            this.menuYeni.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuYeni.Size = new System.Drawing.Size(180, 22);
            this.menuYeni.Text = "Yeni";
            // 
            // menuDuzelt
            // 
            this.menuDuzelt.Image = global::YapilacaklarListesi.Properties.Resources.new_24_128;
            this.menuDuzelt.Name = "menuDuzelt";
            this.menuDuzelt.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menuDuzelt.Size = new System.Drawing.Size(180, 22);
            this.menuDuzelt.Text = "Düzelt";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuSil
            // 
            this.menuSil.Image = global::YapilacaklarListesi.Properties.Resources.cross_24_128;
            this.menuSil.Name = "menuSil";
            this.menuSil.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.menuSil.Size = new System.Drawing.Size(180, 22);
            this.menuSil.Text = "Sil";
            // 
            // menuHakkinda
            // 
            this.menuHakkinda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUyHakkinda,
            this.menuYardim});
            this.menuHakkinda.Name = "menuHakkinda";
            this.menuHakkinda.Size = new System.Drawing.Size(69, 20);
            this.menuHakkinda.Text = "Hakkında";
            // 
            // menuUyHakkinda
            // 
            this.menuUyHakkinda.Name = "menuUyHakkinda";
            this.menuUyHakkinda.Size = new System.Drawing.Size(181, 22);
            this.menuUyHakkinda.Text = "Uygulama Hakkında";
            // 
            // menuYardim
            // 
            this.menuYardim.Name = "menuYardim";
            this.menuYardim.Size = new System.Drawing.Size(181, 22);
            this.menuYardim.Text = "Yardım";
            // 
            // btnSil
            // 
            this.btnSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSil.Image = global::YapilacaklarListesi.Properties.Resources.cross_24_128;
            this.btnSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(23, 22);
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chcbxYapListesi);
            this.splitContainer1.Panel1.Controls.Add(this.lblYapLis);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.grpBxYeGorev);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstbxTamamListesi);
            this.splitContainer1.Panel2.Controls.Add(this.lblTaLis);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(800, 401);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 2;
            // 
            // grpBxYeGorev
            // 
            this.grpBxYeGorev.Controls.Add(this.txtYapLis);
            this.grpBxYeGorev.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBxYeGorev.Location = new System.Drawing.Point(5, 5);
            this.grpBxYeGorev.Name = "grpBxYeGorev";
            this.grpBxYeGorev.Padding = new System.Windows.Forms.Padding(15);
            this.grpBxYeGorev.Size = new System.Drawing.Size(256, 100);
            this.grpBxYeGorev.TabIndex = 0;
            this.grpBxYeGorev.TabStop = false;
            this.grpBxYeGorev.Text = "Yeni Görev";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 10);
            this.panel1.TabIndex = 1;
            // 
            // lblYapLis
            // 
            this.lblYapLis.AutoSize = true;
            this.lblYapLis.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblYapLis.Location = new System.Drawing.Point(5, 115);
            this.lblYapLis.Name = "lblYapLis";
            this.lblYapLis.Padding = new System.Windows.Forms.Padding(5);
            this.lblYapLis.Size = new System.Drawing.Size(107, 23);
            this.lblYapLis.TabIndex = 2;
            this.lblYapLis.Text = "Yapılacaklar Listesi";
            // 
            // chcbxYapListesi
            // 
            this.chcbxYapListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chcbxYapListesi.FormattingEnabled = true;
            this.chcbxYapListesi.Location = new System.Drawing.Point(5, 138);
            this.chcbxYapListesi.Name = "chcbxYapListesi";
            this.chcbxYapListesi.Size = new System.Drawing.Size(256, 258);
            this.chcbxYapListesi.TabIndex = 3;
            this.chcbxYapListesi.SelectedIndexChanged += new System.EventHandler(this.chcbxYapListesi_SelectedIndexChanged);
            // 
            // lblTaLis
            // 
            this.lblTaLis.AutoSize = true;
            this.lblTaLis.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTaLis.Location = new System.Drawing.Point(5, 5);
            this.lblTaLis.Name = "lblTaLis";
            this.lblTaLis.Padding = new System.Windows.Forms.Padding(5);
            this.lblTaLis.Size = new System.Drawing.Size(121, 23);
            this.lblTaLis.TabIndex = 3;
            this.lblTaLis.Text = "Tamamlananlar Listesi";
            // 
            // lstbxTamamListesi
            // 
            this.lstbxTamamListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbxTamamListesi.FormattingEnabled = true;
            this.lstbxTamamListesi.Location = new System.Drawing.Point(5, 28);
            this.lstbxTamamListesi.Name = "lstbxTamamListesi";
            this.lstbxTamamListesi.Size = new System.Drawing.Size(520, 368);
            this.lstbxTamamListesi.TabIndex = 4;
            // 
            // txtYapLis
            // 
            this.txtYapLis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYapLis.Location = new System.Drawing.Point(15, 28);
            this.txtYapLis.Multiline = true;
            this.txtYapLis.Name = "txtYapLis";
            this.txtYapLis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtYapLis.Size = new System.Drawing.Size(226, 57);
            this.txtYapLis.TabIndex = 0;
            this.txtYapLis.Text = "svjasvkkbbvsdbvfdbvfdbv";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ToDo List";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpBxYeGorev.ResumeLayout(false);
            this.grpBxYeGorev.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnYeni;
        private System.Windows.Forms.ToolStripButton btnDuzelt;
        private System.Windows.Forms.ToolStripButton btnSil;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton btnKEs;
        private System.Windows.Forms.ToolStripButton btnKopyala;
        private System.Windows.Forms.ToolStripButton btnYapistir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnYardim;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuDosya;
        private System.Windows.Forms.ToolStripMenuItem menuCikis;
        private System.Windows.Forms.ToolStripMenuItem menuTodo;
        private System.Windows.Forms.ToolStripMenuItem menuYeni;
        private System.Windows.Forms.ToolStripMenuItem menuDuzelt;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuSil;
        private System.Windows.Forms.ToolStripMenuItem menuHakkinda;
        private System.Windows.Forms.ToolStripMenuItem menuUyHakkinda;
        private System.Windows.Forms.ToolStripMenuItem menuYardim;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckedListBox chcbxYapListesi;
        private System.Windows.Forms.Label lblYapLis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpBxYeGorev;
        private System.Windows.Forms.TextBox txtYapLis;
        private System.Windows.Forms.ListBox lstbxTamamListesi;
        private System.Windows.Forms.Label lblTaLis;
    }
}

