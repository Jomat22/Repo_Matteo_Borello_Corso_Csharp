 /*esercizio 1
SELECT categoria, COUNT(*) AS
numero_vendite
FROM tabella_vendite
GROUP BY categoria;*/

/*esercizio 2
SELECT categoria, AVG(prezzo_unitario)
AS prezzo_medio
FROM tabella_vendite
GROUP BY categoria;*/

/*esercizio 3
SELECT prodotto, SUM(quantita) AS quantita_totale
FROM tabella_vendite
GROUP BY prodotto;*/

/*esercizio 4
SELECT MAX(prezzo_unitario) AS prezzo_massimo,
MIn(prezzo_unitario) AS prezzo_minimo
FROM tabella_vendite*/

/*esercizio 5
SELECT COUNT(*) AS totale_vendite
FROM tabella_vendite*/

/*esercizio 6
SELECT prodotto, prezzo_unitario FROM tabella_vendite
ORDER BY prezzo_unitario DESC LIMIT 5;*/

/*esercizio 7 
SELECT prodotto, SUM(quantita) AS totale_vendite
FROM tabella_vendite
GROUP BY prodotto
ORDER BY totale_vendite ASC
LIMIT 3;*/
