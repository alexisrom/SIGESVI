{ DATABASE sigesvi  delimiter | }

grant dba to "informix";











{ TABLE "informix".sucursal row size = 71 number of columns = 6 index size = 9 }

{ unload file name = sucur00100.unl number of rows = 4 }

create table "informix".sucursal 
  (
    id_sucursal serial not null ,
    nombre varchar(20) not null ,
    direccion varchar(20) not null ,
    departamento varchar(20) not null ,
    proveedor "informix".boolean 
        default 'f',
    activo "informix".boolean 
        default 't',
    primary key (id_sucursal) 
  );

revoke all on "informix".sucursal from "public" as "informix";

{ TABLE "informix".telefono_sucursal row size = 8 number of columns = 2 index size = 22 }

{ unload file name = telef00101.unl number of rows = 6 }

create table "informix".telefono_sucursal 
  (
    id_sucursal integer not null ,
    telefono integer not null ,
    primary key (id_sucursal,telefono) 
  );

revoke all on "informix".telefono_sucursal from "public" as "informix";

{ TABLE "informix".cliente row size = 130 number of columns = 7 index size = 9 }

{ unload file name = clien00102.unl number of rows = 0 }

create table "informix".cliente 
  (
    id_cliente integer not null ,
    nombre varchar(30) not null ,
    direccion varchar(40) not null ,
    telefono varchar(9) not null ,
    usuario varchar(20) not null ,
    contrasena varchar(20) not null ,
    activo "informix".boolean 
        default 't',
    primary key (id_cliente) 
  );

revoke all on "informix".cliente from "public" as "informix";

{ TABLE "informix".especificacion_de_producto row size = 330 number of columns = 8 index size = 9 }

{ unload file name = espec00103.unl number of rows = 0 }

create table "informix".especificacion_de_producto 
  (
    id_eproducto serial not null ,
    nombre varchar(30) not null ,
    descripcion varchar(200) not null ,
    precio integer not null ,
    unidad_medida varchar(10) not null ,
    categoria varchar(20) not null ,
    foto byte,
    activo "informix".boolean 
        default 't',
    
    check (unidad_medida IN ('Kg' ,'g' ,'L' ,'mL' )),
    
    check (categoria IN ('Tinto' ,'Blanco' ,'Rosado' )),
    primary key (id_eproducto) 
  );

revoke all on "informix".especificacion_de_producto from "public" as "informix";

{ TABLE "informix".etapa_de_elaboracion row size = 248 number of columns = 6 index size = 18 }

{ unload file name = etapa00104.unl number of rows = 0 }

create table "informix".etapa_de_elaboracion 
  (
    id_etapa serial not null ,
    nombre varchar(30) not null ,
    numero integer not null ,
    descripcion varchar(200) not null ,
    duracion integer not null ,
    id_eproducto integer not null ,
    primary key (id_etapa) 
  );

revoke all on "informix".etapa_de_elaboracion from "public" as "informix";

{ TABLE "informix".produccion row size = 26 number of columns = 7 index size = 27 }

{ unload file name = produ00105.unl number of rows = 0 }

create table "informix".produccion 
  (
    id_produccion serial not null ,
    id_sucursal integer not null ,
    id_eproducto integer not null ,
    fecha_inicio date not null ,
    fecha_fin date not null ,
    cantidad integer not null ,
    activo "informix".boolean 
        default 't',
    
    check (fecha_inicio < fecha_fin ),
    primary key (id_produccion) 
  );

revoke all on "informix".produccion from "public" as "informix";

{ TABLE "informix".recorre row size = 221 number of columns = 6 index size = 31 }

{ unload file name = recor00106.unl number of rows = 0 }

create table "informix".recorre 
  (
    id_produccion serial not null ,
    id_etapa integer not null ,
    fecha_inicio date not null ,
    fecha_fin date not null ,
    observacion varchar(200),
    cantidad integer not null ,
    primary key (id_produccion,id_etapa) 
  );

revoke all on "informix".recorre from "public" as "informix";

{ TABLE "informix".alarma row size = 217 number of columns = 5 index size = 13 }

