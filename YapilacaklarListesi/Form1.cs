using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YapilacaklarListesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<ToDoItem> Gorevlerim = new List<ToDoItem>();

        private void YapilacaklarListesiDoldur()
        {
            this.chcbxYapListesi.Items.Clear();
            foreach (ToDoItem gorev in Gorevlerim)
            {
                this.chcbxYapListesi.Items.Add(gorev);

            }
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            ToDoItem yeniGorev = new ToDoItem()
            {
                Id = Guid.NewGuid(),
                GorevMetni = txtYapLis.Text,
                Tamamlandi = false,

            };
            this.Gorevlerim.Add(yeniGorev);
            //this.chcbxYapListesi.Items.Add(yeniGorev);
            this.YapilacaklarListesiDoldur();



        }

        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            if (chcbxYapListesi.SelectedIndex==-1)
            {
                MessageBox.Show("Lütfen düzeltme işlemi için görev seçiniz.");
            }
            return;

            ToDoItem gorev = (ToDoItem)chcbxYapListesi.SelectedItem;
            gorev.GorevMetni = txtYapLis.Text;
             this.YapilacaklarListesiDoldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (chcbxYapListesi.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen silme işlemi için görev seçiniz.");
            }
                return;
            this.Gorevlerim.Remove((ToDoItem)chcbxYapListesi.SelectedItem);
            // chcbxYapListesi.Items.Remove(chcbxYapListesi.SelectedItem);
            this.YapilacaklarListesiDoldur();

        }

        private void chcbxYapListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chcbxYapListesi.SelectedIndex == -1)
                return;
             ToDoItem gorev=(ToDoItem) chcbxYapListesi.SelectedItem;
            txtYapLis.Text = gorev.GorevMetni;
        }

        private void btnKEs_Click(object sender, EventArgs e)
        {
            txtYapLis.Cut();
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            txtYapLis.Copy();
        }

        private void btnYapistir_Click(object sender, EventArgs e)
        {
            txtYapLis.Paste();
        }
    }
}
