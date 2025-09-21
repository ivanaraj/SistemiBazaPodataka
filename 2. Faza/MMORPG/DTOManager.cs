using FluentNHibernate.Utils;
using MMORPG.Entities;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMORPG
{
    public class DTOManager
    {

        #region Igrac

        public static List<IgracPregled> vratiSveIgrace()
        {
            List<IgracPregled> igraci = new List<IgracPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Igrac> sviIgraci = from o in s.Query<Igrac>()
                                            select o;

                foreach (Igrac i in sviIgraci)
                {
                    igraci.Add(new IgracPregled(i.Id, i.Nadimak, i.Ime, i.Prezime, i.Uzrast));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return igraci;
        }

        public static IgracBasic vratiIgraca(int id)
        {
            IgracBasic igrac = new IgracBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                MMORPG.Entities.Igrac o = s.Load<MMORPG.Entities.Igrac>(id);
                igrac = new IgracBasic(o.Id, o.Nadimak, o.Lozinka, o.Ime, o.Prezime, 
                    o.Pol, o.Uzrast, o.Tim, o.Lik);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return igrac;
        }
        public static IgracBasic azurirajIgraca(IgracBasic p, string nazivTima, int idLika)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MMORPG.Entities.Igrac o = s.Load<MMORPG.Entities.Igrac>(p.Id);

                Tim t1 = s.Load<MMORPG.Entities.Tim>(nazivTima);
                Lik l1 = s.Load<MMORPG.Entities.Lik>(idLika);

                o.Ime = p.Ime;
                o.Prezime = p.Prezime;
                o.Lozinka = p.Lozinka;
                o.Nadimak = p.Nadimak;
                o.Pol = p.Pol;
                o.Uzrast = p.Uzrast;
                o.Tim = t1;
                o.Lik = l1;

                s.Update(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return p;
        }

        public static void sacuvajIgraca(IgracBasic igrac, string nazivTima, int idLika)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MMORPG.Entities.Igrac i = new MMORPG.Entities.Igrac();

                Tim t1 = s.Load<MMORPG.Entities.Tim>(nazivTima);
                Lik l1 = s.Load<MMORPG.Entities.Lik>(idLika);

                i.Ime = igrac.Ime;
                i.Prezime = igrac.Prezime;
                i.Nadimak = igrac.Nadimak;
                i.Pol = igrac.Pol;
                i.Uzrast = igrac.Uzrast;
                i.Lozinka = igrac.Lozinka;
                i.Tim = t1;
                i.Lik = l1;


                s.Save(i);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void obrisiIgraca(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Igrac igrac = s.Load<Igrac>(id);

                s.Delete(igrac);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }


        }

        #endregion

        #region Tim
        public static List<TimPregled> vratiSveTimove()
        {
            List<TimPregled> timovi = new List<TimPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Tim> sviTimovi = from o in s.Query<Tim>()
                                          select o;

                foreach (Tim t in sviTimovi)
                {
                    timovi.Add(new TimPregled(t.Naziv, t.MaxIgraca, t.MinIgraca, t.BonusPoeni));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return timovi;
        }

        public static TimPregled vratiTim(string Naziv)
        {
            TimPregled tp = new TimPregled();
            try
            {
                ISession s = DataLayer.GetSession();
                MMORPG.Entities.Tim t = s.Load<MMORPG.Entities.Tim>(Naziv);
                tp = new TimPregled(t.Naziv, t.MaxIgraca, t.MinIgraca, t.BonusPoeni);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            return tp;
        }

        public static void sacuvajTim(TimBasic tim)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MMORPG.Entities.Tim t = new MMORPG.Entities.Tim();

                t.Naziv = tim.Naziv;
                t.MinIgraca = tim.MinIgraca;
                t.MaxIgraca = tim.MaxIgraca;
                t.BonusPoeni = tim.BonusPoeni;


                s.Save(t);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void obrisiTim(string naziv)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Tim tim = s.Load<Tim>(naziv);

                s.Delete(tim);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        #endregion

        #region Predmet

        public static List<PredmetPregled> vratiSvePredmete()
        {
            List<PredmetPregled> predmeti = new List<PredmetPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Predmet> sviPredmeti = from o in s.Query<Predmet>()
                                                select o;

                foreach (Predmet p in sviPredmeti)
                {
                    predmeti.Add(new PredmetPregled(p.Id, p.Naziv, p.Opis));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return predmeti;
        }
        public static void sacuvajPredmet(PredmetBasic predmet)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MMORPG.Entities.Predmet pr = new MMORPG.Entities.Predmet();

                pr.Naziv = predmet.Naziv;
                pr.Opis = predmet.Opis;
                pr.XpBonus = predmet.XpBonus;

                s.Save(pr);

                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void obrisiPredmet(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predmet predmet = s.Load<Predmet>(id);

                s.Delete(predmet);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        #endregion

        #region Pomocnik
        public static List<PomocnikPregled> vratiSvePomocnike()
        {
            List<PomocnikPregled> pomocnici = new List<PomocnikPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Pomocnik> sviPomocnici = from o in s.Query<Pomocnik>()
                                                  select o;

                foreach (Pomocnik i in sviPomocnici)
                {
                    pomocnici.Add(new PomocnikPregled(i.Id, i.Igrac, i.Ime, i.BonusZastite, 
                        i.NazivRase, i.NazivKlase));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return pomocnici;
        }

        public static void sacuvajPomocnika(PomocnikBasic pom, int idIgraca)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MMORPG.Entities.Pomocnik p = new MMORPG.Entities.Pomocnik();
                Igrac igrac = s.Load<MMORPG.Entities.Igrac>(idIgraca);

                p.Igrac = igrac;
                p.Ime = pom.Ime;
                p.BonusZastite = pom.BonusZastite;
                p.NazivRase = pom.NazivRase;
                p.NazivKlase = pom.NazivKlase;


                s.Save(p);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void obrisiPomocnika(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Pomocnik pomocnik = s.Load<Pomocnik>(id);

                s.Delete(pomocnik);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        #endregion

        #region Staza
        public static List<StazaPregled> vratiSveStaze()
        {
            List<StazaPregled> staze = new List<StazaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Staza> sveStaze = from o in s.Query<Staza>()
                                           select o;

                foreach (Staza i in sveStaze)
                {
                    staze.Add(new StazaPregled(i.Naziv, i.TipStaze, i.BonusPoeni));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return staze;
        }
        public static void sacuvajStazu(StazaBasic staza)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MMORPG.Entities.Staza st = new MMORPG.Entities.Staza();

                st.Naziv = staza.Naziv;
                st.TipStaze = staza.TipStaze;
                st.BonusPoeni = staza.BonusPoeni;

                s.Save(st);

                s.Flush();

                s.Close();
                
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void obrisiStazu(string naziv)
        {
            try 
            {
                ISession s = DataLayer.GetSession();

                Staza staza = s.Load<Staza>(naziv);

                s.Delete(staza);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        #endregion

        #region Rasa

        public static List<RasaPregled> vratiSveRase()
        {
            List<RasaPregled> rase = new List<RasaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Rasa> sveRase = from o in s.Query<Rasa>()
                                           select o;

                foreach (Rasa r in sveRase)
                {
                    rase.Add(new RasaPregled(r.Naziv, r.TipOruzja, r.UmesnostUSkrivanju, r.NivoEnergije));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return rase;
        }

        public static RasaPregled vratiRasu(string Naziv)
        {
            RasaPregled rp = new RasaPregled();

            try
            {
                ISession s = DataLayer.GetSession();

                MMORPG.Entities.Rasa r = s.Load<MMORPG.Entities.Rasa>(Naziv);
                rp = new RasaPregled(r.Naziv, r.TipOruzja, r.UmesnostUSkrivanju, r.NivoEnergije);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return rp;
        }

        #endregion

        #region Klasa

        public static List<KlasaPregled> vratiSveKlase()
        {
            List<KlasaPregled> klase = new List<KlasaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Klasa> sveKlase = from o in s.Query<Klasa>()
                                             select o;

                foreach (Klasa k in sveKlase)
                {
                    //klase.Add(new KlasaPregled(k.Naziv, k.NivoBuke, k.MaxNivoZamki, k.Stit,
                    //    k.OruzjeUObeRuke, k.Religija, k.Lecenje, k.MaxTezinaOklopa, k.LukSamostrel));


                    KlasaPregled kp = new KlasaPregled(k.Naziv, k.NivoBuke, k.MaxNivoZamki, k.Stit,
                                               k.OruzjeUObeRuke, k.Religija, k.Lecenje,
                                               k.MaxTezinaOklopa, k.LukSamostrel);

                    
                    kp.Magije = new List<string>(k.Magije);
                    kp.Blagoslovi = new List<string>(k.Blagoslovi);

                    klase.Add(kp);


                    //foreach (var magija in k.Magije)
                    //{
                    //    k.Magije.Add(magija);
                    //}

                    //foreach (var blagoslov in k.Blagoslovi)
                    //{
                    //    k.Blagoslovi.Add(blagoslov);
                    //}
                }
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            return klase;
        }

        public static KlasaPregled vratiKlasu(string Naziv)
        {
            KlasaPregled kp = new KlasaPregled();

            try
            {
                ISession s = DataLayer.GetSession();

                MMORPG.Entities.Klasa k = s.Load<MMORPG.Entities.Klasa>(Naziv);

                kp = new KlasaPregled(k.Naziv, k.NivoBuke, k.MaxNivoZamki, k.Stit,
                    k.OruzjeUObeRuke, k.Religija, k.Lecenje, k.MaxTezinaOklopa, k.LukSamostrel);


                kp.Magije = new List<string>(k.Magije);
                kp.Blagoslovi = new List<string>(k.Blagoslovi);

                //foreach (var magija in k.Magije)
                //{
                //    kp.Magije.Add(magija);
                //}


                //foreach (var blagoslov in k.Blagoslovi)
                //{
                //    kp.Blagoslovi.Add(blagoslov);
                //}

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            return kp;
        }

        public static List<string> vratiSveMagije()
        {
            List<string> magije = new List<string>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<string> sveMagije = from o in s.Query<Klasa>()
                                               from m in o.Magije
                                               select m;

                magije = sveMagije.Distinct().ToList();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return magije;
        }

        public static List<string> vratiSveBlagoslove()
        {
            List<string> blagoslovi = new List<string>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<string> sviBlagoslovi = from o in s.Query<Klasa>()
                                                  from b in o.Blagoslovi
                                                  select b;

                blagoslovi = sviBlagoslovi.Distinct().ToList();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return blagoslovi;
        }

        #endregion

        #region Lik
        public static List<LikPregled> vratiSveLikove()
        {
            List<LikPregled> likovi = new List<LikPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Lik> sviLikovi = from o in s.Query<Lik>()
                                          select o;

                foreach (Lik i in sviLikovi)
                {
                    likovi.Add(new LikPregled(i.Id ,i.StepenZamora, i.Iskustvo,
                        i.KolicinaZlata, i.NivoZdravstvenogStanja, i.Rasa, i.Klasa));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return likovi;
        }

        public static void sacuvajLika(LikBasic lik, string nazivRase, string nazivKlase)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MMORPG.Entities.Lik l = new MMORPG.Entities.Lik();

                Rasa r1 = s.Load<MMORPG.Entities.Rasa>(nazivRase);
                Klasa k1 = s.Load<MMORPG.Entities.Klasa>(nazivKlase);


                l.StepenZamora = lik.StepenZamora;
                l.Iskustvo = lik.Iskustvo;
                l.KolicinaZlata = lik.KolicinaZlata;
                l.NivoZdravstvenogStanja = lik.NivoZdravstvenogStanja;
                l.Rasa = r1;
                l.Klasa = k1;

                s.Save(l);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void obrisiLika(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lik lik = s.Load<Lik>(id);

                s.Delete(lik);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        #endregion

        #region Borba

        public static List<BorbaPregled> vratiSveBorbe()
        {
            List<BorbaPregled> borbe = new List<BorbaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Borba> sveBorbe = from o in s.Query<Borba>()
                                            select o;
                foreach (Borba b in sveBorbe)
                {
                    borbe.Add(new BorbaPregled(b.Id, b.VremeBorbe, b.Pobednik));
                }
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            return borbe;
        }

        public static BorbaBasic vratiBorbu(int id)
        {
            BorbaBasic bb = new BorbaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                MMORPG.Entities.Borba b = s.Load<MMORPG.Entities.Borba>(id);

                bb = new BorbaBasic(b.Id, b.VremeBorbe, b.Pobednik, b.BonusPoeni);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            return bb;
        }

        public static void sacuvajBorbu(BorbaBasic borba)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MMORPG.Entities.Borba b = new MMORPG.Entities.Borba();

                b.VremeBorbe = borba.VremeBorbe;
                b.Pobednik = borba.Pobednik;

                s.Save(b);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void obrisiBorbu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Borba borba = s.Load<Borba>(id);
                
                s.Delete(borba);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        #endregion

        #region Sesija

        public static List<SesijaPregled> vratiSveSesije()
        {
            List<SesijaPregled> sesije = new List<SesijaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Sesija> sveSesije = from o in s.Query<Sesija>()
                                              select o;
                foreach (Sesija i in sveSesije)
                {
                    sesije.Add(new SesijaPregled(i.Id, i.VremePocetka, i.VremeTrajanja, i.Igrac));
                }
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            return sesije;
        }

        public static SesijaBasic vratiSesiju(int id)
        {
            SesijaBasic sb = new SesijaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                MMORPG.Entities.Sesija se = s.Load<MMORPG.Entities.Sesija>(id);

                sb = new SesijaBasic(se.Id, se.XpPoeni, se.KolicinaZlata,
                    se.VremePocetka, se.VremeTrajanja, se.Igrac);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            return sb;
        }

        public static void sacuvajSesiju(SesijaBasic sesija, int idIgraca)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MMORPG.Entities.Sesija se = new MMORPG.Entities.Sesija();

                Igrac igrac = s.Load<MMORPG.Entities.Igrac>(idIgraca);

                se.XpPoeni = sesija.XpPoeni;
                se.KolicinaZlata = sesija.KolicinaZlata;
                se.VremePocetka = sesija.VremePocetka;
                se.VremeTrajanja = sesija.VremeTrajanja;
                se.Igrac = igrac;

                s.Save(se);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void obrisiSesiju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                Sesija sesija = s.Load<Sesija>(id);

                s.Delete(sesija);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        #endregion

        #region Oprema

        public static List<OpremaPregled> vratiSveOpreme()
        {
            List<OpremaPregled> opreme = new List<OpremaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Oprema> sveOpreme = from o in s.Query<Oprema>()
                                              select o;

                foreach (Oprema i in sveOpreme)
                {
                    opreme.Add(new OpremaPregled(i.Id, i.Naziv, i.TipOpreme, i.XpBonus));
                }
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            return opreme;
        }

        public static OpremaBasic vratiOpremu(int id)
        {
            OpremaBasic ob = new OpremaBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                MMORPG.Entities.Oprema o = s.Load<MMORPG.Entities.Oprema>(id);
                ob = new OpremaBasic(o.Id, o.Naziv, o.TipOpreme, o.Opis, o.Napad, o.Odbrana, o.XpBonus);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            return ob;
        }

        public static void sacuvajOpremu(OpremaBasic oprema)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MMORPG.Entities.Oprema o = new MMORPG.Entities.Oprema();

                o.Naziv = oprema.Naziv;
                o.TipOpreme = oprema.TipOpreme;
                o.XpBonus = oprema.XpBonus;
                o.Napad = oprema.Napad;
                o.Odbrana = oprema.Odbrana;
                o.Opis = oprema.Opis;

                s.Save(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static void obrisiOpremu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Oprema oprema = s.Load<Oprema>(id);
                s.Delete(oprema);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        #endregion
    }
}
