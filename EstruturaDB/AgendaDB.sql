CREATE DATABASE dbAgenda;
USE dbAgenda;

CREATE TABLE tbUsuarios (
	nome VARCHAR(80) NOT NULL,
    usuario VARCHAR(40) PRIMARY KEY,
    telefone VARCHAR(15),
    senha VARCHAR(8) NOT NULL
    );
    
CREATE TABLE tbCategoria (
	cod_categoria INT auto_increment PRIMARY KEY,
    categoria VARCHAR(20) NOT NULL
    );    


