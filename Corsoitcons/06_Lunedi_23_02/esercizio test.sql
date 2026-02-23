/*esercizio 1 test
SELECT libri.titolo, libri.autore, vendite.data_vendita, vendite.negozio
FROM libri
INNER JOIN vendite ON libri.id = vendite.id_libro
WHERE libri.autore LIKE '%King%'*/

/*esercizio 2 test*/

SELECT libri.titolo, libri.anno_pubblicazione, libri.prezzo, vendite.data_vendita
FROM libri
LEFT JOIN vendite ON libri.id = vendite.id_libro
WHERE libri.anno_pubblicazione BETWEEN 2000 AND 2010;
