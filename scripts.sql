CREATE TABLE [EmpMasterDetails] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [UserId] nvarchar(max) NULL,
    [MobiileNumber] INT NULL,
    [Region] nvarchar(max) NULL
    CONSTRAINT [PK_EmpMasterDetails] PRIMARY KEY ([Id])
);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200919081937_addedtableemployemasterdetils', N'3.1.8');

GO

CREATE TABLE [EmpMasterDetails] (
    [Id] int NOT NULL IDENTITY,
    [EmailId] nvarchar(max) NULL,
    [City] nvarchar(max) NULL,
    [Designation] nvarchar(max) NULL,
    [Address] nvarchar(max) NULL,
    [EmployeeMasterId] int NOT NULL,
    CONSTRAINT [PK_EmpMasterDetails] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200919085141_addedtableemployemasterdetilsgh', N'3.1.8');

GO

