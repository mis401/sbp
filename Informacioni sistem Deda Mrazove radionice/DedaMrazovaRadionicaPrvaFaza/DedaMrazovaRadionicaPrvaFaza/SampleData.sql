
INSERT INTO DETE (Ime, Prezime, Drzava, Grad, Adresa, Datum_rodjenja) 
VALUES 
('Ana', 'Jankovic', 'Srbija', 'Beograd', 'Kneza Milosa 45', TO_DATE('15.05.2020', 'DD.MM.YYYY'));
INSERT INTO DETE (Ime, Prezime, Drzava, Grad, Adresa, Datum_rodjenja) 
VALUES 
('Marko', 'Novak', 'Hrvatska', 'Zagreb', 'Ilica 25', TO_DATE('10.02.2021', 'DD.MM.YYYY'));
INSERT INTO DETE (Ime, Prezime, Drzava, Grad, Adresa, Datum_rodjenja) 
VALUES 
('Jana', 'Horvat', 'Slovenija', 'Ljubljana', 'Trg Republike 2', TO_DATE('05.01.2022', 'DD.MM.YYYY'));
INSERT INTO DETE (Ime, Prezime, Drzava, Grad, Adresa, Datum_rodjenja) 
VALUES 
('Milan', 'Popovic', 'Srbija', 'Novi Sad', 'Bulevar Oslobodjenja 66', TO_DATE('20.07.2022', 'DD.MM.YYYY'));
INSERT INTO DETE (Ime, Prezime, Drzava, Grad, Adresa, Datum_rodjenja) 
VALUES 
('Lea', 'Kovac', 'Hrvatska', 'Split', 'Poljicka cesta 20', TO_DATE('11.03.2023', 'DD.MM.YYYY'));

INSERT INTO PISMO (Tekst, Indeks_dobrote, ID_Deteta, Datum_slanja, Datum_prijema)
VALUES 
('Dragi Deda Mraze, ja bih zelela plisanog medu i crveni sesir.', 8, 1, TO_DATE('05.12.2021', 'DD.MM.YYYY'),TO_DATE('15.12.2021', 'DD.MM.YYYY'));
INSERT INTO PISMO (Tekst, Indeks_dobrote, ID_Deteta, Datum_slanja, Datum_prijema)
VALUES
('Dragi Deda Mraze, ja bih zeleo automobil na daljinski upravljac i crni sal.', 7, 2, TO_DATE('05.12.2021', 'DD.MM.YYYY'),TO_DATE('18.12.2021', 'DD.MM.YYYY'));
INSERT INTO PISMO (Tekst, Indeks_dobrote, ID_Deteta, Datum_slanja, Datum_prijema)
VALUES 
('Dragi Deda Mraze, ja bih zelela lutku Pepeljugu i plavu kapu.', 9, 3, TO_DATE('05.12.2021', 'DD.MM.YYYY'),TO_DATE('20.12.2021', 'DD.MM.YYYY'));
INSERT INTO PISMO (Tekst, Indeks_dobrote, ID_Deteta, Datum_slanja, Datum_prijema)
VALUES 
('Dragi Deda Mraze, ja bih zeleo knjigu o zivotinjama', 6, 4, TO_DATE('05.12.2021', 'DD.MM.YYYY'),TO_DATE('17.12.2021', 'DD.MM.YYYY'));
INSERT INTO PISMO (Tekst, Indeks_dobrote, ID_Deteta, Datum_slanja, Datum_prijema)
VALUES 
('Dragi Deda Mraze, ja bih zelela novi bicikl', 10, 5,TO_DATE('05.12.2021', 'DD.MM.YYYY'),TO_DATE('22.12.2021', 'DD.MM.YYYY'));

INSERT INTO LISTA_ZELJA (ID, ID_Pisma)
VALUES 
(1, 1);
INSERT INTO LISTA_ZELJA (ID, ID_Pisma)
VALUES 
(2, 2);
INSERT INTO LISTA_ZELJA (ID, ID_Pisma)
VALUES 
(3, 3);
INSERT INTO LISTA_ZELJA (ID, ID_Pisma)
VALUES 
(4, 4);
INSERT INTO LISTA_ZELJA (ID, ID_Pisma)
VALUES 
(5, 5);

