--------------------------------
--DDL FOR SEQUENCE IGRAC_ID_SEQ
--------------------------------
CREATE SEQUENCE "IGRAC_ID_SEQ" 
MINVALUE 1 MAXVALUE 999999 INCREMENT BY 1 
START WITH 100000 CACHE 20 ORDER NOCYCLE;

--------------------------------
--DDL FOR SEQUENCE POMOCNIK_ID_SEQ
--------------------------------
CREATE SEQUENCE "POMOCNIK_ID_SEQ" 
MINVALUE 1 MAXVALUE 999999 INCREMENT BY 1 
START WITH 100000 CACHE 20 ORDER NOCYCLE;

--------------------------------
--DDL FOR SEQUENCE SESIJA_ID_SEQ
--------------------------------
CREATE SEQUENCE "SESIJA_ID_SEQ" 
MINVALUE 1 MAXVALUE 999999 INCREMENT BY 1 
START WITH 100000 CACHE 20 ORDER NOCYCLE;

--------------------------------
--DDL FOR SEQUENCE LIK_ID_SEQ
--------------------------------
CREATE SEQUENCE "LIK_ID_SEQ" 
MINVALUE 1 MAXVALUE 999999 INCREMENT BY 1 
START WITH 100000 CACHE 20 ORDER NOCYCLE;

--------------------------------
--DDL FOR SEQUENCE BORBA_ID_SEQ
--------------------------------
CREATE SEQUENCE "BORBA_ID_SEQ" 
MINVALUE 1 MAXVALUE 9999999999 INCREMENT BY 1 
START WITH 1000000000 CACHE 20 ORDER NOCYCLE;

--------------------------------
--DDL FOR SEQUENCE OPREMA_ID_SEQ
--------------------------------
CREATE SEQUENCE "OPREMA_ID_SEQ" 
MINVALUE 1 MAXVALUE 999999 INCREMENT BY 1 
START WITH 100000 CACHE 20 ORDER NOCYCLE;

--------------------------------
--DDL FOR SEQUENCE PREDMET_ID_SEQ
--------------------------------
CREATE SEQUENCE "PREDMET_ID_SEQ" 
MINVALUE 1 MAXVALUE 999999 INCREMENT BY 1 
START WITH 100000 CACHE 20 ORDER NOCYCLE;

--------------------------------
--DDL FOR SEQUENCE IGRAO_ID_SEQ
--------------------------------
CREATE SEQUENCE "IGRAO_ID_SEQ" 
MINVALUE 1 MAXVALUE 999999 INCREMENT BY 1 
START WITH 100000 CACHE 20 ORDER NOCYCLE;

--------------------------------
--DDL FOR SEQUENCE UCESTVOVAO_U_ID_SEQ
--------------------------------
CREATE SEQUENCE "UCESTVOVAO_U_ID_SEQ" 
MINVALUE 1 MAXVALUE 999999 INCREMENT BY 1 
START WITH 100000 CACHE 20 ORDER NOCYCLE;


------------------------
--DDL FOR TABLE IGRAC
------------------------
CREATE TABLE igrac(
    id NUMBER(6, 0),
    nadimak VARCHAR2(10 CHAR) NOT NULL,
    lozinka VARCHAR2(30 CHAR) NOT NULL,
    ime VARCHAR2(10 CHAR),
    prezime VARCHAR2(20 CHAR),
    pol VARCHAR2(1 CHAR),
    uzrast NUMBER(2, 0),
    naziv_tima VARCHAR2(10 CHAR)
);
CREATE UNIQUE INDEX igrac_pk ON igrac(id);
CREATE UNIQUE INDEX igrac_nadimak ON igrac(nadimak);
ALTER TABLE igrac ADD CONSTRAINT igrac_pk PRIMARY KEY(id) ENABLE;
ALTER TABLE igrac ADD CONSTRAINT nadimak_unique UNIQUE (nadimak);

-------------------------
--DDL FOR TABLE SESIJA
-------------------------
CREATE TABLE sesija(
    id NUMBER(6, 0),
    xp_poeni INTEGER,
    kolicina_zlato INTEGER,
    vreme_pocetka DATE NOT NULL,
    vreme_trajanja FLOAT NOT NULL,
    id_igraca NUMBER(6, 0)
);
CREATE UNIQUE INDEX sesija_pk ON sesija(id);
ALTER TABLE sesija ADD CONSTRAINT sesija_pk PRIMARY KEY(id) ENABLE;

--------------------------
--DDL FOR TABLE LIK
--------------------------
CREATE TABLE lik(
    id NUMBER(6, 0),
    stepen_zamora INTEGER NOT NULL,
    iskustvo INTEGER NOT NULL,
    kolicina_zlata INTEGER NOT NULL,
    nivo_zdravstvenog_stanja INTEGER NOT NULL,
    naziv_rase VARCHAR2(15 CHAR),
    naziv_klase VARCHAR2(15 CHAR),
    id_igraca NUMBER(6, 0)
);
CREATE UNIQUE INDEX lik_pk ON lik(id);
ALTER TABLE lik ADD CONSTRAINT lik_pk PRIMARY KEY(id) ENABLE;

---------------------------
--DDL FOR TABLE TIM
---------------------------
CREATE TABLE tim(
    naziv VARCHAR2(10 CHAR),
    max_igraca INTEGER NOT NULL,
    min_igraca INTEGER NOT NULL,
    bonus_poeni INTEGER
);
CREATE UNIQUE INDEX tim_pk ON tim(naziv);
ALTER TABLE tim ADD CONSTRAINT tim_pk PRIMARY KEY(naziv) ENABLE;

---------------------------
--DDL FOR TABLE BORBA
---------------------------
CREATE TABLE borba(
    id NUMBER(10, 0),
    vreme_borbe DATE NOT NULL,
    pobednik VARCHAR2(10 CHAR) NOT NULL,
    bonus_poeni INTEGER
);
CREATE UNIQUE INDEX borba_pk ON borba(id);
ALTER TABLE borba ADD CONSTRAINT borba_pk PRIMARY KEY(id) ENABLE;

