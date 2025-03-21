# Login App

## Dependências

- MySql.Data.MySqlClient

## Funcionalidades

Além da funcionalidade de login e registro, o programa possui uma área de registro onde novos usuários podem criar suas próprias contas, fornecendo suas credenciais de login.
Na área privada, existe uma página para remover ou alterar a senha de um e-mail registrado no banco de dados.

## Criptografia SHA256

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

<p float="center">
  <img src="https://i.imgur.com/OHJRjXi.png" width="400" />
</p>

## Licença

[MIT License](https://github.com/rodriaum/Login?tab=MIT-1-ov-file#MIT-1-ov-file).