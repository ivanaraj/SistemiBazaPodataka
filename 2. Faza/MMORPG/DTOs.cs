using MMORPG.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MMORPG.Entities.Staza;

namespace MMORPG
{
    #region Igrac

    public class IgracPregled
    {
        public int Id { get; set; }
        public string Nadimak { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int? Uzrast { get; set; }

        public IgracPregled() { }
        public IgracPregled(int id, string nadimak, string ime, string prezime, int? uzrast)
        {
            this.Id = id;
            this.Nadimak = nadimak;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Uzrast = uzrast;
        }
    }

    public class IgracBasic
    {
        public int Id { get; set; }
        public string Nadimak { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public char? Pol { get; set; }
        public int? Uzrast { get; set; }
        public TimBasic Tim { get; set; } // FK naziv_tima

        public virtual IList<PomocnikBasic> Pomocnici { get; set; } // 1:N
        public virtual IList<SesijaBasic> Sesije { get; set; }    // 1:N
        public virtual IList<PredmetBasic> KljučniPredmeti { get; set; }  // N:M
        public virtual IList<OpremaBasic> Opreme { get; set; }  // N:M
        public virtual IList<LikBasic> Likovi { get; set; } // 1:N
        public virtual IList<Igrao> IgraoStaze { get; set; }

        public IgracBasic()
        {
            Pomocnici = new List<PomocnikBasic>();
            Sesije = new List<SesijaBasic>();
            KljučniPredmeti = new List<PredmetBasic>();
            Opreme = new List<OpremaBasic>();
            Likovi = new List<LikBasic>();
            IgraoStaze = new List<Igrao>();
        }

        public IgracBasic(int id, string nadimak, string lozinka, string ime,
            string prezime, char? pol, int? uzrast, TimBasic tim)
        {
            this.Id = id;
            this.Nadimak = nadimak;
            this.Lozinka = lozinka;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Pol = pol;
            this.Uzrast = uzrast;
            this.Tim = tim;

        }
    }

    #endregion

    #region Tim

    public class TimPregled
    {
        public string Naziv { get; set; }
        public int? BonusPoeni { get; set; }

        public TimPregled() { }

        public TimPregled(string naziv, int? bonusPoeni)
        {
            this.Naziv = naziv;
            this.BonusPoeni = bonusPoeni;
        }
    }

    public class TimBasic
    {
        public string Naziv { get; set; }
        public int MaxIgraca { get; set; }
        public int MinIgraca { get; set; }
        public int? BonusPoeni { get; set; }

        public virtual IList<IgracBasic> Igraci { get; set; } // 1:N
        public virtual IList<StazaBasic> Staze { get; set; } // N:M kroz igrao_tim
        public virtual IList<UcestvovaoU> Borbe { get; set; }

        public TimBasic()
        {
            Igraci = new List<IgracBasic>();
            Staze = new List<StazaBasic>();
            Borbe = new List<UcestvovaoU>();
        }

        public TimBasic(string naziv, int max, int min, int? bonusPoeni)
        {
            this.Naziv = naziv;
            this.MaxIgraca = max;
            this.MinIgraca = min;
            this.BonusPoeni = bonusPoeni;
        }
    }

    #endregion

    #region Predmet

    public class PredmetPregled
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public PredmetPregled() { }
        public PredmetPregled(int id, string naziv, string opis)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.Opis = opis;
        }
    }

    public class PredmetBasic
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int? XpBonus { get; set; }

        public virtual IList<StazaBasic> StazeKljucniPredmet { get; set; } // N:M kroz kljucni_za
        public virtual IList<StazaBasic> StazePredmet { get; set; } // N:M kroz nalazi_se_na
        public virtual IList<IgracBasic> IgraciKoriste { get; set; } // N:M kroz koristi
        public virtual IList<RasaPregled> RaseMoguIskoristiti { get; set; } // N:M kroz moze_iskoristiti

