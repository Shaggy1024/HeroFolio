CREATE TABLE [dbo].[CharacterRace] (
    [Race Type]                     VARCHAR(50)          NOT NULL,
    [Race]                   VARCHAR (15) NULL,
    [Attributes]             VARCHAR (10) NULL,
    [Movement Speed]         INT          NULL,
    [Weapon Familiarity]     VARCHAR (50) NULL,
    [Languages]              VARCHAR (50) NULL,
    [Physical Description]   VARCHAR (50) NULL,
    [Society]                VARCHAR (50) NULL,
    [Relations]              VARCHAR (50) NULL,
    [Alignment and Religion] VARCHAR (50) NULL,
    [Adventurers]            VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Race Type] ASC)
);

