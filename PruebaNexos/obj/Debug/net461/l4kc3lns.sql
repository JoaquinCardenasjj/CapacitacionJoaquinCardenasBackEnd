IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Pacientes] (
    [Id_Paciente] int NOT NULL IDENTITY,
    [Nombre] nvarchar(max) NULL,
    [NumeroSeguroSocial] nvarchar(max) NULL,
    [MedicoPreferido] nvarchar(max) NULL,
    CONSTRAINT [PK_Pacientes] PRIMARY KEY ([Id_Paciente])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200130164542_Inicial', N'3.1.1');

GO

