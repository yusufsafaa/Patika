# Ödev 12 | SUBQUERY
#### *1-Film tablosunda film uzunluğu length sütununda gösterilmektedir. Uzunluğu ortalama film uzunluğundan fazla kaç tane film vardır?*
```sql
SELECT COUNT(length) FROM film
WHERE length > 
(
	SELECT AVG(length) FROM film
);
```
#### *2-Film tablosunda en yüksek rental_rate değerine sahip kaç tane film vardır?*
```sql
SELECT COUNT(rental_rate) FROM film
WHERE rental_rate = 
(
	SELECT MAX(rental_rate) FROM film
);
```
#### *3-Film tablosunda en düşük rental_rate ve en düşün replacement_cost değerlerine sahip filmleri sıralayınız.*
```sql
SELECT title FROM film
WHERE rental_rate = 
(
	SELECT MIN(rental_rate) FROM film
)
AND replacement_cost =
(
	SELECT MIN(replacement_cost) FROM film
);
```
#### *4-Payment tablosunda en fazla sayıda alışveriş yapan müşterileri(customer) sıralayınız.*
```sql
SELECT customer.customer_id,first_name,last_name FROM customer
INNER JOIN 
(
	SELECT customer_id,COUNT(*) AS most_payment FROM payment
	GROUP BY customer_id
) AS subquery
ON subquery.customer_id=customer.customer_id
WHERE subquery.most_payment = 
(
	SELECT MAX(most_payment) FROM 
	(
		SELECT customer_id,COUNT(*) AS most_payment FROM payment
		GROUP BY customer_id
	) subquery2
);
```
