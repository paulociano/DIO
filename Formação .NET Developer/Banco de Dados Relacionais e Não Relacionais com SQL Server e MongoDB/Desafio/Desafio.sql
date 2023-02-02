USE [Filmes]
GO

-- 1
SELECT
	Nome,
	Ano
FROM Filmes
GO

-- 2
SELECT
	Nome,
	Ano
FROM Filmes
ORDER BY Ano ASC;
GO

-- 3
SELECT
	Nome,
	Ano,
	Duracao
FROM Filmes
WHERE Nome = 'De Volta Para O Futuro';
GO

-- 4
SELECT
	Nome,
	Ano,
	Duracao
FROM Filmes
WHERE Ano = 1997;
GO

-- 5
SELECT
	Nome,
	Ano,
	Duracao
FROM Filmes
WHERE Ano >= 2000;
GO

-- 6
SELECT
	Nome,
	Ano,
	Duracao
FROM Filmes
WHERE Duracao >100 AND Duracao <150
ORDER BY Duracao ASC
GO

-- 7
SELECT Ano, COUNT(*) AS Quantidade
FROM Filmes
GROUP BY Ano
ORDER BY Quantidade DESC;
GO

-- 8
SELECT * FROM Atores
WHERE Genero = 'M';
GO

-- 9
SELECT * FROM Atores
WHERE Genero = 'F'
ORDER BY PrimeiroNome ASC;
GO

-- 10
SELECT Nome, Generos.Genero
FROM Filmes
INNER JOIN FilmesGenero
ON Filmes.Id = FilmesGenero.IdFilme
INNER JOIN Generos
ON FilmesGenero.IdGenero = Generos.Id;
GO

-- 11
SELECT Nome, Generos.Genero
FROM Filmes
INNER JOIN FilmesGenero
ON Filmes.Id = FilmesGenero.IdFilme
INNER JOIN Generos
ON FilmesGenero.IdGenero = Generos.Id
WHERE Genero = 'Mistério';
GO

-- 12
SELECT Nome, PrimeiroNome, UltimoNome, Papel
FROM Filmes
JOIN ElencoFilme
	ON Filmes.Id = ElencoFilme.IdFilme
JOIN Atores
	ON ElencoFilme.IdAtor = Atores.Id;
GO