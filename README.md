# 🧾 Folha Fácil Simulado

Simulador de folha de pagamento desenvolvido em **C# com Avalonia UI**, focado em regras reais de **INSS, IRRF e estrutura de holerite**.

O projeto foi criado com o objetivo de demonstrar **domínio técnico em sistemas de folha, contabilidade e RH**, simulando o funcionamento de softwares utilizados por empresas e escritórios contábeis.

---

## 💡 Visão Geral

Este sistema simula, de forma fiel, as principais operações de uma folha de pagamento:

- Cadastro de colaboradores
- Cálculo automático de INSS e IRRF com base nas tabelas oficiais
- Geração de holerite com detalhamento de descontos e base de cálculo
- Estrutura escalável para futura adição de benefícios, eventos e encargos
- Interface cross-platform com Avalonia UI
- Planejado para evoluir com **persistência via SQLite** e **exportação em PDF/CSV**

---

## ✅ Tecnologias utilizadas

| Camada         | Tecnologias                            |
|----------------|-----------------------------------------|
| UI             | Avalonia UI (.NET cross-platform)       |
| Lógica         | C# 12, .NET 8, MVVM                     |
| Banco (em breve) | SQLite                                |
| Outros         | Git, GitHub, .NET CLI                   |

---

## ✨ Funcionalidades (em desenvolvimento)

- [ ] Cadastro de funcionários
- [ ] Cálculo de holerite com INSS e IRRF reais
- [ ] Geração visual do demonstrativo
- [ ] Persistência de dados em SQLite
- [ ] Exportação do demonstrativo (CSV, PDF)
- [ ] Inclusão de outros eventos e encargos (FGTS, pensão etc.)

---

## 🚀 Como rodar o projeto

> Certifique-se de ter o **.NET 8 SDK** instalado na máquina.

```bash
git clone https://github.com/FredSS2323/FolhaFacilSimulado.git
cd FolhaFacilSimulado
dotnet run
