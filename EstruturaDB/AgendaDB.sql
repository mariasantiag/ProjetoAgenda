
-- ----- CRIANDO BANCO DE DADOS E TABELAS ------------------
CREATE DATABASE dbAgenda;
USE dbAgenda;

CREATE TABLE tbUsuarios (
	nome VARCHAR(80) NOT NULL,
    usuario VARCHAR(40) PRIMARY KEY,
    telefone VARCHAR(15),
    senha VARCHAR(8) NOT NULL
    );

CREATE TABLE tbCategoria (
	cod_categoria INT AUTO_INCREMENT PRIMARY KEY,
    nome_categoria VARCHAR (20) NOT NULL,
	usuario VARCHAR(20) NOT NULL
    );



-- ---- TRIGGER DE INSERIR CATEGORIA ---------------------

DELIMITER $$

CREATE TRIGGER trInsertCategoria
	BEFORE 
	INSERT
	ON tbCategoria
	FOR EACH ROW
BEGIN
	SET NEW.usuario = USER();
END;
$$
DELIMITER ;


-- ---- TABELA DE LOG ---------------------

CREATE TABLE tbLog( idLog INT AUTO_INCREMENT PRIMARY KEY,
					 usuario VARCHAR (40) NOT NULL,
					 dataehora DATETIME NOT NULL,
                     descricao VARCHAR (70));
 

 -- ---- TRIGGERS DA CATEGORIA ---------------------
 DELIMITER $$

 
CREATE TRIGGER trLogDeleteCategoria 
	AFTER
    DELETE
    ON tbCategoria
    FOR EACH ROW
BEGIN 
	INSERT INTO tbLog
				(usuario,
				dataehora,
				descricao)
    VALUES
		  (USER(),
		   current_date(),
           CONCAT('A categoria ', old.nome_categoria, ' foi excluida')
           );
END;
 $$   
 
 
DELIMITER ;



DELIMITER $$

 
CREATE TRIGGER trLogInserirCategoria 
	AFTER
    INSERT
    ON tbCategoria
    FOR EACH ROW
BEGIN 
	INSERT INTO tbLog
				(usuario,
				dataehora,
				descricao)
    VALUES
		  (USER(),
		   current_date(),
           CONCAT('A categoria ', new.nome_categoria, ' foi inserida')
           );
END;
 $$   
 
 
DELIMITER ;


DELIMITER $$

 
CREATE TRIGGER trLogAlterarCategoria 
	AFTER
    UPDATE
    ON tbCategoria
    FOR EACH ROW
BEGIN 
	INSERT INTO tbLog
				(usuario,
				dataehora,
				descricao)
    VALUES
		  (USER(),
		   current_date(),
           CONCAT('A categoria ', old.nome_categoria, ' foi  alterada para ', new.nome_categoria)
           );
END;
 $$   
 
 
DELIMITER ;


-- ---- TABELA DE CONTATOS ---------------------

CREATE TABLE tbContatos (
	contato VARCHAR(80) NOT NULL,
    telefone VARCHAR(40) PRIMARY KEY,
    categoria VARCHAR(15)
    );


DELIMITER $$


-- ---- TRIGGERS DO CONTATO ---------------------
 
CREATE TRIGGER trLogInserirContato 
	AFTER
    INSERT
    ON tbContatos
    FOR EACH ROW
BEGIN 
	INSERT INTO tbLog
				(usuario,
				dataehora,
				descricao)
    VALUES
		  (USER(),
		   current_date(),
           CONCAT('O contato ', new.contato, ' foi inserido')
           );
END;
 $$   
 
 
DELIMITER ;


DELIMITER $$

CREATE TRIGGER trLogDeleteContato
	AFTER
    DELETE
    ON tbContatos
    FOR EACH ROW
BEGIN 
	INSERT INTO tbLog
				(usuario,
				dataehora,
				descricao)
    VALUES
		  (USER(),
		   current_date(),
           CONCAT('O contato ', old.contato, ' foi excluido')
           );
END;
 $$   
 
 DELIMITER ;



 DELIMITER $$

CREATE TRIGGER trLogAlterarContato
	AFTER
    UPDATE
    ON tbContatos
    FOR EACH ROW
BEGIN 
	INSERT INTO tbLog
				(usuario,
				dataehora,
				descricao)
    VALUES
		  (USER(),
		   current_date(),
           CONCAT('O contato ', old.contato, ' foi  alterada para ', new.contato, '\n',
				  'A categoria', old.categoria, 'foi alterada para', new.categoria)
           
           );
END;
 $$   
 
 
DELIMITER ;



 -- ---- TRIGGERS DO USUARIO ---------------------

 DELIMITER $$

 
CREATE TRIGGER trLogAlterarSenha
	AFTER
    UPDATE
    ON tbUsuarios
    FOR EACH ROW
BEGIN 
	INSERT INTO tbLog
				(usuario,
				dataehora,
				descricao)
    VALUES
		  (USER(),
		   current_date(),
           CONCAT('A senha ', old.senha, ' foi  alterada para ', new.senha)
           );
END;
 $$   
 
 
DELIMITER ;




DELIMITER $$

CREATE TRIGGER trLogDeleteUsuario
	AFTER
    DELETE
    ON tbUsuarios
    FOR EACH ROW
BEGIN 
	INSERT INTO tbLog
				(usuario,
				dataehora,
				descricao)
    VALUES
		  (USER(),
		   current_date(),
           CONCAT('O usuario ', old.usuario, ' foi excluido')
           );
END;
 $$   
 
 DELIMITER ;
