# 🐾 Sistema de Veterinaria - Práctica 3

**Universidad de San Carlos de Guatemala**  
**Facultad de Ingeniería** - Escuela de Ciencias y Sistemas  
**Curso:** Introducción a la Programación y Computación 2 (IPC2)  
**Semestre:** Segundo Semestre 2026  

## 👤 Datos del Estudiante
* **Nombre:** Angel Balcárcel
* **Carnet:** 202405840
* **Sección:** N
* **Auxiliar Asignado:** Jorge Mejía

---

## 📝 Descripción del Proyecto
Este proyecto consiste en la adaptación de un sistema de gestión de veterinaria (desarrollado originalmente en consola durante la Práctica 1) a una aplicación web moderna. 

La aplicación fue desarrollada utilizando **ASP.NET Core MVC (.NET 8)** y mantiene los principios fundamentales de la **Programación Orientada a Objetos (POO)**, permitiendo gestionar el registro, estado y cálculo de dosis de diferentes tipos de mascotas.

## 🛠️ Tecnologías Utilizadas
* **Lenguaje:** C#
* **Framework:** ASP.NET Core MVC (.NET 8)
* **Motor de Vistas:** Razor (.cshtml)
* **Estilos:** CSS3 personalizado (Diseño minimalista)
* **Entorno de Desarrollo:** Linux Mint
* **Estructura de Datos:** Uso de `List<T>` nativo de C# (según aclaración del catedrático).

## ✨ Características Principales

### Programación Orientada a Objetos (POO)
* **Abstracción:** Clase base abstracta `Mascota`.
* **Herencia:** Clases derivadas `Perro`, `Gato`, `Ave` y `Tortuga`.
* **Encapsulamiento:** Atributos privados con propiedades de acceso (Getters y Setters) y validaciones de datos.
* **Polimorfismo:** Sobrescritura del método `CalcularDosis()` aplicando los factores de ajuste específicos:
  * 🐶 Perro: 100%
  * 🐱 Gato: 90%
  * 🐦 Ave: 50%
  * 🐢 Tortuga: 80%

### Funcionalidades del Sistema
1. Listar todas las mascotas registradas en una tabla interactiva.
2. Registrar nuevas mascotas seleccionando su tipo.
3. Consultar el detalle individual de cada mascota.
4. Editar la información de una mascota existente.
5. Eliminar mascotas del sistema.
6. Cambiar el estado de salud (Sana / Enferma).
7. Calcular la dosis de medicamento en base a los mg/kg ingresados.

## 📂 Arquitectura del Proyecto
El proyecto sigue una estructura estricta del patrón MVC, separando las responsabilidades:

* 📁 `Controllers/`: Manejo de las peticiones HTTP (GET/POST).
* 📁 `Models/`: Clases de entidades y ViewModels.
* 📁 `Services/`: Lógica de negocio y manejo del estado en memoria.
* 📁 `Utils/`: Clases de utilidad y constantes.
* 📁 `Views/`: Interfaces de usuario construidas con Razor.

## 🚀 Instrucciones para Ejecutar el Proyecto

### Requisitos Previos
* Tener instalado el [SDK de .NET 8](https://dotnet.microsoft.com/download).
* Terminal o consola de comandos.

### Pasos
1. Clona este repositorio en tu máquina local:
   ```bash
   git clone https://github.com/Ed-geek/PRACTICA3_IPC2N_202405840.git
