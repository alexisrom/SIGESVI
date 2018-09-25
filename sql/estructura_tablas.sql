CREATE TABLE sucursal 
  (
    id_sucursal SERIAL NOT NULL,
    nombre VARCHAR(20) NOT NULL,
    direccion VARCHAR(20) NOT NULL,
    departamento VARCHAR(20) NOT NULL,
    activo BOOLEAN DEFAULT "t",
    PRIMARY KEY (id_sucursal)
  );

CREATE TABLE telefono_sucursal 
  (
    id_sucursal INTEGER NOT NULL,
    telefono INTEGER NOT NULL,
    PRIMARY KEY (id_sucursal),
    FOREIGN KEY (id_sucursal) REFERENCES sucursal(id_sucursal)
  );

CREATE TABLE produccion 
  (
    id_produccion SERIAL NOT NULL,
    id_sucursal INTEGER NOT NULL,
    fecha_inicio DATE NOT NULL,
    fecha_fin DATE NOT NULL,
    cantidad INTEGER NOT NULL,
    activo BOOLEAN DEFAULT "t",
    PRIMARY KEY (id_produccion),
    FOREIGN KEY (id_sucursal) REFERENCES sucursal(id_sucursal)
  );

CREATE TABLE origen 
  (
    id_origen SERIAL NOT NULL,
    nombre VARCHAR(30) NOT NULL,
    direccion VARCHAR(40) NOT NULL,
    propietario VARCHAR(25) NOT NULL,
    activo BOOLEAN DEFAULT "t",
    PRIMARY KEY (id_origen)
  );

CREATE TABLE cliente 
  (
    id_cliente INTEGER NOT NULL,
    nombre VARCHAR(30) NOT NULL,
    apellido VARCHAR(30) NOT NULL,
    direccion VARCHAR(40) NOT NULL,
    telefono VARCHAR(9) NOT NULL,
    activo BOOLEAN DEFAULT "t",
    PRIMARY KEY (id_cliente) 
  );

CREATE TABLE reserva 
  (
    id_reserva SERIAL NOT NULL,
    fecha_hora DATE NOT NULL,
    id_cliente INTEGER NOT NULL,
    activo BOOLEAN DEFAULT "t",
    PRIMARY KEY (id_reserva),
    FOREIGN KEY (id_cliente) REFERENCES cliente(id_cliente)
  );

CREATE TABLE especificacion_de_producto 
  (
    id_eproducto SERIAL NOT NULL,
    nombre VARCHAR(30) NOT NULL,
    descripcion VARCHAR(200) NOT NULL,
    precio INTEGER NOT NULL,
    unidad_medida VARCHAR(10) NOT NULL CHECK(unidad_medida IN ("Kg", "g", "L", "mL")),
    categoria VARCHAR(20) NOT NULL CHECK(categoria IN ("Tinto", "Blanco", "Rosado")),
    activo BOOLEAN DEFAULT "t",
    PRIMARY KEY (id_eproducto) 
  );

CREATE TABLE etapa_de_elaboracion 
  (
    id_etapa SERIAL NOT NULL ,
    nombre VARCHAR(30) NOT NULL,
    numero INTEGER NOT NULL,
    descripcion VARCHAR(200) NOT NULL,
    duracion VARCHAR(15) NOT NULL,
    id_eproducto INTEGER NOT NULL,
    PRIMARY KEY (id_etapa),
    FOREIGN KEY (id_eproducto) REFERENCES especificacion_de_producto(id_eproducto)
  );

CREATE TABLE recorre 
  (
    id_produccion SERIAL NOT NULL ,
    id_etapa INTEGER NOT NULL,
    fecha_inico DATE NOT NULL,
    fecha_fin DATE NOT NULL,
    etapa_actual VARCHAR(20) NOT NULL,
    PRIMARY KEY (id_produccion),
    FOREIGN KEY (id_produccion) REFERENCES produccion(id_produccion),
    FOREIGN KEY (id_etapa) REFERENCES etapa_de_elaboracion(id_etapa)
  );


CREATE TABLE recordatorio 
  (
    id_recordatorio SERIAL NOT NULL,
    mensaje VARCHAR(200) NOT NULL,
    fecha DATE NOT NULL,
    id_etapa INTEGER NOT NULL,
    PRIMARY KEY (id_recordatorio),
    FOREIGN KEY (id_etapa) REFERENCES etapa_de_elaboracion(id_etapa)
  );

CREATE TABLE transacciones 
  (
    id_transaccion SERIAL NOT NULL,
    fecha_hora DATE NOT NULL,
    activo BOOLEAN DEFAULT "t",
    PRIMARY KEY (id_transaccion) 
  );

CREATE TABLE compra 
  (
    id_transaccion INTEGER NOT NULL,
    costo INTEGER NOT NULL,
    PRIMARY KEY (id_transaccion),
    FOREIGN KEY (id_transaccion) REFERENCES transacciones(id_transaccion)
  );

CREATE TABLE venta 
  (
    id_transaccion INTEGER NOT NULL,
    costo INTEGER NOT NULL,
    PRIMARY KEY (id_transaccion),
    FOREIGN KEY (id_transaccion) REFERENCES transacciones(id_transaccion)
  );

CREATE TABLE destino 
  (
    id_destino SERIAL NOT NULL,
    direccion VARCHAR(40) NOT NULL,
    activo BOOLEAN DEFAULT "t",
    PRIMARY KEY (id_destino) 
  );

  
