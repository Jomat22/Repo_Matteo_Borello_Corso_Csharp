/*esercizio 1 test
SELECT libri.titolo, libri.autore, vendite.data_vendita, vendite.negozio
FROM libri
INNER JOIN vendite ON libri.id = vendite.id_libro
WHERE libri.autore LIKE '%King%'*/

/*esercizio 2 test

SELECT libri.titolo, libri.anno_pubblicazione, libri.prezzo, vendite.data_vendita
FROM libri
LEFT JOIN vendite ON libri.id = vendite.id_libro
WHERE libri.anno_pubblicazione BETWEEN 2000 AND 2010;*/

/*esercizio 3 test

SELECT libri.titolo, vendite.negozio, vendite.quantita, (vendite.quantita * libri.prezzo) AS prezzo_totale
FROM libri
INNER JOIN vendite ON libri.id = vendite.id_libro
WHERE vendite.negozio IN ('Libreria Centrale', 'BookCity Milano', 'Cartoleria Roma');*/

/*esercizio 4 test

SELECT libri.titolo, vendite.data_vendita, libri.prezzo, vendite.quantita
FROM libri
RIGHT JOIN vendite ON libri.id = vendite.id_libro
WHERE vendite.data_vendita BETWEEN '2020-01-01' AND '2022-12-31'
AND vendite.negozio LIKE '%Book%';*/

/*esercizio 5 test

SELECT libri.titolo, libri.autore, libri.prezzo, vendite.data_vendita
FROM libri
INNER JOIN vendite ON libri.id = vendite.id_libro
WHERE libri.genere IN ('Fantasy', 'Horror', 'Giallo') AND libri.anno_pubblicazione > 2015
AND vendite.negozio LIKE '%Store%'
ORDER BY libri.anno_pubblicazione DESC;*/
