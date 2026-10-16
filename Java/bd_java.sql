create schema lpc2x;

use lpc2x;

create table alunos(
	id  int not null auto_increment,
    nome varchar(100) not null,
    cidade varchar(100),
    primary key(id)
    );

INSERT INTO alunos (nome,cidade) VALUES ('Amanda','Paulínia');

INSERT INTO alunos (nome,cidade) VALUES ('Enzo','Paulíniacity');

INSERT INTO alunos (nome,cidade) VALUES ('Quatro 4','Quatrolandia');

SELECT* FROM alunos;