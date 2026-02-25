/*query 1*/
SELECT medico.cognome, medico.nome, COUNT(appuntamento.id_appuntamento) AS totale_appuntamenti
FROM medico 
LEFT JOIN appuntamento  ON medico.id_medico = appuntamento.id_medico
GROUP BY medico.id_medico, medico.cognome, medico.nome
ORDER BY totale_appuntamenti DESC;

/*query 2*/
SELECT paziente.cognome, paziente.nome, COUNT(appuntamento.id_appuntamento) AS n_appu
FROM paziente 
JOIN appuntamento  ON paziente.id_paziente = appuntamento.id_paziente
GROUP BY paziente.id_paziente, paziente.cognome, paziente.nome
HAVING COUNT(appuntamento.id_appuntamento) > 3;

/*query 3*/

SELECT medico.cognome, medico.nome, SUM(pagamento.importo) AS incasso_totale
FROM medico
JOIN appuntamento ON medico.id_medico = appuntamento.id_medico
JOIN pagamento ON appuntamento.id_appuntamento = pagamento.id_appuntamento
GROUP BY medico.id_medico, medico.cognome, medico.nome;

/* query 4*/

SELECT nome_specializzazione, cognome, nome, stipendio
FROM (
    SELECT specializzazione.nome AS nome_specializzazione, medico.cognome, medico.nome, medico.stipendio,
    RANK() OVER (PARTITION BY specializzazione.id_specializzazione ORDER BY medico.stipendio DESC) AS ranking
    FROM medico
    JOIN specializzazione ON medico.id_specializzazione = specializzazione.id_specializzazione
) AS TRank
WHERE ranking = 1;

/*query5*/

SELECT paziente.nome, paziente.cognome, SUM(pagamento.importo) AS totale_speso
FROM paziente
JOIN appuntamento ON paziente.id_paziente = appuntamento.id_paziente
JOIN pagamento ON appuntamento.id_appuntamento = pagamento.id_appuntamento
GROUP BY paziente.id_paziente, paziente.nome, paziente.cognome
HAVING SUM(pagamento.importo) = (
    SELECT MAX(spesa_paziente) 
    FROM (
        SELECT SUM(pagamento.importo) AS spesa_paziente 
        FROM pagamento 
        JOIN appuntamento ON pagamento.id_appuntamento = appuntamento.id_appuntamento 
        GROUP BY appuntamento.id_paziente
    ) AS Sub);