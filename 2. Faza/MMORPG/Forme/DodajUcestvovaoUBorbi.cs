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
    public partial class DodajUcestvovaoUBorbi : Form
    {
        public BorbaBasic b;

        public DodajUcestvovaoUBorbi()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        public DodajUcestvovaoUBorbi(BorbaBasic borba)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.b = borba;
        }

        private void DodajUcestvovaoUBorbi_Load(object sender, EventArgs e)
        {

        }
    }
}
