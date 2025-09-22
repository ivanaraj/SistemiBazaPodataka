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
        public int Id;
        public string Nadimak;
        public string Ime;
        public string Prezime;
        public int? Uzrast;
        public IgracPregled() {}
        public IgracPregled(int id, string nadimak, 
            string ime, string prezime, int? uzrast)
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
        public int Id;
        public string Nadimak;
        public string Lozinka;
        public string Ime;
        public string Prezime;
        public char? Pol;
        public int? Uzrast;
        public Tim Tim;
        public virtual IList<Pomocnik> Pomocnici { get; set; } // 1:N
        public virtual IList<Sesija> Sesije { get; set; }    // 1:N
        public virtual IList<Predmet> KljučniPredmeti { get; set; }  // N:M
        public virtual IList<Oprema> Opreme { get; set; }  // N:M
        public virtual IList<Lik> Likovi { get; set; } // 1:N

        public virtual IList<Igrao> IgraoStaze { get; set; }


        public IgracBasic()
        {
            Pomocnici = new List<Pomocnik>();
            Sesije = new List<Sesija>();
            KljučniPredmeti = new List<Predmet>();
            Opreme = new List<Oprema>();
            IgraoStaze = new List<Igrao>();
            Likovi = new List<Lik>();
        }
        public IgracBasic(int id, string ime, string prezime, string nadimak, 
            string lozinka, char? pol, int? uzrast, Tim tim)
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
        public string Naziv;
        public int MaxIgraca;
        public int MinIgraca;
        public int? BonusPoeni;

        public TimPregled() { }
        public TimPregled(string naziv, int max, int min, int? bonusPoeni)
        {
            this.Naziv = naziv;
            this.MaxIgraca = max;
            this.MinIgraca = min;
            this.BonusPoeni = bonusPoeni;
        }
    }
    public class TimBasic
    {
        public string Naziv;
        public int MaxIgraca;
        public int MinIgraca;
        public int? BonusPoeni;
        public virtual IList<Igrac> Igraci { get; set; } // 1:N
        public virtual IList<Staza> Staze { get; set; } // N:M kroz igrao_tim
        public virtual IList<UcestvovaoU> Borbe { get; set; }

        public TimBasic()
        {
            this.Igraci = new List<Igrac>();
            this.Staze = new List<Staza>();
            this.Borbe = new List<UcestvovaoU>();
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
        public int Id;
        public string Naziv;
        public string Opis;
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
        public int Id;
        public string Naziv;
        public string Opis;
        public int? XpBonus;

        public virtual IList<Staza> StazeKljucniPredmet { get; set; } // N:M kroz kljucni_za
        public virtual IList<Staza> StazePredmet { get; set; } // N:M kroz nalazi_se_na
        public virtual IList<Igrac> IgraciKoriste { get; set; } // N:M kroz koristi
        public virtual IList<Rasa> RaseMoguIskoristiti { get; set; } // N:M kroz moze_iskoristiti

        public PredmetBasic() 
        {
            StazeKljucniPredmet = new List<Staza>();
            StazePredmet = new List<Staza>();
            IgraciKoriste = new List<Igrac>();
            RaseMoguIskoristiti = new List<Rasa>();
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
        public int Id;
        public Igrac Igrac;
        public string Ime;
        public int BonusZastite;
        public Rasa NazivRase;
        public Klasa NazivKlase;

        public PomocnikPregled( int id, Igrac igrac, string ime, int bonus, Rasa rasa, Klasa klasa)
        {
            this.Id = id;
            this.Igrac = igrac;
            this.Ime = ime;
            this.BonusZastite = bonus;
            this.Igrac = igrac;
            this.NazivRase = rasa;
            this.NazivKlase = klasa;
        }
    }

    public class PomocnikBasic
    {
        public int Id;
        public string Ime;
        public int BonusZastite;
        public Igrac Igrac;
        public Rasa NazivRase;
        public Klasa NazivKlase;


        public PomocnikBasic(int id, string ime, int bonus,
            Igrac igrac, Rasa nazivRase, Klasa nazivKlase)
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
        public string Naziv;
        public bool TipStaze;
        public int? BonusPoeni;
        
        public StazaPregled(string naziv, bool tipStaze, int? bonusPoeni)
        {
            this.Naziv = naziv;
            this.TipStaze = tipStaze;
            this.BonusPoeni = bonusPoeni;
        }
    }
    public class StazaBasic
    {
        public string Naziv;
        public bool TipStaze;
        public int? BonusPoeni;

        public virtual IList<Tim> Timovi { get; set; } // N:M kroz igrao_tim
        public virtual IList<Predmet> KljucniPredmeti { get; set; } // N:M kroz kljucni_za
        public virtual IList<Predmet> Predmeti { get; set; } // N:M kroz nalazi_se_na
        public virtual IList<Rasa> ZahtevaneRase { get; set; } // N:M kroz zahteva_rasa
        public virtual IList<Klasa> ZahtevaneKlase { get; set; } // N:M kroz zahteva_klasa
        public virtual IList<Igrao> Igraci { get; set; }

        public StazaBasic()
        {
            Timovi = new List<Tim>();
            KljucniPredmeti = new List<Predmet>();
            Predmeti = new List<Predmet>();
            ZahtevaneRase = new List<Rasa>();
            ZahtevaneKlase = new List<Klasa>();
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

    public class  RasaPregled
    {
        public string Naziv;
        public string TipOruzja;
        public bool? UmesnostUSkrivanju;
        public int? NivoEnergije;

        public RasaPregled() { }

        public RasaPregled( string naziv, string tipOruzja, bool? uus, int? nivoEnergije)
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
        public string Naziv;
        public int? NivoBuke;
        public int? MaxNivoZamki;
        public bool? Stit;
        public bool? OruzjeUObeRuke;
        public string Religija;
        public bool? Lecenje;
        public int? MaxTezinaOklopa;
        public bool? LukSamostrel;
        public virtual IList<string> Magije { get; set; } // visevrednosni atirbut carobnjak_magije
        public virtual IList<string> Blagoslovi { get; set; } // visevrednosni atribut sveštenik_blagoslovi

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
        public int ID;
        public int StepenZamora;
        public int Iskustvo;
        public int KolicinaZlata;
        public int NivoZdravstvenogStanja;
        public Rasa Rasa;
        public Klasa Klasa;
        public Igrac Igrac;

        public LikPregled() { }

        public LikPregled(int id, int stepenZamora, int iskustvo, 
            int kolicinaZlata, int nivoZdravstvenogStanja,
            Rasa rasa, Klasa klasa, Igrac igrac)
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
        public int Id;
        public int KolicinaZlata;
        public int Iskustvo;
        public int StepenZamora;
        public int NivoZdravstvenogStanja;
        public RasaPregled Rasa;
        public KlasaPregled Klasa;
        public IgracBasic Igrac;

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
        public int Id;
        public DateTime VremeBorbe;
        public string Pobednik;
        public virtual IList<UcestvovaoU> Timovi { get; set; }

        public BorbaPregled() 
        {
            Timovi = new List<UcestvovaoU>();
        }

        public BorbaPregled(int id, DateTime vreme, string pobednik)
        {
            this.Id = id;
            this.VremeBorbe = vreme;
            this.Pobednik = pobednik;
        }
    }

    public class BorbaBasic
    {
        public int Id;
        public DateTime VremeBorbe;
        public string Pobednik;
        public int? BonusPoeni;
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
        public int Id;
        public DateTime VremePocetka;
        public double VremeTrajanja;
        public Igrac Igrac;

        public SesijaPregled() { }

        public SesijaPregled(int id, DateTime vp, double vt, Igrac igr)
        {
            this.Id = id;
            this.VremePocetka = vp;
            this.VremeTrajanja = vt;
            this.Igrac = igr;
        }
    }
    public class SesijaBasic
    {
        public int Id;
        public int? XpPoeni;
        public int? KolicinaZlata;
        public DateTime VremePocetka;
        public double VremeTrajanja;
        public Igrac Igrac;

        public SesijaBasic() {}

        public SesijaBasic(int id, int? xp, int? kz, DateTime vp,
            double vt, Igrac igr)
        {
            this.Id = id;
            this.XpPoeni = xp;
            this.KolicinaZlata = kz;
            this.VremePocetka = vp;
            this.VremeTrajanja = vt;
            this.Igrac = igr;
        }

    }
    #endregion Sesija
    
    #region Oprema
    
    public class OpremaPregled
    {
        public int Id;
        public string Naziv;
        public string TipOpreme;
        public int XpBonus;

        public OpremaPregled() {}
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
        public int Id;
        public string Naziv;
        public string TipOpreme;
        public string Opis;
        public int Napad;
        public int Odbrana;
        public int XpBonus;
        public virtual IList<Igrac> Igraci { get; set; } // N:M
        public virtual IList<Rasa> Rase { get; set; } // N:M kroz moze_koristiti_rase
        public virtual IList<Klasa> Klase { get; set; } // N:M kroz moze_koristiti_klase
        public OpremaBasic()
        {
            Igraci = new List<Igrac>();
            Rase = new List<Rasa>();
            Klase = new List<Klasa>();
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
}