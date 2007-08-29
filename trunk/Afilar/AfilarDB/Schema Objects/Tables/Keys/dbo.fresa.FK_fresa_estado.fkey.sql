ALTER TABLE [dbo].[fresa] WITH NOCHECK ADD
CONSTRAINT [FK_fresa_estado] FOREIGN KEY ([estado]) REFERENCES [dbo].[estado] ([idestado])


