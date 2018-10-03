-----------------------------------------------------------------------
-- 4 Sucursales de prueba con sus respectivos teléfonos
-----------------------------------------------------------------------
INSERT INTO sucursal (nombre, direccion, departamento) VALUES
("Casa Central", "Calle 1", "Montevideo");
INSERT INTO sucursal (nombre, direccion, departamento) VALUES
("Sucursal Canelones", "Calle 2", "Canelones");
INSERT INTO sucursal (nombre, direccion, departamento) VALUES
("Sucursal Maldonado", "Calle 3", "Maldonado");
INSERT INTO sucursal (nombre, direccion, departamento) VALUES
("Sucursal Durazno", "Calle 4", "Durazno");

INSERT INTO telefono_sucursal (id_sucursal, telefono) VALUES
(1, 1111111);
INSERT INTO telefono_sucursal (id_sucursal, telefono) VALUES
(1, 1111112);
INSERT INTO telefono_sucursal (id_sucursal, telefono) VALUES
(2, 2222221);
INSERT INTO telefono_sucursal (id_sucursal, telefono) VALUES
(3, 3333331);
INSERT INTO telefono_sucursal (id_sucursal, telefono) VALUES
(4, 444441);
INSERT INTO telefono_sucursal (id_sucursal, telefono) VALUES
(4, 444442);

-----------------------------------------------------------------------
-- 5 Funcionarios en la sucursal 1, uno por cada cargo.
-----------------------------------------------------------------------
INSERT INTO funcionario (cedula, id_sucursal, nombre, apellido, direccion, usuario, contrasena, cargo) VALUES 
(5111111, "Marco", 1, "Uno", "direccion 1", "marco", "uno", "Gerente Sucursal");
INSERT INTO funcionario (cedula, id_sucursal, nombre, apellido, direccion, usuario, contrasena, cargo) VALUES 
(5111112, "José", 1, "Dos", "direccion 1", "jose", "jose", "Administrativo");
INSERT INTO funcionario (cedula, id_sucursal, nombre, apellido, direccion, usuario, contrasena, cargo) VALUES 
(5111113), "Esteban", 1, "Tres", "direccion 1", "esteban", "esteban", "Enologo");
INSERT INTO funcionario (cedula, id_sucursal, nombre, apellido, direccion, usuario, contrasena, cargo) VALUES 
(5111114, "María", 1, "Cuatro", "direccion 1", "maria", "maria", "Administrativo");
INSERT INTO funcionario (cedula, id_sucursal, nombre, apellido, direccion, usuario, contrasena, cargo) VALUES 
(5111115, "Ana", 1, "Cinco", "direccion 1", "ana", "ana", "Administrativo");

-----------------------------------------------------------------------
-- 5 Funcionarios en la sucursal 1, uno por cada cargo.
-----------------------------------------------------------------------