# Ödev 8 | CREATE TABLE, DROP TABLE, UPDATE, DELETE
#### *1-Test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.*
```sql
CREATE TABLE employee(
	id SERIAL PRIMARY KEY,
	name VARCHAR(50),
	birthday DATE,
	email VARCHAR(100)
);
```
#### *2-Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.*
```sql
insert into employee (name, birthday, email) values ('Angeli Fransewich', '1988-01-25', 'afransewich0@ftc.gov');
insert into employee (name, birthday, email) values ('Bethena Theodoris', '1980-09-07', 'btheodoris1@themeforest.net');
insert into employee (name, birthday, email) values ('Ingunna Keaton', '1980-06-18', 'ikeaton2@twitpic.com');
insert into employee (name, birthday, email) values ('Morey Dy', '2018-03-03', 'mdy3@squidoo.com');
insert into employee (name, birthday, email) values ('Olivier Landrieu', '2001-08-09', 'olandrieu4@yellowbook.com');
insert into employee (name, birthday, email) values ('Ramsey Carslake', '1973-07-10', 'rcarslake5@bbc.co.uk');
insert into employee (name, birthday, email) values ('Sandye Paxman', '1995-08-18', 'spaxman6@smh.com.au');
insert into employee (name, birthday, email) values ('Estrella Stirtle', '1989-12-06', 'estirtle7@psu.edu');
insert into employee (name, birthday, email) values ('Ashien Gehrels', '2011-07-23', 'agehrels8@tuttocitta.it');
insert into employee (name, birthday, email) values ('Dominica Livingston', '1972-05-12', 'dlivingston9@wordpress.com');
insert into employee (name, birthday, email) values ('Allx Ethelstone', '2021-08-17', 'aethelstonea@squidoo.com');
insert into employee (name, birthday, email) values ('Gabbie McKain', '1974-01-18', 'gmckainb@dailymotion.com');
insert into employee (name, birthday, email) values ('Rockwell Salzen', '2018-06-26', 'rsalzenc@yale.edu');
insert into employee (name, birthday, email) values ('Grata Mumby', '2009-09-16', 'gmumbyd@com.com');
insert into employee (name, birthday, email) values ('Nobe Scohier', '2015-09-05', 'nscohiere@npr.org');
insert into employee (name, birthday, email) values ('Shell Seif', '2008-06-17', 'sseiff@cargocollective.com');
insert into employee (name, birthday, email) values ('Kalli Golder', '2009-10-01', 'kgolderg@people.com.cn');
insert into employee (name, birthday, email) values ('Conney Farrants', '1973-02-11', 'cfarrantsh@comcast.net');
insert into employee (name, birthday, email) values ('Agosto Dobrowlski', '1985-06-12', 'adobrowlskii@merriam-webster.com');
insert into employee (name, birthday, email) values ('Emilia Pinder', '2020-03-21', 'epinderj@epa.gov');
insert into employee (name, birthday, email) values ('Jeri Branchflower', '2018-05-31', 'jbranchflowerk@photobucket.com');
insert into employee (name, birthday, email) values ('Gardner Maiden', '1993-11-21', 'gmaidenl@tuttocitta.it');
insert into employee (name, birthday, email) values ('Jeremias Allabush', '1973-04-14', 'jallabushm@webeden.co.uk');
insert into employee (name, birthday, email) values ('Diandra Dilston', '1991-11-19', 'ddilstonn@howstuffworks.com');
insert into employee (name, birthday, email) values ('Delores McCurt', '2003-02-04', 'dmccurto@utexas.edu');
insert into employee (name, birthday, email) values ('Corbin de Guise', '1971-03-03', 'cdep@utexas.edu');
insert into employee (name, birthday, email) values ('Kara-lynn Farnfield', '1995-07-28', 'kfarnfieldq@usatoday.com');
insert into employee (name, birthday, email) values ('Willis Hardware', '2021-01-10', 'whardwarer@surveymonkey.com');
insert into employee (name, birthday, email) values ('Ollie Blackster', '2016-02-06', 'oblacksters@canalblog.com');
insert into employee (name, birthday, email) values ('Clem Kloser', '1973-01-08', 'cklosert@intel.com');
insert into employee (name, birthday, email) values ('Rhetta Campaigne', '1976-10-05', 'rcampaigneu@ameblo.jp');
insert into employee (name, birthday, email) values ('Anatol Coppledike', '2017-04-22', 'acoppledikev@dailymail.co.uk');
insert into employee (name, birthday, email) values ('Had Zealander', '2007-01-02', 'hzealanderw@un.org');
insert into employee (name, birthday, email) values ('Bryant Chiommienti', '2008-07-14', 'bchiommientix@discovery.com');
insert into employee (name, birthday, email) values ('Rosana Elham', '1988-01-21', 'relhamy@squarespace.com');
insert into employee (name, birthday, email) values ('Duke Shelmerdine', '2018-12-02', 'dshelmerdinez@amazon.co.uk');
insert into employee (name, birthday, email) values ('Conrade Beetham', '2019-09-30', 'cbeetham10@who.int');
insert into employee (name, birthday, email) values ('Nikolai Pardie', '1982-01-24', 'npardie11@yellowpages.com');
insert into employee (name, birthday, email) values ('Madlin Chiplen', '1974-07-09', 'mchiplen12@mapy.cz');
insert into employee (name, birthday, email) values ('Fania Rao', '1980-11-02', 'frao13@harvard.edu');
insert into employee (name, birthday, email) values ('Jennie Kermeen', '2010-05-24', 'jkermeen14@blogs.com');
insert into employee (name, birthday, email) values ('Eduino Grove', '1976-06-21', 'egrove15@a8.net');
insert into employee (name, birthday, email) values ('Valida Sans', '2013-10-16', 'vsans16@amazonaws.com');
insert into employee (name, birthday, email) values ('Dillon Linacre', '2019-02-12', 'dlinacre17@weather.com');
insert into employee (name, birthday, email) values ('Myriam Strike', '1987-02-07', 'mstrike18@yahoo.com');
insert into employee (name, birthday, email) values ('Nerta Maria', '1971-06-28', 'nmaria19@addtoany.com');
insert into employee (name, birthday, email) values ('Bryanty Pound', '1978-12-19', 'bpound1a@parallels.com');
insert into employee (name, birthday, email) values ('Mala Grouse', '2012-05-18', 'mgrouse1b@wunderground.com');
insert into employee (name, birthday, email) values ('Bailey Heinert', '2004-01-23', 'bheinert1c@craigslist.org');
insert into employee (name, birthday, email) values ('Dani Rubinfeld', '1980-08-10', 'drubinfeld1d@istockphoto.com');
insert into employee (name, birthday, email) values ('Hilliard Braxay', '1970-08-17', 'hbraxay1e@fastcompany.com');
insert into employee (name, birthday, email) values ('Hettie Domenge', '1991-07-04', 'hdomenge1f@bbb.org');
insert into employee (name, birthday, email) values ('Vladimir Auten', '1984-03-04', 'vauten1g@nyu.edu');
insert into employee (name, birthday, email) values ('Mollee Wikey', '2018-01-29', 'mwikey1h@360.cn');
insert into employee (name, birthday, email) values ('Dexter Askie', '2003-03-30', 'daskie1i@paypal.com');
insert into employee (name, birthday, email) values ('Stefania John', '2021-04-29', 'sjohn1j@foxnews.com');
insert into employee (name, birthday, email) values ('Georgy Dedney', '1975-12-27', 'gdedney1k@weather.com');
insert into employee (name, birthday, email) values ('Milissent Cattlemull', '2013-11-06', 'mcattlemull1l@hatena.ne.jp');
insert into employee (name, birthday, email) values ('Tracee Windle', '1983-06-14', 'twindle1m@independent.co.uk');
insert into employee (name, birthday, email) values ('Emmye Boucher', '2007-11-03', 'eboucher1n@goo.ne.jp');
insert into employee (name, birthday, email) values ('Emalia Kirtland', '1979-12-03', 'ekirtland1o@cdbaby.com');
insert into employee (name, birthday, email) values ('Che Joannidi', '1987-04-29', 'cjoannidi1p@free.fr');
insert into employee (name, birthday, email) values ('Lanna Haking', '2010-03-05', 'lhaking1q@lulu.com');
insert into employee (name, birthday, email) values ('Normy Ickovits', '1996-11-15', 'nickovits1r@de.vu');
insert into employee (name, birthday, email) values ('Cherise Roumier', '1985-11-23', 'croumier1s@so-net.ne.jp');
insert into employee (name, birthday, email) values ('Casey Witcher', '1971-12-02', 'cwitcher1t@fema.gov');
insert into employee (name, birthday, email) values ('Bevon McLurg', '1999-06-15', 'bmclurg1u@newsvine.com');
insert into employee (name, birthday, email) values ('Iseabal Hammon', '1996-07-09', 'ihammon1v@symantec.com');
insert into employee (name, birthday, email) values ('Isadore Martinyuk', '2006-04-07', 'imartinyuk1w@apache.org');
insert into employee (name, birthday, email) values ('Dom Hawke', '1977-01-22', 'dhawke1x@networkadvertising.org');
insert into employee (name, birthday, email) values ('Saxe Kiggel', '1983-07-12', 'skiggel1y@buzzfeed.com');
insert into employee (name, birthday, email) values ('Zachery Mertin', '2005-07-03', 'zmertin1z@4shared.com');
insert into employee (name, birthday, email) values ('Ado Vampouille', '1970-08-26', 'avampouille20@moonfruit.com');
insert into employee (name, birthday, email) values ('Winfred Copperwaite', '2016-11-19', 'wcopperwaite21@amazon.co.jp');
insert into employee (name, birthday, email) values ('Hannis MacLice', '2004-08-12', 'hmaclice22@pinterest.com');
insert into employee (name, birthday, email) values ('Edouard Brabben', '1981-09-30', 'ebrabben23@pcworld.com');
insert into employee (name, birthday, email) values ('Fons Ackery', '1988-06-28', 'fackery24@uiuc.edu');
insert into employee (name, birthday, email) values ('Dorrie Casper', '1999-09-05', 'dcasper25@fema.gov');
insert into employee (name, birthday, email) values ('Clive Merigeau', '1998-11-02', 'cmerigeau26@vimeo.com');
insert into employee (name, birthday, email) values ('Elton Nise', '2011-08-23', 'enise27@google.pl');
insert into employee (name, birthday, email) values ('Vikki Hardson', '2010-11-24', 'vhardson28@adobe.com');
insert into employee (name, birthday, email) values ('Simone Cowey', '1999-10-01', 'scowey29@oakley.com');
insert into employee (name, birthday, email) values ('Shelden Rosnau', '1973-06-17', 'srosnau2a@nyu.edu');
insert into employee (name, birthday, email) values ('Joelynn Kraut', '2014-05-22', 'jkraut2b@bloomberg.com');
insert into employee (name, birthday, email) values ('Rodrick Hodgon', '1992-04-23', 'rhodgon2c@opensource.org');
insert into employee (name, birthday, email) values ('Traci Woolveridge', '2003-11-17', 'twoolveridge2d@washington.edu');
insert into employee (name, birthday, email) values ('Kandy Baitman', '1994-06-23', 'kbaitman2e@t.co');
insert into employee (name, birthday, email) values ('Arabela Beyn', '1973-03-24', 'abeyn2f@chronoengine.com');
insert into employee (name, birthday, email) values ('Ailina Tregonna', '2013-02-07', 'atregonna2g@biglobe.ne.jp');
insert into employee (name, birthday, email) values ('Magdalena Zannotelli', '2016-01-12', 'mzannotelli2h@bbc.co.uk');
insert into employee (name, birthday, email) values ('Louisa Flindall', '1989-08-19', 'lflindall2i@elegantthemes.com');
insert into employee (name, birthday, email) values ('Rockey Bellamy', '1978-01-25', 'rbellamy2j@yellowbook.com');
insert into employee (name, birthday, email) values ('Eleanora Falloon', '2006-02-14', 'efalloon2k@tiny.cc');
insert into employee (name, birthday, email) values ('Olva Boyde', '1979-12-01', 'oboyde2l@ft.com');
insert into employee (name, birthday, email) values ('Annabell Wilding', '1998-04-14', 'awilding2m@economist.com');
insert into employee (name, birthday, email) values ('Kai Bonanno', '2010-11-16', 'kbonanno2n@flickr.com');
insert into employee (name, birthday, email) values ('Gualterio Lobe', '1999-03-16', 'globe2o@netvibes.com');
insert into employee (name, birthday, email) values ('Dulcine Ondrak', '1989-05-11', 'dondrak2p@rambler.ru');
insert into employee (name, birthday, email) values ('Lotte Gronaver', '2019-04-15', 'lgronaver2q@pinterest.com');
insert into employee (name, birthday, email) values ('Clemmie Tuffell', '2014-01-07', 'ctuffell2r@wikispaces.com');
```
#### *3-Sütunların her birine göre diğer sütunları güncelleyecek UPDATE işlemi yapalım.*
```sql
UPDATE employee
SET name = 'UPDATEDNAME'
WHERE name LIKE '%e';
```
#### *4-Sütunların her birine göre ilgili satırı silecek DELETE işlemi yapalım.*
```sql
DELETE FROM employee
WHERE id <6;
```
