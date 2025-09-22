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
    public partial class IzmeniIgraca : Form
    {
        public IgracBasic i;

        public IzmeniIgraca()
        {
            InitializeComponent();

            ThemeManager.ApplyTheme(this);
        }

        public IzmeniIgraca(IgracBasic igrac)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.i = igrac;
        }

        private void IzmeniIgraca_Load(object sender, EventArgs e)
        {
            popuniComboboxLik();
            popuniComboboxTim();
        }

        private void btnIzmeniIgraca_Click(object sender, EventArgs e)
        {
            try
            {
                // dodao sam samo da prima string nadimak i tjt
                //IgracBasic noviIgrac = NapuniIgracIzForme();
                char pol = (radioButtonM.Checked ? 'M' : 'Z');
                string nazivTima = comboBoxTim.SelectedItem.ToString();
                int idLika = int.Parse(comboBoxLik.SelectedItem.ToString());
                DTOManager.azurirajIgraca(
                    idLika, i.Id, nazivTima,
                    textBoxIme.Text, textBoxPrezime.Text, textBoxLozinka.Text, textBoxNadimak.Text,
                    pol,
                    (int)numUzrast.Value
                );

                MessageBox.Show("Uspesno izmenjen igrac!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public IgracBasic NapuniIgracIzForme()
        {
            IgracBasic igrac = this.i;

            igrac.Nadimak = textBoxNadimak.Text;
            igrac.Lozinka = textBoxLozinka.Text;
            igrac.Ime = textBoxIme.Text;
            igrac.Prezime = textBoxPrezime.Text;

            if (radioButtonM.Checked)
            {
                igrac.Pol = 'M';
            }
            else if (radioButtonZ.Checked)
            {
                igrac.Pol = 'Z';
            }

            igrac.Uzrast = (int)numUzrast.Value;

            return igrac;

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

        public void popuniComboboxLik()
        {
            comboBoxLik.Items.Clear();

            List<LikPregled> pomLista = DTOManager.vratiSveLikove();

            foreach (LikPregled l in pomLista)
            {
                comboBoxLik.Items.Add(l.ID);
            }
        }
    }
}