{ unload file name = alarm00107.unl number of rows = 0 }

create table "informix".alarma 
  (
    id_produccion integer not null ,
    id_etapa integer not null ,
    fecha date not null ,
    duracion integer 
        default 1,
    mensaje varchar(200),
    primary key (id_produccion,id_etapa) 
  );

revoke all on "informix".alarma from "public" as "informix";

{ TABLE "informix".recordatorio row size = 213 number of columns = 4 index size = 18 }

{ unload file name = recor00108.unl number of rows = 0 }

create table "informix".recordatorio 
  (
    id_recordatorio serial not null ,
    mensaje varchar(200) not null ,
    numero_dia integer not null ,
    id_etapa integer not null ,
    primary key (id_recordatorio) 
  );

revoke all on "informix".recordatorio from "public" as "informix";

{ TABLE "informix".transacciones row size = 17 number of columns = 4 index size = 18 }

{ unload file name = trans00109.unl number of rows = 0 }

create table "informix".transacciones 
  (
    id_transaccion serial not null ,
    id_sucursal integer not null ,
    fecha_hora datetime year to minute not null ,
    activo "informix".boolean 
        default 't',
    primary key (id_transaccion) 
  );

revoke all on "informix".transacciones from "public" as "informix";

{ TABLE "informix".compra row size = 8 number of columns = 2 index size = 9 }

{ unload file name = compr00110.unl number of rows = 0 }

create table "informix".compra 
  (
    id_transaccion integer not null ,
    costo integer not null ,
    primary key (id_transaccion) 
  );

revoke all on "informix".compra from "public" as "informix";

{ TABLE "informix".venta row size = 8 number of columns = 2 index size = 9 }

{ unload file name = venta00111.unl number of rows = 0 }

create table "informix".venta 
  (
    id_transaccion integer not null ,
    costo integer not null ,
    primary key (id_transaccion) 
  );

revoke all on "informix".venta from "public" as "informix";

{ TABLE "informix".destino row size = 47 number of columns = 3 index size = 9 }

{ unload file name = desti00112.unl number of rows = 0 }

create table "informix".destino 
  (
    id_destino serial not null ,
    direccion varchar(40) not null ,
    activo "informix".boolean 
        default 't',
    primary key (id_destino) 
  );

revoke all on "informix".destino from "public" as "informix";

{ TABLE "informix".transporte row size = 31 number of columns = 4 index size = 9 }

{ unload file name = trans00113.unl number of rows = 0 }

create table "informix".transporte 
  (
    id_transporte integer not null ,
    nombre varchar(20) not null ,
    capacidad integer not null ,
    activo "informix".boolean 
        default 't',
    primary key (id_transporte) 
  );

revoke all on "informix".transporte from "public" as "informix";

{ TABLE "informix".traslado row size = 59 number of columns = 3 index size = 18 }

{ unload file name = trasl00114.unl number of rows = 0 }

create table "informix".traslado 
  (
    id_transaccion integer not null ,
    id_transporte integer not null ,
    destino varchar(50) not null ,
    primary key (id_transaccion) 
  );

revoke all on "informix".traslado from "public" as "informix";

{ TABLE "informix".tipo_cepa row size = 41 number of columns = 3 index size = 35 }

{ unload file name = tipo_00115.unl number of rows = 7 }

create table "informix".tipo_cepa 
  (
    id_tipo_cepa serial not null ,
    nombre varchar(20) not null ,
    tipo varchar(15) not null ,
    unique (nombre) ,
    
    check (tipo IN ('Tinto' ,'Rosado' ,'Blanco' )),
    primary key (id_tipo_cepa) 
  );

revoke all on "informix".tipo_cepa from "public" as "informix";

{ TABLE "informix".materia_prima row size = 29 number of columns = 3 index size = 18 }

{ unload file name = mater00116.unl number of rows = 0 }

create table "informix".materia_prima 
  (
    id_eproducto integer not null ,
    id_tipo_cepa integer not null ,
    estado_sanitario varchar(20) not null ,
    primary key (id_eproducto) 
  );

