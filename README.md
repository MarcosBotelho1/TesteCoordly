# TesteApi 

## Descrição

Este projeto é uma API simples de gerenciamento de produtos construída com .NET Core e Entity Framework Core. Ele expõe uma API RESTful para permitir operações básicas de CRUD (Criar, Ler, Atualizar e Deletar) para produtos. Cada produto possui as propriedades:

- **ProductID**: Identificador único do produto.
- **Name**: Nome do produto (obrigatório).
- **Price**: Preço do produto (obrigatório, maior que zero).
- **StockQuantity**: Quantidade disponível em estoque (obrigatório, maior ou igual a zero).

A API também utiliza o Swagger para documentar os endpoints e facilitar os testes.

---

## Instruções para rodar o projeto localmente

### Pré-requisitos

- **.NET SDK**: Você precisa ter o .NET SDK instalado em sua máquina. Se não tiver, pode baixar em: [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download).
- **SQL Server LocalDB** (ou outro banco de dados): Certifique-se de que o LocalDB ou outro banco de dados esteja configurado corretamente para que a API possa se conectar e realizar as migrações.

### Passos

1. **Clone o repositório**:
   Se você ainda não fez isso, comece clonando o repositório para sua máquina local:
   ```bash
   git clone <URL_do_repositorio>
   cd <diretorio_do_repositorio>
   ```

2. **Restaurar as dependências**:
   Execute o comando para restaurar as dependências do projeto:
   ```bash
   dotnet restore
   ```

3. **Criar o banco de dados**:
   Antes de rodar o projeto, você precisa garantir que o banco de dados foi criado. Para isso, execute a migração inicial:
   ```bash
   dotnet ef database update
   ```

4. **Rodar a API**:
   Para rodar a API localmente, use o comando:
   ```bash
   dotnet run
   ```

   Após rodar o comando, a API estará disponível por padrão no endereço:  
   `https://localhost:5001` (ou `http://localhost:5000` para HTTP, caso o HTTPS não esteja habilitado).

---

## Acessando o Swagger

1. **Abra o navegador**:
   Após rodar a API com `dotnet run`, acesse o Swagger para testar os endpoints da API.

2. **Acesse o Swagger UI**:
   O Swagger UI estará disponível no seguinte endereço:
   - **Para HTTPS**: `https://localhost:5001/swagger`
   - **Para HTTP**: `http://localhost:5000/swagger`

   O Swagger UI irá exibir uma interface interativa onde você pode testar os endpoints da API, como:
   - **GET** para listar todos os produtos.
   - **POST** para criar um novo produto.
   - **PUT** para atualizar um produto existente.
   - **DELETE** para excluir um produto.

---

## Tecnologias Utilizadas

- **.NET 9.0**
- **Entity Framework Core** para acesso ao banco de dados.
- **SQL Server LocalDB** (pode ser configurado para outros bancos de dados como SQL Server, MySQL, SQLite, etc).
- **Swagger** para documentação e testes da API.

