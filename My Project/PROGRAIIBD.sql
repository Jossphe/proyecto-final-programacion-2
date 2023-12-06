create database ProyectoPrograIIBD
use proyectoPrograIIBD

----TABLA DATOS GENERALES
CREATE TABLE JPOSHOES( Nombre VARCHAR(12)NOT NULL,
 Direccion VARCHAR(200)NOT NULL, Telefono VARCHAR(12) NOT NULL,
 Email VARCHAR(50) NOT NULL);

INSERT INTO JPOSHOES (Nombre, Direccion, Telefono, Email)
VALUES ('JPO SHOES', 'CONTIGUO A PARQUE CENTRAL JUAYUA SONSONATE', '78901234', 'jposhoes@gmail.com');

select * from JPOSHOES

--TABLA CARGO DE EMPLEADOS
create table CARGO (
 CargoId INT PRIMARY KEY IDENTITY (1,1), 
 NombreCargo VARCHAR(25) NOT NULL
);

-- Inserciónes
INSERT INTO CARGO (NombreCargo)
VALUES ('GERENTE');
INSERT INTO CARGO (NombreCargo)
VALUES ('CAJERO');
INSERT INTO CARGO (NombreCargo)
VALUES ('VENDEDOR');

Select * From CARGO;

--TABLA ESTADO DE EMPLEADO
create table ESTADO( 
EstadoId INT PRIMARY KEY IDENTITY (1,1),
 Estado VARCHAR(25) NOT NULL
 );
INSERT INTO ESTADO (Estado)
VALUES ('ACTIVO');
INSERT INTO ESTADO (Estado)
VALUES ('INACTIVO');

Select * From ESTADO;

--TABLA EMPLEADO
create table EMPLEADO( 
 EmpleadoId INT primary key identity (1,1),
 Nombre varchar (25)NOT NULL, Apellido varchar (25)NOT NULL,
 DUI varchar (10) not null, Telefono varchar (12) not null,
 Sexo char (1) not null, --(F-FEMENINO)/(M-MASCULINO) --relación de cargo a empleado
 CargoId int not null foreign key references CARGO(CargoId), --relación de estado del empleado
 EstadoId int not null foreign key references ESTADO(EstadoId));

-- Insertar un nuevo empleado
INSERT INTO EMPLEADO (Nombre, Apellido, DUI, Telefono, Sexo, CargoId, EstadoId)
VALUES ('Juan', 'Pérez', '67345678-0', '78901235', 'M', 1,1);
-- Insertar un nuevo empleado
INSERT INTO EMPLEADO (Nombre, Apellido, DUI, Telefono, Sexo, CargoId, EstadoId)
VALUES ('Roxana', 'Flores', '45345678-6', '75063577', 'F', 2,1);
-- Insertar un nuevo empleado
INSERT INTO EMPLEADO (Nombre, Apellido, DUI, Telefono, Sexo, CargoId, EstadoId)
VALUES ('Joaquin', 'Murillo', '27345676-4', '70068045', 'M', 3,1);

Select E.EmpleadoId, E.Nombre, E.Apellido, E.DUI, E.Telefono, E.Sexo,  C.NombreCargo, T.Estado
From EMPLEADO E
Join CARGO C On C.CargoId = E.CargoId
Join ESTADO T On T.EstadoId = E.EstadoId; --where IdCodigo = 3;

select * from EMPLEADO

--TABLA USUARIO
create table USUARIO (
 UsuarioId TINYINT primary key identity (1,1), 
 NombreUsuario varchar (30) NOT NULL,
 Clave varchar(15) not null, --relacion empleado con usuario⬇️
 EmpleadoId int not null foreign key references EMPLEADO(EmpleadoId), --relacion del estado del usuario⬇️
 EstadoId int not null foreign key references ESTADO(EstadoId), --relacion de TIPOUSUARIO a USUARIO⬇️
 CargoId int not null foreign key references CARGO(CargoId));

