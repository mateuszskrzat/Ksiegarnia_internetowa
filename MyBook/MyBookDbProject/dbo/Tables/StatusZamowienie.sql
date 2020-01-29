CREATE TABLE [dbo].[StatusZamowienie] (
    [Id]     BIGINT        IDENTITY (1, 1) NOT NULL,
    [Status] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_StatusZamowienie] PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Id] ASC)
);

