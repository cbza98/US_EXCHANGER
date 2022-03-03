using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_EXCHANGER.Models.Productos
{
    internal class OPE_PRODUCTOBean
    {
    public string CODIGO_EMPRESA { get; set; }

        public decimal ID_PRODUCTO { get; set; }

        public string CODIGO { get; set; }

        public string CODIGO_ANTERIOR { get; set; }

        public string CODIGO_BARRA { get; set; }

        public string NOMBRE { get; set; }

        public string DESCRIPCION_EXTENDIDA { get; set; }

        public string ID_UNIDAD_COMPRA { get; set; }

        public decimal? CANT_UNIDAD_COMPRA { get; set; }

        public string ID_UNIDAD_EMPAQUE_COMPRA { get; set; }

        public decimal? CANT_UNIDAD_EMPAQUE_COMPRA { get; set; }

        public string ID_UNIDAD_VENTA { get; set; }

        public decimal? CANT_UNIDAD_VENTA { get; set; }

        public string ID_UNIDAD_EMPAQUE_VENTA { get; set; }

        public decimal? CANT_UNIDAD_EMPAQUE_VENTA { get; set; }

        public string ID_UNIDAD_INVENTARIO { get; set; }

        public string ID_TIPO_PRODUCTO { get; set; }

        public string ID_CATEGORIA { get; set; }

        public decimal? PRECIO_VENTA { get; set; }

        public string COMPRA { get; set; }

        public string VENTA { get; set; }

        public string INVENTARIO { get; set; }

        public string INVENTARIABLE { get; set; }

        public decimal? STOCK_MINIMO { get; set; }

        public decimal? STOCK_MAXIMO { get; set; }

        public string ESTADO { get; set; }

        public decimal? PAGO_TRABAJADOR { get; set; }

        public string ID_UNIDAD_PAGO_TRABAJADOR { get; set; }

        public decimal? PAGO_EMPRESA { get; set; }

        public string ID_UNIDAD_PAGO_EMPRESA { get; set; }

        public string AFECTO_IGV { get; set; }

        public string USUARIO_CREACION { get; set; }

        public DateTime FECHA_CREACION { get; set; }

        public string USUARIO_MODIFICACION { get; set; }

        public DateTime? FECHA_MODIFICACION { get; set; }

        public string VENTA_MASIVA { get; set; }

        public string DESAYUNO { get; set; }

        public string ALMUERZO { get; set; }

        public string CENA { get; set; }

        public string MARCA { get; set; }

        public string MODELO { get; set; }

        public decimal? PRECIO_COMPRA { get; set; }

        public decimal? PRECIO_COMPRAD { get; set; }

        public string RUTA_FICHA { get; set; }

        public string PRESENTACION { get; set; }

        public decimal? IGV_COSTO { get; set; }

        public decimal? COSTO_CON_IGV { get; set; }

        public decimal? COMISION_CONTADO { get; set; }

        public decimal? COMISION_CREDITO { get; set; }

        public string PROMOCION { get; set; }

        public string EDITA_PRECIO { get; set; }

        public string EDITA_DESCRIPCION { get; set; }

        public string MANEJA_SERIE { get; set; }

        public int? MESES_GARANTIA { get; set; }

        public string MANEJA_LOTE { get; set; }

        public decimal? MAXIMO { get; set; }

        public decimal? MINIMO { get; set; }

        public string GRUPO { get; set; }

        public string SUBGRUPO { get; set; }

        public string RUTA_IMAGEN { get; set; }

        public string UBICACION { get; set; }

        public string DESTINO_COMANDA { get; set; }

        public string ADICIONAL { get; set; }

        public string LONCHE { get; set; }

        public string BREAK1 { get; set; }

        public string REFERENCIA1 { get; set; }

        public string REFERENCIA2 { get; set; }

        public string REFERENCIA3 { get; set; }

        public string REFERENCIA4 { get; set; }

        public string PROCEDENCIA { get; set; }

        public decimal? CADA_BULTO { get; set; }

        public decimal? PESO { get; set; }

        public decimal? XCM { get; set; }

        public decimal? YCM { get; set; }

        public decimal? ZCM { get; set; }

        public decimal? MAXPISO { get; set; }

        public string GRUPO_PLANIFICACION { get; set; }

        public string TECNICA_REPOSICION { get; set; }

        public string METODO_ABASTECIMIENTO { get; set; }

        public string INTERVALO_PEDIDO { get; set; }

        public decimal? PEDIDO_MULTIPLE { get; set; }

        public decimal? CANT_MIN_COMPRA { get; set; }

        public decimal? TIEMPO_ENTREGA { get; set; }

        public string TAMANO_LOTE { get; set; }

        public decimal? FACTOR_MES { get; set; }

        public decimal? MULTIPLICADOR { get; set; }

        public decimal? PERIODO_PASADO { get; set; }

        public decimal? VENCE_EN { get; set; }

        public string UNIDAD_VENCE_EN { get; set; }

        public decimal? TIEMPO_RETRASO { get; set; }

        public string INDICADOR { get; set; }

        public string MODELO_GESTION_INVENTARIO { get; set; }

        public int? PROVEEDOR_PREFERIDO { get; set; }

        public decimal? STOCK_SEGURIDAD { get; set; }

        public string AFECTO_PERCEPCION { get; set; }

        public decimal? DETRACCION { get; set; }

        public decimal? PERCEPCION_VENTA { get; set; }

        public decimal? APLICA_IMPORTE { get; set; }

        public string REFERENCIA5 { get; set; }

        public string REFERENCIA6 { get; set; }

        public string REFERENCIA7 { get; set; }

        public decimal? ID_EQUI_PROD { get; set; }

        public decimal? ORDEN { get; set; }

        public decimal? PESO_EMPA_VENTA { get; set; }

        public decimal? XCM_EMPA_VENTA { get; set; }

        public decimal? YCM_EMPA_VENTA { get; set; }

        public decimal? ZCM_EMPA_VENTA { get; set; }

        public string CUENTA_VENTA { get; set; }

        public string CUENTA_COMPRA { get; set; }

        public decimal? APLICA_IMPORTE_DETRACCION { get; set; }

        public string NUM_LAB { get; set; }

        public string NUM_PRE { get; set; }

        public string NUM_GEN { get; set; }

        public string NUM_AFA { get; set; }

        public string BIEN_SERVICIO { get; set; }

        public string NUM_AFA2 { get; set; }

        public string NUM_AFA3 { get; set; }

        public string NUM_COMP { get; set; }

        public string NUM_CONC { get; set; }

        public string NUM_VIAD { get; set; }

        public string SWT_REME { get; set; }

        public string NUM_REFMED { get; set; }

        public string GRUP_UMED { get; set; }

        public string ID_UNIDAD_REC { get; set; }

        public decimal? CANT_UNIDAD_REC { get; set; }

        public string CDG_CAJA { get; set; }

        public string CDG_COLUMNA { get; set; }

        public string CDG_CASILLERO { get; set; }

        public string SWT_IMP1 { get; set; }

        public string SWT_IMP2 { get; set; }

        public string SWT_WEB { get; set; }

        public decimal? VENCIMIENTO { get; set; }

        public string CODIGO_SUNAT { get; set; }

        public decimal? IdCategoria { get; set; }

        public decimal? IdSubCategoria { get; set; }

        public decimal? Precio1 { get; set; }

        public decimal? Precio2 { get; set; }

        public decimal? Precio3 { get; set; }

        public decimal? Precio4 { get; set; }

        public string NUM_LAB2 { get; set; }

        public string SWT_RESTA { get; set; }

        public string CONDICION_CLINICA { get; set; }

        public string CONDICION_PACIENTE { get; set; }

        public string CONDICION_MUESTRA { get; set; }

        public string CONDICION_CONTENEDOR { get; set; }

        public decimal? VMI_H { get; set; }

        public decimal? VMA_H { get; set; }

        public decimal? VMI_M { get; set; }

        public decimal? VMA_M { get; set; }

        public string UNIDAD_VALOR { get; set; }

    
}
}
