CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Created] DATETIME NOT NULL, 
    [LastFetched] DATETIME NOT NULL, 
    [Address1] NCHAR(250) NULL, 
    [Address2] NCHAR(250) NULL, 
    [City] NCHAR(100) NULL, 
    [Province] NCHAR(100) NULL, 
    [ProvinceCode] NCHAR(10) NULL, 
    [Zip] NCHAR(100) NULL, 
    [Phone] NCHAR(15) NULL, 
    [FirstName] NCHAR(100) NULL, 
    [LastName] NCHAR(100) NULL, 
    [Company] NCHAR(100) NULL, 
    [Country] NCHAR(100) NULL, 
    [CountryCode] NCHAR(10) NULL, 
    [Default] BIT NULL, 
    [Active] BIT NULL
)
