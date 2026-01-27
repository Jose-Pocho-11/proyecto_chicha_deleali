# Desarrollo de sistema de control de inventario desarrollado en el lenguaje de programación C# con un gestor de bases de datos SQLite

**Sistema de Gestión Chicha Deliali** es una aplicación de escritorio robusta diseñada para la administración integral de un negocio de bebidas y alimentos. Su función principal es el control de inventario basado en recetas, donde cada venta descuenta automáticamente los insumos correspondientes del almacén.

## 📋 Descripción

Este proyecto automatiza el flujo operativo de ventas y reposición de stock. A diferencia de un inventario convencional, este sistema implementa una lógica de "recetas" o "componentes": al vender un producto preparado (ej. una bebida), el software calcula y descuenta las cantidades exactas de materia prima (leche, azúcar, envases) utilizadas, manteniendo el inventario de insumos siempre actualizado.

## ✨ Características Principales

* **🛒 Punto de Venta (POS):** Interfaz gráfica para el registro rápido de ventas, selección de productos por categorías y cálculo automático de totales.
* **📉 Descuento por Receta:** Lógica avanzada que vincula productos finales con sus ingredientes. Una venta reduce el stock de múltiples insumos simultáneamente.
* **🔐 Seguridad y Acceso:** Módulo de autenticación (Login) con validación de usuarios y recuperación de credenciales mediante preguntas de seguridad.
* **📊 Reportes:** Generación de reportes de inventario y ventas exportables a formato PDF y visualizables en HTML.
* **📦 Gestión de Stock:** Herramientas dedicadas para el ingreso de nueva mercancía, ajuste de cantidades y eliminación lógica de productos.
* **👥 Proveedores:** Módulo para el registro y administración de la información de proveedores.

## 🛠️ Tecnologías Utilizadas

* **Lenguaje:** C# (.NET Framework)
* **Interfaz:** Windows Forms (WinForms)
* **Base de Datos:** SQLite
* **Librerías Externas:**
    * `System.Data.SQLite`: Gestión de la base de datos local.
    * `iTextSharp`: Motor para la creación y exportación de documentos PDF.

## 📂 Estructura del Proyecto

El código se organiza en Formularios (Vistas) que contienen su propia lógica de negocio:

* `FormVentas.cs`: Núcleo del sistema POS y lógica de descuento de inventario.
* `Form_Inicio.cs`: Panel principal, visualización de inventario y navegación.
* `FormLogin.cs`: Control de acceso y seguridad.
* `FormReporte.cs`: Lógica para la construcción de documentos y reportes.

## ⚙️ Configuración e Instalación

Para ejecutar este proyecto en un entorno local, es necesario ajustar la cadena de conexión a la base de datos:

1.  **Clonar el repositorio.**
2.  **Localizar la Base de Datos:** El archivo `Proyecto_python.db` se encuentra en la carpeta raíz o `Resources`.
3.  **Actualizar Ruta:** Buscar la cadena de conexión en los archivos `.cs` (ej. `Form_Inicio.cs`, `FormVentas.cs`) y cambiar la ruta absoluta por la ruta local de tu equipo:
    ```csharp
    // Cambiar: "Data Source=C:\\Users\\usuario_anterior\\...\\Proyecto_python.db"
    // Por: "Data Source=.\\Proyecto_python.db" (o tu ruta específica)
    ```
4.  **Compilar:** Ejecutar la solución desde Visual Studio.

## 📄 Licencia

Este proyecto fue desarrollado con fines académicos.

---
Desarrollado en **C#** y **SQLite**.
