Use master;
go
Create database AhorrosBD;

Use AhorrosBD;

Create table tb_Usuarios(
DUI varchar(10) primary key not null,
nombres varchar(50),
apellidos varchar(50),
contrasenia varchar(50)
);
Create table tb_Cuentas(
idCuenta int primary key identity not null,
DUI varchar(10) not null,
nombreCuenta varchar(20),
entrada decimal(18,5),
salida decimal(18,5),
saldoActual decimal(18,5),
FOREIGN KEY (DUI) references tb_Usuarios(DUI)
);