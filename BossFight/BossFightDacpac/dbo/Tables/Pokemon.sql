CREATE TABLE [dbo].[Pokemon] (
    [Id]     INT          IDENTITY(1,1) PRIMARY KEY,
    [Name]   VARCHAR (50) NOT NULL,
    [Health] INT          NOT NULL, 
    [Speed] INT NOT NULL
);

