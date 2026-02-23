/*esercizio 1
SELECT clienti.nome, ordini.data_ordine, ordini.importo
FROM clienti
INNER JOIN ordini ON clienti.id = ordini.id_cliente;*/

/*esercizio 2
SELECT clienti.nome, ordini.data_ordine, ordini.importo
FROM clienti
LEFT JOIN ordini ON clienti.id = ordini.id_cliente;*/

/*esercizio 3
SELECT clienti.nome, ordini.data_ordine, ordini.importo
FROM clienti
RIGHT JOIN ordini ON clienti.id = ordini.id_cliente;*/

/*esercizio 4
SELECT clienti.nome, COUNT(ordini.id) AS totale_ordini, SUM(ordini.Importo) AS somma_totale
FROM clienti
INNER JOIN ordini  ON clienti.id = ordini.id_cliente
GROUP BY clienti.nome;*/

/*esercizio 5
SELECT clienti.nome, clienti.città
FROM clienti
LEFT JOIN ordini  ON clienti.id = ordini.id_cliente
WHERE ordini.id_cliente IS NULL;*/

/*esercizio 6*/

SELECT ordini.id, ordini.data_Ordine, ordini.Importo,
    'NULL' AS Cliente
FROM clienti
RIGHT JOIN ordini ON clienti.id = ordini.id_cliente
WHERE clienti.id IS NULL;