-- Insertar
INSERT INTO USUARIO (NombreUsuario, Clave, EmpleadoId, EstadoId, CargoId)VALUES 
    ('JP6734', '56780', 1, 1, (select CargoId from EMPLEADO where EmpleadoId = 1)),   
	('RF4534', '56786', 2, 1, (select CargoId from EMPLEADO where EmpleadoId = 2)), 
    ('JM2734', '56764', 3, 1, (select CargoId from EMPLEADO where EmpleadoId = 3));

select * from USUARIO

SELECT U.UsuarioId, U.NombreUsuario, U.Clave, E.Nombre, E.Apellido, C.NombreCargo, T.Estado
FROM USUARIO U 
JOIN EMPLEADO E ON E.EmpleadoId = U.EmpleadoId 
JOIN CARGO C ON C.CargoId = U.CargoId 
JOIN ESTADO T ON T.EstadoId = U.EstadoId 

create table DEPARTAMENTO (
 DepartamentoId tinyint primary key identity (1,1), 
 Departamento varchar (25) NOT NULL
);

INSERT INTO DEPARTAMENTO (Departamento)
VALUES ('San Salvador'),     
	   ('San Miguel');

SELECT * FROM DEPARTAMENTO; 

create table PROVEEDOR ( 
 ProveedorId smallint primary key identity (1,1),
 NomEmpresa varchar (25) NOT NULL, 
 Representante varchar (50) NOT NULL,
 Telefono varchar(12)NOT NULL, 
 Email varchar (40) NULL,
 Direccion varchar (50) NULL,
 DepartamentoId tinyint not null foreign key references DEPARTAMENTO(DepartamentoId)
 );

-- Inserciones en la tabla PROVEEDOR
INSERT INTO PROVEEDOR (NomEmpresa, Representante, Telefono, Email, Direccion,DepartamentoId)
VALUES  ('Calzado Santa Maria', 'Marlon Pacheco', '70456879', ' psantamariaelcalzado@gmail.com', 'San Salvador',1 ),
		('Alpargatas S.A.', 'Karla Corado', '71025170', 'Julianne.HODARA@alpargatas.com.ar.', 'San Miguel',2 );

SELECT P.ProveedorId, P.NomEmpresa, P.Representante, P.Telefono, P.Email, P.Direccion, D.Departamento
FROM PROVEEDOR P
JOIN DEPARTAMENTO D ON P.DepartamentoId = D.DepartamentoId;

SELECT * FROM PROVEEDOR;

CREATE TABLE TALLA ( 
TallaId  int primary key identity (1,1),
Talla varchar (2) NOT NULL
);

INSERT INTO TALLA (Talla)
VALUES 
    ('23'),
    ('24'),
    ('26'),
    ('28'),
	('35'),
	('37'),
	('38'),
	('36'),
	('39'),
	('40'),
	('42');

SELECT * FROM TALLA;

CREATE TABLE COLOR(
ColorId int primary key identity (1,1), 
Color varchar (20) NOT NULL
);

INSERT INTO COLOR (Color)
VALUES
    ('Negro'),
    ('Café'),
    ('Blanco'),
    ('Azul'),
	('Beige'),
	('Verde'),
	('Rosado'),
	('Vino');

SELECT * FROM COLOR;

create table DISENO( 
DisenoId int primary key identity (1,1),
Diseno varchar (30) NOT NULL
);

INSERT INTO DISENO (Diseno)
VALUES
    ('Elegante'),
    ('Casual'),
    ('Clásico');

SELECT * FROM DISENO;

create table MARCA(
 MarcaId int primary key identity (1,1), 
 Marca varchar (25) NOT NULL
);

INSERT INTO MARCA (Marca)
VALUES
    ('Alden'),
    ('Trucks'),
    ('Fluchos'),
    ('Caricias');

SELECT * FROM MARCA;

create table CLASIFICACION(
 ClasificacionId int primary key identity (1,1), 
 Clasificacion varchar (30) NOT NULL
);

INSERT INTO CLASIFICACION (Clasificacion)
VALUES
    ('Hombre'),
    ('Mujer'),
    ('Niño'),
	('Niña');

SELECT * FROM CLASIFICACION;

