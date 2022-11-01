SELECT * FROM Produtos
/*retorna apenas quantidades de  registros*/
SELECT COUNT(*) QuantidadeProdutos FROM Produtos

SELECT COUNT(*) QuantidadeProdutosTamanhoM FROM Produtos WHERE Tamanho = 'M'
/*Somar os produtos*/
SELECT SUM(Preco) PrecoTotal FROM Produtos
/*Somar os produtos especifico*/
SELECT SUM(Preco) PrecoTotalProdutosTamanhoM FROM Produtos WHERE Tamanho = 'M'

/*selecionar o maior preço*/
SELECT MAX(Preco) ProdutoMaisCaro FROM Produtos
SELECT MAX(Preco) ProdutoMaisCaro FROM Produtos	WHERE Tamanho = 'M'

/*selecionar o menor preço*/
SELECT MIN(Preco) ProdutoMaisBarato FROM Produtos

SELECT MIN(Preco) ProdutoMaisCBarato FROM Produtos WHERE Tamanho = 'M'

/*Media dos preços*/

SELECT AVG(Preco) MediaProdutos FROM Produtos
/*concatenando colunas*/
SELECT 
	Nome + ', Cor: ' + Cor NomeProduto
FROM Produtos
/*transformar tudo maiusculo*/
SELECT 
	Nome + ', Cor: ' + Cor NomeProduto,
	UPPER(Nome) Nome,
	LOWER(Cor),Cor
FROM Produtos

/*adiconado uma nva coluna*/

ALTER TABLE Produtos
ADD DataCadastro DATETIME2

UPDATE Produtos SET DataCadastro = GETDATE()

/*FORMATANDO UMA DATA*/
SELECT 
	Nome + ', Cor: ' + Cor NomeProduto,
	UPPER(Nome) Nome,
	LOWER(Cor),Cor,
	FORMAT(DataCadastro, 'dd-MM-yyyy HH:mm') Data
FROM Produtos

/*agrupamento de dados*/
SELECT 
	 Tamanho,
	 COUNT(*) Quantidade
FROM Produtos 
GROUP BY Tamanho

/*sem os que tem espaço em branco*/
SELECT 
	 Tamanho,
	 COUNT(*) Quantidade
FROM Produtos 
WHERE Tamanho <> ' '
GROUP BY Tamanho
ORDER BY Quantidade DESC


