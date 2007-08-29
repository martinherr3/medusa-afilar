ALTER TABLE [dbo].[detallemprecibida] WITH NOCHECK ADD
CONSTRAINT [FK_detallemprecibida_mprecibida1] FOREIGN KEY ([idmprecibida]) REFERENCES [dbo].[mprecibida] ([idmprecibida])


