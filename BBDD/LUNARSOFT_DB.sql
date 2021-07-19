CREATE DATABASE LUNARSOFT_DB

USE LUNARSOFT_DB

CREATE TABLE USUARIOS(
ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
MAIL VARCHAR(50) NOT NULL UNIQUE,
CONTRASEŅA VARCHAR(50) NOT NULL,
NOMBRE VARCHAR(50) NOT NULL,
APELLIDO VARCHAR(50) NOT NULL,
NACIMIENTO DATE NOT NULL,
TELEFONO VARCHAR(50) NOT NULL,
DNI VARCHAR(50) NOT NULL
)
--
CREATE TABLE ESTADOS(
ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
NOMBRE VARCHAR(50) NOT NULL UNIQUE
)
CREATE TABLE CATEGORIAS(
ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
NOMBRE VARCHAR(50) NOT NULL UNIQUE
)
CREATE TABLE COMPOSICIONES(
ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
NOMBRE VARCHAR(50) NOT NULL UNIQUE
)
CREATE TABLE MEDIDAS(
ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
NOMBRE VARCHAR(50) NULL,
LARGO_CM VARCHAR(50) NULL,
ANCHO_CM VARCHAR(50) NULL
)
CREATE TABLE ESTILOS(
ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
NOMBRE VARCHAR(50) NOT NULL UNIQUE
)
CREATE TABLE COLORES(
ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
NOMBRE VARCHAR(100) NOT NULL UNIQUE,
CODIGO VARCHAR(50) NOT NULL
)
CREATE TABLE ARTICULOS(
ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
NOMBRE VARCHAR(100) NOT NULL,
PRECIO MONEY NOT NULL,
IMAGEN VARCHAR(1000) NOT NULL,
STOCK INT NOT NULL CHECK(STOCK>0),
ID_CATEGORIA INT NOT NULL FOREIGN KEY REFERENCES CATEGORIAS(ID),
ID_COMPOSICION INT NOT NULL FOREIGN KEY REFERENCES COMPOSICIONES(ID),
ID_MEDIDA INT NOT NULL FOREIGN KEY REFERENCES MEDIDAS(ID),
ID_ESTILO INT NOT NULL FOREIGN KEY REFERENCES ESTILOS(ID),
ID_COLOR INT NOT NULL FOREIGN KEY REFERENCES COLORES(ID)
)
CREATE TABLE MEDIOS_DE_PAGO(
ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
NOMBRE VARCHAR(100) NOT NULL,
)
CREATE TABLE VENTAS(
ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
FECHA DATE NOT NULL,
ID_USUARIO INT NOT NULL FOREIGN KEY REFERENCES USUARIOS(ID),
ID_ESTADO INT NOT NULL FOREIGN KEY REFERENCES ESTADOS(ID),
ID_MPAGO INT NOT NULL FOREIGN KEY REFERENCES  MEDIOS_DE_PAGO(ID)
)
CREATE TABLE ARTICULOS_X_VENTAS(
ID_ARTICULO INT NOT NULL FOREIGN KEY REFERENCES ARTICULOS(ID),
ID_VENTA INT NOT NULL FOREIGN KEY REFERENCES VENTAS(ID),
CANTIDAD INT NOT NULL CHECK(CANTIDAD>0),
--
PRIMARY KEY(ID_ARTICULO, ID_VENTA)
)
ALTER TABLE ARTICULOS_X_VENTAS
ADD PRECIO_UNITARIO MONEY NOT NULL CHECK(PRECIO_UNITARIO>0)
--
ALTER TABLE ARTICULOS
ADD VISIBLE BIT NULL
--
UPDATE ARTICULOS SET VISIBLE=1
--
ALTER TABLE CATEGORIAS
ADD VISIBLE BIT NULL
--
UPDATE CATEGORIAS SET VISIBLE=1
--
ALTER TABLE COLORES
ADD VISIBLE BIT NULL
--
UPDATE COLORES SET VISIBLE=1
--
ALTER TABLE ESTILOS
ADD VISIBLE BIT NULL
--
UPDATE ESTILOS SET VISIBLE=1