Create table tbl_livro
(
	ID_Livro serial constraint pk_id_livro primary key,
	Nome_Livro varchar(50) not null,
	Autor integer not null,
	Editora integer not null,
	Data_Pub date,
	Genero integer not null,
	Preco_livro money,
	FOREIGN KEY (Autor) REFERENCES autores (ID_Autor)
);

Alter table Livros
add ISBN varchar(20) not null;

Alter table Veiculos
drop cor;

Alter table Livros
Alter column ISBN type varchar(25);