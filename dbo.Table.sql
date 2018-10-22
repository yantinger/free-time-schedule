CREATE TABLE [dbo].[Table] (
    [Id]     INT            NOT NULL,
    [Title]  NVARCHAR (MAX) NULL,
    [Date]   NVARCHAR (MAX) NULL,
	[Number] INT            NOT NULL,
    [Time1]  NVARCHAR (50)  NULL,
    [Time2]  NVARCHAR (50)  NULL,
    [Gap]    NVARCHAR (50)  NULL,
    [Reason] NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

