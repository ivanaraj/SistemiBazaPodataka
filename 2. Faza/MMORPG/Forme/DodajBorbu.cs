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
    public partial class DodajBorbu : Form
    {
        public DodajBorbu()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void DodajBorbu_Load(object sender, EventArgs e)
        {
            popuniPodacima();
            popuniComboboxPobednik();
        }

        public void popuniPodacima()
        {
            borbe.Items.Clear();

            List<BorbaPregled> pomLista = DTOManager.vratiSveBorbe();

            foreach (BorbaPregled i in pomLista)
            {
                ListViewItem item = new ListViewItem(new string[] { 
                    i.Id.ToString(), i.VremeBorbe.ToString(), i.Pobednik, i.BonusPoeni.ToString() });
                
                borbe.Items.Add(item);
            }

            borbe.Refresh();
        }

        public void popuniComboboxPobednik()
        {
            comboBoxPobednik.Items.Clear();

            List<TimPregled> pomLista = DTOManager.vratiSveTimove();

            foreach (TimPregled t in pomLista)
            {
                comboBoxPobednik.Items.Add(t.Naziv);
            }
        }


        public BorbaBasic NapuniBorbaIzForme()
        {
            BorbaBasic bb = new BorbaBasic();

            bb.VremeBorbe = DateTime.Parse(dateTimeVremeBorbe.Text);
            bb.BonusPoeni = (int)(numBonusP.Value);

            if(comboBoxPobednik.SelectedItem == null)
            {
                MessageBox.Show("Morate izabrati pobednika!");
                return null;
            }

            bb.Pobednik = comboBoxPobednik.SelectedItem.ToString();

            return bb;

        }

        private void btnDodajBorbu_Click(object sender, EventArgs e)
        {
            try
            {
                BorbaBasic novaBorba = NapuniBorbaIzForme();

                DTOManager.sacuvajBorbu(novaBorba);
                MessageBox.Show("Uspesno dodata borba!");

                popuniPodacima();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        
        private void btnObrisiBorbu_Click(object sender, EventArgs e)
        {
            ListViewItem item = borbe.SelectedItems[0];

            int idBorbe = Int32.Parse(item.SubItems[0].Text);

            var rezultat = MessageBox.Show("Da li ste sigurni da zelite da obrisete borbu?",
                "Brisanje borbe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rezultat == DialogResult.Yes)
            {
                DTOManager.obrisiBorbu(idBorbe);
                MessageBox.Show("Uspesno obrisana borba!");

                popuniPodacima();
            }
        }

        private void btnDetaljiOBorbi_Click(object sender, EventArgs e)
        {
            try
            {
                if (borbe.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Morate izabrati borbu cije detalje zelite da vidite!");
                    return;
                }

                int idBorbe = Int32.Parse(borbe.SelectedItems[0].SubItems[0].Text);
                BorbaBasic b = DTOManager.vratiBorbu(idBorbe);

                DodajUcestvovaoUBorbi forma = new DodajUcestvovaoUBorbi(b);
                forma.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }
    }
}