revoke all on "informix".materia_prima from "public" as "informix";

{ TABLE "informix".producto_intermedio row size = 20 number of columns = 2 index size = 9 }

{ unload file name = produ00117.unl number of rows = 0 }

create table "informix".producto_intermedio 
  (
    id_eproducto integer not null ,
    tipo varchar(15) not null ,
    
    check (tipo IN ('Yema' ,'Flor' ,'Lagrima' )),
    primary key (id_eproducto) 
  );

revoke all on "informix".producto_intermedio from "public" as "informix";

{ TABLE "informix".producto_final row size = 29 number of columns = 3 index size = 9 }

{ unload file name = produ00118.unl number of rows = 0 }

create table "informix".producto_final 
  (
    id_eproducto integer not null ,
    crianza varchar(20) not null ,
    embotellamiento varchar(3) not null ,
    
    check (crianza IN ('Americano' ,'Frances' )),
    
    check (embotellamiento IN ('5' ,'2.5' ,'2' ,'1.5' ,'1' ,'3/4' ,'1/2' )),
    primary key (id_eproducto) 
  );

revoke all on "informix".producto_final from "public" as "informix";

{ TABLE "informix".lote row size = 22 number of columns = 6 index size = 27 }

{ unload file name = lote_00119.unl number of rows = 0 }

create table "informix".lote 
  (
    id_lote serial not null ,
    cantidad integer not null ,
    id_sucursal integer not null ,
    fecha date not null ,
    id_eproducto integer not null ,
    activo "informix".boolean 
        default 't',
    primary key (id_lote) 
  );

revoke all on "informix".lote from "public" as "informix";

{ TABLE "informix".involucra row size = 8 number of columns = 2 index size = 31 }

{ unload file name = invol00120.unl number of rows = 0 }

create table "informix".involucra 
  (
    id_lote integer not null ,
    id_transaccion integer not null ,
    primary key (id_lote,id_transaccion) 
  );

revoke all on "informix".involucra from "public" as "informix";

{ TABLE "informix".obtiene row size = 8 number of columns = 2 index size = 18 }

{ unload file name = obtie00121.unl number of rows = 0 }

create table "informix".obtiene 
  (
    id_lote integer not null ,
    id_produccion integer not null ,
    primary key (id_lote) 
  );

revoke all on "informix".obtiene from "public" as "informix";

{ TABLE "informix".almacen row size = 41 number of columns = 4 index size = 18 }

{ unload file name = almac00122.unl number of rows = 0 }

create table "informix".almacen 
  (
    id_almacen serial not null ,
    nombre varchar(30) not null ,
    id_sucursal integer not null ,
    activo "informix".boolean 
        default 't',
    primary key (id_almacen) 
  );

revoke all on "informix".almacen from "public" as "informix";

{ TABLE "informix".alberga row size = 8 number of columns = 2 index size = 18 }

{ unload file name = alber00123.unl number of rows = 0 }

create table "informix".alberga 
  (
    id_lote integer not null ,
    id_almacen integer not null ,
    primary key (id_lote) 
  );

revoke all on "informix".alberga from "public" as "informix";

{ TABLE "informix".funcionario row size = 190 number of columns = 10 index size = 18 }

{ unload file name = funci00124.unl number of rows = 5 }

create table "informix".funcionario 
  (
    cedula integer not null ,
    id_sucursal integer not null ,
    nombre varchar(30) not null ,
    apellido varchar(30) not null ,
    direccion varchar(40) not null ,
    usuario varchar(20) not null ,
    contrasena varchar(20) not null ,
    cargo varchar(25) not null ,
    telefono varchar(8),
    activo "informix".boolean 
        default 't',
    
    check ((cedula >= 4000000 ) AND (cedula <= 7000000 ) ),
    
    check (cargo IN ('Gerente General' ,'Gerente Sucursal' ,'Administrativo' ,'Asesor Profesional' ,'Enologo' )),
    primary key (cedula) 
  );

revoke all on "informix".funcionario from "public" as "informix";

{ TABLE "informix".reserva row size = 14 number of columns = 4 index size = 18 }

