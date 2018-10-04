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
(5111111,  1, "Marco","Uno", "direccion 1", "marco", "uno", "Gerente Sucursal");
INSERT INTO funcionario (cedula, id_sucursal, nombre, apellido, direccion, usuario, contrasena, cargo) VALUES 
(5111112, 1, "José", "Dos", "direccion 1", "jose", "jose", "Administrativo");
INSERT INTO funcionario (cedula, id_sucursal, nombre, apellido, direccion, usuario, contrasena, cargo) VALUES 
(5111113, 1, "Esteban", "Tres", "direccion 1", "esteban", "esteban", "Enologo");
INSERT INTO funcionario (cedula, id_sucursal, nombre, apellido, direccion, usuario, contrasena, cargo) VALUES 
(5111114, 1, "María", "Cuatro", "direccion 1", "maria", "maria", "Administrativo");
INSERT INTO funcionario (cedula, id_sucursal, nombre, apellido, direccion, usuario, contrasena, cargo) VALUES 
(5111115, 1, "Ana", "Cinco", "direccion 1", "ana", "ana", "Administrativo");

-----------------------------------------------------------------------
-- Tipos de Cepa
-----------------------------------------------------------------------
-- INSERT INTO tipo_cepa(nombre, tipo) VALUES ("Moscatel", "Rosado");
-- INSERT INTO tipo_cepa(nombre, tipo) VALUES ("Merlot", "Tinto");
-- INSERT INTO tipo_cepa(nombre, tipo) VALUES ("Cabernet Sauvignon", "Tinto");
-- INSERT INTO tipo_cepa(nombre, tipo) VALUES ("Tannat", "Tinto");
-- INSERT INTO tipo_cepa(nombre, tipo) VALUES ("Cabernet", "Tinto");
-- INSERT INTO tipo_cepa(nombre, tipo) VALUES ("Sauvignon Blanc", "Blanco");
-- INSERT INTO tipo_cepa(nombre, tipo) VALUES ("Chardonnay", "Blanco");

-----------------------------------------------------------------------
-- Materia Prima
-----------------------------------------------------------------------

--INSERT INTO especificacion_de_producto(nombre, descripcion, precio, unidad_medida, foto) VALUES
--("Uva Frutilla", "Ejemplares de Parras Uva Frutilla de 1,40 mt de altura de follaje frondoso.", 1000, "Kg", NULL);

--INSERT INTO materia_prima(id_eproducto, tipo_cepa) VALUES
--(1, 3);

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

INSERT INTO producto_final(id_eproducto, conservacion, embotellamiento) VALUES
(4, "Americano", "1");

INSERT INTO especificacion_de_producto(nombre, descripcion, precio, unidad_medida, foto) VALUES
("Cabernet", "...", 80, "mL", NULL);

INSERT INTO producto_final(id_eproducto, conservacion, embotellamiento) VALUES
(5, "Frances", "750");

INSERT INTO especificacion_de_producto(nombre, descripcion, precio, unidad_medida, foto) VALUES
("Cabernet", "...", 200, "L", NULL);

INSERT INTO producto_final(id_eproducto, conservacion, embotellamiento) VALUES
(6, "Americano", "2");


INSERT INTO especificacion_de_producto(nombre, descripcion, precio, unidad_medida, foto) VALUES
("Cabernet", "...", 200, "L", NULL);

INSERT INTO producto_final(id_eproducto, conservacion, embotellamiento) VALUES
(7, "Americano", "2");

-----------------------------------------------------------------------
-- Transporte
-----------------------------------------------------------------------

INSERT INTO transporte(tipo, capacidad) VALUES("Camión", 10000); 

-----------------------------------------------------------------------
-- Origenes
-----------------------------------------------------------------------
INSERT INTO origen(nombre, direccion, propietario) VALUES
("Viñedo Brazo Oriental", "Luis Alberto de Herrera", "ISBO");


-----------------------------------------------------------------------
-- Lotes
-----------------------------------------------------------------------

