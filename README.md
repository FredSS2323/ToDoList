# 📝 ToDoList em C# (Console)

Este é um simples gerenciador de tarefas (To-Do List) feito em **C#** com interface de **linha de comando (CLI)**. O projeto permite ao usuário adicionar, listar, remover, concluir e exportar tarefas para um arquivo `.txt`.

---

## ⚙️ Funcionalidades

- ✅ Adicionar novas tarefas
- 📃 Listar tarefas com status (Pendente ou Concluída)
- ❌ Remover tarefas individualmente
- ✔️ Marcar uma tarefa como concluída
- ✔️ Marcar todas como concluídas
- 🗑️ Apagar todas as tarefas
- 💾 Exportar a lista de tarefas para um arquivo `.txt`
- 🛑 Encerrar o programa

---

## 🖥️ Tecnologias

- [.NET Core](https://dotnet.microsoft.com/)
- C#
- VS Code (Visual Studio Code)
- Console/Terminal (CLI)

---

## 🧪 Ambiente de Desenvolvimento

Este projeto foi desenvolvido e testado em:

- Sistema Operacional: **Ubuntu 22.04 LTS**
- Editor de código: **Visual Studio Code**
- Terminal: **Bash**
- SDK do .NET: **.NET 6.0** (ou superior)

> Compatível com **Linux**, **Windows** e **macOS** desde que o .NET SDK esteja instalado.

---

## 📦 Como executar o projeto

> Pré-requisitos:
> - .NET SDK instalado ([instale aqui](https://learn.microsoft.com/pt-br/dotnet/core/install/linux))
> - Git instalado

### 1. Clone o repositório

git clone https://github.com/seu-usuario/ToDoList.git
cd ToDoList

### 2. Compile e execute o projeto

dotnet build
dotnet run

📂 Estrutura do Projeto

ToDoList/
├── Program.cs         # Código principal (menu e funcionalidades)
├── Tarefa.cs          # Classe que representa uma tarefa
├── Relatório.txt      # Arquivo gerado com as tarefas (se solicitado)
├── README.md          # Este arquivo
└── .gitignore         # Arquivos e pastas ignoradas pelo Git

📄 Exemplo de uso

1 - Nova Tarefa
2 - Listar Tarefas
3 - Remover uma Tarefa
4 - Concluir uma Tarefa
5 - Concluir Todos
6 - Apagar Todos
7 - Gerar Arquivo de Tarefas
8 - Sair