-----------------------------
--DDL FOR TABLE STAZA
-----------------------------
CREATE TABLE staza(
    naziv VARCHAR2(10 CHAR),
    tip_staze NUMBER(1,0) NOT NULL,
    bonus_poeni INTEGER
);
CREATE UNIQUE INDEX staza_pk ON staza(naziv);
ALTER TABLE staza ADD CONSTRAINT staza_pk PRIMARY KEY(naziv) ENABLE;

-----------------------------
--DDL FOR TABLE POMOCNIK
-----------------------------
CREATE TABLE pomocnik(
    id NUMBER(6, 0),
    id_igraca NUMBER(6, 0),
    ime VARCHAR2(10 CHAR),
    bonus_zastite INTEGER NOT NULL,
    naziv_rase VARCHAR2(15 CHAR) NOT NULL,
    naziv_klase VARCHAR2(15 CHAR) NOT NULL
);
CREATE UNIQUE INDEX pomocnik_pk ON pomocnik(id);
CREATE UNIQUE INDEX pomocnik_ime ON pomocnik(ime);
ALTER TABLE pomocnik ADD CONSTRAINT pomocnik_pk PRIMARY KEY(id) ENABLE;
ALTER TABLE pomocnik ADD CONSTRAINT ime_unique UNIQUE (ime);

------------------------------
--DDL FOR TABLE RASA
------------------------------
CREATE TABLE rasa(
    naziv VARCHAR2(15 CHAR),
    tip_oruzja VARCHAR2(10 CHAR),
    umesnost_u_skrivanju NUMBER(1, 0),
    nivo_energije INTEGER
);
CREATE UNIQUE INDEX rasa_pk ON rasa(naziv);
ALTER TABLE rasa ADD CONSTRAINT rasa_pk PRIMARY KEY(naziv) ENABLE;

--------------------------------
--DDL FOR TABLE KLASA
--------------------------------
CREATE TABLE klasa(
    naziv VARCHAR2(15 CHAR),
    nivo_buke INTEGER,
    max_nivo_zamki INTEGER,
    magije VARCHAR2(10 CHAR),
    stit NUMBER(1, 0),
    oruzje_u_obe_ruke NUMBER(1, 0),
    religija VARCHAR2(10 CHAR),
    tipovi_blagoslova VARCHAR2(10 CHAR),
    lecenje NUMBER(1, 0),
    max_tezina_oklopa INTEGER,
    luk_samostrel NUMBER(1, 0)
);
CREATE UNIQUE INDEX klasa_pk ON klasa(naziv);
ALTER TABLE klasa ADD CONSTRAINT klasa_pk PRIMARY KEY(naziv) ENABLE;

-------------------------------------
--DDL FOR TABLE OPREMA
--------------------------------------
CREATE TABLE oprema (
    id NUMBER(6, 0),
    opis VARCHAR2(40 CHAR),
    naziv VARCHAR2(15 CHAR) NOT NULL,
    tip_opreme VARCHAR2(10 CHAR) NOT NULL,
    napad INTEGER NOT NULL,
    odbrana INTEGER NOT NULL,
    xp_bonus INTEGER NOT NULL
);
CREATE UNIQUE INDEX oprema_pk ON oprema(id);
ALTER TABLE oprema ADD CONSTRAINT oprema_pk PRIMARY KEY(id) ENABLE;

-----------------------------------
--DDL FOR TABLE PREDMET
-----------------------------------
CREATE TABLE predmet(
    id NUMBER(6, 0),
    opis VARCHAR2(40 CHAR) NOT NULL,
    naziv VARCHAR2(10 CHAR) NOT NULL,
    xp_bonus INTEGER
);
CREATE UNIQUE INDEX predmet_pk ON predmet(id);
ALTER TABLE predmet ADD CONSTRAINT predmet_pk PRIMARY KEY(id) ENABLE;

-----------------------------------
--DDL FOR TABLE UCESTVOVAO_U
-----------------------------------
CREATE TABLE ucestvovao_u (
    id NUMBER(6, 0),
    naziv_tima VARCHAR2(10 CHAR),
    id_borbe NUMBER(10, 0),
    plasman INTEGER NOT NULL
);
CREATE UNIQUE INDEX ucestvovao_u_pk ON ucestvovao_u(id);
ALTER TABLE UCESTVOVAO_U ADD CONSTRAINT ucestvovao_u_PK PRIMARY KEY (id) ENABLE;

-----------------------------------
--DDL FOR TABLE IGRAO
-----------------------------------
CREATE TABLE igrao (
    id NUMBER(6, 0),
    id_igraca NUMBER(6, 0),
    naziv_staze VARCHAR2(10 CHAR),
    broj_igranja INTEGER,
    broj_savladanih_neprijatelja INTEGER
);
CREATE UNIQUE INDEX igrao_pk ON igrao(id);
ALTER TABLE IGRAO ADD CONSTRAINT igrao_PK PRIMARY KEY(id) ENABLE;

-----------------------------------
--DDL FOR TABLE IGRAO_TIM
-----------------------------------
CREATE TABLE igrao_tim (
    naziv_tima VARCHAR2(10 CHAR),
    naziv_staze VARCHAR2(10 CHAR)
);
ALTER TABLE IGRAO_TIM ADD CONSTRAINT igrao_tim_PK PRIMARY KEY(naziv_tima, naziv_staze) ENABLE;

-----------------------------------
--DDL FOR TABLE KUPIO
-----------------------------------
CREATE TABLE kupio (
    id_igraca NUMBER(6, 0),
    id_opreme NUMBER(6, 0)
);
ALTER TABLE KUPIO ADD CONSTRAINT kupio_PK PRIMARY KEY(id_igraca, id_opreme) ENABLE;

-----------------------------------
--DDL FOR TABLE NALAZI_SE_NA
-----------------------------------
CREATE TABLE nalazi_se_na (
    id_predmeta NUMBER(6, 0),
    naziv_staze VARCHAR2(10 CHAR)
);
ALTER TABLE NALAZI_SE_NA ADD CONSTRAINT nalazi_se_na_PK PRIMARY KEY(id_predmeta, naziv_staze) ENABLE;

