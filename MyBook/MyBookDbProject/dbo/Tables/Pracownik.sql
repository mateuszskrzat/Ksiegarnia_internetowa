CREATE TABLE [dbo].[Pracownik] (
    [Id]       BIGINT        IDENTITY (1, 1) NOT NULL,
    [Imie]     NVARCHAR (50) NOT NULL,
    [Nazwisko] NVARCHAR (50) NOT NULL,
    [Emial]    NVARCHAR (80) NOT NULL,
    [Haslo]    NVARCHAR (20) NOT NULL,
    CONSTRAINT [PK_Pracownik] PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Id] ASC)
);

