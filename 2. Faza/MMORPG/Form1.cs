using MMORPG.Entities;
using MMORPG.Mapiranje;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMORPG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdUcitavanjeIgraca_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o igracu za zadatim brojem
                MMORPG.Entities.Igrac i = s.Load<MMORPG.Entities.Igrac>(100000);

                MessageBox.Show(i.Nadimak);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodavanjeIgraca_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                //Kreira se novi igrac
                MMORPG.Entities.Igrac i = new MMORPG.Entities.Igrac();
                i.Nadimak = "mixa";
                i.Lozinka = "mixaaa";
                i.Ime = "Mihajlo";
                i.Prezime = "Ljubisavljevic";
                i.Pol = 'M';
                i.Uzrast = 22;
                //Dodaje se u bazu
                s.Save(i);

                s.Flush();
                MessageBox.Show("Dodat igrac sa ID-jem: " + i.Id);
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdManyToOne_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o igracu za zadatim brojem
                MMORPG.Entities.Lik l = s.Load<MMORPG.Entities.Lik>(100001);
                MessageBox.Show(l.Rasa.Naziv);
                MessageBox.Show(l.Klasa.Naziv);
                MessageBox.Show(l.Igrac.Nadimak);  

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdOneToMany_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o igracu za zadatim brojem
                MMORPG.Entities.Igrac i = s.Load<MMORPG.Entities.Igrac>(100002);
                MessageBox.Show(i.Nadimak);

                //Pristupa se njegovim porukama
                foreach (Pomocnik p in i.Pomocnici)
                {
                    MessageBox.Show(p.Ime + " " + p.NazivRase.Naziv + " " + p.NazivKlase.Naziv);
                }
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodavanjeTima_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Kreira se novi tim
                MMORPG.Entities.Tim t = new MMORPG.Entities.Tim()
                {
                    Naziv = "Heroji",
                    MaxIgraca = 5,
                    MinIgraca = 2,
                    BonusPoeni = 10
                };

                MMORPG.Entities.Igrac i1 = new MMORPG.Entities.Igrac()
                {
                    Nadimak = "jeka",
                    Lozinka = "jeka2003",
                    Ime = "Jelena",
                    Prezime = "Djoric",
                    Pol = 'Z',
                    Uzrast = 27
                };

                MMORPG.Entities.Igrac i2 = new MMORPG.Entities.Igrac()
                {
                    Nadimak = "ina",
                    Lozinka = "ina1307",
                    Ime = "Irina",
                    Prezime = "Popovic",
                    Pol = 'Z',
                    Uzrast = 25
                };

                //Dodaje se u bazu
                s.Save(t);

                i1.Tim = t;
                s.Save(i1);

                i2.Tim = t;
                s.Save(i2);

                t.Igraci.Add(i1);
                t.Igraci.Add(i2);

                s.Save(t);

                s.Flush();
                MessageBox.Show("Dodat tim sa nazivom: " + t.Naziv);
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdDodavanjeTimaNaStazi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Tim t = s.Load<Tim>("Heroji");
                Entities.Staza staza = s.Load<Entities.Staza>("Mocvara");

                staza.Timovi.Add(t);

                s.Save(staza);

                s.Flush();
                MessageBox.Show("Dodat tim " + t.Naziv + " na stazu: " + staza.Naziv);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdUcitavanjeIgracaNaStazi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MMORPG.Entities.Igrac i = s.Load<MMORPG.Entities.Igrac>(100001);

                MessageBox.Show(i.Nadimak);

                foreach (MMORPG.Entities.Igrao igrao in i.IgraoStaze)
                {
                    MessageBox.Show("Igrao na stazi: " + igrao.Staza.Naziv + "\nBroj igranja: "
                        + igrao.BrojIgranja + "\nBroj savladanih neprijatelja: " + 
                        igrao.BrojSavladanihNeprijatelja);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
