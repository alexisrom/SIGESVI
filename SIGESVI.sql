-- mar 14 ago 2018 15:23:53 -03


-- -----------------------------------------------------
-- Base de datos sigesvi
-- -----------------------------------------------------
CREATE DATABASE sigesvi;
USE sigesvi ;

-- -----------------------------------------------------
-- Tabla sucursal
-- -----------------------------------------------------
CREATE TABLE sucursal (
  id INT NOT NULL,
  nombre VARCHAR(45) NOT NULL,
  direccion VARCHAR(45) NOT NULL,
  departamento VARCHAR(45) NOT NULL,
  PRIMARY KEY (id));



-- -----------------------------------------------------
-- Tabla funcionario
-- -----------------------------------------------------
CREATE TABLE funcionario (
  id INT PRIMARY KEY AUTO_INCREMENT,
  nombre VARCHAR(45) NOT NULL,
  apellido VARCHAR(45) NOT NULL,
  f_nacimiento  NOT NULL DEFAULT CURRENT_TIMESTAMP,
  direccion VARCHAR(45) NOT NULL,
  user VARCHAR(45) NOT NULL UNIQUE,
  psw VARCHAR(45) NOT NULL,
  cargo VARCHAR(15) NOT NULL,
  telefono VARCHAR(8) NULL UNIQUE,
  sucursal_id INT NOT NULL,
  FOREIGN KEY sucursal_id REFERENCES sucursal.id
  );