-----------------------------------
--DDL FOR TABLE ZAHTEVA_RASU
-----------------------------------
CREATE TABLE zahteva_rasu (
    naziv_staze VARCHAR2(10 CHAR),
    naziv_rase VARCHAR2(15 CHAR)
);
ALTER TABLE ZAHTEVA_RASU ADD CONSTRAINT zahteva_rasu_PK PRIMARY KEY(naziv_staze, naziv_rase) ENABLE;

-----------------------------------
--DDL FOR TABLE ZAHTEVA_KLASU
-----------------------------------
CREATE TABLE zahteva_klasu (
    naziv_staze VARCHAR2(10 CHAR),
    naziv_klase VARCHAR2(15 CHAR)
);
ALTER TABLE ZAHTEVA_KLASU ADD CONSTRAINT zahteva_klasu_PK PRIMARY KEY(naziv_staze, naziv_klase) ENABLE;

-----------------------------------
--DDL FOR TABLE MOZE_KORISTITI_RASE
-----------------------------------
CREATE TABLE moze_koristiti_rase(
    id_opreme NUMBER(6, 0),
    naziv_rase VARCHAR2(15 CHAR)
);
ALTER TABLE MOZE_KORISTITI_RASE ADD CONSTRAINT moze_koristiti_rase_PK PRIMARY KEY(id_opreme, naziv_rase) ENABLE;

-----------------------------------
--DDL FOR TABLE MOZE_KORISTITI_KLASE
-----------------------------------
CREATE TABLE moze_koristiti_klase (
    id_opreme NUMBER(6, 0),
    naziv_klase VARCHAR2(15 CHAR)
);
ALTER TABLE MOZE_KORISTITI_KLASE ADD CONSTRAINT moze_koristiti_klase_PK PRIMARY KEY(id_opreme, naziv_klase) ENABLE;

-----------------------------------
--DDL FOR TABLE MOZE_ISKORISTITI
-----------------------------------
CREATE TABLE moze_iskoristiti (
    id_predmeta NUMBER(6, 0),
    naziv_rase VARCHAR2(15 CHAR)
);
ALTER TABLE MOZE_ISKORISTITI ADD CONSTRAINT moze_iskoristiti_PK PRIMARY KEY(id_predmeta, naziv_rase) ENABLE;

-----------------------------------
--DDL FOR TABLE KORISTI
-----------------------------------
CREATE TABLE koristi (
    id_igraca NUMBER(6, 0),
    id_kljucnog_predmeta NUMBER(6, 0)
);
ALTER TABLE koristi ADD CONSTRAINT koristi_PK PRIMARY KEY(id_igraca, id_kljucnog_predmeta) ENABLE;

-----------------------------------
--DDL FOR TABLE KLJUCNI_ZA
-----------------------------------
CREATE TABLE kljucni_za (
    naziv_staze VARCHAR2(10 CHAR),
    id_kljucnog_predmeta NUMBER(6, 0)
);
ALTER TABLE kljucni_za ADD CONSTRAINT kljucni_za_PK PRIMARY KEY(naziv_staze, id_kljucnog_predmeta) ENABLE;

-----------------------------------
--DDL FOR TABLE CAROBNJAK_MAGIJE
-----------------------------------
CREATE TABLE carobnjak_magije (
    id_carobnjaka VARCHAR2(15 CHAR),
    magija VARCHAR2(10 CHAR)
);
ALTER TABLE carobnjak_magije ADD CONSTRAINT carobnjak_magije_PK PRIMARY KEY(id_carobnjaka, magija) ENABLE;

-----------------------------------
--DDL FOR TABLE SVESTENIK_BLAGOSLOV
-----------------------------------
CREATE TABLE svestenik_blagoslov (
    id_svestenika VARCHAR2(15 CHAR),
    tip_blagoslova VARCHAR2(10 CHAR)
);
ALTER TABLE svestenik_blagoslov ADD CONSTRAINT svestenik_blagoslov_PK PRIMARY KEY(id_svestenika, tip_blagoslova) ENABLE;



----------------------------------
--CONTRAINTS FOR TABLE IGRAC
----------------------------------
ALTER TABLE igrac ADD CONSTRAINT igrac_pol_chk CHECK (pol IN ('M', 'Z')) ENABLE;
ALTER TABLE igrac ADD CONSTRAINT naziv_tima_FK FOREIGN KEY (naziv_tima) REFERENCES tim(naziv) ON DELETE CASCADE;

----------------------------------
--CONTRAINTS FOR TABLE SESIJA
----------------------------------
ALTER TABLE sesija ADD CONSTRAINT id_igraca_FK FOREIGN KEY (id_igraca) REFERENCES igrac(id) ON DELETE CASCADE;

----------------------------------
--CONTRAINTS FOR TABLE LIK
----------------------------------
ALTER TABLE lik ADD CONSTRAINT naziv_rase_FK FOREIGN KEY (naziv_rase) REFERENCES rasa(naziv) ON DELETE CASCADE;
ALTER TABLE lik ADD CONSTRAINT naziv_klase_FK FOREIGN KEY (naziv_klase) REFERENCES klasa(naziv) ON DELETE CASCADE;
ALTER TABLE lik ADD CONSTRAINT lik_id_igraca_FK FOREIGN KEY (id_igraca) REFERENCES igrac(id) ON DELETE CASCADE;

----------------------------------
--CONTRAINTS FOR TABLE STAZA
----------------------------------
ALTER TABLE staza ADD CONSTRAINT tip_staze_chk CHECK (tip_staze IN(0,1)) ENABLE;

----------------------------------
--CONTRAINTS FOR TABLE POMOCNIK
----------------------------------
ALTER TABLE pomocnik ADD CONSTRAINT pomocnik_igrac_FK FOREIGN KEY (id_igraca) REFERENCES igrac(id) ON DELETE CASCADE;
ALTER TABLE pomocnik ADD CONSTRAINT pomocnik_rasa_FK FOREIGN KEY (naziv_rase) REFERENCES rasa(naziv) ON DELETE CASCADE;
ALTER TABLE pomocnik ADD CONSTRAINT pomocnik_klasa_FK FOREIGN KEY (naziv_klase) REFERENCES klasa(naziv) ON DELETE CASCADE;

