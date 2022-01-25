# GRA
Api RestFull que retorna o os diretores com maior e menor intervalo de tempo a ganhar o prêmio Framboesa de Ouro
# Tecnologias utilizadas:
Linguagem C#;
.Net Core 5.0;
Entity Framework Core 5.0;
SQLite;
# Execução
Basta baixar o projeto, executar com Visual Studio, Compativel com as versões dos Frameworks citados acima, a consulta pode ser feita direto no browser de internet padrão ou utilizando o Postman atravéz do endereço: https://localhost:44314/Awards
# Fonte de dados
Para alterar a fonte de dados, substitua o conteúdo do arquivo movielist.csv dentro do projeto GRA.Application na pasta \Resources
# OBSERVAÇÃO
O teste integrado foi efetuado com base no Arquivo CSV Original, ao alterar o arquivo, alterar o resultado esperado na classe de testes (AwardControllerTest.cs), no metodo de teste GetIntervalTest().