CREATE TABLE transporte 
  (
    id_transporte SERIAL NOT NULL,
    tipo VARCHAR(20) NOT NULL CHECK(tipo IN ("Camión", "Carro manuel", "Elevador", "Tractor y traileres")),
    capacidad INTEGER NOT NULL,
    activo BOOLEAN DEFAULT "t",
    PRIMARY KEY (id_transporte)
  );

CREATE TABLE traslado 
  (
    id_transaccion INTEGER NOT NULL,
    id_transporte INTEGER NOT NULL,
    id_destino INTEGER NOT NULL,
    PRIMARY KEY (id_transaccion),
    FOREIGN KEY (id_transaccion) REFERENCES transacciones(id_transaccion),
    FOREIGN KEY (id_transporte) REFERENCES transporte(id_transporte),
    FOREIGN KEY (id_destino) REFERENCES destino(id_destino)
  );


CREATE TABLE materia_prima 
  (
    id_eproducto INTEGER NOT NULL,
    estado_sanitario VARCHAR(20) NOT NULL,
    tipo_cepa VARCHAR(20) NOT NULL CHECK(tipo_cepa IN ("Merlot", "Cabernet Sauvignon", "Malbec", "Pinot Noir", "Sangiovese")),
    PRIMARY KEY (id_eproducto),
    FOREIGN KEY (id_eproducto) REFERENCES especificacion_de_producto(id_eproducto)
  );

CREATE TABLE producto_intermedio 
  (
    id_eproducto INTEGER NOT NULL,
    calidad INTEGER NOT NULL,
    crianza VARCHAR(20) NOT NULL CHECK(crianza IN ("Barricas de Roble", "Pileta de hormigón", "Tanque de acero inoxidable")),
    PRIMARY KEY (id_eproducto),
    FOREIGN KEY (id_eproducto) REFERENCES especificacion_de_producto(id_eproducto)
  );

CREATE TABLE producto_final 
  (
    id_eproducto INTEGER NOT NULL,
    embotellamiento VARCHAR(3) NOT NULL CHECK(embotellamiento IN ("2", "1", "1.5", "3/4")),
    PRIMARY KEY (id_eproducto),
    FOREIGN KEY (id_eproducto) REFERENCES especificacion_de_producto(id_eproducto)
  );

CREATE TABLE conformado 
  (
    id_prod_final INTEGER NOT NULL,
    id_prod_intermedio INTEGER NOT NULL,
    cantidad INTEGER NOT NULL,
    PRIMARY KEY (id_prod_final, id_prod_intermedio),
    FOREIGN KEY (id_prod_final) REFERENCES producto_final(id_eproducto),
    FOREIGN KEY (id_prod_intermedio) REFERENCES producto_intermedio(id_eproducto)
  );

CREATE TABLE lote 
  (
    id_lote SERIAL NOT NULL,
    stock INTEGER NOT NULL,
    id_origen INTEGER NOT NULL,
    fecha DATE NOT NULL,
    id_eproducto INTEGER NOT NULL,
    activo BOOLEAN DEFAULT "t",
    PRIMARY KEY (id_lote),
    FOREIGN KEY (id_eproducto) REFERENCES especificacion_de_producto(id_eproducto)
  );

CREATE TABLE obtiene 
  (
    id_lote INTEGER NOT NULL,
    id_produccion INTEGER NOT NULL,
    PRIMARY KEY (id_lote),
    FOREIGN KEY (id_lote) REFERENCES lote(id_lote),
    FOREIGN KEY (id_produccion) REFERENCES produccion(id_produccion)
  );


CREATE TABLE compuesto 
  (
    id_prod_intermedio INTEGER NOT NULL,
    id_mat_prima INTEGER NOT NULL,
    cantidad INTEGER NOT NULL,
    PRIMARY KEY (id_prod_intermedio,id_mat_prima),
    FOREIGN KEY (id_prod_intermedio) REFERENCES producto_intermedio(id_eproducto),
    FOREIGN KEY (id_mat_prima) REFERENCES materia_prima(id_eproducto)
  );

CREATE TABLE almacen 
  (
    id_almacen SERIAL NOT NULL,
    nombre VARCHAR(30) NOT NULL,
    id_sucursal INTEGER NOT NULL,
    activo BOOLEAN DEFAULT "t",
    PRIMARY KEY (id_almacen),
    FOREIGN KEY (id_sucursal) REFERENCES sucursal(id_sucursal)
  );

CREATE TABLE alberga 
  (
    id_lote INTEGER NOT NULL,
    id_almacen INTEGER NOT NULL,
    PRIMARY KEY (id_lote),
    FOREIGN KEY (id_lote) REFERENCES lote(id_lote),
    FOREIGN KEY (id_almacen) REFERENCES almacen(id_almacen)
  );


CREATE TABLE funcionario 
  (
    cedula INTEGER NOT NULL CHECK(cedula BETWEEN 4000000 AND 7000000),
    id_sucursal INTEGER NOT NULL,
    nombre VARCHAR(30) NOT NULL,
    apellido VARCHAR(30) NOT NULL,
    direccion VARCHAR(40) NOT NULL,
    usuario VARCHAR(20) NOT NULL,
    contrasena VARCHAR(20) NOT NULL,
    cargo VARCHAR(25) NOT NULL CHECK(cargo IN ("Gerente General", "Gerente Sucursal", "Administrativo", "Asesor Profesional")),
    activo BOOLEAN DEFAULT "t",
    PRIMARY KEY (cedula),
    FOREIGN KEY (id_sucursal) REFERENCES sucursal(id_sucursal)
  );
