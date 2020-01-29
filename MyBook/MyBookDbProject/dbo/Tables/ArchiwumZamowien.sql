CREATE TABLE [dbo].[ArchiwumZamowien] (
    [Id]                 BIGINT IDENTITY (1, 1) NOT NULL,
    [IdZamowienie]       BIGINT NOT NULL,
    [IdPracownik]        BIGINT NOT NULL,
    [IdStatusZamowienie] BIGINT NOT NULL,
    CONSTRAINT [PK_ArchiwumZamowien] PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([IdPracownik]) REFERENCES [dbo].[Pracownik] ([Id]),
    FOREIGN KEY ([IdStatusZamowienie]) REFERENCES [dbo].[StatusZamowienie] ([Id]),
    FOREIGN KEY ([IdZamowienie]) REFERENCES [dbo].[Zamowienie] ([Id]),
    UNIQUE NONCLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([IdZamowienie] ASC)
);

