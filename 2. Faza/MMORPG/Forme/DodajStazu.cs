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
    public partial class DodajStazu : Form
    {
        public DodajStazu()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void DodajStazu_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            staze.Items.Clear();

            List<StazaPregled> pomLista = DTOManager.vratiSveStaze();

            foreach (StazaPregled sp in pomLista)
            {
                ListViewItem item = new ListViewItem(new string[] { 
                    sp.Naziv.ToString(), sp.TipStaze ?  "Timska" : "Solo",
                    sp.BonusPoeni.ToString() });

                staze.Items.Add(item);
            }

            staze.Refresh();
        }

        private StazaBasic NapuniStazaIzForme()
        {
            StazaBasic staza = new StazaBasic();

            staza.Naziv = textBoxNaziv.Text;
            if (radioButtonSolo.Checked)
            {
                staza.TipStaze = false;
            }
            else if (radioButtonTimska.Checked)
            {
                staza.TipStaze = true;
            }
            else
            {
                MessageBox.Show("Morate izabrati tip staze!");
                return null;
            }

            staza.BonusPoeni = (int)numBonusPoeni.Value;

            return staza;
        }

        private void btnDodajStazu_Click(object sender, EventArgs e)
        {
            try
            {
                StazaBasic novaStaza = NapuniStazaIzForme();

                if(novaStaza == null)
                {
                    MessageBox.Show("Greška pri unosu podataka o stazi!");
                    return;
                }

                DTOManager.sacuvajStazu(novaStaza);
                MessageBox.Show("Uspešno dodata staza!");

                popuniPodacima();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnObrisiStazu_Click(object sender, EventArgs e)
        {
            ListViewItem item = staze.SelectedItems[0];

            string naziv = item.SubItems[0].Text;

            var rezultat = MessageBox.Show("Da li ste sigurni da želite da obrišete stazu " + naziv + "?",
                "Brisanje staze", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rezultat == DialogResult.Yes)
            {
                DTOManager.obrisiStazu(naziv);
                MessageBox.Show("Uspešno obrisana staza!");

                popuniPodacima();
            }
        }
    }
}
