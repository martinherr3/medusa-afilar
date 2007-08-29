ALTER TABLE [dbo].[desperfecto] WITH NOCHECK ADD
CONSTRAINT [FK_desperfecto_tipodesperfecto] FOREIGN KEY ([idtipodesperfecto]) REFERENCES [dbo].[tipodesperfecto] ([idtipodesperfecto])


