IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220815161854_Proyect')
BEGIN
    CREATE TABLE [Formulario_Model] (
        [ID_Form] int NOT NULL IDENTITY,
        [ReleaseDate] datetime2 NOT NULL,
        [Semana] nvarchar(max) NOT NULL,
        [Mes] nvarchar(max) NOT NULL,
        [Anio] nvarchar(max) NOT NULL,
        [MesAnio] nvarchar(max) NOT NULL,
        [Serial] nvarchar(max) NOT NULL,
        [Job] nvarchar(max) NOT NULL,
        [Ensamble] nvarchar(max) NOT NULL,
        [Tamanio] nvarchar(max) NOT NULL,
        [Deteccion] nvarchar(max) NOT NULL,
        [Pareto] nvarchar(max) NOT NULL,
        [ParetoSN] nvarchar(max) NOT NULL,
        [Componente] nvarchar(max) NOT NULL,
        [Elemento] nvarchar(max) NOT NULL,
        [Remaches] nvarchar(max) NOT NULL,
        [Descripcion] nvarchar(max) NOT NULL,
        [Estacion] nvarchar(max) NOT NULL,
        [Comentarios] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Formulario_Model] PRIMARY KEY ([ID_Form])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220815161854_Proyect')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220815161854_Proyect', N'6.0.8');
END;
GO

COMMIT;
GO

