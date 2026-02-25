-- 2 Popolamento Dati 
-- Inserimento Specializzazioni e Reparti
INSERT INTO Specializzazione (nome) VALUES ('Cardiologia'), ('Ortopedia'), ('Neurologia'), ('Pediatria');
INSERT INTO Reparto (nome, numero_posti) VALUES ('Reparto A', 10), ('Reparto B', 5);
-- Inserimento Medici ( per 10 medici)
INSERT INTO Medico (nome, cognome, id_specializzazione, stipendio, data_assunzione) VALUES 
('Mario', 'Rossi', 1, 4500.00, '2020-01-10'), ('Luca', 'Bianchi', 2, 4200.00, '2021-03-15'),
('Paola', 'Verdi', 3, 4800.00, '2019-05-20'), ('Anna', 'Neri', 4, 3900.00, '2022-02-01'),
('Marco', 'Galli', 1, 4600.00, '2018-11-12'), ('Elena', 'Rizzo', 2, 4100.00, '2020-07-25'),
('Roberto', 'Ferri', 3, 5000.00, '2017-09-30'), ('Sara', 'Bruni', 4, 4000.00, '2021-12-05'),
('Fabio', 'Gatti', 1, 4700.00, '2019-01-15'), ('Giulia', 'Leoni', 2, 4300.00, '2022-06-10');
-- Inserimento Pazienti ( per 20 pazienti)
INSERT INTO Paziente (nome, cognome, data_nascita, codice_fiscale) VALUES 
('Giuseppe', 'Verdi', '1980-05-20', 'VRDGPP80E20F205Z'), ('Anna', 'Neri', '1992-11-12', 'NRNNAA92S52H501X'),
('Pietro', 'Rossi', '1975-03-15', 'RSSPTR75C15F205R'), ('Maria', 'Bianchi', '1988-07-22', 'BNCMRA88L62H501T'),
('Filippo', 'Rizzo', '1960-01-30', 'RZZFPP60A30L219G'), ('Lucia', 'Galli', '1995-09-05', 'GLLLCA95P45F205W'),
('Carlo', 'Ferri', '1955-12-10', 'FRRCRL55T10H501Q'), ('Sonia', 'Gatti', '2001-04-18', 'GTTSNA01D58L219Y'),
('Matteo', 'Bruni', '1982-08-25', 'BRNMTT82M25F205K'), ('Elena', 'Costa', '1970-02-14', 'CSTLNE70B54H501V'),
('Giovanni', 'Russo', '1985-11-30', 'RSSGNN85S30L219J'), ('Clara', 'Serra', '1990-06-12', 'SRRCLR90H52F205U'),
('Paolo', 'Manni', '1968-05-05', 'MNNPLA68E05H501D'), ('Rita', 'Dati', '1977-10-20', 'DTARTI77R60L219C'),
('Enzo', 'Bassi', '1998-12-01', 'BSSNZE98T01F205O'), ('Marta', 'Fonti', '2005-03-25', 'FNTMRT05C65H501X'),
('Simone', 'Lupi', '1983-09-15', 'LPUSMN83P15L219Z'), ('Valeria', 'Pini', '1991-01-10', 'PNIVLR91A50F205B'),
('Oscar', 'Valli', '1972-04-04', 'VLLSCR72D04H501N'), ('Nadia', 'Santi', '1989-08-08', 'SNTNDA89M48L219F');
-- Inserimento Appuntamenti (Esempio per 30 appuntamenti)
INSERT INTO Appuntamento (id_paziente, id_medico, data_appuntamento, stato, costo) VALUES 
(1, 1, '2024-02-01 10:00:00', 'completato', 120.00), (1, 2, '2024-02-15 11:30:00', 'completato', 150.00),
(1, 1, '2024-02-20 09:00:00', 'completato', 120.00), (1, 3, '2024-02-25 15:00:00', 'completato', 200.00),
(1, 5, '2024-03-01 10:30:00', 'completato', 130.00), (2, 4, '2024-01-10 16:00:00', 'completato', 100.00),
(3, 5, '2024-01-12 09:00:00', 'completato', 130.00), (4, 1, '2024-01-15 11:00:00', 'completato', 120.00),
(5, 2, '2024-01-18 14:00:00', 'completato', 150.00), (6, 3, '2024-01-20 08:30:00', 'completato', 200.00),
(7, 4, '2024-01-22 17:00:00', 'completato', 100.00), (8, 5, '2024-01-25 10:00:00', 'completato', 130.00),
(9, 1, '2024-01-28 09:30:00', 'completato', 120.00), (10, 2, '2024-01-30 15:30:00', 'completato', 150.00),
(11, 3, '2024-02-02 12:00:00', 'completato', 200.00), (12, 4, '2024-02-04 11:00:00', 'completato', 100.00),
(13, 5, '2024-02-06 08:00:00', 'completato', 130.00), (14, 1, '2024-02-08 14:00:00', 'completato', 120.00),
(15, 2, '2024-02-10 16:30:00', 'completato', 150.00), (16, 3, '2024-02-12 10:00:00', 'completato', 200.00),
(17, 4, '2024-02-14 09:00:00', 'completato', 100.00), (18, 5, '2024-02-16 11:30:00', 'completato', 130.00),
(19, 1, '2024-02-18 15:00:00', 'completato', 120.00), (20, 2, '2024-02-20 17:00:00', 'completato', 150.00),
(1, 6, '2024-02-22 08:30:00', 'completato', 140.00), (2, 7, '2024-02-24 14:00:00', 'completato', 180.00),
(3, 8, '2024-02-26 10:00:00', 'completato', 110.00), (4, 9, '2024-02-28 11:00:00', 'completato', 135.00),
(5, 10, '2024-03-02 16:00:00', 'completato', 125.00), (6, 6, '2024-03-04 09:30:00', 'completato', 140.00);