{ unload file name = reser00125.unl number of rows = 0 }

create table "informix".reserva 
  (
    id_reserva serial not null ,
    fecha_hora date not null ,
    id_cliente integer not null ,
    activo "informix".boolean 
        default 't',
    primary key (id_reserva) 
  );

revoke all on "informix".reserva from "public" as "informix";

{ TABLE "informix".contiene row size = 12 number of columns = 3 index size = 31 }

{ unload file name = conti00126.unl number of rows = 0 }

create table "informix".contiene 
  (
    id_reserva integer not null ,
    id_eproducto integer not null ,
    cantidad integer not null ,
    primary key (id_reserva,id_eproducto) 
  );

revoke all on "informix".contiene from "public" as "informix";

{ TABLE "informix".logs row size = 60 number of columns = 2 index size = 9 }

{ unload file name = logs_00127.unl number of rows = 0 }

create table "informix".logs 
  (
    id_log serial not null ,
    informacion text not null ,
    primary key (id_log) 
  );

revoke all on "informix".logs from "public" as "informix";




grant select on "informix".sucursal to "public" as "informix";
grant update on "informix".sucursal to "public" as "informix";
grant insert on "informix".sucursal to "public" as "informix";
grant delete on "informix".sucursal to "public" as "informix";
grant index on "informix".sucursal to "public" as "informix";
grant select on "informix".telefono_sucursal to "public" as "informix";
grant update on "informix".telefono_sucursal to "public" as "informix";
grant insert on "informix".telefono_sucursal to "public" as "informix";
grant delete on "informix".telefono_sucursal to "public" as "informix";
grant index on "informix".telefono_sucursal to "public" as "informix";
grant select on "informix".cliente to "public" as "informix";
grant update on "informix".cliente to "public" as "informix";
grant insert on "informix".cliente to "public" as "informix";
grant delete on "informix".cliente to "public" as "informix";
grant index on "informix".cliente to "public" as "informix";
grant select on "informix".especificacion_de_producto to "public" as "informix";
grant update on "informix".especificacion_de_producto to "public" as "informix";
grant insert on "informix".especificacion_de_producto to "public" as "informix";
grant delete on "informix".especificacion_de_producto to "public" as "informix";
grant index on "informix".especificacion_de_producto to "public" as "informix";
grant select on "informix".etapa_de_elaboracion to "public" as "informix";
grant update on "informix".etapa_de_elaboracion to "public" as "informix";
grant insert on "informix".etapa_de_elaboracion to "public" as "informix";
grant delete on "informix".etapa_de_elaboracion to "public" as "informix";
grant index on "informix".etapa_de_elaboracion to "public" as "informix";
grant select on "informix".produccion to "public" as "informix";
grant update on "informix".produccion to "public" as "informix";
grant insert on "informix".produccion to "public" as "informix";
grant delete on "informix".produccion to "public" as "informix";
grant index on "informix".produccion to "public" as "informix";
grant select on "informix".recorre to "public" as "informix";
grant update on "informix".recorre to "public" as "informix";
grant insert on "informix".recorre to "public" as "informix";
grant delete on "informix".recorre to "public" as "informix";
grant index on "informix".recorre to "public" as "informix";
grant select on "informix".alarma to "public" as "informix";
grant update on "informix".alarma to "public" as "informix";
grant insert on "informix".alarma to "public" as "informix";
grant delete on "informix".alarma to "public" as "informix";
grant index on "informix".alarma to "public" as "informix";
grant select on "informix".recordatorio to "public" as "informix";
grant update on "informix".recordatorio to "public" as "informix";
grant insert on "informix".recordatorio to "public" as "informix";
grant delete on "informix".recordatorio to "public" as "informix";
grant index on "informix".recordatorio to "public" as "informix";
grant select on "informix".transacciones to "public" as "informix";
grant update on "informix".transacciones to "public" as "informix";
grant insert on "informix".transacciones to "public" as "informix";
grant delete on "informix".transacciones to "public" as "informix";
grant index on "informix".transacciones to "public" as "informix";
grant select on "informix".compra to "public" as "informix";
grant update on "informix".compra to "public" as "informix";
grant insert on "informix".compra to "public" as "informix";
grant delete on "informix".compra to "public" as "informix";
grant index on "informix".compra to "public" as "informix";
grant select on "informix".venta to "public" as "informix";
grant update on "informix".venta to "public" as "informix";
grant insert on "informix".venta to "public" as "informix";
grant delete on "informix".venta to "public" as "informix";
grant index on "informix".venta to "public" as "informix";
grant select on "informix".destino to "public" as "informix";
grant update on "informix".destino to "public" as "informix";
grant insert on "informix".destino to "public" as "informix";
grant delete on "informix".destino to "public" as "informix";
grant index on "informix".destino to "public" as "informix";
grant select on "informix".transporte to "public" as "informix";
grant update on "informix".transporte to "public" as "informix";
grant insert on "informix".transporte to "public" as "informix";
grant delete on "informix".transporte to "public" as "informix";
grant index on "informix".transporte to "public" as "informix";
grant select on "informix".traslado to "public" as "informix";
grant update on "informix".traslado to "public" as "informix";
grant insert on "informix".traslado to "public" as "informix";
grant delete on "informix".traslado to "public" as "informix";
grant index on "informix".traslado to "public" as "informix";
grant select on "informix".tipo_cepa to "public" as "informix";
grant update on "informix".tipo_cepa to "public" as "informix";
grant insert on "informix".tipo_cepa to "public" as "informix";
grant delete on "informix".tipo_cepa to "public" as "informix";
grant index on "informix".tipo_cepa to "public" as "informix";
grant select on "informix".materia_prima to "public" as "informix";
grant update on "informix".materia_prima to "public" as "informix";
grant insert on "informix".materia_prima to "public" as "informix";
grant delete on "informix".materia_prima to "public" as "informix";
grant index on "informix".materia_prima to "public" as "informix";
grant select on "informix".producto_intermedio to "public" as "informix";
grant update on "informix".producto_intermedio to "public" as "informix";
grant insert on "informix".producto_intermedio to "public" as "informix";
grant delete on "informix".producto_intermedio to "public" as "informix";
grant index on "informix".producto_intermedio to "public" as "informix";
grant select on "informix".producto_final to "public" as "informix";
grant update on "informix".producto_final to "public" as "informix";
grant insert on "informix".producto_final to "public" as "informix";
grant delete on "informix".producto_final to "public" as "informix";
grant index on "informix".producto_final to "public" as "informix";
grant select on "informix".lote to "public" as "informix";
grant update on "informix".lote to "public" as "informix";
grant insert on "informix".lote to "public" as "informix";
grant delete on "informix".lote to "public" as "informix";
grant index on "informix".lote to "public" as "informix";
grant select on "informix".involucra to "public" as "informix";
grant update on "informix".involucra to "public" as "informix";
grant insert on "informix".involucra to "public" as "informix";
grant delete on "informix".involucra to "public" as "informix";
grant index on "informix".involucra to "public" as "informix";
grant select on "informix".obtiene to "public" as "informix";
grant update on "informix".obtiene to "public" as "informix";
grant insert on "informix".obtiene to "public" as "informix";
grant delete on "informix".obtiene to "public" as "informix";
grant index on "informix".obtiene to "public" as "informix";
grant select on "informix".almacen to "public" as "informix";
grant update on "informix".almacen to "public" as "informix";
grant insert on "informix".almacen to "public" as "informix";
grant delete on "informix".almacen to "public" as "informix";
grant index on "informix".almacen to "public" as "informix";
grant select on "informix".alberga to "public" as "informix";
grant update on "informix".alberga to "public" as "informix";
grant insert on "informix".alberga to "public" as "informix";
grant delete on "informix".alberga to "public" as "informix";
grant index on "informix".alberga to "public" as "informix";
grant select on "informix".funcionario to "public" as "informix";
grant update on "informix".funcionario to "public" as "informix";
grant insert on "informix".funcionario to "public" as "informix";
grant delete on "informix".funcionario to "public" as "informix";
grant index on "informix".funcionario to "public" as "informix";
grant select on "informix".reserva to "public" as "informix";
grant update on "informix".reserva to "public" as "informix";
grant insert on "informix".reserva to "public" as "informix";
grant delete on "informix".reserva to "public" as "informix";
grant index on "informix".reserva to "public" as "informix";
grant select on "informix".contiene to "public" as "informix";
grant update on "informix".contiene to "public" as "informix";
grant insert on "informix".contiene to "public" as "informix";
grant delete on "informix".contiene to "public" as "informix";
grant index on "informix".contiene to "public" as "informix";
grant select on "informix".logs to "public" as "informix";
grant update on "informix".logs to "public" as "informix";
grant insert on "informix".logs to "public" as "informix";
grant delete on "informix".logs to "public" as "informix";
grant index on "informix".logs to "public" as "informix";
















