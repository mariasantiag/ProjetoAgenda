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
    nome_categoria VARCHAR (20) NOT NULL
    );

DELIMITER $$

CREATE TRIGGER trInsertCategoria
	BEFORE 
	INSERT
	ON tbCategoria
	FOR EACH ROW
BEGIN
	SET NEW.usuario = CURRENT_USER();
END;
$$
DELIMITER ;

CREATE USER 'Usuario1'@'%' IDENTIFIED BY '123';
select * from mysql.user;



CREATE TABLE tbLog( idLog INT AUTO_INCREMENT PRIMARY KEY,
					 usuario VARCHAR (40) NOT NULL,
					 dataehora DATETIME NOT NULL,
                     descricao VARCHAR (70));
 
 DELIMITER $$
 DROP TRIGGER trLogDeleteCategoria;
 
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
