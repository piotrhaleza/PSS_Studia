CREATE TABLE [dbo].[USERS]
(
	[ID]            INT            IDENTITY (1, 1) NOT NULL,
    [NAME]       NVARCHAR (260)                    NOT NULL,
    [PASSWORD]       NVARCHAR (260)                    NOT NULL,
    [ROLEID]       INT                NOT NULL,
       
   CONSTRAINT [FK_USERS_ROLEID] FOREIGN KEY ([ROLEID]) REFERENCES [dbo].[ROLES] ([ID]),
   CONSTRAINT [PK_USERS] PRIMARY KEY CLUSTERED ([ID] ASC),
)
