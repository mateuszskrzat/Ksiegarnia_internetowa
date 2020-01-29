CREATE TABLE [dbo].[Zamowienie] (
    [Id]        BIGINT        IDENTITY (1, 1) NOT NULL,
    [Imie]      NVARCHAR (50) NOT NULL,
    [Nazwisko]  NVARCHAR (50) NOT NULL,
    [Email]     NVARCHAR (50) NOT NULL,
    [Miasto]    NVARCHAR (50) NOT NULL,
    [Ulica]     NVARCHAR (50) NOT NULL,
    [NumerDomu] INT           NOT NULL,
    CONSTRAINT [PK_Zamowienie] PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Id] ASC)
);

