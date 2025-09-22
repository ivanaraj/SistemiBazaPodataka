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

        private Size originalSize;
        private Dictionary<Control, Rectangle> controlsOriginalRects = new Dictionary<Control, Rectangle>();


        public DodajLika()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);

            this.Load += DodajLika_Load;
            this.Resize += DodajLika_Resize;
        }


        private void DodajLika_Resize(object sender, EventArgs e)
        {
            float xRatio = (float)this.Width / originalSize.Width;
            float yRatio = (float)this.Height / originalSize.Height;

            foreach (Control ctrl in this.Controls)
            {
                Rectangle originalRect = controlsOriginalRects[ctrl];
                ctrl.Width = (int)(originalRect.Width * xRatio);
                ctrl.Height = (int)(originalRect.Height * yRatio);
                ctrl.Left = (int)(originalRect.Left * xRatio);
                ctrl.Top = (int)(originalRect.Top * yRatio);
            }
        }


        private void DodajLika_Load(object sender, EventArgs e)
        {
            originalSize = this.Size;
            foreach (Control ctrl in this.Controls)
                controlsOriginalRects[ctrl] = new Rectangle(ctrl.Location, ctrl.Size);



            groupBoxBorac.Enabled = false;
            groupBoxLopov.Enabled = false;
            groupBoxOklopnik.Enabled = false;
            groupBoxStrelac.Enabled = false;
            groupBoxCarobnjak.Enabled = false;
            groupBoxSvestenik.Enabled = false;
            groupBoxStit.Enabled = false;

            textBoxTipOruzja.Enabled = false;
            radioButtonUUSDa.Enabled = false;
            radioButtonUUSNe.Enabled = false;
            numNivoEnergije.Enabled = false;

            popuniPodacima();
            PopuniComboBoxRase();
            PopuniComboBoxKlase();
            PopuniComboBoxIgraci();
            popuniMagije();
            popuniBlagoslove();

        }

        public void popuniPodacima()
        {
            likovi.Items.Clear();

            List<LikPregled> pomLista = DTOManager.vratiSveLikove();

            foreach (LikPregled i in pomLista)
            {
                ListViewItem item = new ListViewItem(new string[] { i.ID.ToString(), i.StepenZamora.ToString(), i.Iskustvo.ToString(),
                    i.KolicinaZlata.ToString(), i.NivoZdravstvenogStanja.ToString(), i.Rasa.Naziv.ToString(), i.Klasa.Naziv.ToString() });

                likovi.Items.Add(item);
            }

            likovi.Refresh();
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
                comboBoxIgrac.Items.Add(i.Nadimak);
            }

        }

        public LikBasic NapuniLikIzForme()
        {
            LikBasic lik = new LikBasic();

            lik.StepenZamora = (int)numStepenZamora.Value;
            lik.Iskustvo = (int)numIskustvo.Value;
            lik.KolicinaZlata = (int)numKolicinaZlata.Value;
            lik.NivoZdravstvenogStanja = (int)numNivoZS.Value;

            if (comboBoxRasa.SelectedItem != null)
            {
                RasaPregled r = DTOManager.vratiRasu(comboBoxRasa.SelectedItem.ToString());

                if( r.Naziv.ToLower() == "patuljak" || r.Naziv.ToLower() == "ork")
                {
                    textBoxTipOruzja.Enabled = true;
                    r.TipOruzja = textBoxTipOruzja.Text;
                    r.UmesnostUSkrivanju = null;
                    r.NivoEnergije = null;
                }
                else if( r.Naziv.ToLower() == "vilenjak" || r.Naziv.ToLower() == "demon")
                {
                    numNivoEnergije.Enabled = true;
                    r.NivoEnergije = (int)numNivoEnergije.Value;
                    r.TipOruzja = null;
                    r.UmesnostUSkrivanju = null;
                }
                else if (r.Naziv.ToLower() == "covek")
                {
                    radioButtonUUSDa.Enabled = true;
                    radioButtonUUSNe.Enabled = true;

                    if (radioButtonUUSDa.Checked)
                    {
                        r.UmesnostUSkrivanju = true;
                    }
                    else if(radioButtonUUSNe.Checked)
                    {
                        r.UmesnostUSkrivanju = false;
                    }
                    else
                    {
                        MessageBox.Show("Morate da unesete da li covek ume da se krije!");
                    }

                    r.TipOruzja = null;
                    r.NivoEnergije = null;
                }
                else
                {
                    MessageBox.Show("Nepoznata rasa!");
                }

                    lik.Rasa = new RasaPregled(r.Naziv, r.TipOruzja, r.UmesnostUSkrivanju, r.NivoEnergije);
            }
            else
            {
                MessageBox.Show("Morate izabrati rasu!");
                return null;
            }


            if (comboBoxKlasa.SelectedItem != null)
            {
                KlasaPregled k = DTOManager.vratiKlasu(comboBoxKlasa.SelectedItem.ToString());

              
                if (k.Naziv.ToLower() == "lopov")
                {
                    k.NivoBuke = (int)numNivoBuke.Value;
                    k.MaxNivoZamki = (int)numMaxNivoZamki.Value;
                    k.Stit = null;
                    k.OruzjeUObeRuke = null;
                    k.Religija = null;
                    k.Lecenje = null;
                    k.MaxTezinaOklopa = null;
                    k.LukSamostrel = null;
                }
                else if (k.Naziv.ToLower() == "borac")
                {
                    if (radioButtonStitDa.Checked)
                    {
                        k.Stit = true;
                    }
                    else if (radioButtonStitNe.Checked)
                    {
                        k.Stit = false;
                    }
                    else
                    {
                        MessageBox.Show("Morate da unesete da li borac koristi stit!");
                    }

                    if (radioButtonOUORDa.Checked)
                    {
                        k.OruzjeUObeRuke = true;
                    }
                    else if (radioButtonOUORNe.Checked)
                    {
                        k.OruzjeUObeRuke = false;
                    }
                    else
                    {
                        MessageBox.Show("Morate da unesete da li borac koristi oruzje u obe ruke!");
                    }

                    k.NivoBuke = null;
                    k.MaxNivoZamki = null;
                    k.Religija = null;
                    k.Lecenje = null;
                    k.MaxTezinaOklopa = null;
                    k.LukSamostrel = null;

                }
                else if( k.Naziv.ToLower() == "oklopnik")
                {
                    k.MaxTezinaOklopa = (int)numMaxTezinaOklopa.Value;

                    k.NivoBuke = null;
                    k.MaxNivoZamki = null;
                    k.Stit = null;
                    k.OruzjeUObeRuke = null;
                    k.Religija = null;
                    k.Lecenje = null;
                    k.LukSamostrel = null;
                }
                else if(k.Naziv.ToLower() == "strelac")
                {
                    if (radioButtonLuk.Checked)
                    {
                        k.LukSamostrel = false;
                    }
                    else if(radioButtonSamostrel.Checked)
                    {
                        k.LukSamostrel = true;
                    }
                    else
                    {
                        MessageBox.Show("Morate da unesete da li strelac koristi luk ili samostrel!");
                    }

                    k.MaxTezinaOklopa = null;
                    k.NivoBuke = null;
                    k.MaxNivoZamki = null;
                    k.Stit = null;
                    k.OruzjeUObeRuke = null;
                    k.Religija = null;
                    k.Lecenje = null;

                }
                else if( k.Naziv.ToLower() == "carobnjak")
                {
                    k.MaxTezinaOklopa = null;
                    k.NivoBuke = null;
                    k.MaxNivoZamki = null;
                    k.Stit = null;
                    k.OruzjeUObeRuke = null;
                    k.Religija = null;
                    k.Lecenje = null;
                    k.LukSamostrel = null;
                }
                else if( k.Naziv.ToLower() == "svestenik")
                {                    
                    k.Religija = textBoxReligija.Text;

                    if(radioButtonLecenjeDa.Checked)
                    {
                        k.Lecenje = true;
                    }
                    else if(radioButtonLecenjeNe.Checked)
                    {
                        k.Lecenje = false;
                    }
                    else
                    {
                        MessageBox.Show("Morate da unesete da li svestenik zna da leci!");
                    }

                    k.MaxTezinaOklopa = null;
                    k.NivoBuke = null;
                    k.MaxNivoZamki = null;
                    k.Stit = null;
                    k.OruzjeUObeRuke = null;
                    k.LukSamostrel = null;
                }


                lik.Klasa = new KlasaPregled(k.Naziv, k.NivoBuke, k.MaxNivoZamki, k.Stit, k.OruzjeUObeRuke, k.Religija, k.Lecenje, k.MaxTezinaOklopa, k.LukSamostrel);
            }
            else
            {
                MessageBox.Show("Morate izabrati klasu!");
                return null;
            }

            if (comboBoxIgrac.SelectedItem != null)
            {
                IgracBasic i = DTOManager.vratiIgraca(Int32.Parse(comboBoxIgrac.SelectedItem.ToString()));
                lik.Igrac = new IgracBasic(i.Id, i.Ime, i.Prezime, i.Nadimak, i.Lozinka, i.Pol, i.Uzrast, i.Tim);
            }
            else
            {
                MessageBox.Show("Morate izabrati igraca!");
                return null;
            }

            return lik;
        }


        private void popuniMagije()
        {
            checkedListBoxMagije.Items.Clear();

            foreach (var m in DTOManager.vratiSveMagije())
                checkedListBoxMagije.Items.Add(m);

        }

        private void popuniBlagoslove()
        {
            checkedListBoxBlagoslovi.Items.Clear();

            foreach (var b in DTOManager.vratiSveBlagoslove())
                checkedListBoxBlagoslovi.Items.Add(b);
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnDodajLika_Click(object sender, EventArgs e)
        {
            try
            {
                LikBasic noviLik = NapuniLikIzForme();
                string nazivRase = comboBoxRasa.SelectedItem.ToString();
                string nazivKlase = comboBoxKlasa.SelectedItem.ToString();
                int idIgraca = Int32.Parse(comboBoxIgrac.SelectedItem.ToString());
                DTOManager.sacuvajLika(noviLik, nazivRase, nazivKlase, idIgraca);
                MessageBox.Show("Lik je uspesno sacuvan!");

                popuniPodacima();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void comboBoxKlasa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxKlasa.SelectedItem.ToString() == "Lopov")
            {
                groupBoxLopov.Enabled = true;
                groupBoxBorac.Enabled = false;
                groupBoxOklopnik.Enabled = false;
                groupBoxStrelac.Enabled = false;
                groupBoxCarobnjak.Enabled = false;
                groupBoxSvestenik.Enabled = false;
                groupBoxStit.Enabled = false;
            }
            else if (comboBoxKlasa.SelectedItem.ToString() == "Borac")
            {
                groupBoxBorac.Enabled = true;
                groupBoxStit.Enabled = true;
                groupBoxLopov.Enabled = false;
                groupBoxOklopnik.Enabled = false;
                groupBoxStrelac.Enabled = false;
                groupBoxCarobnjak.Enabled = false;
                groupBoxSvestenik.Enabled = false;
            }
            else if (comboBoxKlasa.SelectedItem.ToString() == "Oklopnik")
            {
                groupBoxOklopnik.Enabled = true;
                groupBoxBorac.Enabled = false;
                groupBoxLopov.Enabled = false;
                groupBoxStrelac.Enabled = false;
                groupBoxCarobnjak.Enabled = false;
                groupBoxSvestenik.Enabled = false;
                groupBoxStit.Enabled = false;
            }
            else if (comboBoxKlasa.SelectedItem.ToString() == "Strelac")
            {
                groupBoxStrelac.Enabled = true;
                groupBoxBorac.Enabled = false;
                groupBoxLopov.Enabled = false;
                groupBoxOklopnik.Enabled = false;
                groupBoxCarobnjak.Enabled = false;
                groupBoxSvestenik.Enabled = false;
                groupBoxStit.Enabled = false;
            }
            else if (comboBoxKlasa.SelectedItem.ToString() == "Carobnjak")
            {
                groupBoxCarobnjak.Enabled = true;
                groupBoxBorac.Enabled = false;
                groupBoxLopov.Enabled = false;
                groupBoxOklopnik.Enabled = false;
                groupBoxStrelac.Enabled = false;
                groupBoxSvestenik.Enabled = false;
                groupBoxStit.Enabled = false;

            }
            else if (comboBoxKlasa.SelectedItem.ToString() == "Svestenik")
            {
                groupBoxSvestenik.Enabled = true;
                groupBoxBorac.Enabled = false;
                groupBoxLopov.Enabled = false;
                groupBoxOklopnik.Enabled = false;
                groupBoxStrelac.Enabled = false;
                groupBoxCarobnjak.Enabled = false;
                groupBoxStit.Enabled = false;
            }
        }

        private void comboBoxRasa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRasa.SelectedItem.ToString() == "Patuljak" || comboBoxRasa.SelectedItem.ToString() == "Ork")
            {
                textBoxTipOruzja.Enabled = true;
                numNivoEnergije.Enabled = false;
                radioButtonUUSDa.Enabled = false;
                radioButtonUUSNe.Enabled = false;
            }
            else if (comboBoxRasa.SelectedItem.ToString() == "Vilenjak" || comboBoxRasa.SelectedItem.ToString() == "Demon")
            {
                textBoxTipOruzja.Enabled = false;
                numNivoEnergije.Enabled = true;
                radioButtonUUSDa.Enabled = false;
                radioButtonUUSNe.Enabled = false;
            }
            else if (comboBoxRasa.SelectedItem.ToString() == "Covek")
            {
                textBoxTipOruzja.Enabled = false;
                numNivoEnergije.Enabled = false;
                radioButtonUUSDa.Enabled = true;
                radioButtonUUSNe.Enabled = true;
            }
            else
            {
                MessageBox.Show("Nepoznata rasa!");
            }
        }

        private void btnObrisiLika_Click(object sender, EventArgs e)
        {
            ListViewItem item = likovi.SelectedItems[0];

            int idLika = int.Parse(item.SubItems[0].Text);

            var result = MessageBox.Show("Da li ste sigurni da želite da obrišete lika?",
                                         "Potvrda",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DTOManager.obrisiLika(idLika);

                popuniPodacima();
            }
        }

        private void likovi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
