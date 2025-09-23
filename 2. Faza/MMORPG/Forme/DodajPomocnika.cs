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
    public partial class DodajPomocnika : Form
    {
        public DodajPomocnika()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void DodajPomocnika_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            PopuniComboBoxIgraci();
            PopuniComboBoxRase();
            PopuniComboBoxKlase();
        }

        private void popuniPodacima()
        {
            pomocnici.Items.Clear();

            List<PomocnikPregled> pomLista = DTOManager.vratiSvePomocnike();

            foreach (PomocnikPregled p in pomLista)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    p.Id.ToString(), p.Igrac.Nadimak, p.Ime, p.BonusZastite.ToString() });

                pomocnici.Items.Add(item);
            }

            pomocnici.Refresh();
        }

        private void PopuniComboBoxRase()
        {
            comboBoxRasa.Items.Clear();

            List<RasaPregled> sveRase = DTOManager.vratiSveRase();

            foreach (RasaPregled r in sveRase)
            {
                comboBoxRasa.Items.Add(r.Naziv);
            }

        }

        private void PopuniComboBoxKlase()
        {
            comboBoxKlasa.Items.Clear();

            List<KlasaPregled> sveKlase = DTOManager.vratiSveKlase();

            foreach (KlasaPregled k in sveKlase)
            {
                comboBoxKlasa.Items.Add(k.Naziv);
            }

        }

        private void PopuniComboBoxIgraci()
        {
            comboBoxIgrac.Items.Clear();

            List<IgracPregled> sviIgraci = DTOManager.vratiSveIgrace();

            foreach (IgracPregled i in sviIgraci)
            {
                comboBoxIgrac.Items.Add(i.Id);
            }

        }

        private PomocnikBasic NapuniPomocnikIzForme()
        {
            PomocnikBasic pomocnikBasic = new PomocnikBasic();

            pomocnikBasic.Ime = textBoxIme.Text;
            pomocnikBasic.BonusZastite = (int)(numBonusZastite.Value);

            if(comboBoxIgrac.SelectedItem != null)
            {
                IgracBasic i = DTOManager.vratiIgraca(Int32.Parse(comboBoxIgrac.SelectedItem.ToString()));
                pomocnikBasic.Igrac = i;
            }
            else
            {
                MessageBox.Show("Morate izabrati igraca!");
                return null;
            }

            if (comboBoxRasa.SelectedItem != null)
            {
                RasaPregled r = DTOManager.vratiRasu(comboBoxRasa.SelectedItem.ToString());
                pomocnikBasic.NazivRase = r;
            }
            else
            {
                MessageBox.Show("Morate izabrati rasu!");
                return null;
            }

            if (comboBoxKlasa.SelectedItem != null)
            {
                KlasaPregled k = DTOManager.vratiKlasu(comboBoxKlasa.SelectedItem.ToString());
                pomocnikBasic.NazivKlase = k;
            }
            else
            {
                MessageBox.Show("Morate izabrati klasu!");
                return null;
            }

            return pomocnikBasic;
        }

        private void btnDodajPomocnika_Click(object sender, EventArgs e)
        {
            try
            {
                PomocnikBasic noviPomocnik = NapuniPomocnikIzForme();
                string nazivRase = comboBoxRasa.SelectedItem.ToString();
                string nazivKlase = comboBoxKlasa.SelectedItem.ToString();
                int idIgraca = Int32.Parse(comboBoxIgrac.SelectedItem.ToString());

                DTOManager.sacuvajPomocnika(noviPomocnik, idIgraca, nazivRase, nazivKlase);
                MessageBox.Show("Uspesno dodat pomocnik!");

                popuniPodacima();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnObrisiPomocnika_Click(object sender, EventArgs e)
        {
            ListViewItem item = pomocnici.SelectedItems[0];

            int idPomocnika = Int32.Parse(item.SubItems[0].Text);

            var rezultat = MessageBox.Show("Da li ste sigurni da zelite da obrisete pomocnika?", 
                "Pitanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rezultat == DialogResult.Yes)
            {
                DTOManager.obrisiPomocnika(idPomocnika);

                MessageBox.Show("Uspesno obrisan pomocnik!");

                popuniPodacima();

            }
        }
    }
}
