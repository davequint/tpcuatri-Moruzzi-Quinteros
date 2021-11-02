CREATE DATABASE TpCuatrimestralMoruzziQuinteros
GO
USE TpCuatrimestralMoruzziQuinteros
GO
CREATE TABLE TipoDeProducto(
     Id INT PRIMARY KEY NOT NULL,
     Descripcion VARCHAR(50) NOT NULL,
)
GO
CREATE TABLE Producto(
    Codigo INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    IdTipoProducto INT FOREIGN KEY REFERENCES TipoDeProducto(Id) NOT NULL,
    Precio Money NOT NULL CHECK(Precio>0),
    Stock int NOT NULL CHECK(Stock>=0),
    Estado BIT NOT NULL, 
    DescripcionPlato VARCHAR(50) NOT NULL,
)

