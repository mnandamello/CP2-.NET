### Disciplina: ADVANCED BUSINESS DEVELOPMENT WITH .NET

### Equipe do Projeto
- Alberto R. Peruchi - RM 99706
- Gabrielle Stanguini- RM 98786
- Maria Fernanda Ribeiro Mello- RM 98818
- Nicolas Reis do Espirito Santo - RM 98819


### O que foi feito no projeto?

- Criação de uma Model User, com atributos de id, nome, email e senha.
- Utilização da View e Controller Home, para printar os dados dos integrantes do grupo na tela principal.
- Criação de um UserController onde está o método post de cadastro, chamado Register. A view que referencia a controller de cadastro é a User. Sendo o Index, o formulário, e o Register onde colocamos para retornar a mensagem em outra página, quando ele é cadastrado com sucesso.
- Criação de um UserLoginController onde está o método post de Login, chamado FLogin. A view que referencia a controller de login é a UserLogin. Sendo o Index o formulário, e o FLogin onde colocamos para retornar a mesagem em outra página, quando o usuário realiza login com sucesso.
- Programa está salvando os novos usuários no banco de dados. Os dados do banco estão no appsettings.json. Além disso foi criado um DataContext, para fazer a criação da tabela no Banco de Dados e um DTO de Register para a validação do usuário no cadastro.
