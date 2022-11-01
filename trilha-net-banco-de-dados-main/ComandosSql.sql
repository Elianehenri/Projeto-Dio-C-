/*todas as colunas*/
SELECT * FROM Clientes
/*por nome e sobrenome*/
ORDER BY Nome , Sobrenome
/*colunas especificas*/
SELECT	Nome, email From Clientes

/*where filtrar determidados tipos de dados*/
SELECT * FROM Clientes
/*somente o nome*/
/*WHERE Nome = 'Camila'*/
/*o nome e sobrenome*/
/*WHERE Nome = 'Grazi'AND Sobrenome = 'Walters' */
/*o nome e sobrenome com or => quando uma das condiçoes for verdadeira*/
WHERE Nome = 'Grazi ' OR Sobrenome = 'Walters' 


/*LIKE filtrar clientes que comecam com G*/
SELECT * FROM Clientes
/*por nome e sobrenome*/
WHERE Nome LIKE 'A%'/*colunas especificas*/
 

 /*INSERIR DADOS NA TABELAS*/
 INSERT INTO Clientes(Nome,Sobrenome,Email,AceitaComunicados,DataCadastro)
 VALUES('Agilson', 'Silva','email@gmail.com', 1, GETDATE())
 /*inserir dados na tabelas*/
 INSERT INTO Clientes VALUES('Elaine', 'Souza','email@gmail.com', 1, GETDATE())

 /*atualizar dados*/
 /*fazer sempre pelo Id*/
 UPDATE Clientes
 SET email = 'agilson@gmail.com'
WHERE Id = 61

/*Deletando registro da tabela*/
DELETE Clientes WHERE Id = 51

/*restaurar clientes*/
 BEGIN TRAN 
 ROLLBACK