CREATE TABLE PRODUCTO( 
 ProductoID INT PRIMARY KEY IDENTITY (1,1),
 NombreProducto VARCHAR(50) NOT NULL, 
 Descripcion varchar (200) NOT NULL,
 Garantia datetime NOT NULL, 
 Precio money NOT NULL,
 CanBodega INT NOT NULL, 
 CanStock INT NOT NULL,
 --relación en la tabla producto 
 DisenoId int not null foreign key references DISENO(DisenoId),
 --relación en la tabla producto 
 MarcaId int not null foreign key references MARCA(MarcaId),
 --relación en la tabla producto 
 ClasificacionId int not null foreign key references CLASIFICACION(CLasificacionId),
 --relación en la tabla producto 
 TallaId int not null foreign key references TALLA(TallaId),
 --relación en la tabla producto 
 ColorId int not null foreign key references COLOR(ColorId),
 ProveedorId smallint not null foreign key references PROVEEDOR(ProveedorId)
);

INSERT INTO PRODUCTO 
(NombreProducto, Descripcion, Garantia, Precio, CanBodega, CanStock, DisenoId, MarcaId, ClasificacionId, TallaId, ColorId,ProveedorId)
VALUES ('Zapatillas', 'Elaboradas con cuero, cocidas', '2023-12-15', 40.99, 100, 50, 2, 2, 1, 8, 1, 1);
INSERT INTO PRODUCTO 
(NombreProducto, Descripcion, Garantia, Precio, CanBodega, CanStock, DisenoId, MarcaId, ClasificacionId, TallaId, ColorId,ProveedorId)
VALUES ('Zapatillas', 'Elaboradas con cuero, cocidas', '2023-12-15', 40.99, 100, 50, 1, 4, 2, 4, 5, 1);

INSERT INTO PRODUCTO 
(NombreProducto, Descripcion, Garantia, Precio, CanBodega, CanStock, DisenoId, MarcaId, ClasificacionId, TallaId, ColorId,ProveedorId)
VALUES ('Zapatillas', 'Elaboradas con cuero, cocidas', '2023-12-20', 60.00, 150, 75, 1, 1, 2, 5, 8, 1);
INSERT INTO PRODUCTO 
(NombreProducto, Descripcion, Garantia, Precio, CanBodega, CanStock, DisenoId, MarcaId, ClasificacionId, TallaId, ColorId,ProveedorId)
VALUES ('Zapatillas', 'Elaboradas con cuero, cocidas', '2023-12-20', 60.00, 150, 75, 2, 1, 2, 6, 1, 1);

INSERT INTO PRODUCTO 
(NombreProducto, Descripcion, Garantia, Precio, CanBodega, CanStock, DisenoId, MarcaId, ClasificacionId, TallaId, ColorId,ProveedorId)
VALUES ('Zapatillas', 'Elaboradas con cuero, cocidas', '2023-12-18', 36.99, 200, 120, 3, 3, 1, 7, 2, 2);
INSERT INTO PRODUCTO 
(NombreProducto, Descripcion, Garantia, Precio, CanBodega, CanStock, DisenoId, MarcaId, ClasificacionId, TallaId, ColorId,ProveedorId)
VALUES ('Zapatillas', 'Elaboradas con cuero, cocidas', '2023-12-18', 36.99, 200, 120, 3, 3, 1, 5, 8, 2);

INSERT INTO PRODUCTO 
(NombreProducto, Descripcion, Garantia, Precio, CanBodega, CanStock, DisenoId, MarcaId, ClasificacionId, TallaId, ColorId,ProveedorId)
VALUES ('Tacones', 'Elaborados con cuero, cocidos', '2023-12-22', 30.99, 200, 130, 3, 4, 2, 6, 4, 2);
INSERT INTO PRODUCTO 
(NombreProducto, Descripcion, Garantia, Precio, CanBodega, CanStock, DisenoId, MarcaId, ClasificacionId, TallaId, ColorId,ProveedorId)
VALUES ('Tacones', 'Elaborados con cuero, cocidos', '2023-12-22', 30.99, 200, 130, 3, 4, 2, 5, 7, 2);

