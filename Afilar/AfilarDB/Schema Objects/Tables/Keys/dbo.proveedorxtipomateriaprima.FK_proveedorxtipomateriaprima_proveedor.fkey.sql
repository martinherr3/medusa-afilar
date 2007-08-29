ALTER TABLE [dbo].[proveedorxtipomateriaprima] WITH NOCHECK ADD
CONSTRAINT [FK_proveedorxtipomateriaprima_proveedor] FOREIGN KEY ([idproveedor]) REFERENCES [dbo].[proveedor] ([idproveedor])


