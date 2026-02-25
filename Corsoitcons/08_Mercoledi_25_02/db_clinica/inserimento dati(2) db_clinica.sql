-- Inserimento ricovero ( per 10 ricoveri) 
INSERT INTO Ricovero (id_paziente, id_reparto, data_ingresso, data_dimissione) VALUES 
(1, 1, '2024-01-01', '2024-01-05'), 
(1, 1, '2024-02-10', '2024-02-15'), 
(2, 2, '2024-01-12', '2024-01-18'), 
(3, 1, '2024-02-01', '2024-02-08'), 
(4, 2, '2024-02-20', '2024-02-25'), 
(5, 1, '2024-03-01', NULL),
(6, 2, '2024-03-02', NULL),
(7, 1, '2024-02-15', '2024-02-22'),
(8, 2, '2024-01-05', '2024-01-10'),
(9, 1, '2024-03-05', NULL); 

---- Inserimento pagamenti ( per 10 pagamenti) 
INSERT INTO Pagamento (id_appuntamento, importo, metodo_pagamento, data_pagamento) VALUES 
(1, 120.00, 'Carta di Credito', '2024-02-01'), 
(2, 150.00, 'Contanti', '2024-02-15'),
(3, 120.00, 'Bancomat', '2024-02-20'),
(4, 200.00, 'Carta di Credito', '2024-02-25'),
(5, 130.00, 'Contanti', '2024-03-01'),
(6, 100.00, 'Bancomat', '2024-01-10'),
(7, 130.00, 'Carta di Credito', '2024-01-12'),
(8, 120.00, 'Contanti', '2024-01-15'),
(9, 150.00, 'Bancomat', '2024-01-18'),
(10, 200.00, 'Carta di Credito', '2024-01-20');