/*
    Proyecto: Sistema de Agendamiento y Gestion para Barberias y Salones de Belleza
    Equipo: Virus
    Base de datos: SistemaAgendamiento
    Motor: Microsoft SQL Server

    Ejecutar este script desde SQL Server Management Studio (SSMS)
    o desde una herramienta compatible con SQL Server.
*/

IF DB_ID(N'SistemaAgendamiento') IS NULL
BEGIN
    CREATE DATABASE SistemaAgendamiento;
END
GO

USE SistemaAgendamiento;
GO

/* =========================================================
   1. CLIENTE
   ========================================================= */
IF OBJECT_ID(N'dbo.CLIENTE', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.CLIENTE
    (
        IdCliente INT IDENTITY(1,1) NOT NULL,
        Nombre NVARCHAR(100) NOT NULL,
        Telefono NVARCHAR(20) NOT NULL,
        Email NVARCHAR(120) NULL,
        CONSTRAINT PK_CLIENTE PRIMARY KEY (IdCliente)
    );
END
GO

/* =========================================================
   2. PROFESIONAL
   ========================================================= */
IF OBJECT_ID(N'dbo.PROFESIONAL', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.PROFESIONAL
    (
        IdProfesional INT IDENTITY(1,1) NOT NULL,
        Nombre NVARCHAR(100) NOT NULL,
        Especialidad NVARCHAR(80) NOT NULL,
        Activo BIT NOT NULL
            CONSTRAINT DF_PROFESIONAL_Activo DEFAULT (1),
        CONSTRAINT PK_PROFESIONAL PRIMARY KEY (IdProfesional)
    );
END
GO

/* =========================================================
   3. SERVICIO
   ========================================================= */
IF OBJECT_ID(N'dbo.SERVICIO', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.SERVICIO
    (
        IdServicio INT IDENTITY(1,1) NOT NULL,
        Nombre NVARCHAR(100) NOT NULL,
        DuracionMinutos INT NOT NULL,
        Precio DECIMAL(10,2) NOT NULL,
        Activo BIT NOT NULL
            CONSTRAINT DF_SERVICIO_Activo DEFAULT (1),
        CONSTRAINT PK_SERVICIO PRIMARY KEY (IdServicio),
        CONSTRAINT CK_SERVICIO_Duracion CHECK (DuracionMinutos > 0),
        CONSTRAINT CK_SERVICIO_Precio CHECK (Precio >= 0)
    );
END
GO

/* =========================================================
   4. CITA
   Una cita pertenece a un cliente y a un profesional.
   ========================================================= */
IF OBJECT_ID(N'dbo.CITA', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.CITA
    (
        IdCita INT IDENTITY(1,1) NOT NULL,
        FechaHoraInicio DATETIME2(0) NOT NULL,
        FechaHoraFin DATETIME2(0) NOT NULL,
        Estado NVARCHAR(20) NOT NULL
            CONSTRAINT DF_CITA_Estado DEFAULT (N'Programada'),
        IdCliente INT NOT NULL,
        IdProfesional INT NOT NULL,
        Observacion NVARCHAR(250) NULL,
        CONSTRAINT PK_CITA PRIMARY KEY (IdCita),
        CONSTRAINT FK_CITA_CLIENTE
            FOREIGN KEY (IdCliente) REFERENCES dbo.CLIENTE(IdCliente),
        CONSTRAINT FK_CITA_PROFESIONAL
            FOREIGN KEY (IdProfesional) REFERENCES dbo.PROFESIONAL(IdProfesional),
        CONSTRAINT CK_CITA_RangoFecha CHECK (FechaHoraFin > FechaHoraInicio),
        CONSTRAINT CK_CITA_Estado CHECK
            (Estado IN (N'Programada', N'Atendida', N'Cancelada'))
    );
END
GO

/* =========================================================
   5. DETALLE_CITA
   Permite que una cita incluya uno o varios servicios.
   El precio se guarda como valor historico al reservar.
   ========================================================= */
IF OBJECT_ID(N'dbo.DETALLE_CITA', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.DETALLE_CITA
    (
        IdDetalle INT IDENTITY(1,1) NOT NULL,
        IdCita INT NOT NULL,
        IdServicio INT NOT NULL,
        Precio DECIMAL(10,2) NOT NULL,
        DuracionMinutos INT NOT NULL,
        CONSTRAINT PK_DETALLE_CITA PRIMARY KEY (IdDetalle),
        CONSTRAINT FK_DETALLE_CITA_CITA
            FOREIGN KEY (IdCita) REFERENCES dbo.CITA(IdCita),
        CONSTRAINT FK_DETALLE_CITA_SERVICIO
            FOREIGN KEY (IdServicio) REFERENCES dbo.SERVICIO(IdServicio),
        CONSTRAINT CK_DETALLE_CITA_Precio CHECK (Precio >= 0),
        CONSTRAINT CK_DETALLE_CITA_Duracion CHECK (DuracionMinutos > 0)
    );
END
GO

/* =========================================================
   6. FACTURA
   En el MVP se registra una factura por cita como maximo.
   No representa facturacion fiscal electronica.
   ========================================================= */
IF OBJECT_ID(N'dbo.FACTURA', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.FACTURA
    (
        IdFactura INT IDENTITY(1,1) NOT NULL,
        IdCita INT NOT NULL,
        FechaEmision DATETIME2(0) NOT NULL
            CONSTRAINT DF_FACTURA_Fecha DEFAULT (SYSDATETIME()),
        Total DECIMAL(10,2) NOT NULL,
        Estado NVARCHAR(20) NOT NULL
            CONSTRAINT DF_FACTURA_Estado DEFAULT (N'Pendiente'),
        CONSTRAINT PK_FACTURA PRIMARY KEY (IdFactura),
        CONSTRAINT FK_FACTURA_CITA
            FOREIGN KEY (IdCita) REFERENCES dbo.CITA(IdCita),
        CONSTRAINT UQ_FACTURA_CITA UNIQUE (IdCita),
        CONSTRAINT CK_FACTURA_Total CHECK (Total >= 0),
        CONSTRAINT CK_FACTURA_Estado CHECK
            (Estado IN (N'Pendiente', N'Pagada', N'Anulada'))
    );
END
GO

/* =========================================================
   7. INDICES PARA CONSULTAS FRECUENTES
   ========================================================= */
IF NOT EXISTS
(
    SELECT 1 FROM sys.indexes
    WHERE name = N'IX_CITA_Profesional_Fecha'
      AND object_id = OBJECT_ID(N'dbo.CITA')
)
BEGIN
    CREATE INDEX IX_CITA_Profesional_Fecha
        ON dbo.CITA (IdProfesional, FechaHoraInicio, FechaHoraFin)
        INCLUDE (Estado);
END
GO

IF NOT EXISTS
(
    SELECT 1 FROM sys.indexes
    WHERE name = N'IX_CITA_Cliente_Fecha'
      AND object_id = OBJECT_ID(N'dbo.CITA')
)
BEGIN
    CREATE INDEX IX_CITA_Cliente_Fecha
        ON dbo.CITA (IdCliente, FechaHoraInicio);
END
GO

/* =========================================================
   8. VERIFICACION DE TABLAS CREADAS
   ========================================================= */
SELECT
    TABLE_NAME AS Tabla
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE'
  AND TABLE_SCHEMA = 'dbo'
ORDER BY TABLE_NAME;
GO

/*
    IMPORTANTE:
    La validacion de solapamiento debe realizarse tambien en la
    logica de negocio de la aplicacion antes de guardar o modificar
    una cita. No basta con validar desde el formulario.
*/
