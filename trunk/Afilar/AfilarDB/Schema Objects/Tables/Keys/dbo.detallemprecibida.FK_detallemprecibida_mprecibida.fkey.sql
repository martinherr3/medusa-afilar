ALTER TABLE [dbo].[detallemprecibida] WITH NOCHECK ADD
CONSTRAINT [FK_detallemprecibida_mprecibida] FOREIGN KEY ([idmprecibida]) REFERENCES [dbo].[mprecibida] ([idmprecibida])


