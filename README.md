# 🩺 Sistema de Registro de Atividades de Saúde (Console em C#)

Este projeto é uma aplicação **console em C#** desenvolvida para registrar, organizar e visualizar informações relacionadas a atividades de saúde, como:

- Minutos de exercício
- Litros de água ingeridos
- Horas de sono

O programa foi desenvolvido utilizando **arrays internos**, conforme requisitos acadêmicos, e possui expansão automática de capacidade.

---

## 📌 Funcionalidades

### ✅ **1. Adicionar registro**
O usuário informa:
- Tipo de atividade  
- Data no formato **DD/MM/YYYY**  
- Valor numérico (minutos, litros ou horas)  

Os dados são validados antes de serem salvos.

---

### ✅ **2. Listar registros**
Exibe todos os registros cadastrados em ordem.

---

### ✅ **3. Exibir estatísticas**
Para cada tipo de atividade, o programa mostra:
- Soma total dos valores
- Média dos valores registrados

---

### ✅ **4. Sair**
Encerra a aplicação.

---

## 🧱 Estrutura e Requisitos Atendidos

| Requisito | Atendido | Descrição |
|----------|----------|-----------|
| Métodos/funções organizadas | ✔ | Cada funcionalidade tem seu próprio método |
| Validação de entradas | ✔ | Verificação de números, formatos e dados |
| Interface clara | ✔ | Menu organizado com feedback visual |
| Uso de arrays internos | ✔ | Arrays dinâmicos com expansão automática |

---

## 🚀 Como executar o projeto

### 1. Abra o Visual Studio  
Versão recomendada: **Visual Studio 2022**

### 2. Crie um novo projeto
- Tipo: **Console Application (.NET 6 ou superior)**

### 3. Substitua o conteúdo do `Program.cs`
Cole o código fornecido neste repositório.

### 4. Execute
Pressione **F5** ou clique em **Run ▶**.

---

## 🧩 Tecnologias Utilizadas

- **C# .NET 6+**
- Console Application
- Arrays internos com `Array.Resize`
- `DateTime.TryParseExact` para validação de datas

---

## 📦 Expansão Automática de Registros

Embora arrays tenham tamanho fixo, este projeto implementa expansão automática:

```csharp
Array.Resize(ref tipos, novoTamanho);
```

Isso garante capacidade ilimitada sem usar List<>.

##  Integrantes
* RM553377 - Enzo Rodrigues
* RM553266 - Hugo Santos
* RM553384 - Maria Julia
* RM553521 - Rafael Cristofali