revoke usage on language SPL from public ;

grant usage on language SPL to public ;








alter table "informix".telefono_sucursal add constraint (foreign 
    key (id_sucursal) references "informix".sucursal );
alter table "informix".etapa_de_elaboracion add constraint (foreign 
    key (id_eproducto) references "informix".especificacion_de_producto 
    );
alter table "informix".produccion add constraint (foreign key 
    (id_eproducto) references "informix".especificacion_de_producto 
    );
alter table "informix".produccion add constraint (foreign key 
    (id_sucursal) references "informix".sucursal );
alter table "informix".recorre add constraint (foreign key (id_produccion) 
    references "informix".produccion );
alter table "informix".recorre add constraint (foreign key (id_etapa) 
    references "informix".etapa_de_elaboracion );
alter table "informix".recordatorio add constraint (foreign key 
    (id_etapa) references "informix".etapa_de_elaboracion );
alter table "informix".transacciones add constraint (foreign 
    key (id_sucursal) references "informix".sucursal );
alter table "informix".compra add constraint (foreign key (id_transaccion) 
    references "informix".transacciones );
alter table "informix".venta add constraint (foreign key (id_transaccion) 
    references "informix".transacciones );
alter table "informix".traslado add constraint (foreign key (id_transaccion) 
    references "informix".transacciones );
