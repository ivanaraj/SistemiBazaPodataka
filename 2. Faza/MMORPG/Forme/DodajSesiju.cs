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
    public partial class DodajSesiju : Form
    {
        public DodajSesiju()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void DodajSesiju_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            PopuniComboBoxIgraci();
        }

        private void popuniPodacima()
        {
            sesije.Items.Clear();

            List<SesijaPregled> pomLista = DTOManager.vratiSveSesije();

            foreach (SesijaPregled sp in pomLista)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    sp.Id.ToString(), sp.VremePocetka.ToString(),
                    sp.VremeTrajanja.ToString(), sp.Igrac.Nadimak.ToString() });

                sesije.Items.Add(item);
            }

            sesije.Refresh();
        }

        private void PopuniComboBoxIgraci()
        {
            comboBoxIgrac.Items.Clear();

            List<IgracPregled> sviIgraci = DTOManager.vratiSveIgrace();

            foreach (IgracPregled i in sviIgraci)
            {
                comboBoxIgrac.Items.Add(i.Nadimak);
            }

        }

        private SesijaBasic NapuniSesijaIzForme()
        {
            SesijaBasic sesija = new SesijaBasic();

            sesija.XpPoeni = (int)numXpPoeni.Value;
            sesija.KolicinaZlata = (int)numKolicinaZlata.Value;
            sesija.VremePocetka = (DateTime)dateTimeVremePocetka.Value;
            sesija.VremeTrajanja = (double)numVremeTrajanja.Value;

            if(comboBoxIgrac.SelectedItem != null)
            {
                IgracBasic i = DTOManager.vratiIgraca(Int32.Parse(comboBoxIgrac.SelectedItem.ToString()));
                sesija.Igrac = i;
            }
            else
            {
                MessageBox.Show("Niste izabrali igraca!");
                return null;
            }

            return sesija;
        }

        private void btnDodajSesiju_Click(object sender, EventArgs e)
        {
            try
            {
                SesijaBasic novaSesija = NapuniSesijaIzForme();

                int idIgraca = Int32.Parse(comboBoxIgrac.SelectedItem.ToString());

                DTOManager.sacuvajSesiju(novaSesija, idIgraca);
                MessageBox.Show("Uspesno dodata sesija!");

                popuniPodacima();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnObrisiSesiju_Click(object sender, EventArgs e)
        {
            ListViewItem item = sesije.SelectedItems[0];

            int idSesije = Int32.Parse(item.SubItems[0].Text);

            var rezultat = MessageBox.Show("Da li ste sigurni da zelite da obrisete sesiju?", 
                "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rezultat == DialogResult.Yes)
            {
                DTOManager.obrisiSesiju(idSesije);

                MessageBox.Show("Uspesno obrisana sesija!");

                popuniPodacima();
            }
        }
    }
}
