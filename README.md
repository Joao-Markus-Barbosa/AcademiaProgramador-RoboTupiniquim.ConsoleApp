# 🤖 RoboMarte - Simulador de Exploradores Marcianos 🚀

Um simulador interativo de robôs exploradores em Marte desenvolvido como projeto da **Academia do Programador** para a Agência Espacial Brasileira (AEB).

## 📌 Visão Geral

O RoboMarte simula a movimentação de robôs em um planalto marciano retangular, seguindo especificações precisas da AEB. Os robôs podem:
- Ser posicionados em coordenadas específicas
- Receber sequências de comandos de movimento
- Ter sua jornada acompanhada em tempo real

## 🛠️ Tecnologias Utilizadas

- .NET 6.0
- C# 10
- Visual Studio Code / Visual Studio

## 🚀 Como Executar


## 🗺️ Configuração do Planalto

Digite as coordenadas do canto superior direito (ex: 5 5):
5 5

- Cria área retangular de exploração

- Coordenadas válidas: (0,0) até (5,5)

- Validação automática de limites

## 🤖 Controle de Robôs
Posicionamento Inicial

- 1 2 N
  

## Parâmetro	Descrição	Valores Válidos

X	Posição horizontal	0 a limite do planalto 

Y	Posição vertical	0 a limite do planalto
 
Direção	Orientação inicial	N, S, L, O


## 🕹️ Comandos Disponíveis

E	Gira 90° à esquerda	N → O	◄

D	Gira 90° à direita	N → L	►

M	Move para frente	(1,2) → (1,3)	▲


## 👁️ Visualização Dinâmica

```
 5  .  .  .  .  .  .
 4  .  .  .  .  .  .
 3  .  .  ►  .  .  .
 2  .  ▲  .  .  .  .
 1  .  .  .  .  .  .
 0  0  1  2  3  4  5
```
## Exemplo de Funcionamento 

![Funcionamento](/assets/RoboMarte.gif)
