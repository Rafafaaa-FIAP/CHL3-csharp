# Sistema de Registro de Pedidos - Delivery

Este projeto é um sistema simples em **C# Console Application** para registrar pedidos de delivery utilizando **arrays estáticos**, sem limite de quantidade pré-definido além da capacidade natural do array.

---

## 🧩 Tema do Projeto
O projeto representa um sistema básico de controle de pedidos de delivery. Ele simula operações essenciais como:
- Cadastro de pedidos
- Listagem dos pedidos existentes
- Busca por pedidos específicos
- Exclusão de pedidos
- Armazenamento em arrays simples

Esse modelo pode servir como base para o desenvolvimento de sistemas mais complexos, como:
- Aplicações Desktop,
- APIs REST,
- Integração com bancos de dados,
- Sistemas de gestão de restaurantes.

---

## 📌 Funcionalidades
- Registrar pedidos contendo:
  - Nome do cliente  
  - Item pedido  
  - Valor  
  - Data no formato **DD/MM/YYYY**
- Listar todos os pedidos
- Pesquisar pedido por cliente
- Excluir pedido por índice
- Arrays dinâmicos (sem limitação artificial)
- Código totalmente comentado

---

## 📦 Requisitos
- **Windows**, **Linux** ou **macOS**
- **.NET SDK 8.0** ou superior
- Editor recomendado:
  - Visual Studio 2022  
  - Visual Studio Code  
  - Rider

---

## ▶️ Como executar

### 1. Criar o projeto
No terminal:
```bash
dotnet new console -n SistemaDelivery
```

Entre no diretório:
```bash
cd SistemaDelivery
```

Substitua o conteúdo do `Program.cs` pelo código fornecido anteriormente.

---

### 2. Executar o sistema
```bash
dotnet run
```

---

## 🛠 Estrutura de Arquivos
```
SistemaDelivery/
│-- Program.cs
│-- README.md
```

---

## 👨‍💻 Autor
Projeto solicitado por estudante de Engenharia de Software para trabalho acadêmico.

---

## 📝 Observações
Sinta-se à vontade para expandir este projeto adicionando:
- Persistência em arquivos JSON
- Banco de dados SQL
- Interface gráfica (WinForms/WPF)
- API Web (ASP.NET Core)

