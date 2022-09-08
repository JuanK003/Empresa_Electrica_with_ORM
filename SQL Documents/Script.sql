/*
Created: 06/09/2022
Modified: 06/09/2022
Model: Microsoft SQL Server 2019
Database: MS SQL Server 2019
By: Juan Carlos Palacios
*/


-- Create tables section -------------------------------------------------

-- Table Empleado

CREATE TABLE [Empleado]
(
 [ID_Empleado] Int IDENTITY(1,1) NOT NULL,
 [Nombre Empleado] Varchar(150) NOT NULL,
 [Telefono] Varchar(50) NOT NULL,
 [ID_Puesto] Int NULL,
 [UserName] Varchar(50) NOT NULL,
 [Contraseña] Varchar(50) NOT NULL,
 [ID_EstadoEmpleado] Int NULL,
 [Direccion] Varchar(100) NOT NULL,
 [DPI] Varchar(50) NOT NULL
)
go

-- Create indexes for table Empleado

CREATE INDEX [IX_Relationship1] ON [Empleado] ([ID_EstadoEmpleado])
go

CREATE INDEX [IX_Relationship2] ON [Empleado] ([ID_Puesto])
go

-- Add keys for table Empleado

ALTER TABLE [Empleado] ADD CONSTRAINT [PK_Empleado] PRIMARY KEY ([ID_Empleado])
go

-- Table Estado_Empleado

CREATE TABLE [Estado_Empleado]
(
 [ID_EstadoEmpleado] Int IDENTITY(1,1) NOT NULL,
 [Estado] Varchar(20) NOT NULL
)
go

-- Add keys for table Estado_Empleado

ALTER TABLE [Estado_Empleado] ADD CONSTRAINT [PK_Estado_Empleado] PRIMARY KEY ([ID_EstadoEmpleado])
go

-- Table Puesto

CREATE TABLE [Puesto]
(
 [ID_Puesto] Int IDENTITY(1,1) NOT NULL,
 [Puesto] Varchar(100) NOT NULL
)
go

-- Add keys for table Puesto

ALTER TABLE [Puesto] ADD CONSTRAINT [PK_Puesto] PRIMARY KEY ([ID_Puesto])
go

-- Table Datos_Cliente

CREATE TABLE [Datos_Cliente]
(
 [ID_DatosCliente] Int IDENTITY(1,1) NOT NULL,
 [ID_Empleado] Int NULL,
 [Fecha Contratacion] Date NOT NULL,
 [Salario] Float NOT NULL,
 [Permisos] Text NOT NULL,
 [ID_RegistroCliente] Int NULL,
 [ID_TareasClientes] Int NULL
)
go

-- Create indexes for table Datos_Cliente

CREATE INDEX [IX_Relationship3] ON [Datos_Cliente] ([ID_Empleado])
go

CREATE INDEX [IX_Relationship5] ON [Datos_Cliente] ([ID_RegistroCliente])
go

CREATE INDEX [IX_Relationship7] ON [Datos_Cliente] ([ID_TareasClientes])
go

-- Add keys for table Datos_Cliente

ALTER TABLE [Datos_Cliente] ADD CONSTRAINT [PK_Datos_Cliente] PRIMARY KEY ([ID_DatosCliente])
go

-- Table Registro_Empleado

CREATE TABLE [Registro_Empleado]
(
 [ID_RegistroEmpleado] Int IDENTITY(1,1) NOT NULL,
 [ID_Empleado] Int NULL,
 [Hora de Entrada] Time NOT NULL,
 [Hora de Salida] Time NOT NULL
)
go

-- Create indexes for table Registro_Empleado

CREATE INDEX [IX_Relationship4] ON [Registro_Empleado] ([ID_Empleado])
go

-- Add keys for table Registro_Empleado

ALTER TABLE [Registro_Empleado] ADD CONSTRAINT [PK_Registro_Empleado] PRIMARY KEY ([ID_RegistroEmpleado])
go

-- Table Tareas_Cliente

CREATE TABLE [Tareas_Cliente]
(
 [ID_TareasClientes] Int IDENTITY(1,1) NOT NULL,
 [Nombre de Tarea] Varchar(75) NOT NULL,
 [Descripcion] Text NOT NULL,
 [ID_Empleado] Int NULL
)
go

-- Create indexes for table Tareas_Cliente

CREATE INDEX [IX_Relationship6] ON [Tareas_Cliente] ([ID_Empleado])
go

-- Add keys for table Tareas_Cliente

ALTER TABLE [Tareas_Cliente] ADD CONSTRAINT [PK_Tareas_Cliente] PRIMARY KEY ([ID_TareasClientes])
go

-- Create foreign keys (relationships) section ------------------------------------------------- 


ALTER TABLE [Empleado] ADD CONSTRAINT [Relationship1] FOREIGN KEY ([ID_EstadoEmpleado]) REFERENCES [Estado_Empleado] ([ID_EstadoEmpleado]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Empleado] ADD CONSTRAINT [Relationship2] FOREIGN KEY ([ID_Puesto]) REFERENCES [Puesto] ([ID_Puesto]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Datos_Cliente] ADD CONSTRAINT [Relationship3] FOREIGN KEY ([ID_Empleado]) REFERENCES [Empleado] ([ID_Empleado]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Registro_Empleado] ADD CONSTRAINT [Relationship4] FOREIGN KEY ([ID_Empleado]) REFERENCES [Empleado] ([ID_Empleado]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Datos_Cliente] ADD CONSTRAINT [Relationship5] FOREIGN KEY ([ID_RegistroCliente]) REFERENCES [Registro_Empleado] ([ID_RegistroEmpleado]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Tareas_Cliente] ADD CONSTRAINT [Relationship6] FOREIGN KEY ([ID_Empleado]) REFERENCES [Empleado] ([ID_Empleado]) ON UPDATE NO ACTION ON DELETE NO ACTION
go



ALTER TABLE [Datos_Cliente] ADD CONSTRAINT [Relationship7] FOREIGN KEY ([ID_TareasClientes]) REFERENCES [Tareas_Cliente] ([ID_TareasClientes]) ON UPDATE NO ACTION ON DELETE NO ACTION
go
