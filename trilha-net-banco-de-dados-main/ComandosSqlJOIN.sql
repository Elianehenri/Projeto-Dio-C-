/* relaizando o join jun�ao de 2 tables*/

SELECT * FROM Clientes
INNER JOIN Enderecos ON Clientes.Id = Enderecos.IdCliente
WHERE Clientes.Id = 61