INSERT INTO lotes(cantidad, id_origen, fecha, id_eproducto) VALUES
(100, 1, '2018-01-04', 5);
INSERT INTO lotes(cantidad, id_origen, fecha, id_eproducto) VALUES
(300, 1, '2018-02-04', 5);
INSERT INTO lotes(cantidad, id_origen, fecha, id_eproducto) VALUES
(1, 1, '2018-03-04', 6);
INSERT INTO lotes(cantidad, id_origen, fecha, id_eproducto) VALUES
(200, 1, '2018-03-04', 6);

-----------------------------------------------------------------------
-- Traslados
-----------------------------------------------------------------------

INSERT INTO transacciones(fecha_hora) VALUES('2018-01-04 15:00');
INSERT INTO traslado(id_transaccion, id_transporte, id_destino) VALUES(1, 4, 1);

INSERT INTO transacciones(fecha_hora) VALUES('2018-02-04 11:00');
INSERT INTO traslado(id_transaccion, id_transporte, id_destino) VALUES(1, 5, 1);

INSERT INTO transacciones(fecha_hora) VALUES('2018-03-04 15:00');
INSERT INTO traslado(id_transaccion, id_transporte, id_destino) VALUES(1, 6, 1);

INSERT INTO transacciones(fecha_hora) VALUES('2018-03-04 16:00');
INSERT INTO traslado(id_transaccion, id_transporte, id_destino) VALUES(1, 7, 1);

-----------------------------------------------------------------------
-- Producciones
-----------------------------------------------------------------------

INSERT INTO produccion(id_sucursal, fecha_inicio, fecha_fin, cantidad) VALUES
(1, '2017-12-01', '2018-01-03');
INSERT INTO obtiene(id_lote, id_produccion) VALUES(1, 1);

INSERT INTO produccion(id_sucursal, fecha_inicio, fecha_fin, cantidad) VALUES
(2, '2018-01-01', '2018-02-03');
INSERT INTO obtiene(id_lote, id_produccion) VALUES(2, 2);

INSERT INTO produccion(id_sucursal, fecha_inicio, fecha_fin, cantidad) VALUES
(1, '2018-02-01', '2018-03-03');
INSERT INTO obtiene(id_lote, id_produccion) VALUES(3, 3);

INSERT INTO produccion(id_sucursal, fecha_inicio, fecha_fin, cantidad) VALUES
(2, '2017-12-01', '2018-01-03');
INSERT INTO obtiene(id_lote, id_produccion) VALUES(4, 4);


-----------------------------------------------------------------------
-- Funcionarios
-----------------------------------------------------------------------
INSERT INTO funcionario(cedula, id_sucursal, nombre, apellido, direccion, usuario, contrasena, cargo) VALUES
(4100001, 1, "José", "Pérez", "18 de Julio 1111", "jose", "jose", "Gerente General");

INSERT INTO funcionario(cedula, id_sucursal, nombre, apellido, direccion, usuario, contrasena, cargo) VALUES
(4200001, 1, "Ana", "Pérez", "18 de Julio 22222", "ana", "ana", "Gerente Sucursal");

INSERT INTO funcionario(cedula, id_sucursal, nombre, apellido, direccion, usuario, contrasena, cargo) VALUES
(4300001, 1, "Enrique", "Martinez", "18 de Julio 3333", "enrique", "enrique", "Administrativo");

INSERT INTO funcionario(cedula, id_sucursal, nombre, apellido, direccion, usuario, contrasena, cargo) VALUES
(4400001, 1, "María", "Pérez", "18 de Julio 4444", "maria", "maria", "Enologo");

INSERT INTO funcionario(cedula, id_sucursal, nombre, apellido, direccion, usuario, contrasena, cargo) VALUES
(4500001, 1, "Mirta", "Legrand", "18 de Julio 55555", "jose", "jose", "Viverista");

INSERT INTO funcionario(cedula, id_sucursal, nombre, apellido, direccion, usuario, contrasena, cargo) VALUES
(4600001, 1, "Mario", "Bros", "18 de Julio 6666", "mario", "mario", "Viticultor");

INSERT INTO funcionario(cedula, id_sucursal, nombre, apellido, direccion, usuario, contrasena, cargo) VALUES
(4700001, 1, "Homero", "Simpson", "18 de Julio 7777", "homero", "homero", "Agrónomo");

