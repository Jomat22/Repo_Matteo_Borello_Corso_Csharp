/*query festival 1 Mostrare il numero di performance per artista. */

SELECT 
    A.nome_darte, 
    COUNT(P.id_performance) AS numero_performance
FROM Artista A
LEFT JOIN Performance P ON A.id_artista = P.id_artista
GROUP BY A.id_artista, A.nome_darte;

/*query festival 2 Mostrare il totale incasso per giorno del festival. */

SELECT 
    B.data_validita AS giorno, 
    SUM(B.prezzo) AS incasso_totale
FROM Acquisto AC
JOIN Biglietto B ON AC.id_biglietto = B.id_biglietto
GROUP BY B.data_validita;

/*query festival 3 Mostrare gli artisti che si sono esibiti su più di un palco. */

SELECT 
    A.nome_darte
FROM Artista A
JOIN Performance P ON A.id_artista = P.id_artista
GROUP BY A.id_artista, A.nome_darte
HAVING COUNT(DISTINCT P.id_palco) > 1;

/*query festival 4 Mostrare il palco con il maggior numero di spettatori totali. */

SELECT 
    PA.nome AS nome_palco, 
    COUNT(AC.id_acquisto) AS totale_spettatori
FROM Palco PA
JOIN Performance PE ON PA.id_palco = PE.id_palco
JOIN Biglietto B ON PE.data_ora = B.data_validita 
JOIN Acquisto AC ON B.id_biglietto = AC.id_biglietto
GROUP BY PA.id_palco, PA.nome
ORDER BY totale_spettatori DESC
LIMIT 1;