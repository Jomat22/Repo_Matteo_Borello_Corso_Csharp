/*esercizio 1 world
SELECT city.Name AS citta, country.Name AS nazione, Language
FROM city
INNER JOIN country ON city.CountryCode = country.Code
INNER JOIN countrylanguage ON country.Code = countrylanguage.CountryCode;*/

/*esercizio 2 world

SELECT country.Name AS nazione, COUNT(city.ID) AS numerocittà
FROM country
INNER JOIN city ON country.Code = city.CountryCode
GROUP BY country.Name
ORDER BY numerocittà DESC;*/

/*esercizio 3 world

SELECT country.Name, LifeExpectancy, Language
FROM country
INNER JOIN countrylanguage ON country.Code = countrylanguage.CountryCode
WHERE GovernmentForm LIKE '%Republic%' 
AND LifeExpectancy > 70;*/

/*esercizio 1 world parte 2

SELECT country.Name AS nazione, countrylanguage.Language, countrylanguage.Percentage
FROM world.countrylanguage
INNER JOIN country ON countrylanguage.CountryCode = country.Code;*/

/*esercizio 2 world parte 2

SELECT Country.Code, MAX(Percentage) AS percentuale
FROM countrylanguage
GROUP BY CountryCode
ORDER BY percentuale DESC;*/

/*esercizio 3 world parte 2

SELECT country.Name AS nazione, countrylanguage.Language, countrylanguage.Percentage
FROM countrylanguage
JOIN country ON countrylanguage.CountryCode = country.Code
WHERE (countrylanguage.CountryCode, countrylanguage.Percentage) IN (
SELECT CountryCode, MAX(Percentage)
FROM countrylanguage
GROUP BY CountryCode)
ORDER BY countrylanguage.Percentage DESC;*/

/*esercizio extra world parte 2
Traccia: 
Per ogni continente, mostra le 3 lingue più parlate in termini di popolazione totale,
considerando la popolazione di ogni nazione moltiplicata per la percentuale della lingua.
(Usa Country e CountryLanguage /
Calcola la popolazione che parla ogni lingua (Population * Percentage / 100) /
Usa subquery per ottenere il ranking per continente /
Ordina i risultati per continente e popolazione decrescente )*/

/*
SELECT country.Continent AS continente, countrylanguage.language AS lingua,
SUM(country.population * countrylanguage.Percentage /100) AS totale_abitanti
FROM countrylanguage
INNER JOIN country ON countrylanguage.CountryCode = country.Code
GROUP BY country.Continent, countrylanguage.Language
HAVING(SELECT COUNT(*) 
FROM (SELECT country2.Continent, countrylanguage2.Language, SUM(country2.Population * countrylanguage2.Percentage / 100) AS Somma
FROM countrylanguage countrylanguage2
JOIN country country2 ON countrylanguage2.CountryCode = country2.Code
GROUP BY country2.Continent, countrylanguage2.Language) AS TabellaConfronto
WHERE TabellaConfronto.Continent = country.Continent 
AND TabellaConfronto.Somma > SUM(country.Population * countrylanguage.Percentage / 100)) < 3
ORDER BY country.Continent ASC, totale_abitanti DESC;*/

/*esercizio 7 world

SELECT country.Name AS nazione,
IF (country.SurfaceArea >=100000, 'maggiore di 100.000','minore di 100.000') 
AS superficie_nazione,
IFNULL(country.IndepYear, 'non presente') AS indep_year
FROM country;*/

/*esercizio 8 world
SELECT city.Name AS città, city.countrycode AS codice_nazione
FROM city
INNER JOIN country ON city.CountryCode = country.Code
WHERE city.CountryCode = 'USA' AND city.Population > 1500000
ORDER BY city.Name ASC*/

/*esercizio 9 world
CREATE VIEW citta_italiane AS 
SELECT *
FROM city
WHERE CountryCode = 'ITA';
SELECT Name, Population
FROM citta_italiane
WHERE Population < 100000;*/

