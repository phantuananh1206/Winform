﻿CREATE TABLE [dbo].[tbDANHMUC] (
    [MADANHMUC]  INT            NOT NULL,
    [TENDANHMUC] NCHAR (50)     NOT NULL,
    [DANHMUCCHA] NVARCHAR(50)            NOT NULL,
    [MOTA]       NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([MADANHMUC] ASC)
);

