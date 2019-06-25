# Nhibernate-.NetCore

Database scripts

CREATE DATABASE `livrariademo` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;

CREATE TABLE `livros` (
  `livroId` int(11) NOT NULL AUTO_INCREMENT,
  `titulo` varchar(200) DEFAULT NULL,
  `dataCadastro` datetime DEFAULT NULL,
  PRIMARY KEY (`livroId`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*
-- Query: SELECT * FROM livrariademo.livros
LIMIT 0, 1000

-- Date: 2019-06-25 14:52
*/
INSERT INTO `` (`livroId`,`titulo`,`dataCadastro`) VALUES (1,'C# Como Programar','2019-06-01 07:00:00');
INSERT INTO `` (`livroId`,`titulo`,`dataCadastro`) VALUES (2,'Use a Cabeça C#','2019-06-02 09:00:00');
INSERT INTO `` (`livroId`,`titulo`,`dataCadastro`) VALUES (3,'Harry Potter e a Pedra Filosofal','2019-06-03 10:00:00');
INSERT INTO `` (`livroId`,`titulo`,`dataCadastro`) VALUES (4,'O Código Da Vinci','2019-06-04 07:00:00');
