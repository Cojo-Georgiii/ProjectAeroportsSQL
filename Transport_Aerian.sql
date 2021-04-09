CREATE DATABASE Transport_Aerian
USE Transport_Aerian

CREATE TABLE Aeroporturi(
id_Aeroport int PRIMARY KEY,
Denumire_Aeroport varchar(20),
Tara varchar(20)
);

CREATE TABLE ModeleAvioane(
id_Model INT PRIMARY KEY,
Nume_Avion varchar(20),
Numar_Locuri int,
id_Aeroport  INT CONSTRAINT FK_ModeleAvioane_Aeroporturi FOREIGN KEY REFERENCES Aeroporturi(id_Aeroport)
);

CREATE TABLE Zboruri(
id_Zboruri int PRIMARY KEY,
Companie_Aeriana varchar(20) ,
Data_Plecare date ,
Oras_Plecare varchar(20),
Oras_Sosire varchar(20),
Pret_Bilet int,
id_Model int CONSTRAINT FK_Zboruri_ModeleAcioane FOREIGN KEY REFERENCES ModeleAvioane(id_Model)		
);

CREATE TABLE Pasageri(
id_Pasageri int PRIMARY KEY,
Nume_Pasager varchar(20),
Prenume_Pasager varchar(20),
Sex_Pasager varchar(1),
Numar_Telefon int ,
id_Zboruri INT CONSTRAINT FK_Pasageri_Zboruri FOREIGN KEY REFERENCES Zboruri(id_Zboruri)
);

insert into Aeroporturi values (1,'Aurel Vlaicu','Romania'),
							   (2,'Glasgow','Marea Britanie'),
							   (3,'Henri Coanda','Romania'),
							   (4,'Bristol','Marea Britanie'),
							   (5,'Berlin','Germania'),
							   (6,'Stockholm-Skavsta','Suedia')

insert into ModeleAvioane values (20,'Boeing-747-8',410,2),
								 (21,'Airbus-A350',370,1),
								 (22,'Boeing-787',330,4),
								 (23,'Boeing-767',200,2),
								 (24,'Airbus-A380',550,6),
								 (25,'Boeing-747-8',410,3),
								 (26,'Boeing-777',400,2),
								 (27,'Airbus-A220',200,1),
								 (28,'Airbus-A380',550,3)

insert into Zboruri values (100,'WizAir','2021-03-23','Bucuresti','Berlin',200,20),
						   (101,'TransAir','2021-02-19','Glasgow','Moscova',300,25),
						   (102,'Tarom','2021-03-10','Bristol','Cluj-Napoca',295,24),
						   (103,'WizAir','2021-04-01','Stockholm','Barcelona',350,28),
						   (104,'GermanWings','2021-01-29','Berlin','Roma',330,23),
						   (105,'GermanWings','2021-02-20','Augsburg','Instanbul',340,22),
						   (106,'Tarom','2021-03-21','Bucuresti','Bristol',280,26),
						   (107,'TransfAir','2021-04-01','Bristol','Paris',310,21),
						   (108,'WizAir','2021-01-21','Londra','Bucuresti',305,27)
						   insert into ModeleAvioane values (29,'Boeing-778',2,1)
						   insert into Zboruri values (109,'Tarom','2021-03-18','Bucuresti','Beijing',600,29)

insert into Pasageri values (011,'Brichiusi','Radu','M',0722122001,100),
							(012,'Andrew','David','M',0733300011,101),
							(013,'Ragnar','Lothbrok','M',073302228,103),
							(014,'Hans','Zimmer','M',0399123901,104),
							(015,'Joita','Marius','M',0488123980,106),
							(016,'Elena','Mihaela','F',0991230123,102),
							(017,'McCarthy','Ema','F',0988113981,105),
							(018,'Dorobantu','Raluca','F',0788128801,108),
							(019,'Cojocaru','Alexandru','M',0789054613,107)
insert into Pasageri values (020,'Obama','Barack','M',0777777777,109),
							(021,'Trump','McDonalds','M',888888888,109)
select * from Aeroporturi
select * from ModeleAvioane
select * from Zboruri
select * from Pasageri

create procedure ps_Locuri(@id_Zboruri int,@plin int output)
as 
if ((select count(id_Pasageri) from Pasageri where id_Zboruri = @id_Zboruri ) =(select Numar_Locuri from ModeleAvioane,Zboruri where ModeleAvioane.id_Model=Zboruri.id_Model and id_Zboruri=@id_Zboruri) ) 
select @plin=1
else
select @plin=0
 
 