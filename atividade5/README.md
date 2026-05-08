# Pratica LP2 - Aula 6

## Descrição
Este projeto implements dois exercícios propostos na aula de LP2 (Linguagem de Programação 2) utilizando Windows Forms com C#.

## Estrutura do Projeto
```
atividade5/
├── atividade5.sln              # Arquivo de solução do Visual Studio
├── Pratica_LP2_Aula6.pdf       # PDF com os enunciados dos exercícios
├── package.json                # Configuração Node.js (opencode)
└── atividade5/
    ├── atividade5.csproj       # Projeto MSBuild (.NET Framework 4.7.2)
    ├── Program.cs              # Ponto de entrada da aplicação
    ├── Form1.cs                # Lógica dos formulários
    ├── Form1.Designer.cs       # Designer UI do Windows Forms
    └── bin/Debug/atividade5.exe # Executável compilado
```

## Tecnologias
- **Framework:** .NET Framework 4.7.2
- **Linguagem:** C#
- **UI:** Windows Forms
- **IDE:** Visual Studio 2022

## Exercícios Implementados

### Exercício 1 - Ordenar 3 Números (4.0 pontos)
**Objetivo:** Criar uma aplicação que leia 3 números e exiba-os em ordem crescente.

**Funcionalidades:**
- 3 campos de texto para entrada dos números
- 1 campo de texto somente leitura para exibir o resultado
- Botão "Ordenar" que executa a lógica de ordenação
- Tratamento de erros para entradas inválidas

**Lógica implementada:**
```csharp
double[] numeros = { num1, num2, num3 };
Array.Sort(numeros);
textBox4.Text = numeros[0] + ", " + numeros[1] + ", " + numeros[2];
```

### Exercício 2 - Calcular Desconto (6.0 pontos)
**Objetivo:** Criar uma aplicação que leia o preço de um produto e uma porcentagem de desconto, exibindo o valor do desconto e o preço final.

**Funcionalidades:**
- Campo para entrada do preço do produto
- Campo para entrada da porcentagem de desconto
- 2 campos somente leitura para exibir valor do desconto e preço final
- Botão "Calcular" que executa os cálculos
- Tratamento de erros para entradas inválidas

**Lógica implementada:**
```csharp
double valorDesconto = preco * (desconto / 100);
double precoFinal = preco - valorDesconto;
```

## Interface
A aplicação utiliza um `TabControl` com duas abas:
- **Aba 1:** Exercício 1 - Ordenar Números
- **Aba 2:** Exercício 2 - Calcular Desconto

## Compilação e Execução

### Compilar
```bash
cd C:/Users/0030482523046/source/repos/atividade5
"/c/Program Files (x86)/Microsoft Visual Studio/2019/BuildTools/MSBuild/Current/Bin/MSBuild.exe" atividade5.sln -p:Configuration=Debug
```

### Executar
O executável está localizado em:
```
atividade5/bin/Debug/atividade5.exe
```

Ou simplesmente abra o projeto no Visual Studio e pressione F5.

## Validação
- Build: **Sucesso** (0 warnings, 0 errors)
- Tratamento de exceções implementado para entradas inválidas
- Interface amigável com mensagens de erro via MessageBox