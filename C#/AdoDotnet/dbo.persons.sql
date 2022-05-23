CREATE TABLE [dbo].[Persons]  --識別規格 就是自動編號 識別種子是初始值 識別增量就是步進值
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [姓名] NVARCHAR(50) NULL, 
    [電話] NVARCHAR(50) NULL, 
    [地址] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [生日] DATE NULL, 
    [婚姻狀態] BIT NULL, 
    [會員點數] INT NULL
	
)