CREATE TABLE [dbo].[ProductTable] (
    [SıraNo]		INT          NOT NULL,
	[MakaraNo]      INT          NOT NULL,
    [UniComKodları] VARCHAR (50) NOT NULL,
    [Marka]         VARCHAR (50) NOT NULL,
    [Core]          VARCHAR (50) NOT NULL,
    [FiberTipi]     VARCHAR (50) NOT NULL,
    [Kod]           VARCHAR (50) NOT NULL,
    [Metre]         INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([SıraNo] ASC)
);

