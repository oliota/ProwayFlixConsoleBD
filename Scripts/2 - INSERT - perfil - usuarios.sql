use BancoProway;


INSERT perfis (nome) VALUES ('Administrador'); 
INSERT perfis (nome) VALUES ('Usu�rio'); 


select * from perfis;

------------------------------------------

INSERT usuarios  
   (nome, email, login ,senha,perfil)  
VALUES  
   (
	   'Rubem Oliota',
	   'rubemoliota@gmail.com',
	   'admin',
	   '123',
	   ( select id_perfil from perfis where nome = 'Administrador')
   ); 

INSERT usuarios  
   (nome, email, login ,senha,perfil)  
VALUES  
   (
	   'Fulano',
	   'fulano@gmail.com',
	   'fulano',
	   '123',
	   ( select id_perfil from perfis where nome = 'Usu�rio')
   ); 
    
select * from usuarios;

select u.id_usuario,u.nome,u.email,u.login,u.senha,f.nome as perfil
from usuarios u
inner join perfis f on f.id_perfil= u.perfil;



------------------------------------------
 