----------------------------------
--CONTRAINTS FOR TABLE RASA
----------------------------------
ALTER TABLE rasa ADD CONSTRAINT rasa_umesnost_u_skrivanju_chk CHECK (umesnost_u_skrivanju IN(0,1)) ENABLE;

----------------------------------
--CONTRAINTS FOR TABLE KLASA
----------------------------------
ALTER TABLE klasa ADD CONSTRAINT klasa_stit_chk CHECK (stit IN(0,1)) ENABLE;
ALTER TABLE klasa ADD CONSTRAINT oruzje_u_obe_ruke CHECK (oruzje_u_obe_ruke IN(0,1)) ENABLE;
ALTER TABLE klasa ADD CONSTRAINT  lecenje CHECK (lecenje IN(0,1)) ENABLE;
ALTER TABLE klasa ADD CONSTRAINT   luk_samostrel CHECK (luk_samostrel IN(0,1)) ENABLE;

----------------------------------
--CONTRAINTS FOR TABLE UCESTVOVAO_U
----------------------------------
ALTER TABLE UCESTVOVAO_U ADD CONSTRAINT ucestvovao_tim_FK FOREIGN KEY(naziv_tima) REFERENCES tim(naziv) ON DELETE CASCADE;
ALTER TABLE UCESTVOVAO_U ADD CONSTRAINT ucestvovao_u_borbi_FK FOREIGN KEY(id_borbe) REFERENCES borba(id) ON DELETE CASCADE;

----------------------------------
--CONTRAINTS FOR TABLE IGRAO
----------------------------------
ALTER TABLE IGRAO ADD CONSTRAINT igrao_igrac_FK FOREIGN KEY(id_igraca) REFERENCES igrac(id) ON DELETE CASCADE;
ALTER TABLE IGRAO ADD CONSTRAINT igrao_na_stazi_FK FOREIGN KEY(naziv_staze) REFERENCES staza(naziv) ON DELETE CASCADE;

----------------------------------
--CONTRAINTS FOR TABLE IGRAO_TIM
----------------------------------
ALTER TABLE IGRAO_TIM ADD CONSTRAINT igrao_tim_FK FOREIGN KEY(naziv_tima) REFERENCES tim(naziv) ON DELETE CASCADE;
ALTER TABLE IGRAO_TIM ADD CONSTRAINT igrao_tim_na_stazi_FK FOREIGN KEY(naziv_staze) REFERENCES staza(naziv) ON DELETE CASCADE;

----------------------------------
--CONTRAINTS FOR TABLE KUPIO
----------------------------------
ALTER TABLE KUPIO ADD CONSTRAINT igrac_kupio_FK FOREIGN KEY(id_igraca) REFERENCES igrac(id) ON DELETE CASCADE;
ALTER TABLE KUPIO ADD CONSTRAINT igrac_kupio_opremu_FK FOREIGN KEY(id_opreme) REFERENCES oprema(id) ON DELETE CASCADE;

----------------------------------
--CONTRAINTS FOR TABLE NALAZI_SE_NA
----------------------------------
ALTER TABLE NALAZI_SE_NA ADD CONSTRAINT predmet_se_nalazi_FK FOREIGN KEY(id_predmeta) REFERENCES predmet(id) ON DELETE CASCADE;
ALTER TABLE NALAZI_SE_NA ADD CONSTRAINT nalazi_se_na_stazi_FK FOREIGN KEY(naziv_staze) REFERENCES staza(naziv) ON DELETE CASCADE;

----------------------------------
--CONTRAINTS FOR TABLE ZAHTEVA_RASU
----------------------------------
ALTER TABLE ZAHTEVA_RASU ADD CONSTRAINT zahtevana_na_stazi_FK FOREIGN KEY(naziv_staze) REFERENCES staza(naziv) ON DELETE CASCADE;
ALTER TABLE ZAHTEVA_RASU ADD CONSTRAINT zahtevana_rasa_FK FOREIGN KEY(naziv_rase) REFERENCES rasa(naziv) ON DELETE CASCADE;

----------------------------------
--CONTRAINTS FOR TABLE ZAHTEVA_KLASU
----------------------------------
ALTER TABLE ZAHTEVA_KLASU ADD CONSTRAINT zahtevana_klasa_na_stazi_FK FOREIGN KEY(naziv_staze) REFERENCES staza(naziv) ON DELETE CASCADE;
ALTER TABLE ZAHTEVA_KLASU ADD CONSTRAINT zahtevana_klasa_FK FOREIGN KEY(naziv_klase) REFERENCES klasa(naziv) ON DELETE CASCADE;


----------------------------------
--CONTRAINTS FOR TABLE MOZE_KORISTITI_RASE
----------------------------------
ALTER TABLE MOZE_KORISTITI_RASE ADD CONSTRAINT koristi_opremu_FK FOREIGN KEY(id_opreme) REFERENCES oprema(id) ON DELETE CASCADE;
ALTER TABLE MOZE_KORISTITI_RASE ADD CONSTRAINT rasa_koristi_FK FOREIGN KEY(naziv_rase) REFERENCES rasa(naziv) ON DELETE CASCADE;

----------------------------------
--CONTRAINTS FOR TABLE MOZE_KORISTITI_KLASE
----------------------------------
ALTER TABLE MOZE_KORISTITI_KLASE ADD CONSTRAINT koristi_opremu_klasa_FK FOREIGN KEY(id_opreme) REFERENCES oprema(id) ON DELETE CASCADE;
ALTER TABLE MOZE_KORISTITI_KLASE ADD CONSTRAINT klasa_koristi_FK FOREIGN KEY(naziv_klase) REFERENCES klasa(naziv) ON DELETE CASCADE;

----------------------------------------
--CONTRAINTS FOR TABLE MOZE_ISKORISTITI
----------------------------------------
ALTER TABLE MOZE_ISKORISTITI ADD CONSTRAINT iskoristi_predmet_FK FOREIGN KEY(id_predmeta) REFERENCES predmet(id) ON DELETE CASCADE;
ALTER TABLE MOZE_ISKORISTITI ADD CONSTRAINT rasa_iskoristi_FK FOREIGN KEY(naziv_rase) REFERENCES rasa(naziv) ON DELETE CASCADE;

