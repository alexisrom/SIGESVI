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
(5111113, "Esteban", 1, "Tres", "direccion 1", "esteban", "esteban", "Enologo");
INSERT INTO funcionario (cedula, id_sucursal, nombre, apellido, direccion, usuario, contrasena, cargo) VALUES 
(5111114, "María", 1, "Cuatro", "direccion 1", "maria", "maria", "Administrativo");
INSERT INTO funcionario (cedula, id_sucursal, nombre, apellido, direccion, usuario, contrasena, cargo) VALUES 
(5111115, "Ana", 1, "Cinco", "direccion 1", "ana", "ana", "Administrativo");

-----------------------------------------------------------------------
-- Tipos de Cepa
-----------------------------------------------------------------------
INSERT INTO tipo_cepa(nombre, tipo) VALUES ("Merlot", "Tinto");
INSERT INTO tipo_cepa(nombre, tipo) VALUES ("Cabernet Sauvignon", "Tinto");
INSERT INTO tipo_cepa(nombre, tipo) VALUES ("Tannat", "Tinto");
INSERT INTO tipo_cepa(nombre, tipo) VALUES ("Cabernet", "Tinto");
INSERT INTO tipo_cepa(nombre, tipo) VALUES ("Moscatel", "Rosado");
INSERT INTO tipo_cepa(nombre, tipo) VALUES ("Sauvignon Blanc", "Blanco");
INSERT INTO tipo_cepa(nombre, tipo) VALUES ("Chardonnay", "Blanco");

-----------------------------------------------------------------------
-- Materia Prima
-----------------------------------------------------------------------

INSERT INTO especificacion_de_producto(nombre, descripcion, precio, unidad_medida, foto) VALUES
("Uva Frutilla", "Ejemplares de Parras Uva Frutilla de 1,40 mt de altura de follaje frondoso.", 1000, "Kg", NULL);

INSERT INTO materia_prima(id_eproducto, tipo_cepa) VALUES
(1, 3);

-----------------------------------------------------------------------
-- Producto Intermedio
-----------------------------------------------------------------------
INSERT INTO especificacion_de_producto(nombre, descripcion, precio, unidad_medida, foto) VALUES
("Tannat Merlot", "...", 2000, "L", NULL);

INSERT INTO producto_intermedio(id_eproducto, calidad, crianza) VALUES
(2, "Yema");


INSERT INTO especificacion_de_producto(nombre, descripcion, precio, unidad_medida, foto) VALUES
("Tannat Merlot", "...", 2000, "L", NULL);

INSERT INTO producto_intermedio(id_eproducto, calidad, crianza) VALUES
(3, "Lagrima");


INSERT INTO especificacion_de_producto(nombre, descripcion, precio, unidad_medida, foto) VALUES
(3, "Tannat Merlot", "...", 2000, "L", NULL);

INSERT INTO producto_intermedio(id_eproducto, calidad, crianza) VALUES
(3, "Flor");


INSERT INTO especificacion_de_producto(nombre, descripcion, precio, unidad_medida, foto) VALUES
("Tannat Merlot", "...", 2000, "L", NULL);

INSERT INTO producto_intermedio(id_eproducto, calidad, crianza) VALUES
(3, "Yema");


INSERT INTO especificacion_de_producto(nombre, descripcion, precio, unidad_medida, foto) VALUES
("Cabernet", "...", 2000, "L", NULL);

INSERT INTO producto_intermedio(id_eproducto, calidad, crianza) VALUES
(3, "Yema");


-----------------------------------------------------------------------
-- Producto Final
-----------------------------------------------------------------------
INSERT INTO especificacion_de_producto(nombre, descripcion, precio, unidad_medida, foto) VALUES
("Cabernet", "...", 120, "L", NULL);

INSERT INTO producto_final(id_eproducto, crianza, embotellamiento) VALUES
(4, "Barricas de Roble", "1");

INSERT INTO especificacion_de_producto(nombre, descripcion, precio, unidad_medida, foto) VALUES
("Cabernet", "...", 80, "mL", NULL);

INSERT INTO producto_final(id_eproducto, crianza, embotellamiento) VALUES
(5, "Barricas de Roble", "750");

INSERT INTO especificacion_de_producto(nombre, descripcion, precio, unidad_medida, foto) VALUES
("Cabernet", "...", 200, "L", NULL);

INSERT INTO producto_final(id_eproducto, crianza, embotellamiento) VALUES
(6, "Barricas de Roble", "2");


INSERT INTO especificacion_de_producto(nombre, descripcion, precio, unidad_medida, foto) VALUES
("Cabernet", "...", 200, "L", NULL);

INSERT INTO producto_final(id_eproducto, crianza, embotellamiento) VALUES
(7, "Barricas de Roble", "2");

-----------------------------------------------------------------------
-- Producto Final
-----------------------------------------------------------------------

INSERT INTO transporte(tipo, capacidad) VALUES
("Camión", 10000); 

