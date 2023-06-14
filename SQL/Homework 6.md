# Ödev 6 | Aggregate Fonksiyonlar
#### *1-Film tablosunda bulunan rental_rate sütunundaki değerlerin ortalaması nedir?*
```
SELECT ROUND(AVG(rental_rate),3) FROM film;
```
#### *2-Film tablosunda bulunan filmlerden kaç tanesi 'C' karakteri ile başlar?*
```
SELECT title FROM film
WHERE title LIKE '%n'
ORDER BY length
OFFSET 5
LIMIT 5;
```
#### *3-Film tablosunda bulunan filmlerden rental_rate değeri 0.99 a eşit olan en uzun (length) film kaç dakikadır?*
```
SELECT MAX(length) FROM film
WHERE rental_rate = 0.99;
```
#### *4-Film tablosunda bulunan filmlerin uzunluğu 150 dakikadan büyük olanlarına ait kaç farklı replacement_cost değeri vardır?*
```
SELECT COUNT(DISTINCT replacement_cost) FROM film
WHERE length > 150;
```
