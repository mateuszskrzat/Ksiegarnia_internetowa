CREATE TABLE [dbo].[PozycjaZamowienie] (
    [Id]           BIGINT IDENTITY (1, 1) NOT NULL,
    [IdZamowienie] BIGINT NOT NULL,
    [IdProdukt]    BIGINT NOT NULL,
    CONSTRAINT [PK_PozycjaZamowienie] PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([IdProdukt]) REFERENCES [dbo].[Produkt] ([Id]),
    FOREIGN KEY ([IdZamowienie]) REFERENCES [dbo].[Zamowienie] ([Id]),
    UNIQUE NONCLUSTERED ([Id] ASC)
);