INSERT INTO funcionario(cedula, id_sucursal, nombre, apellido, direccion, usuario, contrasena, cargo) VALUES
(4800001, 1, "Lisa", "Simpson", "18 de Julio 8888", "homero", "homero", "Ampelólogo");



INSERT INTO funcionario(cedula, id_sucursal, nombre, apellido, direccion, usuario, contrasena, cargo) VALUES
(4200002, 2, "Ana", "Pérez", "18 de Julio 22222", "ana", "ana", "Gerente Sucursal");

INSERT INTO funcionario(cedula, id_sucursal, nombre, apellido, direccion, usuario, contrasena, cargo) VALUES
(4300002, 2, "Enrique", "Martinez", "18 de Julio 3333", "enrique", "enrique", "Administrativo");

INSERT INTO funcionario(cedula, id_sucursal, nombre, apellido, direccion, usuario, contrasena, cargo) VALUES
(4400002, 2, "María", "Pérez", "18 de Julio 4444", "maria", "maria", "Enologo");

INSERT INTO funcionario(cedula, id_sucursal, nombre, apellido, direccion, usuario, contrasena, cargo) VALUES
(4500002, 2, "Mirta", "Legrand", "18 de Julio 55555", "jose", "jose", "Viverista");

INSERT INTO funcionario(cedula, id_sucursal, nombre, apellido, direccion, usuario, contrasena, cargo) VALUES
(4600002, 2, "Mario", "Bros", "18 de Julio 6666", "mario", "mario", "Viticultor");

INSERT INTO funcionario(cedula, id_sucursal, nombre, apellido, direccion, usuario, contrasena, cargo) VALUES
(4700002, 2, "Homero", "Simpson", "18 de Julio 7777", "homero", "homero", "Agrónomo");

INSERT INTO funcionario(cedula, id_sucursal, nombre, apellido, direccion, usuario, contrasena, cargo) VALUES
(4800002, 2, "Lisa", "Simpson", "18 de Julio 8888", "homero", "homero", "Ampelólogo");

INSERT INTO funcionario(cedula, id_sucursal, nombre, apellido, direccion, usuario, contrasena, cargo) VALUES
(4900002, 2, "Bob", "Esponja", "18 de Julio 9999", "bob", "bob", "Administrativo");


-----------------------------------------------------------------------
-- Clientes
-----------------------------------------------------------------------
INSERT INTO cliente(id_cliente, nombre,direccion, telefono)
VALUES(100000000000, "Grupo Traversa", "8 Octubre 1100", '023595876');

INSERT INTO cliente(id_cliente, nombre,direccion, telefono)
VALUES(200000000000, "Bodega Roses", "8 Octubre 22000", '056535885');


INSERT INTO cliente(id_cliente, nombre, direccion, telefono)
VALUES(11111111, "Pedro Escamoso", "8 Octubre 1111", '023595876');

INSERT INTO cliente(id_cliente, nombre, direccion, telefono)
VALUES(22222222, "Luis Suarez", "8 Octubre 2222", '023595876');


-----------------------------------------------------------------------
-- Reservas
-----------------------------------------------------------------------

INSERT INTO reserva(fecha_hora, id_cliente) VALUES('2018-07-04', 100000000000);
INSERT INTO contiene(id_reserva, id_eproducto, cantidad) VALUES(1, 5, 100);

INSERT INTO reserva(fecha_hora, id_cliente) VALUES('2018-08-04', 100000000000);
INSERT INTO contiene(id_reserva, id_eproducto, cantidad) VALUES(2, 6, 200);

INSERT INTO reserva(fecha_hora, id_cliente) VALUES('2018-09-04', 200000000000);
INSERT INTO contiene(id_reserva, id_eproducto, cantidad) VALUES(3, 6, 300);

INSERT INTO reserva(fecha_hora, id_cliente) VALUES('2018-10-04', 11111111);
INSERT INTO contiene(id_reserva, id_eproducto, cantidad) VALUES(4, 6, 2);
INSERT INTO contiene(id_reserva, id_eproducto, cantidad) VALUES(5, 6, 2);
INSERT INTO contiene(id_reserva, id_eproducto, cantidad) VALUES(6, 6, 2);
INSERT INTO contiene(id_reserva, id_eproducto, cantidad) VALUES(7, 6, 2);