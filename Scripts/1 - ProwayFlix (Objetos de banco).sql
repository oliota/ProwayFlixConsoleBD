 
create database BancoProway;

use BancoProway;
 
 --owner padrao LAPTOP-TT37ONLI\algor
 --caso de erro alterar para sa

 --drop table perfis
 CREATE TABLE perfis (
    id_perfil int IDENTITY(1,1)  ,
    nome varchar(50),
);


  
 --drop table usuarios
 CREATE TABLE usuarios (
    id_usuario int IDENTITY(1,1) ,
    nome varchar(50),
    email varchar(50),
    login varchar(50),
    senha varchar(50),
    perfil int
);
  

---------------------------------------



 CREATE TABLE categorias (
    id_categoria int IDENTITY(1,1),
    nome varchar(50)
);

  
 CREATE TABLE filmes (
    id_filme int IDENTITY(1,1),
    nome varchar(50),
    ano int,
    sinopse varchar(1024), 
    categoria int
);




-------------------------------
 
 CREATE TABLE series (
    id_serie int IDENTITY(1,1),
    nome varchar(50), 
    ano int,
    sinopse varchar(1024), 
    categoria int
);


    
	

    CREATE TABLE temporadas (
    id_temporada int IDENTITY(1,1), 
    serie int,
    sequencial int
);

 

	----------------------------
	 
	 CREATE TABLE episodios (
    id_episodio int IDENTITY(1,1), 
	 nome varchar(50),  
    sinopse varchar(1024),
    temporada int,
    sequencial int
);


	 CREATE TABLE assistidos (
    id_assistido int IDENTITY(1,1), 
	filme int,  
    serie int,
    dataehora date
);





