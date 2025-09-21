using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MMORPG.Forme;

namespace MMORPG
{
    public partial class PocetnaStrana : Form
    {
        public PocetnaStrana()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void btnIgraci_Click(object sender, EventArgs e)
        {
            DodajIgraca forma = new DodajIgraca();
            forma.ShowDialog();
        }
    }
}