-- Unos torki u tabelu DEO_RADIONICE
INSERT INTO DEO_RADIONICE (ID, Naziv, Tip_igracke) VALUES
(1, 'Radionica1', 'Metalna');
INSERT INTO DEO_RADIONICE (ID, Naziv, Tip_igracke) VALUES
(2, 'Radionica2', 'Drvena');
INSERT INTO DEO_RADIONICE (ID, Naziv, Tip_igracke) VALUES
(3, 'Radionica3', 'Plisana');
INSERT INTO DEO_RADIONICE (ID, Naziv, Tip_igracke) VALUES
(4, 'Radionica4', 'Plasticna');

-- Unos torki u tabelu MAGIcNA_VEsTINA
INSERT INTO MAGICNA_VESTINA (Naziv, ID_Dela_radionice) VALUES
('Lebdeci stapici', 1);
INSERT INTO MAGICNA_VESTINA (Naziv, ID_Dela_radionice) VALUES
('Carobni sesiri', 2);
INSERT INTO MAGICNA_VESTINA (Naziv, ID_Dela_radionice) VALUES
('Magicni plis', 3);
INSERT INTO MAGICNA_VESTINA (Naziv, ID_Dela_radionice) VALUES
('Sjajna mehanika', 4);
INSERT INTO MAGICNA_VESTINA (Naziv, ID_Dela_radionice) VALUES
('Rastegljiva plastika', 1);
INSERT INTO MAGICNA_VESTINA (Naziv, ID_Dela_radionice) VALUES
('Knjiga cini', 2);

INSERT INTO TOVAR (ID, Grad)
VALUES
    (1, 'Beograd');
INSERT INTO TOVAR (ID, Grad)
VALUES
    (2, 'Zagreb');
INSERT INTO TOVAR (ID, Grad)
VALUES
    (3, 'Ljubljana');
INSERT INTO TOVAR (ID, Grad)
VALUES
    (4, 'Novi Sad');
INSERT INTO TOVAR (ID, Grad)
VALUES
    (5, 'Split');


-- Unos torki u tabelu IRVAS
INSERT INTO IRVAS (ID, Ime, Nadimak, Pol, Datum_rodjenja) VALUES
(1, 'Dancer', 'Dan', 'Z', TO_DATE('12.06.2020', 'DD.MM.YYYY'));
INSERT INTO IRVAS (ID, Ime, Nadimak, Pol, Datum_rodjenja) VALUES
(2, 'Prancer', 'Pran', 'M', TO_DATE('01.07.2020', 'DD.MM.YYYY'));
INSERT INTO IRVAS (ID, Ime, Nadimak, Pol, Datum_rodjenja) VALUES
(3, 'Vixen', 'Viks', 'Z', TO_DATE('11.08.2020', 'DD.MM.YYYY'));
INSERT INTO IRVAS (ID, Ime, Nadimak, Pol, Datum_rodjenja) VALUES
(4, 'Comet', 'Com', 'M', TO_DATE('15.01.2020', 'DD.MM.YYYY'));
INSERT INTO IRVAS (ID, Ime, Nadimak, Pol, Datum_rodjenja) VALUES
(5, 'Cupid', 'Cup', 'M', TO_DATE('08.02.2020', 'DD.MM.YYYY'));
INSERT INTO IRVAS (ID, Ime, Nadimak, Pol, Datum_rodjenja) VALUES
(6, 'Blitzen', 'Blitz', 'Z', TO_DATE('25.03.2020', 'DD.MM.YYYY'));


INSERT INTO TIM (ID, Naziv)
VALUES
    (1, 'Tim 1');
iNSERT INTO TIM (ID, Naziv)
VALUES
    (2, 'Tim 2');
INSERT INTO TIM (ID, Naziv)
VALUES
    (3, 'Tim 3');
INSERT INTO TIM (ID, Naziv)
VALUES
    (4, 'Tim 4');
INSERT INTO TIM (ID, Naziv)
VALUES
    (5, 'Tim 5');
	

INSERT INTO VILENJAK_ZA_IRVASE(Ime, Zemlja_porekla, Datum_zaposljavanja, ID_Irvasa)
VALUES 
	('Pospanko', 'Finska', TO_DATE('01.12.2021', 'DD.MM.YYYY'), 6);
