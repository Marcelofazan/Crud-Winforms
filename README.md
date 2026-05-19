## CRUD-Windows-Form-MySQL
Exemplo de criação de CRUD em Windows Form C# com banco de dados MySQL.

#### O que voçê vai ver nesse Projeto
| Tecnologia | Descrição |
|-----------|-----------|
|  **DAO** | Centralizar e isolar toda a lógica de persistência e acesso a dados. |

#### Execução da aplicação
- Para executar a aplicação é necessário a execução do Script do MySQL.

#### String de conexão do banco
Modifique a string de conexão no arquivo **app.config**, no trecho indicado:

```bash
connectionString="server=127.0.0.1;userid=root;password=SUASENHA;database=SEUBANCO;persistsecurityinfo=True"
```
O script para criação da tabela do exemplo encontra-se na pasta **Database**.
