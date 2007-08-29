ALTER TABLE [dbo].[detallemprecibida] WITH NOCHECK ADD
CONSTRAINT [FK_detallemprecibida_estado1] FOREIGN KEY ([idestado]) REFERENCES [dbo].[estado] ([idestado])