INSERT INTO PRODUCTO 
(NombreProducto, Descripcion, Garantia, Precio, CanBodega, CanStock, DisenoId, MarcaId, ClasificacionId, TallaId, ColorId,ProveedorId)
VALUES ('Sandalias', 'Elaboradas con cuerina', '2023-12-25', 25.99, 100, 50, 2, 4, 4, 2, 2, 1);
INSERT INTO PRODUCTO 
(NombreProducto, Descripcion, Garantia, Precio, CanBodega, CanStock, DisenoId, MarcaId, ClasificacionId, TallaId, ColorId,ProveedorId)
VALUES ('Sandalias', 'Elaboradas con cuerina', '2023-12-25', 25.99, 100, 50, 2, 4, 4, 1, 3, 2);

INSERT INTO PRODUCTO 
(NombreProducto, Descripcion, Garantia, Precio, CanBodega, CanStock, DisenoId, MarcaId, ClasificacionId, TallaId, ColorId,ProveedorId)
VALUES ('Botines', 'Elaborados con cuerina', '2023-12-23', 29.95, 100, 40, 2, 1, 2, 4, 2, 1);
INSERT INTO PRODUCTO 
(NombreProducto, Descripcion, Garantia, Precio, CanBodega, CanStock, DisenoId, MarcaId, ClasificacionId, TallaId, ColorId,ProveedorId)
VALUES ('Botines', 'Elaborados con cuerina', '2023-12-23', 29.95, 100, 40, 2, 1, 4, 2, 1, 2);

INSERT INTO PRODUCTO 
(NombreProducto, Descripcion, Garantia, Precio, CanBodega, CanStock, DisenoId, MarcaId, ClasificacionId, TallaId, ColorId,ProveedorId)
VALUES ('Botas', 'Elaborados con cuero', '2023-12-17', 67.00, 175, 70, 2, 2, 3, 3, 1, 1);
INSERT INTO PRODUCTO 
(NombreProducto, Descripcion, Garantia, Precio, CanBodega, CanStock, DisenoId, MarcaId, ClasificacionId, TallaId, ColorId,ProveedorId)
VALUES ('Botas', 'Elaborados con cuero', '2023-12-17', 67.00, 175, 70, 2, 3, 1, 8, 6, 2);

Select P.ProductoID, P.NombreProducto, P.Descripcion, P.Garantia, P.Precio, P.CanBodega, P.CanStock, D.Diseno, M.Marca, C.Clasificacion, T.Talla, L.Color, R.ProveedorId
From PRODUCTO P
Join DISENO D On D.DisenoId = P.DisenoId
Join MARCA M On M.MarcaId = P.MarcaId
Join CLASIFICACION C On C.ClasificacionId = P.ClasificacionId
Join TALLA T On T.TallaId = P.TallaId
Join COLOR L On L.ColorId = P.ColorId
Join PROVEEDOR R On R.ProveedorId = P.ProveedorId;

create table METODOPAGO(
	MetodoPagoId INT primary key identity (1,1),
	Descripcion varchar (30)NOT NULL
);

INSERT INTO METODOPAGO(Descripcion)
VALUES
    ('Efectivo'),
    ('Tarjeta de Crédito'),
	('Tarjeta de Débito');

SELECT * FROM METODOPAGO

create table PROMOCION (
	PromocionId INT primary key identity (1,1),
	FechaInicio datetime NOT NULL,
	FechaFin datetime NOT NULL,
	PorcentajeDescuento varchar(5) NOT NULL,
	Descripcion varchar (50)NOT NULL,
	ProductoId int not null foreign key references PRODUCTO(ProductoId)
);

INSERT INTO PROMOCION (FechaInicio, FechaFin, PorcentajeDescuento, Descripcion, ProductoId)
VALUES
    ('2024-05-09', '2024-05-11', '50%', 'Celebración del día de la Madre', 7),
    ('2024-06-16', '2024-06-18', '50%', 'Celebración del día del Padre', 1),
    ('2024-10-05', '2024-10-05', '40%', 'Día del Profesional de la informática', 3);

Select P.PromocionId, P.FechaInicio, P.FechaFin, P.PorcentajeDescuento, P.Descripcion, N.NombreProducto
From PROMOCION P
Join PRODUCTO N On N.ProductoID = P.ProductoID

SELECT * FROM PROMOCION; 