INSERT INTO VILENJAK_ZA_IRVASE(Ime, Zemlja_porekla, Datum_zaposljavanja, ID_Irvasa)
VALUES
	('Stidljivko', 'Svedska', TO_DATE('12.10.2021', 'DD.MM.YYYY'), 4);

	

INSERT INTO VILENJAK_ZA_IZRADU_IGRACAKA(Ime, Zemlja_porekla, Datum_zaposljavanja, Tip_materijala, Flag_koordinator, ID_tima, Flag_sef, Datum_postavljanja, ID_Dela_radionice, ID_Mentora, Ocena, Duzina_obuke)
VALUES
	 ('Kefalo', 'Holandija', TO_DATE('11.12.2018', 'DD.MM.YYYY'), 'Tkanina', 1, 4, 1, TO_DATE('05.06.2020', 'DD.MM.YYYY'), 3, NULL, NULL, NULL);
INSERT INTO VILENJAK_ZA_IZRADU_IGRACAKA(Ime, Zemlja_porekla, Datum_zaposljavanja, Tip_materijala, Flag_koordinator, ID_tima, Flag_sef, Datum_postavljanja, ID_Dela_radionice, ID_Mentora, Ocena, Duzina_obuke)
VALUES
	('Kijavko', 'Island', TO_DATE('23.08.2021', 'DD.MM.YYYY'), 'Drvo', 0, 3, 1, TO_DATE('30.09.2021', 'DD.MM.YYYY'), 1, 2, 8, 3);
INSERT INTO VILENJAK_ZA_IZRADU_IGRACAKA(Ime, Zemlja_porekla, Datum_zaposljavanja, Tip_materijala, Flag_koordinator, ID_tima, Flag_sef, Datum_postavljanja, ID_Dela_radionice, ID_Mentora, Ocena, Duzina_obuke)
VALUES	
	('Mrgud', 'Belgija', TO_DATE('17.11.2021', 'DD.MM.YYYY'),'Plastika', 1, 1, 1, TO_DATE('03.07.2022', 'DD.MM.YYYY'), 4, 2, 10, 4);
INSERT INTO VILENJAK_ZA_IZRADU_IGRACAKA(Ime, Zemlja_porekla, Datum_zaposljavanja, Tip_materijala, Flag_koordinator, ID_tima, Flag_sef, Datum_postavljanja, ID_Dela_radionice, ID_Mentora, Ocena, Duzina_obuke)
VALUES	
	'Gricko', 'Francuska', TO_DATE('08.12.2021', 'DD.MM.YYYY'), 'Metal', 0, 5, 0, NULL, 1, 1, 6, 2);
INSERT INTO VILENJAK_ZA_IZRADU_IGRACAKA(Ime, Zemlja_porekla, Datum_zaposljavanja, Tip_materijala, Flag_koordinator, ID_tima, Flag_sef, Datum_postavljanja, ID_Dela_radionice, ID_Mentora, Ocena, Duzina_obuke)
VALUES		
	('Cekicar', 'Italija', TO_DATE('17.05.2021', 'DD.MM.YYYY'),'Tkanina', 1, 5, 1, TO_DATE('01.02.2022', 'DD.MM.YYYY'), 2, 1, 9, 7);
INSERT INTO VILENJAK_ZA_IZRADU_IGRACAKA(Ime, Zemlja_porekla, Datum_zaposljavanja, Tip_materijala, Flag_koordinator, ID_tima, Flag_sef, Datum_postavljanja, ID_Dela_radionice, ID_Mentora, Ocena, Duzina_obuke)
VALUES		
	('Njuskalo', 'Nemacka', TO_DATE('15.03.2020', 'DD.MM.YYYY'),'Plastika', 0, 1, 0, NULL, 2, 4, 7, 1);
INSERT INTO VILENJAK_ZA_IZRADU_IGRACAKA(Ime, Zemlja_porekla, Datum_zaposljavanja, Tip_materijala, Flag_koordinator, ID_tima, Flag_sef, Datum_postavljanja, ID_Dela_radionice, ID_Mentora, Ocena, Duzina_obuke)
VALUES	
	('Smesko', 'Italija', TO_DATE('17.05.2023', 'DD.MM.YYYY'), 'Papir', 0,3, 0,NULL, 3, 6, 10, 8);

