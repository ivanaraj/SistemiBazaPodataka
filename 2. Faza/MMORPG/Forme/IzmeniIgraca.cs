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
        public string nazivTima;

        public IzmeniIgraca()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        public IzmeniIgraca(IgracBasic igrac, string tim)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);

            this.i = igrac;
            this.nazivTima = tim;
        }

        private void IzmeniIgraca_Load(object sender, EventArgs e)
        {
            popuniComboboxTim();
        }

        private void btnIzmeniIgraca_Click(object sender, EventArgs e)
        {
            try
            {
                char pol = (radioButtonM.Checked ? 'M' : 'Z');
                string nTima = comboBoxTim.SelectedItem.ToString();
                DTOManager.azurirajIgraca( i.Id, nTima,
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


        public void popuniComboboxTim()
        {
            comboBoxTim.Items.Clear();

            List<TimPregled> pomLista = DTOManager.vratiSveTimove();

            foreach (TimPregled t in pomLista)
            {
                comboBoxTim.Items.Add(t.Naziv);
            }

            if (!string.IsNullOrEmpty(this.nazivTima))
            {
                comboBoxTim.SelectedItem = this.nazivTima;
            }
        }

    }
}
