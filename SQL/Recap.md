# RECAP 
#### *1-İsminde en az 4 tane e veya E bulunan kaç tane film vardır?*
```sql
SELECT COUNT(*) FROM film
WHERE title ILIKE '%e%e%e%e%';
```
#### *2-Kategori isimlerini ve kategori başına düşen film sayısını yazınız.*
```sql
SELECT category.name,COUNT(*) FROM film
INNER JOIN film_category ON film_category.film_id = film.film_id
INNER JOIN category ON category.category_id = film_category.category_id
GROUP BY category.name;
```
#### *3-En çok film bulunan rating kategorisi hangisidir?*
```sql
SELECT COUNT(*) FROM film
GROUP BY rating
ORDER BY count DESC
LIMIT 1;
```
#### *4-Film tablosundan 'K' karakteri ile başlayan en uzun ve replacenet_cost'u en düşük 4 filmi sıralayınız.*
```sql
SELECT * FROM film
WHERE title LIKE 'K%'
ORDER BY length DESC, replacement_cost ASC
LIMIT 3;
```
#### *5-Customer tablosunda alışverişe en çok para harcayan müşterinin adı nedir?*
```sql
SELECT SUM(amount),customer.first_name,customer.last_name FROM customer
INNER JOIN payment ON payment.customer_id=customer.customer_id
GROUP BY payment.customer_id,customer.first_name,customer.last_name
ORDER BY SUM(amount) DESC
LIMIT 1;
```
