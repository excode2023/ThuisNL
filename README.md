# ThuisNL

Plataforma backend moderna para la gestión de servicios y procesos relacionados con vivienda (*thuis* = hogar), construida con **.NET** y enfocada en buenas prácticas de arquitectura, escalabilidad y mantenibilidad.

Este proyecto está pensado como un **laboratorio realista** de backend profesional: no es un "hola mundo", es una base sólida para crecer hacia APIs robustas, seguras y listas para producción.

---

## 🧠 Visión del proyecto

**ThuisNL** nace como un proyecto educativo–profesional con objetivos claros:

* Construir una API backend moderna usando el ecosistema **.NET**
* Aplicar principios de **Clean Architecture** desde el inicio
* Practicar patrones usados en entornos reales (no solo académicos)
* Preparar el proyecto para escalar a microservicios, cloud y DevOps

El foco principal está en el **backend**, pero el diseño contempla una futura integración con frontend moderno.

---

## 🧱 Arquitectura

El proyecto sigue una **Clean Architecture**, separando responsabilidades de forma estricta:

```
ThuisNL
│
├── ThuisNL.Api           → Capa de presentación (ASP.NET Core)
├── ThuisNL.Application   → Casos de uso, lógica de negocio
├── ThuisNL.Domain        → Entidades, Value Objects, reglas del dominio
├── ThuisNL.Infrastructure→ Acceso a datos, servicios externos
└── ThuisNL.Tests         → Pruebas unitarias e integración
```

### Principios aplicados

* Separación de responsabilidades
* Dependencias dirigidas hacia el dominio
* Dominio independiente de frameworks
* Código orientado a testabilidad

---

## ⚙️ Stack tecnológico

* **.NET 9 / 10** (ASP.NET Core)
* **C#**
* **Entity Framework Core**
* **PostgreSQL**
* **Docker & Docker Compose**
* **Git & GitHub**
* **xUnit** (testing)
* **Postman** (pruebas de API)

---

## 🚀 Estado actual

Actualmente el proyecto se encuentra en fase de **fundamentos estructurales**:

* ✔️ Solución creada y organizada por capas
* ✔️ API configurada con `WebApplicationBuilder`
* ✔️ Git inicializado y repositorio remoto configurado
* ✔️ Docker y variables de entorno preparados
* 🔄 Configuración de base de datos en progreso

---

## 🔐 Buenas prácticas incluidas

* Uso de `private set` y constructores controlados
* Entidades ricas (no anémicas)
* Configuración clara de dependencias
* Preparación para:

  * Autenticación con JWT
  * CQRS + MediatR
  * Validaciones
  * Manejo de errores global

---

## 🧪 Testing

El proyecto está diseñado para ser **probado desde el inicio**:

* Pruebas unitarias sobre lógica de dominio
* Pruebas de casos de uso
* Preparación para pruebas de integración con base de datos

---

## 🐳 Docker

El entorno de desarrollo se ejecuta mediante **Docker Compose**, permitiendo:

* Base de datos PostgreSQL aislada
* Variables de entorno controladas
* Entorno reproducible

---

## 📚 Objetivo de aprendizaje

Este proyecto sirve como guía práctica para dominar:

* Backend profesional en .NET
* Arquitecturas limpias
* Diseño orientado a dominio
* Preparación para entornos reales de trabajo

---

## 📌 Roadmap

* [ ] Configuración completa de PostgreSQL + EF Core
* [ ] Migraciones
* [ ] CRUD inicial con casos de uso
* [ ] Autenticación y autorización
* [ ] Testing avanzado
* [ ] CI/CD
* [ ] Despliegue en cloud

---

## 👤 Autor

**Exavier**
Backend Developer (.NET)
Proyecto educativo-profesional orientado a estándares reales de la industria.

---

## 📄 Licencia

Este proyecto se distribuye bajo licencia MIT.

---


