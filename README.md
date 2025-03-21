# Windows Forms Login

Este projeto � um simples programa de login e registro criado em C#.

## Depend�ncias

- MySql.Data.MySqlClient

## Funcionalidades

- Conex�o com banco de dados MySQL.
- Verifica��o de campos de e-mail e senha.
- Sistema de encripta��o SHA256.

## Encripta��o SHA256

```csharp
        public static string SHA256(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
```

## Imagens

<p float="left">
  <img src="https://i.imgur.com/OHJRjXi.png" width="800" />
</p>

## Uso

Al�m da funcionalidade de login, o programa possui uma �rea de registro onde os novos usu�rios podem criar suas pr�prias contas, fornecendo suas credenciais de login.
Na �rea privada, existe uma p�gina para remover ou alterar a password de um e-mail a escolha registrado no banco de dados.

## Licen�a

[MIT License](https://github.com/rodriaum/Login?tab=MIT-1-ov-file#MIT-1-ov-file).