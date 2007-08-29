ALTER TABLE [dbo].[controlcalidad] WITH NOCHECK ADD
CONSTRAINT [FK_controlcalidad_fresa] FOREIGN KEY ([idfresa]) REFERENCES [dbo].[fresa] ([nroserie])


