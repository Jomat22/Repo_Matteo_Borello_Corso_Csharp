/*query festival 1*/

SELECT 
    A.nome_darte, 
    COUNT(P.id_performance) AS numero_performance
FROM Artista A
LEFT JOIN Performance P ON A.id_artista = P.id_artista
GROUP BY A.id_artista, A.nome_darte;

/*query festival 2*/

SELECT 
    B.data_validita AS giorno, 
    SUM(B.prezzo) AS incasso_totale
FROM Acquisto AC
JOIN Biglietto B ON AC.id_biglietto = B.id_biglietto
GROUP BY B.data_validita;

/*query festival 3*/

SELECT 
    A.nome_darte
FROM Artista A
JOIN Performance P ON A.id_artista = P.id_artista
GROUP BY A.id_artista, A.nome_darte
HAVING COUNT(DISTINCT P.id_palco) > 1;

/*query festival 4*/

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