        public PredmetBasic()
        {
            StazeKljucniPredmet = new List<StazaBasic>();
            StazePredmet = new List<StazaBasic>();
            IgraciKoriste = new List<IgracBasic>();
            RaseMoguIskoristiti = new List<RasaPregled>();
        }

        public PredmetBasic(int id, string naziv, string opis, int? xpBonus)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.Opis = opis;
            this.XpBonus = xpBonus;
        }
    }

    #endregion

    #region Pomocnik

    public class PomocnikPregled
    {
        public int Id { get; set; }
        public IgracPregled Igrac { get; set; }
        public string Ime { get; set; }
        public int BonusZastite { get; set; }

        public PomocnikPregled() { }

        public PomocnikPregled(int id, IgracPregled igrac, string ime, int bonus)
        {
            this.Id = id;
            this.Igrac = igrac;
            this.Ime = ime;
            this.BonusZastite = bonus;
        }
    }

    public class PomocnikBasic
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public int BonusZastite { get; set; }
        public IgracBasic Igrac { get; set; }
        public RasaPregled NazivRase { get; set; }
        public KlasaPregled NazivKlase { get; set; }

        public PomocnikBasic() { }

        public PomocnikBasic(int id, string ime, int bonus, IgracBasic igrac, RasaPregled nazivRase, KlasaPregled nazivKlase)
        {
            this.Id = id;
            this.Ime = ime;
            this.BonusZastite = bonus;
            this.Igrac = igrac;
            this.NazivRase = nazivRase;
            this.NazivKlase = nazivKlase;
        }
    }

    #endregion

    #region Staza

    public class StazaPregled
    {
        public string Naziv { get; set; }
        public bool TipStaze { get; set; }
        public int? BonusPoeni { get; set; }

        public StazaPregled() { }

        public StazaPregled(string naziv, bool tipStaze, int? bonusPoeni)
        {
            this.Naziv = naziv;
            this.TipStaze = tipStaze;
            this.BonusPoeni = bonusPoeni;
        }
    }

    public class StazaBasic
    {
        public string Naziv { get; set; }
        public bool TipStaze { get; set; }
        public int? BonusPoeni { get; set; }

        public virtual IList<TimBasic> Timovi { get; set; } // N:M kroz igrao_tim
        public virtual IList<PredmetBasic> KljucniPredmeti { get; set; } // N:M kroz kljucni_za
        public virtual IList<PredmetBasic> Predmeti { get; set; } // N:M kroz nalazi_se_na
        public virtual IList<RasaPregled> ZahtevaneRase { get; set; } // N:M kroz zahteva_rasa
        public virtual IList<KlasaPregled> ZahtevaneKlase { get; set; } // N:M kroz zahteva_klasa
        public virtual IList<Igrao> Igraci { get; set; }

        public StazaBasic()
        {
            Timovi = new List<TimBasic>();
            KljucniPredmeti = new List<PredmetBasic>();
            Predmeti = new List<PredmetBasic>();
            ZahtevaneRase = new List<RasaPregled>();
            ZahtevaneKlase = new List<KlasaPregled>();
            Igraci = new List<Igrao>();
        }

        public StazaBasic(string naziv, bool tip, int? bonusPoeni)
        {
            this.Naziv = naziv;
            this.TipStaze = tip;
            this.BonusPoeni = bonusPoeni;
        }
    }

    #endregion

    #region Rasa

    public class RasaPregled
    {
        public string Naziv { get; set; }
        public string TipOruzja { get; set; }
        public bool? UmesnostUSkrivanju { get; set; }
        public int? NivoEnergije { get; set; }

        public RasaPregled() { }

        public RasaPregled(string naziv, string tipOruzja, bool? uus, int? nivoEnergije)
        {
            this.Naziv = naziv;
            this.TipOruzja = tipOruzja;
            this.UmesnostUSkrivanju = uus;
            this.NivoEnergije = nivoEnergije;
        }
    }

    #endregion

    #region Klasa

    public class KlasaPregled
    {
        public string Naziv { get; set; }
        public int? NivoBuke { get; set; }
        public int? MaxNivoZamki { get; set; }
        public bool? Stit { get; set; }
        public bool? OruzjeUObeRuke { get; set; }
        public string Religija { get; set; }
        public bool? Lecenje { get; set; }
        public int? MaxTezinaOklopa { get; set; }
        public bool? LukSamostrel { get; set; }
        public virtual IList<string> Magije { get; set; }
        public virtual IList<string> Blagoslovi { get; set; }

        public KlasaPregled()
        {
            Magije = new List<string>();
            Blagoslovi = new List<string>();
        }

        public KlasaPregled(string naziv, int? nivoBuke, int? maxNivoZamki,
            bool? stit, bool? oruzjeUObeRuke, string religija, bool? lecenje,
            int? maxTezinaOklopa, bool? lukSamostrel)
        {
            this.Naziv = naziv;
            this.NivoBuke = nivoBuke;
            this.MaxNivoZamki = maxNivoZamki;
            this.Stit = stit;
            this.OruzjeUObeRuke = oruzjeUObeRuke;
            this.Religija = religija;
            this.Lecenje = lecenje;
            this.MaxTezinaOklopa = maxTezinaOklopa;
            this.LukSamostrel = lukSamostrel;
        }
    }

    #endregion

    #region Lik

    public class LikPregled
    {
        public int ID { get; set; }
        public int StepenZamora { get; set; }
        public int Iskustvo { get; set; }
        public int KolicinaZlata { get; set; }
        public int NivoZdravstvenogStanja { get; set; }
        public RasaPregled Rasa { get; set; }
        public KlasaPregled Klasa { get; set; }
        public IgracPregled Igrac { get; set; }

        public LikPregled() { }

        public LikPregled(int id, int stepenZamora, int iskustvo,
            int kolicinaZlata, int nivoZdravstvenogStanja,
            RasaPregled rasa, KlasaPregled klasa, IgracPregled igrac)
        {
            this.ID = id;
            this.StepenZamora = stepenZamora;
            this.Iskustvo = iskustvo;
            this.KolicinaZlata = kolicinaZlata;
            this.NivoZdravstvenogStanja = nivoZdravstvenogStanja;
            this.Rasa = rasa;
            this.Klasa = klasa;
            this.Igrac = igrac;
        }
    }

    public class LikBasic
    {
        public int Id { get; set; }
        public int KolicinaZlata { get; set; }
        public int Iskustvo { get; set; }
        public int StepenZamora { get; set; }
        public int NivoZdravstvenogStanja { get; set; }
        public RasaPregled Rasa { get; set; }
        public KlasaPregled Klasa { get; set; }
        public IgracBasic Igrac { get; set; }

        public LikBasic() { }

        public LikBasic(int id, int kolicinaZlata, int iskustvo,
            int stepenZ, int nivoZS, RasaPregled rasa, KlasaPregled klasa, IgracBasic igrac)
        {
            this.Id = id;
            this.KolicinaZlata = kolicinaZlata;
            this.Iskustvo = iskustvo;
            this.StepenZamora = stepenZ;
            this.NivoZdravstvenogStanja = nivoZS;
            this.Rasa = rasa;
            this.Klasa = klasa;
            this.Igrac = igrac;
        }
    }

    #endregion

    #region Borba

    public class BorbaPregled
    {
        public int Id { get; set; }
        public DateTime VremeBorbe { get; set; }
        public string Pobednik { get; set; }
        public int? BonusPoeni { get; set; }

        public BorbaPregled() { }

        public BorbaPregled(int id, DateTime vreme, string pobednik, int? bonusPoeni)
        {
            this.Id = id;
            this.VremeBorbe = vreme;
            this.Pobednik = pobednik;
            this.BonusPoeni = bonusPoeni;
        }
    }

    public class BorbaBasic
    {
        public int Id { get; set; }
        public DateTime VremeBorbe { get; set; }
        public string Pobednik { get; set; }
        public int? BonusPoeni { get; set; }
        public virtual IList<UcestvovaoU> Timovi { get; set; }

        public BorbaBasic()
        {
            Timovi = new List<UcestvovaoU>();
        }

        public BorbaBasic(int id, DateTime vreme, string pobednik, int? bonusP)
        {
            this.Id = id;
            this.VremeBorbe = vreme;
            this.Pobednik = pobednik;
            this.BonusPoeni = bonusP;
        }
    }

    #endregion

    #region Sesija

    public class SesijaPregled
    {
        public int Id { get; set; }
        public DateTime VremePocetka { get; set; }
        public double VremeTrajanja { get; set; }
        public IgracPregled Igrac { get; set; }

        public SesijaPregled() { }

        public SesijaPregled(int id, DateTime vp, double vt, IgracPregled igr)
        {
            this.Id = id;
            this.VremePocetka = vp;
            this.VremeTrajanja = vt;
            this.Igrac = igr;
        }
    }

    public class SesijaBasic
    {
        public int Id { get; set; }
        public int? XpPoeni { get; set; }
        public int? KolicinaZlata { get; set; }
        public DateTime VremePocetka { get; set; }
        public double VremeTrajanja { get; set; }
        public IgracBasic Igrac { get; set; }

        public SesijaBasic() { }

        public SesijaBasic(int id, int? xp, int? kz, DateTime vp, double vt, IgracBasic igr)
        {
            this.Id = id;
            this.XpPoeni = xp;
            this.KolicinaZlata = kz;
            this.VremePocetka = vp;
            this.VremeTrajanja = vt;
            this.Igrac = igr;
        }
    }

    #endregion

    #region Oprema

    public class OpremaPregled
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string TipOpreme { get; set; }
        public int XpBonus { get; set; }

        public OpremaPregled() { }

        public OpremaPregled(int id, string naziv, string tip, int xpBonus)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.TipOpreme = tip;
            this.XpBonus = xpBonus;
        }
    }

    public class OpremaBasic
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string TipOpreme { get; set; }
        public string Opis { get; set; }
        public int Napad { get; set; }
        public int Odbrana { get; set; }
        public int XpBonus { get; set; }
        public virtual IList<IgracBasic> Igraci { get; set; }
        public virtual IList<RasaPregled> Rase { get; set; }
        public virtual IList<KlasaPregled> Klase { get; set; }

        public OpremaBasic()
        {
            Igraci = new List<IgracBasic>();
            Rase = new List<RasaPregled>();
            Klase = new List<KlasaPregled>();
        }

        public OpremaBasic(int id, string naziv, string tip, string opis,
            int napad, int odbrana, int xpBonus)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.TipOpreme = tip;
            this.Opis = opis;
            this.Napad = napad;
            this.Odbrana = odbrana;
            this.XpBonus = xpBonus;
        }
    }

    #endregion




    #region UcestvovaoU

    public class UcestvovaoUBasic
    {
        public int Id { get; set; }
        public int Plasman { get; set; }
        public TimBasic Tim { get; set; }
        public BorbaBasic Borba { get; set; }

        public UcestvovaoUBasic() { }

        public UcestvovaoUBasic(int id, int plasman, TimBasic tim, BorbaBasic borba)
        {
            this.Id = id;
            this.Plasman = plasman;
            this.Tim = tim;
            this.Borba = borba;
        }
    }

    #endregion

    #region Igrao
    public class IgraoBasic
    {
        public int Id { get; set; }
        public int? BrojIgranja { get; set; }
        public int? BrojSavladanihNeprijatelja { get; set; }
        public IgracBasic Igrac { get; set; }
        public StazaBasic Staza { get; set; }

        public IgraoBasic() { }

        public IgraoBasic(int id, int? brojIgranja, int? brojSavladanihNeprijatelja,
            IgracBasic igrac, StazaBasic staza)
        {
            this.Id = id;
            this.BrojIgranja = brojIgranja;
            this.BrojSavladanihNeprijatelja = brojSavladanihNeprijatelja;
            this.Igrac = igrac;
            this.Staza = staza;
        }
    }

    #endregion



}