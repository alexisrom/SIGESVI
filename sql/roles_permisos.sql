CREATE ROLE gerente_general
CREATE ROLE gerente_sucursal
CREATE ROLE administrativo
CREATE ROLE asesor_profesional
CREATE ROLE cliente

GRANT ALL ON almacen TO "gerente_general"
GRANT ALL ON alberga TO "gerente_general"
GRANT ALL ON cliente TO "gerente_general"
GRANT ALL ON compra TO "gerente_general"
GRANT ALL ON compuesto TO "gerente_general"
GRANT ALL ON conformado TO "gerente_general"
GRANT ALL ON destino TO "gerente_general"
GRANT ALL ON especificacion_de_producto TO "gerente_general"
GRANT ALL ON etapa_de_elaboracion TO "gerente_general"
GRANT ALL ON funcionario TO "gerente_general"
GRANT ALL ON lote TO "gerente_general"
GRANT ALL ON materia_prima TO "gerente_general"
GRANT ALL ON obtiene TO "gerente_general"
GRANT ALL ON origen TO "gerente_general"
GRANT ALL ON produccion TO "gerente_general"
GRANT ALL ON producto_final TO "gerente_general"
GRANT ALL ON producto_intermedio TO "gerente_general"
GRANT ALL ON recordatorio TO "gerente_general"
GRANT ALL ON recorre TO "gerente_general"
GRANT ALL ON reserva TO "gerente_general"
GRANT SELECT ON sucursal TO "gerente_general"
GRANT ALL ON telefono_sucursal TO "gerente_general"
GRANT ALL ON transacciones TO "gerente_general"
GRANT ALL ON transporte TO "gerente_general"
GRANT ALL ON traslado TO "gerente_general"
GRANT ALL ON venta TO "gerente_general"

GRANT ALL ON almacen TO  "administrativo"
GRANT ALL ON alberga TO  "administrativo"
GRANT SELECT ON cliente TO  "administrativo"
GRANT ALL ON compra TO  "administrativo"
GRANT ALL ON compuesto TO  "administrativo"
GRANT ALL ON conformado TO  "administrativo"
GRANT ALL ON destino TO  "administrativo"
GRANT ALL ON especificacion_de_producto TO "administrativo"
GRANT ALL ON etapa_de_elaboracion TO "administrativo"
GRANT SELECT ON funcionario TO "administrativo"
GRANT ALL ON lote TO  "administrativo"
GRANT ALL ON materia_prima TO  "administrativo"
GRANT ALL ON obtiene TO  "administrativo"
GRANT ALL ON origen TO  "administrativo"
GRANT ALL ON produccion TO  "administrativo"
GRANT ALL ON producto_final TO  "administrativo"
GRANT ALL ON producto_intermedio TO  "administrativo"
GRANT SELECT ON recordatorio TO  "administrativo"
GRANT ALL ON recorre TO  "administrativo"
GRANT SELECT ON sucursal TO "administrativo"
GRANT ALL ON transacciones TO  "administrativo"
GRANT ALL ON transporte TO  "administrativo"
GRANT ALL ON traslado TO "administrativo"
GRANT ALL ON venta TO "administrativo"

GRANT SELECT ON compuesto TO  "asesor_profesional"
GRANT SELECT ON conformado TO  "asesor_profesional"
GRANT SELECT ON especificacion_de_producto TO "asesor_profesional"
GRANT SELECT ON etapa_de_elaboracion TO "asesor_profesional"
GRANT SELECT ON funcionario TO "asesor_profesional"
GRANT SELECT ON lote TO  "asesor_profesional"
GRANT SELECT ON materia_prima TO  "asesor_profesional"
GRANT SELECT ON obtiene TO  "asesor_profesional"
GRANT SELECT ON origen TO  "asesor_profesional"
GRANT SELECT ON produccion TO  "asesor_profesional"
GRANT SELECT ON producto_final TO  "asesor_profesional"
GRANT SELECT ON producto_intermedio TO  "asesor_profesional"
GRANT ALL ON recordatorio TO  "asesor_profesional"
GRANT SELECT, UPDATE(observaciones) ON recorre TO  "asesor_profesional"
GRANT SELECT ON sucursal TO "asesor_profesional"

GRANT SELECT, INSERT ON cliente TO "cliente"
GRANT SELECT, INSERT ON reserva TO "cliente"
GRANT SELECT ON sucursal TO "cliente"
















