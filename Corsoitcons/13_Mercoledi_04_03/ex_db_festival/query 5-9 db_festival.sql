/*query festival 5 Mostrare l’artista che ha generato il maggior incasso in biglietti. 
(richiede join + aggregazioni) */

SELECT 
    A.nome_darte, 
    SUM(B.prezzo) AS incasso_totale
FROM Artista A
JOIN Performance P ON A.id_artista = P.id_artista
JOIN Biglietto B ON DATE(P.data_ora) = B.data_validita
JOIN Acquisto AC ON B.id_biglietto = AC.id_biglietto
GROUP BY A.id_artista, A.nome_darte
ORDER BY incasso_totale DESC
LIMIT 1;

/*query festival 6 Mostrare le coppie di artisti che hanno collaborato almeno 2 volte. 
(richiede relazione N–M + grouping)*/

SELECT 
    A1.nome_darte AS artista_1, 
    A2.nome_darte AS artista_2
FROM Collaborazione C
JOIN Artista A1 ON C.id_artista1 = A1.id_artista
JOIN Artista A2 ON C.id_artista2 = A2.id_artista
GROUP BY C.id_artista1, C.id_artista2
HAVING COUNT(*) >= 2;

/*query festival 7 Mostrare gli sponsor che hanno sponsorizzato performance in almeno 3 giorni diversi. */

SELECT 
    S.nome AS nome_sponsor
FROM Sponsor S
JOIN Sponsorizzazione SP ON S.id_sponsor = SP.id_sponsor
JOIN Performance P ON SP.id_performance = P.id_performance
GROUP BY S.id_sponsor, S.nome
HAVING COUNT(DISTINCT DATE(P.data_ora)) >= 3;


/*query festival 8 Mostrare per ogni giorno il palco con l’incasso più alto. 
(subquery o window function) */

SELECT giorno, nome_palco, incasso_massimo
FROM (
    SELECT 
        B.data_validita AS giorno, 
        PA.nome AS nome_palco, 
        SUM(B.prezzo) AS incasso_massimo,
        RANK() OVER (PARTITION BY B.data_validita ORDER BY SUM(B.prezzo) DESC) as rank_incasso
    FROM Performance P
    JOIN Palco PA ON P.id_palco = PA.id_palco
    JOIN Biglietto B ON DATE(P.data_ora) = B.data_validita
    JOIN Acquisto AC ON B.id_biglietto = AC.id_biglietto
    GROUP BY B.data_validita, PA.id_palco, PA.nome
) AS Classifica
WHERE rank_incasso = 1;

/*query festival 9 Mostrare la variazione percentuale di incasso giorno per giorno.*/

SELECT 
    Oggi.data_validita AS giorno,
    Oggi.incasso AS incasso_oggi,
    Ieri.incasso AS incasso_ieri,
    ((Oggi.incasso - Ieri.incasso) / Ieri.incasso) * 100 AS variazione_percentuale
FROM (
    SELECT B.data_validita, SUM(B.prezzo) AS incasso
    FROM Acquisto AC
    JOIN Biglietto B ON AC.id_biglietto = B.id_biglietto
    GROUP BY B.data_validita
) AS Oggi
LEFT JOIN (
    SELECT B.data_validita, SUM(B.prezzo) AS incasso
    FROM Acquisto AC
    JOIN Biglietto B ON AC.id_biglietto = B.id_biglietto
    GROUP BY B.data_validita
) AS Ieri ON Ieri.data_validita = Oggi.data_validita - INTERVAL 1 DAY;