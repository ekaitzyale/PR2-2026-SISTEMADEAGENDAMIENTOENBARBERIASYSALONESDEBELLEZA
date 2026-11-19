/*
 Migración 02: asociar cada cita a un servicio.
 Ejecutar UNA VEZ o repetir de forma segura después del script 01.
 No borra citas existentes; para registros antiguos IdServicio permanece NULL.
*/
USE SistemaAgendamiento;
GO

IF COL_LENGTH('dbo.CITA', 'IdServicio') IS NULL
BEGIN
    ALTER TABLE dbo.CITA ADD IdServicio INT NULL;
END
GO

IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys
               WHERE name = N'FK_CITA_SERVICIO'
                 AND parent_object_id = OBJECT_ID(N'dbo.CITA'))
BEGIN
    ALTER TABLE dbo.CITA WITH CHECK
    ADD CONSTRAINT FK_CITA_SERVICIO
    FOREIGN KEY (IdServicio) REFERENCES dbo.SERVICIO(IdServicio);
END
GO

SELECT COLUMN_NAME, DATA_TYPE, IS_NULLABLE
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'CITA'
ORDER BY ORDINAL_POSITION;
GO