alter table "informix".traslado add constraint (foreign key (id_transporte) 
    references "informix".transporte );
alter table "informix".materia_prima add constraint (foreign 
    key (id_eproducto) references "informix".especificacion_de_producto 
    );
alter table "informix".materia_prima add constraint (foreign 
    key (id_tipo_cepa) references "informix".tipo_cepa );
alter table "informix".producto_intermedio add constraint (foreign 
    key (id_eproducto) references "informix".especificacion_de_producto 
    );
alter table "informix".producto_final add constraint (foreign 
    key (id_eproducto) references "informix".especificacion_de_producto 
    );
alter table "informix".lote add constraint (foreign key (id_eproducto) 
    references "informix".especificacion_de_producto );
alter table "informix".lote add constraint (foreign key (id_sucursal) 
    references "informix".sucursal );
alter table "informix".involucra add constraint (foreign key 
    (id_lote) references "informix".lote );
alter table "informix".involucra add constraint (foreign key 
    (id_transaccion) references "informix".transacciones );
alter table "informix".obtiene add constraint (foreign key (id_lote) 
    references "informix".lote );
alter table "informix".obtiene add constraint (foreign key (id_produccion) 
    references "informix".produccion );
alter table "informix".almacen add constraint (foreign key (id_sucursal) 
    references "informix".sucursal );
alter table "informix".alberga add constraint (foreign key (id_lote) 
    references "informix".lote );
alter table "informix".alberga add constraint (foreign key (id_almacen) 
    references "informix".almacen );
alter table "informix".funcionario add constraint (foreign key 
    (id_sucursal) references "informix".sucursal );
alter table "informix".reserva add constraint (foreign key (id_cliente) 
    references "informix".cliente );
alter table "informix".contiene add constraint (foreign key (id_reserva) 
    references "informix".reserva );
alter table "informix".contiene add constraint (foreign key (id_eproducto) 
    references "informix".especificacion_de_producto );







 



