# recipes-csharp

## anotações técnicas

- fazer em csharp ou fsharp?
considerações: em csharp eu entrego algo com qualidade melhor. 
em fsharp eu entrego algo mais aderente com o que a vaga quer.  ¯\_(ツ)_/¯

- banco: para testes, in-memory. para a app, decidir entre sqlserver/postgres e in-memory.
se a preguiça for muito grande, in-memory. se não, subir sqlserver/postgres num docker.

- queries: entre dapper, ef e escrever queries na mão, prefiro ef. 
não tem motivo pra ficar quebrando cabeça com query na mão. 
e também, queries 'tipadas', ou seja, geradas automaticamente, sem a chance de um erro humano ou de
um problema de um tipo são tudo de bom. =)

## dúvidas sobre os models
equipment, food, ingredient, recipe, tool