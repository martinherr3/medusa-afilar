CREATE TABLE [dbo].[app_param]
(
[id] [int] NOT NULL,
[label] [varchar] (50) COLLATE Traditional_Spanish_CI_AS NULL,
[numeric_value] [decimal] (18, 4) NULL,
[string_value] [nvarchar] (max) COLLATE Traditional_Spanish_CI_AS NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