----------------------------------------
--CONTRAINTS FOR TABLE KORISTI
----------------------------------------
ALTER TABLE koristi ADD CONSTRAINT koristi_igrac_FK FOREIGN KEY(id_igraca) REFERENCES igrac(id) ON DELETE CASCADE;
ALTER TABLE koristi ADD CONSTRAINT predmet_koristi_FK FOREIGN KEY(id_kljucnog_predmeta) REFERENCES predmet(id) ON DELETE CASCADE;

----------------------------------------
--CONTRAINTS FOR TABLE KLJUCNI_ZA
----------------------------------------
ALTER TABLE kljucni_za ADD CONSTRAINT kljucan_za_stazu_FK FOREIGN KEY(naziv_staze) REFERENCES staza(naziv) ON DELETE CASCADE;
ALTER TABLE kljucni_za ADD CONSTRAINT predmet_kljucni_za_FK FOREIGN KEY(id_kljucnog_predmeta) REFERENCES predmet(id) ON DELETE CASCADE;

----------------------------------------
--CONTRAINTS FOR TABLE CAROBNJAK_MAGIJE
----------------------------------------
ALTER TABLE carobnjak_magije ADD CONSTRAINT carobnjak_FK FOREIGN KEY(id_carobnjaka) REFERENCES klasa(naziv) ON DELETE CASCADE;

-------------------------------------------
--CONTRAINTS FOR TABLE SVESTENIK_BLAGOSLOV
-------------------------------------------
ALTER TABLE svestenik_blagoslov ADD CONSTRAINT svestenik_FK FOREIGN KEY(id_svestenika) REFERENCES klasa(naziv) ON DELETE CASCADE;



----------------------------
--DDL FOR TRIGGER IGRAC_PK
----------------------------
CREATE OR REPLACE TRIGGER "IGRAC_PK"
    BEFORE INSERT ON igrac
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT IGRAC_ID_SEQ.NEXTVAL INTO :NEW.id FROM DUAL;
END;
/
ALTER TRIGGER "IGRAC_PK" ENABLE;

----------------------------
--DDL FOR TRIGGER POMOCNIK_PK
----------------------------
CREATE OR REPLACE TRIGGER "POMOCNIK_PK"
    BEFORE INSERT ON pomocnik
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT POMOCNIK_ID_SEQ.NEXTVAL INTO :NEW.id FROM DUAL;
END;
/
ALTER TRIGGER "POMOCNIK_PK" ENABLE;

----------------------------
--DDL FOR TRIGGER SESIJA_PK
----------------------------
CREATE OR REPLACE TRIGGER "SESIJA_PK"
    BEFORE INSERT ON sesija
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT SESIJA_ID_SEQ.NEXTVAL INTO :NEW.id FROM DUAL;
END;
/
ALTER TRIGGER "SESIJA_PK" ENABLE;

----------------------------
--DDL FOR TRIGGER LIK_PK
----------------------------
CREATE OR REPLACE TRIGGER "LIK_PK"
    BEFORE INSERT ON lik
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT LIK_ID_SEQ.NEXTVAL INTO :NEW.id FROM DUAL;
END;
/
ALTER TRIGGER "LIK_PK" ENABLE;

----------------------------
--DDL FOR TRIGGER BORBA_PK
----------------------------
CREATE OR REPLACE TRIGGER "BORBA_PK"
    BEFORE INSERT ON borba
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT BORBA_ID_SEQ.NEXTVAL INTO :NEW.id FROM DUAL;
END;
/
ALTER TRIGGER "BORBA_PK" ENABLE;

----------------------------
--DDL FOR TRIGGER OPREMA_PK
----------------------------
CREATE OR REPLACE TRIGGER "OPREMA_PK"
    BEFORE INSERT ON oprema
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT OPREMA_ID_SEQ.NEXTVAL INTO :NEW.id FROM DUAL;
END;
/
ALTER TRIGGER "OPREMA_PK" ENABLE;

----------------------------
--DDL FOR TRIGGER PREDMET_PK
----------------------------
CREATE OR REPLACE TRIGGER "PREDMET_PK"
    BEFORE INSERT ON predmet
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT PREDMET_ID_SEQ.NEXTVAL INTO :NEW.id FROM DUAL;
END;
/
ALTER TRIGGER "PREDMET_PK" ENABLE;

----------------------------
--DDL FOR TRIGGER UCESTVOVAO_U_PK
----------------------------
CREATE OR REPLACE TRIGGER "UCESTVOVAO_U_PK"
    BEFORE INSERT ON ucestvovao_u
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT UCESTVOVAO_U_ID_SEQ.NEXTVAL INTO :NEW.id FROM DUAL;
END;
/
ALTER TRIGGER "UCESTVOVAO_U_PK" ENABLE;

----------------------------
--DDL FOR TRIGGER IGRAO_PK
----------------------------
CREATE OR REPLACE TRIGGER "IGRAO_PK"
    BEFORE INSERT ON igrao
    REFERENCING NEW AS NEW
    FOR EACH ROW
BEGIN
    SELECT IGRAO_ID_SEQ.NEXTVAL INTO :NEW.id FROM DUAL;
END;
/
ALTER TRIGGER "IGRAO_PK" ENABLE;




----------------------------------------------------
-- 1. RASA
----------------------------------------------------
REM INSERTING into RASA
SET DEFINE OFF;
INSERT INTO rasa (naziv, tip_oruzja, umesnost_u_skrivanju, nivo_energije) VALUES ('Covek', NULL, 1, NULL);
INSERT INTO rasa (naziv, tip_oruzja, umesnost_u_skrivanju, nivo_energije) VALUES ('Patuljak', 'Sekira', NULL, NULL);
INSERT INTO rasa (naziv, tip_oruzja, umesnost_u_skrivanju, nivo_energije) VALUES ('Ork', 'Topuz', NULL, NULL);
INSERT INTO rasa (naziv, tip_oruzja, umesnost_u_skrivanju, nivo_energije) VALUES ('Demon', NULL, NULL, 100);
INSERT INTO rasa (naziv, tip_oruzja, umesnost_u_skrivanju, nivo_energije) VALUES ('Vilenjak', NULL, NULL, 85);

