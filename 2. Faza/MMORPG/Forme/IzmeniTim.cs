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
    public partial class IzmeniTim : Form
    {
        public TimBasic t;

        public IzmeniTim()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        public IzmeniTim(TimBasic tim)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);

            this.t = tim;
        }


        private void IzmeniTim_Load(object sender, EventArgs e)
        {

        }

        private void btnIzmeniTim_Click(object sender, EventArgs e)
        {
            try
            {
                DTOManager.azurirajTim(t.Naziv, (int)numMaxIgraca.Value, 
                    (int)numMinIgraca.Value, (int)numBonusP.Value);

                MessageBox.Show("Uspesno izmenjen tim!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