create table CLIENTE (
	ClienteId TINYINT primary key identity (1,1),
	Nombres varchar (25) NOT NULL,
	Apellidos varchar (25) NOT NULL,
	DUI varchar (9) NULL,
	Direccion varchar (100) NULL,
	Telefono varchar (12) NULL,
	Email varchar (40) NULL,
	Sexo varchar (1) NOT NULL,
);

INSERT INTO CLIENTE (Nombres, Apellidos, DUI, Direccion, Telefono, Email, Sexo)
VALUES
    ('Juan','Pérez','123456789','La Guacamaya, Nahuizalco, Sonsonate','70345678','juan@gmail.com','M'),
    ('Ana','Gómez','987654321','Barrio El Calvario, Juayua, Sonsonate','78765432','ana@gmail.com','F'),
    ('Carlos','López','456789123','Casa 44 Canton San Juan De Dios, Juayua, Sonsonate','65678912','carlos@gmail.com','M');

	SELECT * FROM CLIENTE

CREATE TABLE VENTA (
	VentaId INT PRIMARY KEY identity (1,1),
	fechaHora DATETIME NOT NULL,
	NombreCliente VARCHAR(50) NOT NULL,
	Total MONEY NOT NULL,
	MetodoPagoId int not null foreign key references METODOPAGO(MetodoPagoId),
	ClienteId tinyint not null foreign key references CLIENTE(ClienteId),
	UsuarioId tinyint not null foreign key references USUARIO(UsuarioId)
);
 
INSERT INTO VENTA (fechaHora, NombreCliente, Total, MetodoPagoId, ClienteId, UsuarioId)
VALUES
    ('2023-12-01 14:30:00', 'Juan Pérez', 100.50, 1, 2, 1),
    ('2023-12-02 15:45:00', 'Ana Gómez', 75.25, 2, 3, 2),
    ('2023-12-03 12:15:00', 'Carlos López', 120.75, 3, 4, 3);

Select V.VentaId, V.fechaHora, V.NombreCliente, V.Total, D.Descripcion, C.Nombres, U.NombreUsuario
From VENTA V
Join METODOPAGO D On D.MetodoPagoId = V.MetodoPagoId
Join CLIENTE C On C.ClienteId = V.ClienteId
Join USUARIO U On U.UsuarioId = V.UsuarioId

CREATE TABLE DETVENTA(
	DetVentaId INT PRIMARY KEY IDENTITY (1,1),
	PrecioUnitario money NOT NULL,
	Cantidad INT NOT NULL,
	Total money NOT NULL,
	Descuento money not null,
	VentaId int not null foreign key references VENTA(VentaId),
	ProductoId int not null foreign key references PRODUCTO(ProductoId)
);

INSERT INTO DETVENTA (PrecioUnitario, Cantidad, Total, Descuento, VentaId, ProductoId)
VALUES
    (40.99, 2, 81.98, 0, 5, 1),  
    (60.00, 1, 60.00, 0, 6, 3),  
    (36.99, 3, 110.97, 0, 7, 5);

Select D.DetVentaId, D.PrecioUnitario, D.Cantidad, D.Total, D.Descuento, V.VentaId, P.ProductoId
From DETVENTA D
Join VENTA V On V.VentaId = D.VentaId
Join PRODUCTO P On P.ProductoId = D.ProductoId

CREATE TABLE TODATABLA(
	TablaId int primary key identity (1,1),
	Tabla varchar (50)
);

