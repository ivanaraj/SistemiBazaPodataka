using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMORPG.Forme
{
    public partial class DodajTim : Form
    {
        public DodajTim()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void DodajTim_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            timovi.Items.Clear();

            List<TimPregled> pomLista = DTOManager.vratiSveTimove();

            foreach (TimPregled i in pomLista)
            {
                ListViewItem item = new ListViewItem(new string[] { 
                    i.Naziv, i.BonusPoeni.ToString() });

                timovi.Items.Add(item);
            }

            timovi.Refresh();
        }

        public TimBasic NapuniTimIzForme()
        {
            TimBasic t = new TimBasic();

            t.Naziv = textBoxNaziv.Text;
            t.MaxIgraca = (int)(numMaxIgraca.Value);
            t.MinIgraca = (int)(numMinIgraca.Value);
            t.BonusPoeni = (int)(numBonusP.Value);

            return t;
        }

        private void btnDodajTim_Click(object sender, EventArgs e)
        {
            try
            {
                TimBasic noviTim = NapuniTimIzForme();

                DTOManager.sacuvajTim(noviTim);

                MessageBox.Show("Uspesno dodat tim!");

                popuniPodacima();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIzmeniTim_Click(object sender, EventArgs e)
        {
            try
            {
                if (timovi.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Morate izabrati tim koji zelite da izmenite!");
                    return;
                }

                string naziv = timovi.SelectedItems[0].SubItems[0].Text;
                TimBasic tb = DTOManager.vratiTim(naziv);

                IzmeniTim forma = new IzmeniTim(tb);
                forma.ShowDialog();

                popuniPodacima();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnObrisiTim_Click(object sender, EventArgs e)
        {
            ListViewItem item = timovi.SelectedItems[0];

            string naziv = item.SubItems[0].Text;

            var result = MessageBox.Show("Da li ste sigurni da zelite da obrisete tim?",
                "Brisanje tima", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                DTOManager.obrisiTim(naziv);
                MessageBox.Show("Uspesno obrisan tim!");
                popuniPodacima();
            }

        }

        private void btnDodajBorbu_Click(object sender, EventArgs e)
        {
            DodajBorbu forma = new DodajBorbu();
            forma.ShowDialog();
        }
    }
}
