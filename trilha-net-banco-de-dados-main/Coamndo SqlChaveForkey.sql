/*primary key e forekey*/
CREATE TABLE Enderecos(
Id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
IdCliente int ,
Rua VARCHAR(255),
Bairro VARCHAR(255),
Cidade VARCHAR(255),
Estado CHAR(2),

CONSTRAINT FK_Enderecos_Clientes FOREIGN KEY(IdCliente)
REFERENCES Clientes(Id)
)

select * from Enderecos

INSERT INTO Enderecos VALUES(61, 'Rua Sao Jose','Bairro Tracado','Cidade Urubici', 'SC')

select * from Clientes where Id = 61
select * from Enderecos where IdCliente = 61