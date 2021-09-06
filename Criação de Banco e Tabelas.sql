Create Database ProvaRemota;

Use ProvaRemota;

CREATE TABLE TIPO_CLIENTES(
	TICL_PK_ID INT IDENTITY(1,1) PRIMARY KEY,
	TICL_TIPO VARCHAR(50) NOT NULL,
	TICL_DESCRICAO VARCHAR(100) NOT NULL
);
GO

CREATE INDEX TICL_PK_DESCRICAO_TIPO
ON TIPO_CLIENTES (TICL_PK_ID, TICL_DESCRICAO, TICL_TIPO);
GO

CREATE TABLE SITUACAO_CLIENTES(
	SICL_PK_ID INT IDENTITY(1,1) PRIMARY KEY,
	SICL_DESCRICAO VARCHAR(100) NOT NULL
);
GO

CREATE INDEX SICL_PK_DESCRICAO
ON SITUACAO_CLIENTES (SICL_PK_ID, SICL_DESCRICAO);
GO

CREATE TABLE CLIENTES(
	CLIE_PK_ID INT IDENTITY(1,1) PRIMARY KEY,
	CLIE_CPF VARCHAR(15) NOT NULL UNIQUE,
	CLIE_NOME VARCHAR(100) NOT NULL,
	CLIE_NASCIMENTO DATETIME NOT NULL,
	CLIE_SEXO CHAR(1),
	CLIE_FK_PK_TICL INT NOT NULL,
	CLIE_FK_PK_SICL INT NOT NULL,
	FOREIGN KEY (CLIE_FK_PK_TICL) REFERENCES TIPO_CLIENTES(TICL_PK_ID),
	FOREIGN KEY (CLIE_FK_PK_SICL) REFERENCES SITUACAO_CLIENTES(SICL_PK_ID)
);
GO

CREATE INDEX CLIE_PK_NOME
ON CLIENTES (CLIE_PK_ID, CLIE_NOME);
GO

CREATE INDEX CLIE_PK_NOME_CPF
ON CLIENTES (CLIE_PK_ID, CLIE_NOME, CLIE_CPF);
GO

CREATE INDEX CLIE_PK_CPF
ON CLIENTES (CLIE_PK_ID, CLIE_CPF);
GO

CREATE INDEX CLIE_PK_SICL_PK_TICL_PK
ON CLIENTES (CLIE_PK_ID, CLIE_FK_PK_TICL, CLIE_FK_PK_SICL);
GO