		--Insert into AUTOMOBIL (BAR_KOD,NAZIV_SERIJE,BATERIJE) values ('14','Serija B','Da');

		INSERT INTO DETE (Ime, Prezime, Drzava, Grad, Adresa, Datum_Rodjenja) 
		VALUES ('Mihajlo', 'Bencun', 'Republika Srbija', 'Vranje', 'Viktora Bubnja 22/1-2', TO_DATE('17.05.2001', 'DD.MM.YYYY'));

		INSERT INTO DETE (Ime, Prezime, Drzava, Grad, Adresa, Datum_Rodjenja) 
		VALUES ('Andjelija', 'Mijajlovic', 'Republika Srbija', 'Kursumlija', 'Drinke Pavlovic 62', TO_DATE('11.12.2001', 'DD.MM.YYYY'));

		INSERT INTO DETE (Ime, Prezime, Drzava, Grad, Adresa, Datum_Rodjenja) 
		VALUES ('Anita', 'Aleksic', 'Kina', 'Peking', 'Betovenova 15', TO_DATE('17.11.2001', 'DD.MM.YYYY'));

		INSERT INTO DETE (Ime, Prezime, Drzava, Grad, Adresa, Datum_Rodjenja) 
		VALUES ('Andjela', 'Miletic', 'Italija', 'Rim', 'Struma 5', TO_DATE('22.11.2001', 'DD.MM.YYYY'));


		INSERT INTO PISMO (Tekst, Indeks_dobrote, ID_Deteta, Datum_slanja, Datum_prijema) 
		VALUES ('Dragi Deda Mraze, srecna Nova godina i Bozicni praznici!', 2.00, 1, TO_DATE('17.12.2022', 'DD.MM.YYYY'), TO_DATE('25.12.2022', 'DD.MM.YYYY'));
		INSERT INTO PISMO (Tekst, Indeks_dobrote, ID_Deteta, Datum_slanja, Datum_prijema) 
		VALUES ('Dir Senta, srecna Nova godina i Bozicni praznici!', 2.50, 2, TO_DATE('12.12.2022', 'DD.MM.YYYY'), TO_DATE('20.12.2022', 'DD.MM.YYYY'));
		INSERT INTO PISMO (Tekst, Indeks_dobrote, ID_Deteta, Datum_slanja, Datum_prijema) 
		VALUES ('Dear Santa, srecna Nova godina i Bozicni praznici!', 1.00, 3, TO_DATE('29.12.2022', 'DD.MM.YYYY'), TO_DATE('30.12.2022', 'DD.MM.YYYY'));
		INSERT INTO PISMO (Tekst, Indeks_dobrote, ID_Deteta, Datum_slanja, Datum_prijema) 
		VALUES ('Dear, srecna Nova godina i Bozicni praznici!', 8.00, 4, TO_DATE('23.12.2022', 'DD.MM.YYYY'), TO_DATE('28.12.2022', 'DD.MM.YYYY'));
		
		
		INSERT INTO LISTA_ZELJA(ID_Pisma) 
		VALUES (1);
		INSERT INTO LISTA_ZELJA(ID_Pisma) 
		VALUES (2);
		INSERT INTO LISTA_ZELJA(ID_Pisma) 
		VALUES (3);
		INSERT INTO LISTA_ZELJA(ID_Pisma) 
		VALUES (4);
		
		INSERT INTO IGRACKA(ID_Liste_zelja, Redni_broj, Tip, Opis, ID_Poklona, ID_Vilenjaka, ID_Dela_radionice)
		VALUES (1, 1, 'Plasticna', 'Vojnik', 1, 1, 2);
		INSERT INTO IGRACKA(ID_Liste_zelja, Redni_broj, Tip, Opis, ID_Poklona, ID_Vilenjaka, ID_Dela_radionice)
		VALUES (1, 2, 'Metalna', 'Ford Focus MK1', 1, 2, 1);
		INSERT INTO IGRACKA(ID_Liste_zelja, Redni_broj, Tip, Opis, ID_Poklona, ID_Vilenjaka, ID_Dela_radionice)
		VALUES (1, 3, 'Plasticna', 'Mac', 1, 1, 2);
		INSERT INTO IGRACKA(ID_Liste_zelja, Redni_broj, Tip, Opis, ID_Poklona, ID_Vilenjaka, ID_Dela_radionice)
		VALUES (1, 4, 'Plasticna', 'Pistolj na kuglice', 1, 3, 1);
		INSERT INTO IGRACKA(ID_Liste_zelja, Redni_broj, Tip, Opis, ID_Poklona, ID_Vilenjaka, ID_Dela_radionice)
		VALUES (2, 1, 'Papirni', '100e', 2, );
		INSERT INTO IGRACKA(ID_Liste_zelja, Redni_broj, Tip, Opis, ID_Poklona, ID_Vilenjaka, ID_Dela_radionice)
		VALUES (2, 2, 'Plasticna', 'Decko');
		INSERT INTO IGRACKA(ID_Liste_zelja, Redni_broj, Tip, Opis, ID_Poklona, ID_Vilenjaka, ID_Dela_radionice)
		VALUES (2, 3, 'Plasticna', 'Flasa rakije');
		INSERT INTO IGRACKA(ID_Liste_zelja, Redni_broj, Tip, Opis, ID_Poklona, ID_Vilenjaka, ID_Dela_radionice)
		VALUES (3, 1, 'Metalna', 'Neunistiva flasa');
		INSERT INTO IGRACKA(ID_Liste_zelja, Redni_broj, Tip, Opis, ID_Poklona, ID_Vilenjaka, ID_Dela_radionice)
		VALUES (3, 2, 'Plasticna', 'Vozacka dozvola');
		INSERT INTO IGRACKA(ID_Liste_zelja, Redni_broj, Tip, Opis, ID_Poklona, ID_Vilenjaka, ID_Dela_radionice)
		VALUES (4, 1, 'Svilena', 'Vencanica');
		INSERT INTO IGRACKA(ID_Liste_zelja, Redni_broj, Tip, Opis, ID_Poklona, ID_Vilenjaka, ID_Dela_radionice)
		VALUES (4, 2, 'Plasticna', 'Kolevka');
		INSERT INTO IGRACKA(ID_Liste_zelja, Redni_broj, Tip, Opis, ID_Poklona, ID_Vilenjaka, ID_Dela_radionice)
		VALUES (4, 3, 'Plasticna', 'Kolica');	

		
		INSERT INTO DEO_RADIONICE(Naziv, Tip_igracke)
		VALUES ('Srecni ljudi', 'Metalna');
		INSERT INTO DEO_RADIONICE(Naziv, Tip_igracke)
		VALUES ('Porodicno blago', 'Plasticna');
		INSERT INTO DEO_RADIONICE(Naziv, Tip_igracke)
		VALUES ('Otpisani', 'Papirna');
		INSERT INTO DEO_RADIONICE(Naziv, Tip_igracke)
		VALUES ('Bela ladja', 'Svilena');
		
		INSERT INTO TIM(Naziv)
		VALUES ('Salamanka');
		INSERT INTO TIM(Naziv)
		VALUES ('Fring');
		INSERT INTO TIM(Naziv)
		VALUES ('Mehiko');
		INSERT INTO TIM(Naziv)
		VALUES ('Autoboti');
		INSERT INTO TIM(Naziv)
		VALUES ('Deseptikoni');
		
		
		INSERT INTO VILENJAK(
		Ime, 
		Zemlja_porekla, 
		Datum_zaposljavanja, 
		Vrsta_vilenjaka,
		ID_Irvasa,
		ID_Tovara,
		Tip_materijala,
		Flag_koordinator, 
		ID_Tima, 
		Flag_sef, 
		Datum_postavljanja, 
		ID_Mentora, 
		Ocena, 
		Duzina_obuke)
		VALUES ('Uca', 'Slovacka', TO_DATE('13.05.2016', 'DD.MM.YYYY'), 'Izrada igracaka', NULL, NULL,'Plastika', 1, 4, 0, NULL, 2, 8, 20);
	--1
		INSERT INTO VILENJAK(
		Ime, 
		Zemlja_porekla, 
		Datum_zaposljavanja, 
		Vrsta_vilenjaka,
		ID_Irvasa,
		ID_Tovara, 
		Tip_materijala,
		Flag_koordinator, 
		ID_Tima, 
		Flag_sef, 
		Datum_postavljanja, 
		ID_Mentora, 
		Ocena, 
		Duzina_obuke)
		VALUES ('Ljutko', 'Finska', TO_DATE('10.01.2013', 'DD.MM.YYYY'), 'Izrada igracaka', NULL, NULL, 'Metal', 0, 5, 0, NULL, NULL, NULL, NULL);
	--2	
		INSERT INTO VILENJAK(
		Ime, 
		Zemlja_porekla, 
		Datum_zaposljavanja, 
		Vrsta_vilenjaka,
		ID_Irvasa,
		ID_Tovara, 
		Tip_materijala,
		Flag_koordinator, 
		ID_Tima, 
		Flag_sef, 
		Datum_postavljanja, 
		ID_Mentora, 
		Ocena, 
		Duzina_obuke)
		VALUES ('Pospanko', 'Bugarske', TO_DATE('10.04.2020', 'DD.MM.YYYY'), 'Izrada igracaka', NULL, NULL, 'Plastika', 0, 2, 0, NULL, 4, 6, 40);
	--3	
		INSERT INTO VILENJAK(
		Ime, 
		Zemlja_porekla, 
		Datum_zaposljavanja, 
		Vrsta_vilenjaka,
		ID_Irvasa,
		ID_Tovara,
		Tip_materijala,
		Flag_koordinator, 
		ID_Tima, 
		Flag_sef, 
		Datum_postavljanja, 
		ID_Mentora, 
		Ocena, 
		Duzina_obuke)
		VALUES ('Stidljivko', 'Novi Zeland', TO_DATE('11.10.2017', 'DD.MM.YYYY'), 'Izrada igracaka', NULL, NULL, 'Metal', 0, 5, 0, NULL, 2, 9, 25);
	--4
				INSERT INTO VILENJAK(
		Ime, 
		Zemlja_porekla, 
		Datum_zaposljavanja, 
		Vrsta_vilenjaka,
		ID_Irvasa,
		ID_Tovara,
		Tip_materijala,
		Flag_koordinator, 
		ID_Tima, 
		Flag_sef, 
		Datum_postavljanja, 
		ID_Mentora, 
		Ocena, 
		Duzina_obuke)
		VALUES ('Kijavko', 'Alzir', TO_DATE('03.03.2023', 'DD.MM.YYYY'), 'Izrada igracaka', NULL, NULL, 'Tkanini', 1, 1, 0 NULL, 3, 9, 35);
		
		
		
		
		