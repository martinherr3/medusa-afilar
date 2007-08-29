ALTER TABLE [dbo].[detallepresupuesto] WITH NOCHECK ADD
CONSTRAINT [FK_detallepresupuesto_presupuesto] FOREIGN KEY ([idpresupuesto]) REFERENCES [dbo].[presupuesto] ([idpresupuesto])


