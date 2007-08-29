ALTER TABLE [dbo].[mprecibida] WITH NOCHECK ADD
CONSTRAINT [FK_mprecibida_ordencompramp] FOREIGN KEY ([idordencompramp]) REFERENCES [dbo].[ordencompramp] ([idordencompra])


