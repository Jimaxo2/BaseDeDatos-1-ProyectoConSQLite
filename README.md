# BaseDeDatos_SQLLite

<h1 align="center">📦 Manejador de Inventario en C# con SQLite</h1>

<p align="center">
  <b>Hecho por: Jimmy Silva Luna</b>
</p>

<p align="center">
  Sistema con interfaz gráfica hecho en C#, conectado a una base de datos SQLite, que permite gestionar un inventario con funciones de búsqueda, registro, edición y eliminación de productos.
</p>

---

## 🧩 Estructura de la Base de Datos

La base de datos contiene las siguientes tablas:

- usuarios  
- productos  
- almacenes  

Organizadas de la siguiente manera:

<p align="center">
  <img 
    src="https://github.com/Jimaxo2/BaseDeDatos-1-ProyectoConSQLite/blob/master/ForReadme/dbdesign_BaseDeDatosI.png" 
    alt="Diagrama de la base de datos" 
    width="600" 
    style="border-radius: 10px;"
  />
</p>

---

## 🔐 Pantalla de Inicio

Al abrir la aplicación se muestra la primera vista, con campos para ingresar el usuario y la contraseña.

<p align="center">
  <img 
    src="https://github.com/Jimaxo2/BaseDeDatos-1-ProyectoConSQLite/blob/master/ForReadme/primera-vista.png" 
    alt="Primera vista de inicio de sesión" 
    width="500" 
    style="border-radius: 10px;"
  />
</p>

---

## 👥 Inicio de Sesión

Se puede iniciar sesión con cualquiera de las siguientes credenciales:

- **Admin →** admin23  
- **Productos →** producto19  
- **Almacén →** almacen11  

Vista después de iniciar sesión:

<p align="center">
  <img 
    src="https://github.com/Jimaxo2/BaseDeDatos-1-ProyectoConSQLite/blob/master/ForReadme/inicio.png" 
    alt="Vista principal tras iniciar sesión"
    width="600"
    style="border-radius: 10px;"
  />
</p>

---

## 🧭 Navegación del Sistema

Desde la ventana principal, el toolbar permite acceder al administrador de productos y almacenes:

<p align="center">
  <img 
    src="https://github.com/Jimaxo2/BaseDeDatos-1-ProyectoConSQLite/blob/master/ForReadme/ManejarCatalogos.png" 
    alt="Ventana de manejo de catálogos" 
    width="600" 
    style="border-radius: 10px;"
  />
</p>

---

## ✏️ Agregar o Editar Registros

Al editar o agregar un elemento aparece la siguiente vista.  
En el caso de editar, los campos se autocompletan automáticamente para facilitar la modificación:

<p align="center">
  <img 
    src="https://github.com/Jimaxo2/BaseDeDatos-1-ProyectoConSQLite/blob/master/ForReadme/Campos.png" 
    alt="Vista de edición/agregado" 
    width="500" 
    style="border-radius: 10px;"
  />
</p>

---

## 🔍 Filtrado de Información

Desde la ventana de consulta es posible filtrar elementos según sus características, haciendo clic en el botón **"Filtrar"**.

- Los filtros se alternan conforme el usuario los selecciona.  
- Se acumulan en una lista de cadenas.  
- Si se desea modificar un filtro específico, es necesario reiniciar la búsqueda.

---
