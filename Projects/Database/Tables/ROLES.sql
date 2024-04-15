CREATE TABLE [dbo].[ROLES]
(
	[ID]            INT                 IDENTITY (1, 1) NOT NULL,
    [NAME]          NVARCHAR (260)                      NOT NULL,
    [PERMISSIONS]   SMALLINT                               NOT NULL

    CONSTRAINT [PK_ROLES] PRIMARY KEY CLUSTERED ([ID] ASC),
)


