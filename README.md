# 💰 Calculadora de Investimentos

Calculadora de investimentos baseada na taxa CDI, desenvolvida como projeto prático para aplicação de conceitos de desenvolvimento web com **C# e ASP.NET Core**.

O sistema permite simular o rendimento de um investimento considerando o valor aplicado, a taxa CDI, o percentual do CDI e o período em dias úteis.

## 🚀 Funcionalidades

* Cálculo de rendimento baseado no CDI
* Suporte a diferentes percentuais do CDI
* Cálculo de rendimento bruto
* Cálculo automático do Imposto de Renda
* Cálculo de rendimento líquido
* Cálculo do saldo final
* Formatação de valores em reais
* Interface web para realização das simulações
* Endpoint HTTP para realizar os cálculos

## 🛠️ Tecnologias utilizadas

* **C#**
* **ASP.NET Core**
* **.NET 10**
* **HTML5**
* **CSS3**
* **JavaScript**
* **Git**
* **GitHub**

## 📂 Estrutura do projeto

```text
Calculadora Investimentos/
│
├── Properties/
│   └── launchSettings.json
│
├── wwwroot/
│   └── index.html
│
├── Program.cs
├── Calculadora Investimentos.csproj
├── Calculadora Investimentos.http
├── appsettings.json
├── appsettings.Development.json
└── .gitignore
```

## ⚙️ Como executar

### Pré-requisito

É necessário ter o **.NET 10 SDK** instalado.

### Executando o projeto

Clone o repositório:

```bash
git clone https://github.com/Breno011910/calculadora-investimentos.git
```

Entre na pasta:

```bash
cd calculadora-investimentos
```

Execute o projeto:

```bash
dotnet run
```

O endereço da aplicação será exibido no terminal.

## 📊 Exemplo de simulação

```text
Valor investido: R$ 5.000,00
CDI: 13,90% a.a.
Percentual do CDI: 100%
Período: 22 dias úteis
```

A aplicação retorna:

```text
Rendimento bruto
Imposto de Renda
Rendimento líquido
Saldo final
```

## 🎯 Objetivo do projeto

Este projeto foi desenvolvido como uma aplicação prática para estudar e aplicar conceitos de **C#**, **ASP.NET Core**, desenvolvimento de endpoints HTTP e integração entre backend e frontend utilizando **HTML, CSS e JavaScript**.