INSERT INTO TODATABLA (Tabla) VALUES ('JPOSHOES');
INSERT INTO TODATABLA (Tabla) VALUES ('CARGO');
INSERT INTO TODATABLA (Tabla) VALUES ('ESTADO');
INSERT INTO TODATABLA (Tabla) VALUES ('EMPLEADO');
INSERT INTO TODATABLA (Tabla) VALUES ('USUARIO');
INSERT INTO TODATABLA (Tabla) VALUES ('DEPARTAMENTO');
INSERT INTO TODATABLA (Tabla) VALUES ('PROVEEDOR');
INSERT INTO TODATABLA (Tabla) VALUES ('TALLA');
INSERT INTO TODATABLA (Tabla) VALUES ('COLOR');
INSERT INTO TODATABLA (Tabla) VALUES ('DISENO');
INSERT INTO TODATABLA (Tabla) VALUES ('MARCA');
INSERT INTO TODATABLA (Tabla) VALUES ('CLASIFICACION');
INSERT INTO TODATABLA (Tabla) VALUES ('PRODUCTO');
INSERT INTO TODATABLA (Tabla) VALUES ('METODOPAGO');
INSERT INTO TODATABLA (Tabla) VALUES ('PROMOCION');
INSERT INTO TODATABLA (Tabla) VALUES ('CLIENTE');
INSERT INTO TODATABLA (Tabla) VALUES ('VENTA');
INSERT INTO TODATABLA (Tabla) VALUES ('DETVENTA');
INSERT INTO TODATABLA (Tabla) VALUES ('TODATABLA');

SELECT * FROM TODATABLA;

CREATE TABLE PERMISO(
	PermisoId int primary key identity (1,1),
	Permiso varchar (50),
	TablaId int not null foreign key references TODATABLA(TablaId)
);

INSERT INTO PERMISO (Permiso, TablaId) VALUES ('LECTURA', 1); -- Permiso de lectura en JPOSHOES
INSERT INTO PERMISO (Permiso, TablaId) VALUES ('MODIFICACION', 2); -- Permiso de modificación en CARGO
INSERT INTO PERMISO (Permiso, TablaId) VALUES ('ELIMINACION', 3); -- Permiso de eliminación en ESTADO
INSERT INTO PERMISO (Permiso, TablaId) VALUES ('LECTURA', 4); -- Permiso de lectura en EMPLEADO
INSERT INTO PERMISO (Permiso, TablaId) VALUES ('MODIFICACION', 5); -- Permiso de modificación en USUARIO
INSERT INTO PERMISO (Permiso, TablaId) VALUES ('ELIMINACION', 6); -- Permiso de eliminación en DEPARTAMENTO
INSERT INTO PERMISO (Permiso, TablaId) VALUES ('LECTURA', 7); -- Permiso de lectura en PROVEEDOR
INSERT INTO PERMISO (Permiso, TablaId) VALUES ('MODIFICACION', 8); -- Permiso de modificación en TALLA
INSERT INTO PERMISO (Permiso, TablaId) VALUES ('ELIMINACION', 9); -- Permiso de eliminación en COLOR
INSERT INTO PERMISO (Permiso, TablaId) VALUES ('LECTURA', 10); -- Permiso de lectura en DISENO
INSERT INTO PERMISO (Permiso, TablaId) VALUES ('MODIFICACION', 11); -- Permiso de modificación en MARCA
INSERT INTO PERMISO (Permiso, TablaId) VALUES ('ELIMINACION', 12); -- Permiso de eliminación en CLASIFICACION
INSERT INTO PERMISO (Permiso, TablaId) VALUES ('LECTURA', 13); -- Permiso de lectura en PRODUCTO
INSERT INTO PERMISO (Permiso, TablaId) VALUES ('MODIFICACION', 14); -- Permiso de modificación en METODOPAGO
INSERT INTO PERMISO (Permiso, TablaId) VALUES ('ELIMINACION', 15); -- Permiso de eliminación en PROMOCION
INSERT INTO PERMISO (Permiso, TablaId) VALUES ('LECTURA', 16); -- Permiso de lectura en CLIENTE
INSERT INTO PERMISO (Permiso, TablaId) VALUES ('MODIFICACION', 17); -- Permiso de modificación en VENTA
INSERT INTO PERMISO (Permiso, TablaId) VALUES ('ELIMINACION', 18); -- Permiso de eliminación en DETVENTA
INSERT INTO PERMISO (Permiso, TablaId) VALUES ('LECTURA', 19); -- Permiso de lectura en TODATABLA

SELECT * FROM PERMISO;

Select P.PermisoId, P.Permiso, T.Tabla
From PERMISO P
Join TODATABLA T On T.TablaId = P.TablaId

CREATE TABLE USUARIOPERMISO(
	UsuarioPermisoId int primary key identity (1,1),
	UsuarioId tinyint not null foreign key references USUARIO(UsuarioId),
	PermisoId int not null foreign key references PERMISO(PermisoId),
	TablaId int not null foreign key references TODATABLA(TablaId)
);

