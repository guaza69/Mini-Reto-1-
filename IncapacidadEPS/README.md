# 🏥 Cálculo de Incapacidad EPS - C#

Este proyecto calcula cuántos días de incapacidad se le asignan a un empleado que consulta a la EPS, según el tipo de enfermedad y su salario 💵.

## 📋 Funcionalidades

- Se determina el número de días de incapacidad según la enfermedad 🦠
- Se calcula el pago de incapacidad con base en el salario mensual del empleado 💰
- Considera reglas diferentes para:
  - Salarios < $750.000
  - Salarios entre $750.000 y $1.500.000
  - Salarios > $1.500.000

## 📌 Lógica de negocio

- Salario < 750.000 👉 se pagan todos los días al 100%
- Salario entre 750.000 y 1.500.000 👉 no se pagan los primeros 3 días, pero sí los demás al 100%
- Salario > 1.500.000 👉 se pagan todos los días, pero al 65%

## 📆 Suposiciones

- Todos los meses tienen 30 días

## 🛠️ Lenguaje

- C# (Aplicación de consola)



![Captura de pantalla 2025-05-21 150020](https://github.com/user-attachments/assets/838174ed-07ad-4abd-8c83-1cf4bc4c0b9f)
![Captura de pantalla 2025-05-21 150040](https://github.com/user-attachments/assets/a551dc48-5559-4169-b3a1-7cd50b74cc1b)
