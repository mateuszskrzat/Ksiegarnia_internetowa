CREATE TABLE [dbo].[Produkt] (
    [Id]          BIGINT         IDENTITY (1, 1) NOT NULL,
    [Nazwa]       NVARCHAR (100) NOT NULL,
    [Ilosc]       INT            NOT NULL,
    [Dostepny]    BIT            NOT NULL,
    [Cena]        DECIMAL (18)   NOT NULL,
    [DataDodania] DATETIME       NOT NULL,
    CONSTRAINT [PK_Produkt] PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Id] ASC)
);

