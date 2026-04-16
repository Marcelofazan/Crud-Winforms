CREATE TABLE pessoa (
  Id int NOT NULL AUTO_INCREMENT,
  RazaoSocial varchar(80) DEFAULT NULL,
  NomeFantasia varchar(80) DEFAULT NULL,
  Cnpj varchar(18) DEFAULT NULL,
  InscrEstadual varchar(20) DEFAULT NULL,
  InscrMunicipal varchar(20) DEFAULT NULL,
  DataCadastro datetime DEFAULT NULL,
  Email varchar(200) DEFAULT NULL,
  Celular varchar(15) DEFAULT NULL,
  Usuario varchar(100) DEFAULT NULL,
  Senha varchar(12) DEFAULT NULL,
  IeDestinatario varchar(20) DEFAULT NULL,
  PRIMARY KEY (Id)
);