-- -----------------------------------------------------
-- Tabla telefonos
-- -----------------------------------------------------
CREATE TABLE telefonos (
  numero INT NOT NULL,
  sucursal_id INT NOT NULL,
  PRIMARY KEY (numero),
  INDEX fk_telefonos_sucursal_idx (sucursal_id ASC),
  CONSTRAINT fk_telefonos_sucursal
    FOREIGN KEY (sucursal_id)
    REFERENCES sucursal (id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)



-- -----------------------------------------------------
-- Tabla categoria
-- -----------------------------------------------------
CREATE TABLE categoria (
  id INT NOT NULL,
  nombre VARCHAR(45) NOT NULL,
  PRIMARY KEY (id))



-- -----------------------------------------------------
-- Tabla especificacion_producto
-- -----------------------------------------------------
CREATE TABLE especificacion_producto (
  id INT NOT NULL,
  nombre VARCHAR(45) NOT NULL,
  descripcion VARCHAR(45) NOT NULL,
  precio DECIMAL NOT NULL,
  unidad_medida VARCHAR(3) NOT NULL,
  recipiente VARCHAR(45) NOT NULL,
  categoria_id INT NOT NULL,
  PRIMARY KEY (id),
  INDEX fk_especificacion_producto_categoria1_idx (categoria_id ASC),
  CONSTRAINT fk_especificacion_producto_categoria1
    FOREIGN KEY (categoria_id)
    REFERENCES categoria (id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)



-- -----------------------------------------------------
-- Tabla etapa_de_elaboracion
-- -----------------------------------------------------
CREATE TABLE etapa_de_elaboracion (
  id INT NOT NULL,
  nombre VARCHAR(45) NOT NULL,
  descripcion VARCHAR(45) NOT NULL,
  numero INT NOT NULL,
  duracion INT NOT NULL,
  especificacion_producto_id INT NOT NULL,
  PRIMARY KEY (id),
  INDEX fk_etapa_de_elaboracion_especificacion_producto1_idx (especificacion_producto_id ASC),
  CONSTRAINT fk_etapa_de_elaboracion_especificacion_producto1
    FOREIGN KEY (especificacion_producto_id)
    REFERENCES especificacion_producto (id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)



-- -----------------------------------------------------
-- Tabla cliente
-- -----------------------------------------------------
CREATE TABLE cliente (
  id INT NOT NULL,
  nombre VARCHAR(45) NOT NULL,
  apellido VARCHAR(45) NOT NULL,
  direccion VARCHAR(45) NOT NULL,
  telefono VARCHAR(45) NOT NULL,
  PRIMARY KEY (id))



-- -----------------------------------------------------
-- Tabla reserva
-- -----------------------------------------------------
CREATE TABLE reserva (
  id INT NOT NULL,
  fecha_hora DATETIME NOT NULL,
  estado CHAR(1) NOT NULL,
  clientes_id INT NOT NULL,
  PRIMARY KEY (id),
  INDEX fk_reserva_clientes1_idx (clientes_id ASC),
  CONSTRAINT fk_reserva_clientes1
    FOREIGN KEY (clientes_id)
    REFERENCES cliente (id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)



-- -----------------------------------------------------
-- Tabla reserva_contiene_especificacion_producto
-- -----------------------------------------------------
CREATE TABLE reserva_contiene_especificacion_producto (
  reserva_id INT NOT NULL,
  especificacion_de_producto_id INT NOT NULL,
  cantidad VARCHAR(45) NULL,
  PRIMARY KEY (reserva_id, especificacion_de_producto_id),
  INDEX fk_reserva_has_especificacion_de_producto_especificacion_de_idx (especificacion_de_producto_id ASC),
  INDEX fk_reserva_has_especificacion_de_producto_reserva1_idx (reserva_id ASC),
  CONSTRAINT fk_reserva_has_especificacion_de_producto_reserva1
    FOREIGN KEY (reserva_id)
    REFERENCES reserva (id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_reserva_has_especificacion_de_producto_especificacion_de_p1
    FOREIGN KEY (especificacion_de_producto_id)
    REFERENCES especificacion_producto (id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)



-- -----------------------------------------------------
-- Tabla origen
-- -----------------------------------------------------
CREATE TABLE origen (
  id INT NOT NULL,
  nombre VARCHAR(45) NOT NULL,
  propietario VARCHAR(45) NOT NULL,
  PRIMARY KEY (id))



-- -----------------------------------------------------
-- Tabla lote
-- -----------------------------------------------------
CREATE TABLE lote (
  id INT NOT NULL,
  stock INT NOT NULL,
  fecha_produccion DATETIME NOT NULL,
  origen_id INT NOT NULL,
  PRIMARY KEY (id),
  INDEX fk_lote_campos1_idx (origen_id ASC),
  CONSTRAINT fk_lote_campos1
    FOREIGN KEY (origen_id)
    REFERENCES origen (id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)



-- -----------------------------------------------------
-- Tabla alberga
-- -----------------------------------------------------
CREATE TABLE alberga (
  lote_id INT NOT NULL,
  PRIMARY KEY (lote_id),
  CONSTRAINT fk_alberga_lote1
    FOREIGN KEY (lote_id)
    REFERENCES lote (id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);


-- -----------------------------------------------------
-- Tabla almacen
-- -----------------------------------------------------
CREATE TABLE almacen (
  id INT NOT NULL,
  nombre VARCHAR(45) NOT NULL,
  sucursal_id INT NOT NULL,
  alberga_lote_id INT NOT NULL,
  PRIMARY KEY (id, alberga_lote_id),
  INDEX fk_almacen_sucursal1_idx (sucursal_id ASC),
  INDEX fk_almacen_alberga1_idx (alberga_lote_id ASC),
  CONSTRAINT fk_almacen_sucursal1
    FOREIGN KEY (sucursal_id)
    REFERENCES sucursal (id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_almacen_alberga1
    FOREIGN KEY (alberga_lote_id)
    REFERENCES alberga (lote_id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)



-- -----------------------------------------------------
-- Tabla transacciones
-- -----------------------------------------------------
CREATE TABLE transacciones (
  id INT NOT NULL,
  fecha_hora DATETIME NOT NULL,
  PRIMARY KEY (id))



-- -----------------------------------------------------
-- Tabla compra
-- -----------------------------------------------------
CREATE TABLE compra (
  id INT NOT NULL,
  costo DECIMAL NOT NULL,
  Transacciones_id INT NOT NULL,
  PRIMARY KEY (id),
  INDEX fk_compra_Transacciones1_idx (Transacciones_id ASC),
  CONSTRAINT fk_compra_Transacciones1
    FOREIGN KEY (Transacciones_id)
    REFERENCES transacciones (id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)



-- -----------------------------------------------------
-- Tabla venta
-- -----------------------------------------------------
CREATE TABLE venta (
  id INT NOT NULL,
  valor DECIMAL NOT NULL,
  Transacciones_id INT NOT NULL,
  PRIMARY KEY (id),
  INDEX fk_venta_Transacciones1_idx (Transacciones_id ASC),
  CONSTRAINT fk_venta_Transacciones1
    FOREIGN KEY (Transacciones_id)
    REFERENCES transacciones (id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)



-- -----------------------------------------------------
-- Tabla transporte
-- -----------------------------------------------------
CREATE TABLE transporte (
  id INT NULL,
  tipo VARCHAR(15) NULL,
  capacidad VARCHAR(15) NULL,
  PRIMARY KEY (id))



-- -----------------------------------------------------
-- Tabla destino
-- -----------------------------------------------------
CREATE TABLE destino (
  id INT NOT NULL DEFAULT CURRENT_TIMESTAMP,
  direccion VARCHAR(45) NULL,
  PRIMARY KEY (id));


-- -----------------------------------------------------
-- Tabla traslado
-- -----------------------------------------------------
CREATE TABLE traslado (
  id INT NOT NULL,
  destino VARCHAR(45) NULL,
  Transacciones_id INT NOT NULL,
  transporte_id INT NOT NULL,
  destino_id INT NOT NULL,
  PRIMARY KEY (id),
  INDEX fk_traslado_Transacciones1_idx (Transacciones_id ASC),
  INDEX fk_traslado_transporte1_idx (transporte_id ASC),
  INDEX fk_traslado_destino1_idx (destino_id ASC),
  CONSTRAINT fk_traslado_Transacciones1
    FOREIGN KEY (Transacciones_id)
    REFERENCES transacciones (id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_traslado_transporte1
    FOREIGN KEY (transporte_id)
    REFERENCES transporte (id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_traslado_destino1
    FOREIGN KEY (destino_id)
    REFERENCES destino (id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)



-- -----------------------------------------------------
-- Tabla produccion
-- -----------------------------------------------------
CREATE TABLE produccion (
  id INT NOT NULL,
  fecha_inicio VARCHAR(45) NULL,
  fecha_fin VARCHAR(45) NULL,
  cantidad VARCHAR(45) NULL,
  PRIMARY KEY (id))



-- -----------------------------------------------------
-- Tabla recordatorio
-- -----------------------------------------------------
CREATE TABLE recordatorio (
  id INT NOT NULL,
  mensaje TEXT NOT NULL,
  fecha_hora DATETIME NOT NULL,
  etapa_de_elaboracion_id INT NOT NULL,
  PRIMARY KEY (id, etapa_de_elaboracion_id),
  INDEX fk_recordatorio_etapa_de_elaboracion1_idx (etapa_de_elaboracion_id ASC),
  CONSTRAINT fk_recordatorio_etapa_de_elaboracion1
    FOREIGN KEY (etapa_de_elaboracion_id)
    REFERENCES etapa_de_elaboracion (id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)



-- -----------------------------------------------------
-- Tabla materia_prima
-- -----------------------------------------------------
CREATE TABLE materia_prima (
  id INT NOT NULL,
  estado sanitario VARCHAR(45) NOT NULL,
  tipo_cepa VARCHAR(45) NOT NULL,
  PRIMARY KEY (id))



-- -----------------------------------------------------
-- Tabla producto_intermedio
-- -----------------------------------------------------
CREATE TABLE producto_intermedio (
  id INT NOT NULL,
  calidad VARCHAR(15) NOT NULL,
  PRIMARY KEY (id))



-- -----------------------------------------------------
-- Tabla producto_final
-- -----------------------------------------------------
CREATE TABLE producto_final (
  especificacion_producto_id INT NOT NULL,
  INDEX fk_producto_final_especificacion_producto1_idx (especificacion_producto_id ASC),
  PRIMARY KEY (especificacion_producto_id),
  CONSTRAINT fk_producto_final_especificacion_producto1
    FOREIGN KEY (especificacion_producto_id)
    REFERENCES especificacion_producto (id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)



-- -----------------------------------------------------
-- Tabla Obtiene
-- -----------------------------------------------------
CREATE TABLE Obtiene (
  id_lote  NOT NULL DEFAULT CURRENT_TIMESTAMP,
  id_produccion  NULL,
  PRIMARY KEY (id_lote));


-- -----------------------------------------------------
-- Tabla recorre
-- -----------------------------------------------------
CREATE TABLE recorre (
  fecha_inicio DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  fecha_fin DATETIME NOT NULL,
  etapa_actual BIT NOT NULL DEFAULT 0);


-- -----------------------------------------------------
-- Tabla composicion_producto_intermedio
-- -----------------------------------------------------
CREATE TABLE composicion_producto_intermedio (
  producto_intermedio_id INT NOT NULL,
  materia_prima_id INT NOT NULL,
  cantidad INT NOT NULL,
  INDEX fk_composicion_producto_intermedio_producto_intermedio1_idx (producto_intermedio_id ASC),
  INDEX fk_composicion_producto_intermedio_materia_prima1_idx (materia_prima_id ASC),
  PRIMARY KEY (materia_prima_id, producto_intermedio_id),
  CONSTRAINT fk_composicion_producto_intermedio_producto_intermedio1
    FOREIGN KEY (producto_intermedio_id)
    REFERENCES producto_intermedio (id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_composicion_producto_intermedio_materia_prima1
    FOREIGN KEY (materia_prima_id)
    REFERENCES materia_prima (id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);


-- -----------------------------------------------------
-- Tabla composicion_producto_final
-- -----------------------------------------------------
CREATE TABLE composicion_producto_final (
  producto_final_especificacion_producto_id INT NOT NULL,
  producto_intermedio_id INT NOT NULL,
  cantidad INT NOT NULL,
  PRIMARY KEY (producto_final_especificacion_producto_id, producto_intermedio_id),
  INDEX fk_producto_final_has_producto_intermedio_producto_intermed_idx (producto_intermedio_id ASC),
  INDEX fk_producto_final_has_producto_intermedio_producto_final1_idx (producto_final_especificacion_producto_id ASC),
  CONSTRAINT fk_producto_final_has_producto_intermedio_producto_final1
    FOREIGN KEY (producto_final_especificacion_producto_id)
    REFERENCES producto_final (especificacion_producto_id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT fk_producto_final_has_producto_intermedio_producto_intermedio1
    FOREIGN KEY (producto_intermedio_id)
    REFERENCES producto_intermedio (id)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);