----------------------------------------------------
-- 2. KLASA
----------------------------------------------------
REM INSERTING into KLASA
SET DEFINE OFF;
INSERT INTO klasa (naziv, nivo_buke, max_nivo_zamki, magije, stit, oruzje_u_obe_ruke, religija, tipovi_blagoslova, lecenje, max_tezina_oklopa, luk_samostrel)
VALUES ('Lopov', 2, 5, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO klasa (naziv, nivo_buke, max_nivo_zamki, magije, stit, oruzje_u_obe_ruke, religija, tipovi_blagoslova, lecenje, max_tezina_oklopa, luk_samostrel)
VALUES ('Carobnjak', NULL, NULL, 'Vatra', NULL, NULL, NULL, NULL, NULL, NULL, NULL);
INSERT INTO klasa (naziv, nivo_buke, max_nivo_zamki, magije, stit, oruzje_u_obe_ruke, religija, tipovi_blagoslova, lecenje, max_tezina_oklopa, luk_samostrel)
VALUES ('Borac', NULL, NULL, NULL, 1, 0, NULL, NULL, NULL, NULL, NULL);
INSERT INTO klasa (naziv, nivo_buke, max_nivo_zamki, magije, stit, oruzje_u_obe_ruke, religija, tipovi_blagoslova, lecenje, max_tezina_oklopa, luk_samostrel)
VALUES ('Svestenik', NULL, NULL, NULL, NULL, NULL, 'Svetlo', 'Snaga', 1, NULL, NULL);
INSERT INTO klasa (naziv, nivo_buke, max_nivo_zamki, magije, stit, oruzje_u_obe_ruke, religija, tipovi_blagoslova, lecenje, max_tezina_oklopa, luk_samostrel)
VALUES ('Oklopnik', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 80, NULL);
INSERT INTO klasa (naziv, nivo_buke, max_nivo_zamki, magije, stit, oruzje_u_obe_ruke, religija, tipovi_blagoslova, lecenje, max_tezina_oklopa, luk_samostrel)
VALUES ('Strelac', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1);

----------------------------------------------------
-- 3. TIM
----------------------------------------------------
REM INSERTING into TIM
SET DEFINE OFF;
INSERT INTO tim (naziv, max_igraca, min_igraca, bonus_poeni) VALUES ('Vitezovi', 10, 3, 50);
INSERT INTO tim (naziv, max_igraca, min_igraca, bonus_poeni) VALUES ('Senke', 8, 2, 40);
INSERT INTO tim (naziv, max_igraca, min_igraca, bonus_poeni) VALUES ('SILA', 12, 4, 60);

----------------------------------------------------
-- 4. STAZA
----------------------------------------------------
REM INSERTING into STAZA
SET DEFINE OFF;
INSERT INTO staza (naziv, tip_staze, bonus_poeni) VALUES ('Suma', 0, 30);
INSERT INTO staza (naziv, tip_staze, bonus_poeni) VALUES ('Pustinja', 0, 20);
INSERT INTO staza (naziv, tip_staze, bonus_poeni) VALUES ('Planina', 1, 50);
INSERT INTO staza (naziv, tip_staze, bonus_poeni) VALUES ('Mocvara', 1, 80);

----------------------------------------------------
-- 5. OPREMA (triger puni ID)
----------------------------------------------------
REM INSERTING into OPREMA
SET DEFINE OFF;
INSERT INTO oprema (opis, naziv, tip_opreme, napad, odbrana, xp_bonus) VALUES ('Mocni dvosek', 'SekiraGroma', 'Oruzje', 80, 10, 15);
INSERT INTO oprema (opis, naziv, tip_opreme, napad, odbrana, xp_bonus) VALUES ('Magican stit svetlosti', 'StitSvetlosti', 'Stit', 10, 80, 20);
INSERT INTO oprema (opis, naziv, tip_opreme, napad, odbrana, xp_bonus) VALUES ('Luk vilenjaka', 'ZeleniLuk', 'Oruzje', 60, 5, 10);

----------------------------------------------------
-- 6. PREDMET (triger puni ID)
----------------------------------------------------
REM INSERTING into PREDMET
SET DEFINE OFF;
INSERT INTO predmet (opis, naziv, xp_bonus) VALUES ('Magican prsten nevidljivosti', 'Prsten', NULL);
INSERT INTO predmet (opis, naziv, xp_bonus) VALUES ('Ocarana amajlija', 'Amajlia', NULL);
INSERT INTO predmet (opis, naziv, xp_bonus) VALUES ('Sveti svitak', 'Svitak', NULL);
INSERT INTO predmet (opis, naziv, xp_bonus) VALUES ('Bozanska ogrlica', 'Ogrlica', 100);
INSERT INTO predmet (opis, naziv, xp_bonus) VALUES ('Carobnjakov plast', 'Plast', 85);

----------------------------------------------------
-- 7. BORBA (triger puni ID)
----------------------------------------------------
REM INSERTING into BORBA
SET DEFINE OFF;
INSERT INTO borba (vreme_borbe, pobednik, bonus_poeni) VALUES (TO_DATE('2024-05-01','YYYY-MM-DD'), 'Vitezovi', 100);
INSERT INTO borba (vreme_borbe, pobednik, bonus_poeni) VALUES (TO_DATE('2024-06-15','YYYY-MM-DD'), 'Senke', 80);
INSERT INTO borba (vreme_borbe, pobednik, bonus_poeni) VALUES (TO_DATE('2024-07-20','YYYY-MM-DD'), 'SILA', 120);


-- =========================================================
-- 8. IGRAC
-- =========================================================
REM INSERTING into IGRAC
SET DEFINE OFF;
INSERT INTO IGRAC (ime, prezime, pol, nadimak, lozinka, uzrast, naziv_tima) VALUES ('Stefan', 'Petkovic', 'M', 'stefy', 'stefy123', 25, 'SILA');
INSERT INTO IGRAC (ime, prezime, pol, nadimak, lozinka, uzrast, naziv_tima) VALUES ('Anastasija', 'Popovic', 'Z', 'asija', 'asija456', 21, 'SILA');
INSERT INTO IGRAC (ime, prezime, pol, nadimak, lozinka, uzrast, naziv_tima) VALUES ('Lazar', 'Markovic', 'M', 'laza', 'laza789', 24, 'SILA');
INSERT INTO IGRAC (ime, prezime, pol, nadimak, lozinka, uzrast, naziv_tima) values ('Ivana','Rajkovic','Z', 'rivana','rivana246',22,'SILA');


-- =========================================================
-- 9. lik (triger puni ID)
-- =========================================================
REM INSERTING INTO lik
SET DEFINE OFF;
INSERT INTO lik ( stepen_zamora, iskustvo, kolicina_zlata, nivo_zdravstvenog_stanja, naziv_rase, naziv_klase, id_igraca) values (50,150,170,100,'Vilenjak','Oklopnik', 100000);
INSERT INTO lik ( stepen_zamora, iskustvo, kolicina_zlata, nivo_zdravstvenog_stanja, naziv_rase, naziv_klase, id_igraca) values (40,170,200,200,'Patuljak','Carobnjak', 100001);
INSERT INTO lik ( stepen_zamora, iskustvo, kolicina_zlata, nivo_zdravstvenog_stanja, naziv_rase, naziv_klase, id_igraca) values (30,100,120,80,'Ork','Lopov', 100002);
INSERT INTO lik ( stepen_zamora, iskustvo, kolicina_zlata, nivo_zdravstvenog_stanja, naziv_rase, naziv_klase, id_igraca) values (20,300,250,300,'Covek','Svestenik', 100003);





-- =========================================================
-- 10. POMOCNIK
-- =========================================================
REM INSERTING into POMOCNIK
SET DEFINE OFF;
INSERT INTO POMOCNIK (id_igraca, ime, bonus_zastite, naziv_rase, naziv_klase) VALUES (100000, 'Stanca', 100, 'Demon', 'Oklopnik');
INSERT INTO POMOCNIK (id_igraca, ime, bonus_zastite, naziv_rase, naziv_klase) VALUES (100001, 'Lola', 90, 'Vilenjak', 'Lopov');
INSERT INTO POMOCNIK (id_igraca, ime, bonus_zastite, naziv_rase, naziv_klase) VALUES (100002, 'Boka', 100, 'Covek', 'Carobnjak');
INSERT INTO POMOCNIK (id_igraca, ime, bonus_zastite, naziv_rase, naziv_klase) VALUES (100002, 'Ika', 140, 'Vilenjak', 'Borac');

-- =========================================================
-- 11. SESIJA
-- =========================================================
REM INSERTING into SESIJA
SET DEFINE OFF;
INSERT INTO SESIJA (xp_poeni, kolicina_zlato, vreme_pocetka, vreme_trajanja, id_igraca) VALUES (400, 90, TO_DATE('2024-05-01','YYYY-MM-DD'), 100.5, 100000);
INSERT INTO SESIJA (xp_poeni, kolicina_zlato, vreme_pocetka, vreme_trajanja, id_igraca) VALUES (500, 180, TO_DATE('2024-05-02','YYYY-MM-DD'), 120.8, 100001);
INSERT INTO SESIJA (xp_poeni, kolicina_zlato, vreme_pocetka, vreme_trajanja, id_igraca) VALUES (600, 150, TO_DATE('2024-05-01','YYYY-MM-DD'), 150.9, 100002);
INSERT INTO SESIJA (xp_poeni, kolicina_zlato, vreme_pocetka, vreme_trajanja, id_igraca) VALUES (300, 80, TO_DATE('2024-05-02','YYYY-MM-DD'), 80.6, 100003);


-- =========================================================
-- 12. CAROBNJAK_MAGIJE
-- =========================================================

REM INSERTING into CAROBNJAK_MAGIJE
SET DEFINE OFF;
INSERT INTO carobnjak_magije (id_carobnjaka, magija) VALUES ('Carobnjak', 'Vatra');
INSERT INTO carobnjak_magije (id_carobnjaka, magija) VALUES ('Carobnjak', 'Voda');
INSERT INTO carobnjak_magije (id_carobnjaka, magija) VALUES ('Carobnjak', 'Hipnoza');

-- =========================================================
-- 13. SVESTENIK_BLAGOSLOV
-- =========================================================

REM INSERTING into SVESTENIK_BLAGOSLOV
SET DEFINE OFF;
INSERT INTO svestenik_blagoslov (id_svestenika, tip_blagoslova) VALUES ('Svestenik', 'Snaga');
INSERT INTO svestenik_blagoslov (id_svestenika, tip_blagoslova) VALUES ('Svestenik', 'Zivot');


-- =========================================================
-- 14. IGRAO
-- =========================================================

REM INSERTING into IGRAO
SET DEFINE OFF;
INSERT INTO igrao (id_igraca, naziv_staze, broj_igranja, broj_savladanih_neprijatelja) VALUES (100000, 'Pustinja', 3, 10);
INSERT INTO igrao (id_igraca, naziv_staze, broj_igranja, broj_savladanih_neprijatelja) VALUES (100000, 'Suma', 5, 50);
INSERT INTO igrao (id_igraca, naziv_staze, broj_igranja, broj_savladanih_neprijatelja) VALUES (100001, 'Pustinja', 1, 3);
INSERT INTO igrao (id_igraca, naziv_staze, broj_igranja, broj_savladanih_neprijatelja) VALUES (100002, 'Suma', 2, 4);
INSERT INTO igrao (id_igraca, naziv_staze, broj_igranja, broj_savladanih_neprijatelja) VALUES (100001, 'Suma', 3, 10);
INSERT INTO igrao (id_igraca, naziv_staze, broj_igranja, broj_savladanih_neprijatelja) VALUES (100003, 'Pustinja', 10, 100);

-- =========================================================
-- 13. IGRAO TIM
-- =========================================================

REM INSERTING into IGRAO_TIM
SET DEFINE OFF;
INSERT INTO igrao_tim (naziv_tima, naziv_staze) VALUES ('SILA', 'Planina');
INSERT INTO igrao_tim (naziv_tima, naziv_staze) VALUES ('Senke', 'Mocvara');
INSERT INTO igrao_tim (naziv_tima, naziv_staze) VALUES ('Vitezovi', 'Planina');

-- =========================================================
-- 14. KORISTI
-- =========================================================

REM INSERTING into KORISTI
SET DEFINE OFF;
INSERT INTO koristi (id_igraca, id_kljucnog_predmeta) VALUES (100000, 100003);
INSERT INTO koristi (id_igraca, id_kljucnog_predmeta) VALUES (100002, 100004);
INSERT INTO koristi (id_igraca, id_kljucnog_predmeta) VALUES (100003, 100003);


-- =========================================================
-- 15. KLJUCNI_ZA
-- =========================================================

REM INSERTING into KLJUCNI_ZA
SET DEFINE OFF;
INSERT INTO kljucni_za (naziv_staze, id_kljucnog_predmeta) VALUES ('Suma', 100004);
INSERT INTO kljucni_za (naziv_staze, id_kljucnog_predmeta) VALUES ('Pustinja', 100003);

-- =========================================================
-- 15. KUPIO
-- =========================================================

REM INSERTING into KUPIO
SET DEFINE OFF;
INSERT INTO kupio (id_igraca, id_opreme) VALUES (100000, 100000);
INSERT INTO kupio (id_igraca, id_opreme) VALUES (100001, 100001);
INSERT INTO kupio (id_igraca, id_opreme) VALUES (100002, 100002);
INSERT INTO kupio (id_igraca, id_opreme) VALUES (100003, 100002);

-- =========================================================
-- 16. MOZE_ISKORISTITI
-- =========================================================

REM INSERTING into MOZE_ISKORISTITI
SET DEFINE OFF;
INSERT INTO moze_iskoristiti (id_predmeta, naziv_rase) VALUES (100000, 'Vilenjak');
INSERT INTO moze_iskoristiti (id_predmeta, naziv_rase) VALUES (100000, 'Ork');
INSERT INTO moze_iskoristiti (id_predmeta, naziv_rase) VALUES (100002, 'Covek');



-- =========================================================
-- 17. MOZE_KORISTITI_RASE
-- =========================================================

REM INSERTING into MOZE_KORISTITI_RASE
SET DEFINE OFF;
INSERT INTO MOZE_KORISTITI_RASE (id_opreme, naziv_rase)VALUES (100000, 'Vilenjak');
INSERT INTO MOZE_KORISTITI_RASE (id_opreme, naziv_rase)VALUES (100001, 'Patuljak');
INSERT INTO MOZE_KORISTITI_RASE (id_opreme, naziv_rase)VALUES (100002, 'Ork');
INSERT INTO MOZE_KORISTITI_RASE (id_opreme, naziv_rase)VALUES (100002, 'Covek');


-- =========================================================
-- 18. MOZE_KORISTITI_RASE
-- =========================================================

REM INSERTING into MOZE_KORISTITI_KLASE
SET DEFINE OFF;
INSERT INTO MOZE_KORISTITI_KLASE (id_opreme, naziv_klase)VALUES (100000, 'Oklopnik');
INSERT INTO MOZE_KORISTITI_KLASE (id_opreme, naziv_klase)VALUES (100001, 'Carobnjak');
INSERT INTO MOZE_KORISTITI_KLASE (id_opreme, naziv_klase)VALUES (100002, 'Lopov');
INSERT INTO MOZE_KORISTITI_KLASE (id_opreme, naziv_klase)VALUES (100002, 'Svestenik');

-- =========================================================
-- 19. NALAZI_SE_NA
-- =========================================================

REM INSERTING into NALAZI_SE_NA
SET DEFINE OFF;
INSERT INTO NALAZI_SE_NA (id_predmeta, naziv_staze) VALUES (100004, 'Pustinja');
INSERT INTO NALAZI_SE_NA (id_predmeta, naziv_staze) VALUES (100003, 'Suma');
INSERT INTO NALAZI_SE_NA (id_predmeta, naziv_staze) VALUES (100003, 'Pustinja');

-- =========================================================
-- 20. UCESTVOVAO_U
-- =========================================================

REM INSERTING into UCESTVOVAO_U
SET DEFINE OFF;
INSERT INTO UCESTVOVAO_U (naziv_tima, id_borbe, plasman) VALUES ('Vitezovi', 1000000000, 1);
INSERT INTO UCESTVOVAO_U (naziv_tima, id_borbe, plasman) VALUES ('Senke', 1000000001, 1);
INSERT INTO UCESTVOVAO_U (naziv_tima, id_borbe, plasman) VALUES ('SILA', 1000000002, 1);
INSERT INTO UCESTVOVAO_U (naziv_tima, id_borbe, plasman) VALUES ('SILA', 1000000000, 2);
INSERT INTO UCESTVOVAO_U (naziv_tima, id_borbe, plasman) VALUES ('SILA', 1000000001, 3);

-- =========================================================
-- 21. ZAHTEVA_KLASU
-- =========================================================

REM INSERTING into ZAHTEVA_KLASU
SET DEFINE OFF;
INSERT INTO ZAHTEVA_KLASU (naziv_staze, naziv_klase) VALUES ('Pustinja', 'Oklopnik');
INSERT INTO ZAHTEVA_KLASU (naziv_staze, naziv_klase) VALUES ('Suma', 'Carobnjak');
INSERT INTO ZAHTEVA_KLASU (naziv_staze, naziv_klase) VALUES ('Planina', 'Lopov');

-- =========================================================
-- 22. ZAHTEVA_RASU
-- =========================================================

REM INSERTING into ZAHTEVA_RASU
SET DEFINE OFF;
INSERT INTO ZAHTEVA_RASU (naziv_staze, naziv_rase) VALUES ('Suma', 'Patuljak');
INSERT INTO ZAHTEVA_RASU (naziv_staze, naziv_rase) VALUES ('Mocvara', 'Ork');