INSERT INTO USUARIOPERMISO (UsuarioId, PermisoId, TablaId) VALUES (1, 1, 1); -- Usuario 1 tiene permiso de lectura en JPOSHOES
INSERT INTO USUARIOPERMISO (UsuarioId, PermisoId, TablaId) VALUES (1, 2, 2); -- Usuario 1 tiene permiso de modificación en CARGO
INSERT INTO USUARIOPERMISO (UsuarioId, PermisoId, TablaId) VALUES (1, 3, 3); -- Usuario 1 tiene permiso de eliminación en ESTADO
INSERT INTO USUARIOPERMISO (UsuarioId, PermisoId, TablaId) VALUES (2, 4, 4); -- Usuario 2 tiene permiso de lectura en EMPLEADO
INSERT INTO USUARIOPERMISO (UsuarioId, PermisoId, TablaId) VALUES (2, 5, 5); -- Usuario 2 tiene permiso de modificación en USUARIO
INSERT INTO USUARIOPERMISO (UsuarioId, PermisoId, TablaId) VALUES (2, 6, 6); -- Usuario 2 tiene permiso de eliminación en DEPARTAMENTO
INSERT INTO USUARIOPERMISO (UsuarioId, PermisoId, TablaId) VALUES (3, 7, 7); -- Usuario 3 tiene permiso de lectura en PROVEEDOR
INSERT INTO USUARIOPERMISO (UsuarioId, PermisoId, TablaId) VALUES (3, 8, 8); -- Usuario 3 tiene permiso de modificación en TALLA
INSERT INTO USUARIOPERMISO (UsuarioId, PermisoId, TablaId) VALUES (3, 9, 9); -- Usuario 3 tiene permiso de eliminación en COLOR
INSERT INTO USUARIOPERMISO (UsuarioId, PermisoId, TablaId) VALUES (1, 10, 10); -- Usuario 1 tiene permiso de lectura en DISENO
INSERT INTO USUARIOPERMISO (UsuarioId, PermisoId, TablaId) VALUES (2, 11, 11); -- Usuario 2 tiene permiso de modificación en MARCA
INSERT INTO USUARIOPERMISO (UsuarioId, PermisoId, TablaId) VALUES (2, 12, 12); -- Usuario 2 tiene permiso de eliminación en CLASIFICACION
INSERT INTO USUARIOPERMISO (UsuarioId, PermisoId, TablaId) VALUES (3, 13, 13); -- Usuario 3 tiene permiso de lectura en PRODUCTO
INSERT INTO USUARIOPERMISO (UsuarioId, PermisoId, TablaId) VALUES (3, 14, 14); -- Usuario 3 tiene permiso de modificación en METODOPAGO
INSERT INTO USUARIOPERMISO (UsuarioId, PermisoId, TablaId) VALUES (3, 15, 15); -- Usuario 3 tiene permiso de eliminación en PROMOCION
INSERT INTO USUARIOPERMISO (UsuarioId, PermisoId, TablaId) VALUES (1, 16, 16); -- Usuario 1 tiene permiso de lectura en CLIENTE
INSERT INTO USUARIOPERMISO (UsuarioId, PermisoId, TablaId) VALUES (2, 17, 17); -- Usuario 2 tiene permiso de modificación en VENTA
INSERT INTO USUARIOPERMISO (UsuarioId, PermisoId, TablaId) VALUES (2, 18, 18); -- Usuario 2 tiene permiso de eliminación en DETVENTA
INSERT INTO USUARIOPERMISO (UsuarioId, PermisoId, TablaId) VALUES (3, 19, 19); -- Usuario 3 tiene permiso de lectura en TODATABLA

SELECT * FROM USUARIOPERMISO;

SELECT U.UsuarioPermisoId, S.NombreUsuario, P.Permiso, T.Tabla
FROM USUARIOPERMISO U
JOIN USUARIO S ON S.UsuarioId = U.UsuarioId
JOIN PERMISO P ON P.PermisoId = U.PermisoId
JOIN TODATABLA T ON T.TablaId = U.TablaId;