INSERT INTO VILENJAK_ZA_ISPORUKU_POKLONA(Ime, Zemlja_porekla, Datum_zaposljavanja, ID_Tovara)
VALUES 
	 ('Tupko', 'Danska', TO_DATE('05.12.2021', 'DD.MM.YYYY'), 4);
	 
	 
INSERT INTO VILENJAK_ZA_POKLON (Ime, Zemlja_porekla, Datum_zaposljavanja)
VALUES
    ('Srecko', 'Norveska', TO_DATE('14.11.2019', 'DD.MM.YYYY'));






INSERT INTO POKLON (Boja, Posveta, ID_Liste_zelja, ID_Tovara)
VALUES 
    ('Crvena', 'Za najposlusnijeg decka', 2, 3);
INSERT INTO POKLON (Boja, Posveta, ID_Liste_zelja, ID_Tovara)
VALUES 
    ('Plava', 'Srecan Bozic', 1, 1);
INSERT INTO POKLON (Boja, Posveta, ID_Liste_zelja, ID_Tovara)
VALUES 
    ('Zelena', 'Za divnu devojcicu', 3, 2);
INSERT INTO POKLON (Boja, Posveta, ID_Liste_zelja, ID_Tovara)
VALUES 
    ('Crvena', 'Za moju dragu', 5, 3);
INSERT INTO POKLON (Boja, Posveta, ID_Liste_zelja, ID_Tovara)
VALUES 
   ('Roza', 'Srecan rodjendan, junace!', 4, 2);



INSERT INTO IGRACKA (ID_Liste_zelja, Redni_broj, Tip, Opis, ID_Poklona, Id_Vilenjaka_za_igracke, ID_Dela_radionice)
VALUES
	(1, 1, 'Plisani meda', 'Napunjen vunom', 2, 5, 3);
INSERT INTO IGRACKA (ID_Liste_zelja, Redni_broj, Tip, Opis, ID_Poklona, Id_Vilenjaka_za_igracke, ID_Dela_radionice)
VALUES
	(1, 2, 'Sesir', 'Zastita od sunca', 2, 6, 4);
INSERT INTO IGRACKA (ID_Liste_zelja, Redni_broj, Tip, Opis, ID_Poklona, Id_Vilenjaka_za_igracke, ID_Dela_radionice)
VALUES
	(2, 1, 'Automobil', 'Daljinsko upravljanje', 1, 6, 4);
INSERT INTO IGRACKA (ID_Liste_zelja, Redni_broj, Tip, Opis, ID_Poklona, Id_Vilenjaka_za_igracke, ID_Dela_radionice)
VALUES
	(2, 2, 'Sal', NULL, 1, 1, 4);
INSERT INTO IGRACKA (ID_Liste_zelja, Redni_broj, Tip, Opis, ID_Poklona, Id_Vilenjaka_za_igracke, ID_Dela_radionice)
VALUES
	(3, 1, 'Lutka', NULL, 3, 2, 4);
INSERT INTO IGRACKA (ID_Liste_zelja, Redni_broj, Tip, Opis, ID_Poklona, Id_Vilenjaka_za_igracke, ID_Dela_radionice)
VALUES
	(3, 2, 'Kapa', 'Pletena kapa', 3,5 , 3);
INSERT INTO IGRACKA (ID_Liste_zelja, Redni_broj, Tip, Opis, ID_Poklona, Id_Vilenjaka_za_igracke, ID_Dela_radionice)
VALUES
	(4, 1, 'Knjiga', 'Knjiga o zivotanjama', 3, 7, 2);
INSERT INTO IGRACKA (ID_Liste_zelja, Redni_broj, Tip, Opis, ID_Poklona, Id_Vilenjaka_za_igracke, ID_Dela_radionice)
VALUES
	(5, 1, 'Bicikl', NULL, 4, 4, 1);
	

