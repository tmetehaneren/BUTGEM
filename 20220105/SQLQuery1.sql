use okulson
select * from Ogrenciler

alter table Ogrenciler add 
adres nvarchar(50)

update Ogrenciler set adres = 'Bursa'
where OgrNo = 10

update Ogrenciler set adres = 'Bilecik'
where OgrNo = 20 

select * from Ogrenciler where adres is null

select * from Ogrenciler where adres is not null

select * from Notlar order by Final asc

select * from Notlar order by Final desc 

select top 1 OgrAd, OgrSoyad, Vize, Final, (Vize * 0.4 + Final * 0.6 ) as Ortalama from Ogrenciler, Notlar where Ogrenciler.OgrNo = Notlar.Ogrid order by Ortalama desc

select * from Ogrenciler order by OgrAd, OgrSoyad desc

select OgrAd, Vize, Final, DersAdi,adres from Ogrenciler,Notlar,Dersler where OgrAd like '%e%' and Ogrenciler.OgrNo= Notlar.Ogrid and Notlar.Dersid = Dersler.DersNo and adres = 'Bilecik'

SELECT MIN(Final), MAX(Vize)
FROM Notlar

select sum(Final) as 'Toplam Final' from Notlar

select sum(Final)/ count (SNo) as 'Ortalama Final' from Notlar

select * from Ogrenciler, Notlar where Final >= (select avg(Final) as FinalOrtalama from Notlar) and  Ogrenciler .OgrNo = Notlar.Ogrid 

select OgrAd,OgrSoyad,Vize,Final,DersAdi from Ogrenciler, Notlar, Dersler where Vize=(select max(Vize) from Notlar) and Ogrenciler.OgrNo=Notlar.Ogrid and Notlar.Dersid = Dersler.DersNo

create table personel (
PerNo int primary key,
PerAd nvarchar(50) not null,
PerSoyad nvarchar(50) not null,
PYas int not null,
PCinsiyet bit not null,
Sehir nvarchar(30) not null,
Ülke nvarchar(30) not null,
Maas int not null)

insert into personel values 
(10,'Ali','Yılmaz',32,0,'İstanbul','Türkiye',8500),
(20,'Hans','Muller',41,0,'Hamburg','Almanya',2000),
(30,'Tarık','Çiçek',28,0,'Adana','Türkiye',4200)

select Ülke from personel 
group by Ülke

select distinct Ülke from personel

select Ülke,avg(Maas) as 'Ortalama Maaş' from personel group by Ülke 

select Ülke, count(*) as 'Personel Sayısı' from personel group by Ülke

select PCinsiyet,count(*) 'Sayısı' from personel group by PCinsiyet

select Ülke,Sehir,avg(PYas) from personel
group by Ülke,Sehir

select Ülke, PCinsiyet, count(*),avg(Maas) from personel where Maas > 10000 group by Ülke,PCinsiyet

select Ülke,avg(Maas) from personel where PYas > 35 and PCinsiyet = 'False' group by Ülke

select Ülke ,avg(Maas) 'Maaş Ortalaması'from personel group by Ülke having avg(PYas) > 30

select Sehir,count(*) 'Çalışan Sayısı' from personel group by Sehir having count(*) > 1

select Ülke,SUM(Maas) from personel where PCinsiyet = 'False' group by Ülke having COUNT(PCinsiyet) > 1 order by Ülke desc

select Ülke,avg(Maas) from personel where PYas > 35 and PCinsiyet = 0 group by Ülke having AVG(Maas) > 10000
