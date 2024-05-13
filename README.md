# Windows Forms Login

Este projeto é um simples programa de login e registro criado em C#.

## Dependências

- MySql.Data.MySqlClient

## Funcionalidades

- Conexão com banco de dados MySQL.
- Verificação de campos de e-mail e senha.
- Sistema de encriptação SHA256.

## Imagens

<p float="left">
  <img src="https://imgur.com/OzuXU64.png" width="200" />
  <img src="https://imgur.com/ZjC4pXE.png" width="200" /> 
  <img src="https://imgur.com/AMRP4zs.png" width="200" />
  <img src="https://imgur.com/GrB14cw.png" width="200" /> 
  <img src="https://imgur.com/CjYIXzT.png" width="200" />
</p>

## Uso

Antes de tudo, é preciso criar as tabelas, e você pode usar um [programa]([https://github.com/rodriaum/Login?tab=MIT-1-ov-file#MIT-1-ov-file](https://github.com/rodriaum/SQLTaskApplication)) que eu fiz dedicado para esse projeto. Ao iniciar o programa, uma conexão com o banco de dados é iniciada. Quando o botão de login é clicado, o programa verifica se os campos de e-mail e senha estão preenchidos. Se estiverem, ele cria um login não verificado no banco de dados.
Além da funcionalidade de login, o programa possui uma área de registro onde os novos usuários podem criar suas próprias contas, fornecendo suas credenciais de login.
Na área privada, existe uma página para remover ou alterar a password de um e-mail a escolha registrado no banco de dados.

## Contribuição

Contribuições são bem-vindas. Por favor, faça um fork do projeto e crie um pull request com suas alterações.

## Licença

Este projeto é licenciado sob a [MIT License](https://github.com/rodriaum/Login?tab=MIT-1-ov-file#MIT-1-ov-file).

---

*Nota: Por favor, esteja ciente de que este programa ainda está em fase de desenvolvimento e pode sofrer alterações.*