INSERT INTO PESMA (ID_Vilenjaka_za_irvase, Naziv, Tekst)
VALUES
	(1, 'Deck the Halls', 'Fa la la la la, la la la la
Fa la la la la, la la la la
Oh no no
Deck the halls with boughs of holly
Fa la la la la, la la la la (fa la la la la, la la la la)
This the season to be jolly
Fa la la la la, la la la la fa la la la la, la la la la
Don we now our gay apparel
Fa la la la la, la la la la fa la la la la, la la la la
Troll the ancient Yuletide carol
Fa la la la la, la la la la
Fa la la la la, la la la la la la
Fa la la la la, fa la la la
Fa la la la la, la la la la la la
Fa la la la la, fa la la la
See the blazing yule before us
Fa la la la la, la la la la fa la la la la, la la la la
Strike the harp and join the chorus
Fa la la la la, la la la, fa la la la la, la la la
Follow me in merry measure
Fa la la la la, la la la la, fa la la la la, la la la la
While I tell of Yuletide treasure
Fa la la la la, la la la la
Fa la la la la, la la la la la la
Fa la la la la, fa la la la
Fa la la la la, la la la la la la
Fa la la la la, fa la la la
Fast away, the old year passes
Fa la la la la, la la la la fa la la la la, la la la la
Hail the new, ye lads and lasses
(a la la, la la la, la la la, la la la, fa la la, la la la, la la la la
Sing we joyous all together, oh
Heedless of the wind and weather
Fa la la la la, la la la la (hey)
Fa la la la la, la la la la la la (oh)
Fa la la la la, fa la la la (oh)
Oh oh fa la la la la, la la la la la la
Fa la la la la, fa la la la
Deck the halls with boughs of holly
Fa la la la la, la la la la
This the season to be jolly
Fa la la la la, la la la la
Don we now our gay apparel
Fa la la la la, la la la la
Troll the ancient Yuletide carol
Fa la la la la, la la la la
Fa la la la la, la la la la
Fa la la la la, la la la la
La la la la, la la la la');
INSERT INTO PESMA (ID_Vilenjaka_za_irvase, Naziv, Tekst)
VALUES
	(1,'Will the circle be unbroken', 'Will The Circle Be Unbroken
(feat. Jerry Lee Lewis and Carl Perkins)

I was standing by the window
On one cold and cloudy day
When I saw the hearse come rolling
For to carry my mother away

Will the circle be unbroken
By and by Lord, by and by
Theres a better home awaiting
In the sky Lord, in the sky

I said to the undertaker
Undertaker please drive slow
For this lady you are carrying
Lord I hate to see her go

Will the circle be unbroken
By and by Lord, by and by
Theres a better home awaiting
In the sky Lord, in the sky

Oh, I followed close behind her
Tried to hold up and be brave
But I could not hide my sorrow
When they laid her in the grave

Will the circle be unbroken
By and by Lord, by and by
Theres a better home awaiting
In the sky Lord, in the sky

I went back home, the home was lonesome
Since my mother, she was gone
All my brothers and sisters crying
What a home so sad and alone

Will the circle be unbroken
By and by Lord, by and by
Theres a better home awaiting
In the sky Lord, in the sky

We sang songs of childhood
Hymns of faith that made us strong
Ones that mother maybelle taught us
Hear the angels sing along

Will the circle be unbroken
By and by Lord, by and by
Theres a better home awaiting
In the sky Lord, in the sky');
INSERT INTO PESMA (ID_Vilenjaka_za_irvase, Naziv, Tekst)
VALUES
	(2, 'Eyes on fire', 'Ill seek you out
Flay you alive
One more word and you wont survive
And Im not scared
Of your stolen power
I see right through you any hour
I wont soothe your pain
I wont ease your strain
Youll be waiting in vain
I got nothing for you to gain
Im taking it slow
Feeding my flame
Shuffling the cards of your game
And just in time
In the right place
Suddenly, I will play my ace
I wont soothe your pain
I wont ease your strain
Youll be waiting in vain
I got nothing for you to gain
Eyes on fire
Your spine is ablaze
Felling any foe with my gaze
And just in time
In the right place
Steadily emerging with grace
Ahh, felling any foe with my gaze
Ahh, steadily emerging with grace
Ahh, felling any foe with my gaze
Ahh, steadily emerging with grace');

INSERT INTO IRVAS_ISPORUCUJE_TOVAR (ID_Irvasa, ID_Tovara)
VALUES
	(2,3);
INSERT INTO IRVAS_ISPORUCUJE_TOVAR (ID_Irvasa, ID_Tovara)
VALUES
	(6,3);
INSERT INTO IRVAS_ISPORUCUJE_TOVAR (ID_Irvasa, ID_Tovara)
VALUES
	(6,4);
INSERT INTO IRVAS_ISPORUCUJE_TOVAR (ID_Irvasa, ID_Tovara)
VALUES
	(3,3);
INSERT INTO IRVAS_ISPORUCUJE_TOVAR (ID_Irvasa, ID_Tovara)
VALUES
	(1,1);
INSERT INTO IRVAS_ISPORUCUJE_TOVAR (ID_Irvasa, ID_Tovara)
VALUES
	(5,1);
INSERT INTO IRVAS_ISPORUCUJE_TOVAR (ID_Irvasa, ID_Tovara)
VALUES
	(2,2);
INSERT INTO IRVAS_ISPORUCUJE_TOVAR (ID_Irvasa, ID_Tovara)
VALUES
	(4,5);
	
	
	
INSERT INTO PAKOVANJE_POKLONA (ID_Vilenjaka_za_tovar, ID_Poklona)
VALUES
	(1, 4);
INSERT INTO PAKOVANJE_POKLONA (ID_Vilenjaka_za_tovar, ID_Poklona)
VALUES
	(1, 2);
INSERT INTO PAKOVANJE_POKLONA (ID_Vilenjaka_za_tovar, ID_Poklona)
VALUES
	(1, 1);
INSERT INTO PAKOVANJE_POKLONA (ID_Vilenjaka_za_tovar, ID_Poklona)
VALUES
	(1, 3);
	
	
-- INSERT INTO VILENJAK_POSEDUJE_VESTINU (ID_Vilenjaka, ID_Vestine)
-- VALUES
	-- (9,3);
-- INSERT INTO VILENJAK_POSEDUJE_VESTINU (ID_Vilenjaka, ID_Vestine)
-- VALUES
	-- (10,2);
-- INSERT INTO VILENJAK_POSEDUJE_VESTINU (ID_Vilenjaka, ID_Vestine)
-- VALUES
	-- (7,5);
-- INSERT INTO VILENJAK_POSEDUJE_VESTINU (ID_Vilenjaka, ID_Vestine)
-- VALUES
	-- (2,3);
-- INSERT INTO VILENJAK_POSEDUJE_VESTINU (ID_Vilenjaka, ID_Vestine)
-- VALUES
	-- (7,3);
-- INSERT INTO VILENJAK_POSEDUJE_VESTINU (ID_Vilenjaka, ID_Vestine)
-- VALUES
	-- (9,2);
-- INSERT INTO VILENJAK_POSEDUJE_VESTINU (ID_Vilenjaka, ID_Vestine)
-- VALUES
	-- (2,6);
-- INSERT INTO VILENJAK_POSEDUJE_VESTINU (ID_Vilenjaka, ID_Vestine)
-- VALUES
	-- (8,6);

INSERT INTO DETE_RODITELJ (ID_Deteta, Ime_roditelja)
VALUES
	(1, 'Dragan Jankovic');
INSERT INTO DETE_RODITELJ (ID_Deteta, Ime_roditelja)
VALUES
	(1, 'Marija Jankovic');
INSERT INTO DETE_RODITELJ (ID_Deteta, Ime_roditelja)
VALUES
	(2, 'Dusko Novak');
INSERT INTO DETE_RODITELJ (ID_Deteta, Ime_roditelja)
VALUES
	(2, 'Leontina Novak');
INSERT INTO DETE_RODITELJ (ID_Deteta, Ime_roditelja)
VALUES
	(3, 'Danijel Horvat');
INSERT INTO DETE_RODITELJ (ID_Deteta, Ime_roditelja)
VALUES
	(3, 'Sandra Horvat');
INSERT INTO DETE_RODITELJ (ID_Deteta, Ime_roditelja)
VALUES
	(4, 'Slobodan Popovic');
INSERT INTO DETE_RODITELJ (ID_Deteta, Ime_roditelja)
VALUES
	(5, 'Milutin Kovac');
INSERT INTO DETE_RODITELJ (ID_Deteta, Ime_roditelja)
VALUES
	(5, 'Aleksandra Kovac');