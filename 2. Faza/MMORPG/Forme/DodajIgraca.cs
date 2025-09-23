using MMORPG.Entities;
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
    public partial class DodajIgraca : Form
    {
        public DodajIgraca()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void igraci_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DodajIgraca_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            popuniComboboxTim();
        }

        public void popuniPodacima()
        {
            igraci.Items.Clear();

            List<IgracPregled> pomLista = DTOManager.vratiSveIgrace();

            foreach (IgracPregled i in pomLista)
            {
                ListViewItem item = new ListViewItem(new string[] { i.Id.ToString(), i.Nadimak, i.Ime, i.Prezime, i.Uzrast.ToString() });

                igraci.Items.Add(item);
            }

            igraci.Refresh();
        }

        public void popuniComboboxTim()
        {
            comboBoxTim.Items.Clear();

            List<TimPregled> pomLista = DTOManager.vratiSveTimove();

            foreach (TimPregled t in pomLista)
            {
                comboBoxTim.Items.Add(t.Naziv);
            }
        }

           
    
        public IgracBasic NapuniIgracIzForme()
        {
            IgracBasic igrac = new IgracBasic();

            igrac.Nadimak = textBoxNadimak.Text;
            igrac.Lozinka = textBoxLozinka.Text;
            igrac.Ime = textBoxIme.Text;
            igrac.Prezime = textBoxPrezime.Text;
            
            if( radioButtonM.Checked)
            {
                igrac.Pol = 'M';
            }
            else if( radioButtonZ.Checked)
            {
                igrac.Pol = 'Z';
            }
            else
            {
                MessageBox.Show("Morate izabrati pol!");
            }

            igrac.Uzrast = (int)numUzrast.Value;

            return igrac;

        }

        private void btnDodajIgraca_Click(object sender, EventArgs e)
        {
            try
            {
                IgracBasic noviIgrac = NapuniIgracIzForme();
                string nazivTima = comboBoxTim.SelectedItem.ToString();
                DTOManager.sacuvajIgraca(noviIgrac, nazivTima);

                MessageBox.Show("Uspesno dodat igrac!");

                popuniPodacima();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIzmeniIgraca_Click(object sender, EventArgs e)
        {
            try
            {
                if (igraci.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Morate izabrati igraca kog zelite da izmenite!");
                    return;
                }

                int idIgraca = Int32.Parse(igraci.SelectedItems[0].SubItems[0].Text);
                IgracBasic ib = DTOManager.vratiIgraca(idIgraca);
                string nazivTima = ib.Tim.Naziv;

                IzmeniIgraca forma = new IzmeniIgraca(ib, nazivTima);
                forma.ShowDialog();

                popuniPodacima();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnObrisiIgraca_Click(object sender, EventArgs e)
        {
            ListViewItem item = igraci.SelectedItems[0];

            int idIgraca = Int32.Parse(item.SubItems[0].Text);

            var result = MessageBox.Show("Da li ste sigurni da želite da obrišete igraca?",
                                         "Potvrda",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DTOManager.obrisiIgraca(idIgraca);

                popuniPodacima();
            }
        }

        private void btnDodajLika_Click(object sender, EventArgs e)
        {
            DodajLika forma = new DodajLika();
            forma.ShowDialog();
        }

        private void btnDodajTim_Click(object sender, EventArgs e)
        {
            DodajTim forma = new DodajTim();
            forma.ShowDialog();
        }

        private void btnDodajPomocnika_Click(object sender, EventArgs e)
        {
            DodajPomocnika forma = new DodajPomocnika();
            forma.ShowDialog();
        }

        private void brnDodajSesiju_Click(object sender, EventArgs e)
        {
            DodajSesiju forma = new DodajSesiju();
            forma.ShowDialog();
        }
    }
}
