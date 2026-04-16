# CRUD-Windows-Form-MySQL

Exemplo de criação de CRUD em Windows Form C# com banco de dados MySQL.

## Competências

- **DAO** - Camada de dados separada da interface 
- **POO** - Criação de estrutura POO em 3 camadas 
- **DataTable** - Conversão de Reader para manipular DataGrid

## Execução da aplicação

Para executar a aplicação é necessário rodar Script banco de dados e Recompilar o Projeto

## String de conexão do banco

Modifique a string de conexão no arquivo **app.config**, no trecho indicado:

```bash
...
    connectionString="server=127.0.0.1;userid=root;password=SUASENHA;database=SEUBANCO;persistsecurityinfo=True"
...

```
O script para criação da tabela do exemplo encontra-se na pasta **Database**.

### Aqui está uma demonstração do Projeto

<img width="806" height="491" alt="CRUD-DAO-Windows-Form" src="https://github.com/user-attachments/assets/0e4a2c47-b621-45a4-b602-6119444d4e17" />

