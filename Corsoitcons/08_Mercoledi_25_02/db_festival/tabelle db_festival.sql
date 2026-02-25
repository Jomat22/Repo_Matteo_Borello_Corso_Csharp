CREATE DATABASE IF NOT EXISTS festival;
USE festival;

-- 1. Artista (Singoli o Band)
CREATE TABLE Artista (
    id_artista INT PRIMARY KEY AUTO_INCREMENT,
    nome_darte VARCHAR(100) UNIQUE NOT NULL,
    tipo ENUM('singolo', 'band') NOT NULL,
    genere VARCHAR(50)
);

-- 2. Palco
CREATE TABLE Palco (
    id_palco INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    capacita_max INT NOT NULL CHECK (capacita_max > 0),
    posizione VARCHAR(100)
);

-- 3. Staff Tecnico
CREATE TABLE Staff (
    id_staff INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    ruolo VARCHAR(50),
    id_palco INT,
    FOREIGN KEY (id_palco) REFERENCES Palco(id_palco) ON DELETE SET NULL
);

-- 4. Performance (Evento Live)
CREATE TABLE Performance (
    id_performance INT PRIMARY KEY AUTO_INCREMENT,
    id_artista INT,
    id_palco INT,
    data_ora DATETIME NOT NULL,
    durata_minuti INT DEFAULT 60 CHECK (durata_minuti > 0),
    FOREIGN KEY (id_artista) REFERENCES Artista(id_artista) ON DELETE CASCADE,
    FOREIGN KEY (id_palco) REFERENCES Palco(id_palco) ON DELETE CASCADE
);

-- 5. Collaborazione (Relazione N-M tra Artisti)
CREATE TABLE Collaborazione (
    id_artista1 INT,
    id_artista2 INT,
    id_performance INT,
    PRIMARY KEY (id_artista1, id_artista2, id_performance),
    FOREIGN KEY (id_artista1) REFERENCES Artista(id_artista) ON DELETE CASCADE,
    FOREIGN KEY (id_artista2) REFERENCES Artista(id_artista) ON DELETE CASCADE,
    FOREIGN KEY (id_performance) REFERENCES Performance(id_performance) ON DELETE CASCADE,
    CHECK (id_artista1 < id_artista2) -- Evita duplicati speculari
);

-- 6. Biglietto (Prezzo Variabile)
CREATE TABLE Biglietto (
    id_biglietto INT PRIMARY KEY AUTO_INCREMENT,
    tipologia VARCHAR(50) NOT NULL, -- 'Daily', 'VIP', 'Full-Pass'
    prezzo DECIMAL(10,2) NOT NULL CHECK (prezzo >= 0),
    data_validita DATE NOT NULL
);

-- 7. Spettatore e Pagamento
CREATE TABLE Spettatore (
    id_spettatore INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(100) UNIQUE NOT NULL
);

CREATE TABLE Acquisto (
    id_acquisto INT PRIMARY KEY AUTO_INCREMENT,
    id_spettatore INT,
    id_biglietto INT,
    data_pagamento DATETIME DEFAULT CURRENT_TIMESTAMP,
    metodo_pagamento VARCHAR(50),
    FOREIGN KEY (id_spettatore) REFERENCES Spettatore(id_spettatore),
    FOREIGN KEY (id_biglietto) REFERENCES Biglietto(id_biglietto)
);

-- 8. Sponsor
CREATE TABLE Sponsor (
    id_sponsor INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) UNIQUE NOT NULL,
    contributo_totale DECIMAL(15,2) CHECK (contributo_totale > 0)
);

-- Sponsorizzazione associata a Performance
CREATE TABLE Sponsorizzazione (
    id_sponsor INT,
    id_performance INT,
    PRIMARY KEY (id_sponsor, id_performance),
    FOREIGN KEY (id_sponsor) REFERENCES Sponsor(id_sponsor),
    FOREIGN KEY (id_performance) REFERENCES Performance(id_performance)
);
-- popoliamo il db 
-- Artisti e Palchi
INSERT INTO Artista (nome_darte, tipo, genere) VALUES ('RockBand', 'band', 'Rock'), ('DJ Cloud', 'singolo', 'EDM'), ('Indie Duo', 'band', 'Indie');
INSERT INTO Palco (nome, capacita_max) VALUES ('Main Stage', 10000), ('Alternative Tent', 3000);

-- Performance e Biglietti
INSERT INTO Biglietto (tipologia, prezzo, data_validita) VALUES ('Giorno 1', 50.00, '2024-07-01'), ('Giorno 2', 55.00, '2024-07-02');
INSERT INTO Performance (id_artista, id_palco, data_ora) VALUES (1, 1, '2024-07-01 21:00:00'), (2, 1, '2024-07-01 23:00:00'), (1, 2, '2024-07-02 20:00:00');

-- Spettatori e Acquisti
INSERT INTO Spettatore (nome, email) VALUES ('Mario Rossi', 'mario@test.com'), ('Luca Bianchi', 'luca@test.com');
INSERT INTO Acquisto (id_spettatore, id_biglietto, metodo_pagamento) VALUES (1, 1, 'Carta'), (2, 1, 'PayPal'), (1, 2, 'Carta');

-- Collaborazioni
INSERT INTO Collaborazione (id_artista1, id_artista2, id_performance) VALUES (1, 2, 1);