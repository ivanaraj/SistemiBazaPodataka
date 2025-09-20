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
    public partial class DodajLika : Form
    {
        public DodajLika()
        {
            InitializeComponent();
        }

        private void DodajLika_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.LIK' table. You can move, or remove it, as needed.
            //this.lIKTableAdapter.Fill(this.dataSet1.LIK);
            using (var s = DataLayer.GetSession())
            {
                var likovi = s.Query<Lik>().ToList();
                dataGridView1.DataSource = likovi;
            }

        }

        //public void popuniPodacima()
        //{
        //    likovi.Items.Clear();
        //    List<LikPregled> pomLista = DTOManager.vratiLikove();
        //    foreach (LikPregled i in pomLista)
        //    {
        //        ListViewItem item = new ListViewItem(new string[] { i.ID.ToString(), i.NivoZdravstvenogStanja.ToString(), i.StepenZamora.ToString(), i.Iskustvo.ToString(), i.KolicinaZlata.ToString(), i.UmesnostSkrivanja, i.FCovek.ToString(), i.FPatuljak.ToString(), i.FOrk.ToString(), i.FDemon.ToString(), i.FVilenjak.ToString(), i.TipOruzja, i.EnergijaZaMagiju });
        //        likovi.Items.Add(item);
        //    }

        //    likovi.Refresh();
        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
