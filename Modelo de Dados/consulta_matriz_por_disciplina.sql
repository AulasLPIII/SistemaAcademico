SELECT m.nome,d.modulo,d.sigla,d.nome,d.cargahoraria 
FROM disciplina d, matrizcurricular m
where
d.iddisciplina = m.fk_iddisciplina
order by m.nome,d.modulo;