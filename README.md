
# To do List App (Console)

Este projeto é uma aplicação console em C# aplicando um CRUD básico para manipular listas de tarefas de forma simples e organizada. 

### Objetivo
Este projeto tem como objetivo principal a prática e consolidação de conceitos fundamentais da linguagem C# e do ecossistema .NET, com foco estrito no Paradigma de Orientação a Objetos (POO).

A aplicação consiste em um gerenciador de tarefas via terminal (Console Application), permitindo ao usuário controlar suas atividades diárias através de operações de criação, leitura, atualização e remoção.

### Desafio
O desafio proposto foi desenvolver uma solução que separasse adequadamente as responsabilidades das classes, evitando colocar toda a lógica no arquivo principal (Program.cs). 

Os principais pontos abordados foram:
- Abstração: Criação de entidades que representam o item de trabalho (WorkItem).

- Encapsulamento: Proteção das propriedades e uso de métodos para alterar o estado do objeto (como MarkCompleted).

- Camada de Serviço: Implementação de uma classe dedicada (ItemManagement) para lidar com a lógica de negócios e manipulação da lista.

- Tratamento de Erros: Uso de exceções personalizadas (DomainExceptions) para garantir a robustez da aplicação.

### Exemplo de funcionamento

Abaixo, uma demonstração da interface da aplicação rodando no console:

**Example:**
<img width="1120" height="629" alt="Image" src="https://github.com/user-attachments/assets/70720557-68c8-433c-aefe-02c53a4a8fc9" />

**Example adding items to the list:**
<img width="1121" height="405" alt="Image" src="https://github.com/user-attachments/assets/efa739ff-31b3-4e1a-8d10-ca4b725c29cd" />

**Example marking a task as complete:**
<img width="1119" height="431" alt="Image" src="https://github.com/user-attachments/assets/19a198d7-c664-4b3b-b4a7-729fcd08d238" />

O menu interativo permite navegar entre adicionar, listar, concluir e remover tarefas de forma dinâmica.

### Instruções de uso
Para executar este projeto em sua máquina local, certifique-se de ter o SDK do .NET instalado.


+ Clone este repositório.

+ Compile e execute o projeto (por exemplo, usando o Visual Studio ou o comando dotnet run se estiver utilizando o VS Code).

Navegação no Menu:

- Digite o número correspondente à opção desejada e pressione ENTER.
- Siga as instruções na tela para inserir descrições de tarefas ou IDs para remoção/conclusão.

### Tecnologias e conceitos utilizados

O projeto foi desenvolvido utilizando as seguintes tecnologias e conceitos:

+ Linguagem: C#
+ Plataforma de desenvolvimento:.NET (Console Application)
+ Conceitos de POO:
    + Classes e Objetos
    + Encapsulamento (Properties e Access Modifiers)
    + Enums (Status) para controle de estado

+ Estruturas de Dados: List<T> para gerenciamento dinâmico de memória.
+ LINQ: Utilizado para consultas em coleções (métodos Where, FirstOrDefault).
+ Exception Handling: Tratamento de exceções padrão (FormatException) e personalizadas (DomainExceptions).
<div align="center"> Desenvolvido para fins de estudo e prática de C#. </div>

### Contato
Sou uma pessoa em continuo aprendizado e evolução, então, peço por favor, se você é uma pessoa com conhecimento na linguagem e tecnologias utilizadas, realize contato comigo a través do meu Linkedln para receber seu Feedback. 

🔗 **[Conecte-se comigo no LinkedIn!](https://www.linkedin.com/in/luis-marcano537/)**
