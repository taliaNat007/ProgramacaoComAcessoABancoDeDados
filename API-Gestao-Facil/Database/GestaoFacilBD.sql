CREATE DATABASE GestaoFacilBD;
USE GestaoFacilBD;

CREATE TABLE Servidor(
id_servidor INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
nome_servidor VARCHAR(150) NOT NULL,
cpf_servidor VARCHAR(14)  NOT NULL,
siape_servidor INT NOT NULL
);

INSERT INTO Servidor VALUES
	(null, "Natália da Silva Fernandes", "05810263224", 20222020),
    (null, "Heitor da Silva Fernandes", "06138712224", 02202126),
    (null, "Daniel Augusto Ferreira", "61361752424", 13695896),
    (null, "Maria de Fátima da Silva Ferreira", "78384320456", 56983652);
    
SELECT * FROM Servidor;
    