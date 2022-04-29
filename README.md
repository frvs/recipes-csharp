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

### dúvidas sobre os models

Food.Hero - o que é?
Ingredient.Quantity - virou int
Ingredient.Unit - o que é?
Tool.Hero - o que é?
Recipe.Hero - o que é?
------- dúvidas até aqui sanadas pelo twitter

### por que dto e models se a diferença é tão pouca?
também estou me perguntando xD. talvez até o final do projeto eu mude isso, mas...
1. não quero expor ids no input do controller (não queremos que o usuário sete o id de algo e sim o banco)
2. a separação entre 'viewmodel' (objeto da tela) e 'model' (objeto do banco) faz sentido na maioria dos casos
3. partindo do pressuposto q viewmodel e model podem evoluir pra coisas distintas, 
é melhor ter dois objetos parecidos do q deixar um acoplamento q não faz sentido

## por que default values nos reference types nos models/dtos?
sem tempo pra null reference exception, irmao

## disclaimer sobre comentários
sem perceber, comecei a deixar comentários no código pra documentar meus pensamentos/decisoes
nao faria isso num código 'de trabalho', a intenção é só q tu veja o q pensei =)

## commits