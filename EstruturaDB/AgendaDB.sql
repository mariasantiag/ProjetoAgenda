CREATE DATABASE dbAgenda;
USE dbAgenda;

CREATE TABLE tbUsuarios (
	nome VARCHAR(80) NOT NULL,
    usuario VARCHAR(40) PRIMARY KEY,
    telefone VARCHAR(15),
    senha VARCHAR(8) NOT NULL
    );
    
    
