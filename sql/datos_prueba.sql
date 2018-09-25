INSERT INTO sucursal (nombre, direccion, departamento) VALUES
("Sucursal 1", "Calle 1", "Montevideo");
INSERT INTO sucursal (nombre, direccion, departamento) VALUES
("Sucursal 2", "Calle 2", "Canelones");
INSERT INTO sucursal (nombre, direccion, departamento) VALUES
("Sucursal 3", "Calle 3", "Maldonado");
INSERT INTO sucursal (nombre, direccion, departamento) VALUES
("Sucursal 4", "Calle 4", "Durazno");

INSERT INTO telefono_sucursal (id_sucursal, telefono) VALUES
(1, 1111111);
INSERT INTO telefono_sucursal (id_sucursal, telefono) VALUES
(1, 1111112);
INSERT INTO telefono_sucursal (id_sucursal, telefono) VALUES
(2, 2222222);
INSERT INTO telefono_sucursal (id_sucursal, telefono) VALUES
(3, 3333333);
INSERT INTO telefono_sucursal (id_sucursal, telefono) VALUES
(4, 1111111);


INSERTO INTO funcionario (cedula, id_sucursal, nombre, apellido, direccion, usuario, contrasena, cargo) VALUES 
(5555555, "jose", "uno", "direccion 1", "jose", "jose", "Administrativo");