using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_EXCHANGER.Models.OperacionCambio
{
    public class DIVI_OPERACIONBean
    {
        public class _OPERACION
        {
            private int _cod_operacion;

            private string _cod_empresa;

            private string _name_empresa;

            private int _cod_sucursal;

            private string _name_sucursal;

            private int _cod_usuario;

            private string _name_usuario;

            private string _cod_moneda;

            private string _name_moneda;

            private string _estado;

            private string _tipo;

            private DateTime _fecha;

            private double _monto;

            private int _cod_tipo_cambio;

            private double _monto_tipo_cambio;

            private int _cod_detalle_corte;

            private double _cot_cierre;

            private double _cot_apertura;

            private double _porc_descuento;

            private double _impor_descuento;

            private string _cod_ejecutante;

            private string _cod_documento_ejecutante;

            private string _name_documento_ejecutante;

            private string _num_documento_ejecutante;

            private string _nombre_ejecutante;

            private string _ape_paterno_ejecutante;

            private string _ape_materno_ejecutante;

            private string _direccion_ejecutante;

            private string _cod_beneficiario;

            private string _cod_documento_beneficiario;

            private string _name_documento_beneficiario;

            private string _num_documento_beneficiario;

            private string _nombre_beneficiario;

            private string _ape_paterno_beneficiario;

            private string _ape_materno_beneficiario;

            private string _direccion_beneficiario;

            private string _cod_forma_pago;

            private string _name_forma_pago;

            private int _cod_entidad_bancaria;

            private string _name_entidad_bancaria;

            private string _num_ticket_forma_pago;

            private string _cod_documento_operacion;

            private string _name_documento_operacion;

            private string _num_documento_correlativo;

            private string _num_documento_operacion;

            private string _serie_impresora;

            private DateTime _fecha_operacion;

            private bool _flag_correlativo;

            private string _correlativo_string;

            private double _importe_entregado;

            private double _vuelto;

            private bool _flag_declaracion_jurada;

            private string _cod_moneda_cambio;

            private string _name_moneda_cambio;

            private string _data;

            public int cod_operacion
            {
                get
                {
                    return _cod_operacion;
                }
                set
                {
                    _cod_operacion = value;
                }
            }
            public string cod_empresa
            {
                get
                {
                    return _cod_empresa;
                }
                set
                {
                    _cod_empresa = value;
                }
            }
            public string name_empresa
            {
                get
                {
                    return _name_empresa;
                }
                set
                {
                    _name_empresa = value;
                }
            }

            public int cod_sucursal
            {
                get
                {
                    return _cod_sucursal;
                }
                set
                {
                    _cod_sucursal = value;
                }
            }

            public string name_sucursal
            {
                get
                {
                    return _name_sucursal;
                }
                set
                {
                    _name_sucursal = value;
                }
            }

            public int cod_usuario
            {
                get
                {
                    return _cod_usuario;
                }
                set
                {
                    _cod_usuario = value;
                }
            }

            public string name_usuario
            {
                get
                {
                    return _name_usuario;
                }
                set
                {
                    _name_usuario = value;
                }
            }

            public string cod_moneda
            {
                get
                {
                    return _cod_moneda;
                }
                set
                {
                    _cod_moneda = value;
                }
            }

            public string name_moneda
            {
                get
                {
                    return _name_moneda;
                }
                set
                {
                    _name_moneda = value;
                }
            }

            public string estado
            {
                get
                {
                    return _estado;
                }
                set
                {
                    _estado = value;
                }
            }

            public string tipo
            {
                get
                {
                    return _tipo;
                }
                set
                {
                    _tipo = value;
                }
            }

            public DateTime fecha
            {
                get
                {
                    return _fecha;
                }
                set
                {
                    _fecha = value;
                }
            }

            public double monto
            {
                get
                {
                    return _monto;
                }
                set
                {
                    _monto = value;
                }
            }

            public int cod_tipo_cambio
            {
                get
                {
                    return _cod_tipo_cambio;
                }
                set
                {
                    _cod_tipo_cambio = value;
                }
            }

            public double monto_tipo_cambio
            {
                get
                {
                    return _monto_tipo_cambio;
                }
                set
                {
                    _monto_tipo_cambio = value;
                }
            }

            public int cod_detalle_corte
            {
                get
                {
                    return _cod_detalle_corte;
                }
                set
                {
                    _cod_detalle_corte = value;
                }
            }

            public double cot_cierre
            {
                get
                {
                    return _cot_cierre;
                }
                set
                {
                    _cot_cierre = value;
                }
            }

            public double cot_apertura
            {
                get
                {
                    return _cot_apertura;
                }
                set
                {
                    _cot_apertura = value;
                }
            }

            public double porc_descuento
            {
                get
                {
                    return _porc_descuento;
                }
                set
                {
                    _porc_descuento = value;
                }
            }

            public double impor_descuento
            {
                get
                {
                    return _impor_descuento;
                }
                set
                {
                    _impor_descuento = value;
                }
            }

            public string cod_ejecutante
            {
                get
                {
                    return _cod_ejecutante;
                }
                set
                {
                    _cod_ejecutante = value;
                }
            }

            public string cod_documento_ejecutante
            {
                get
                {
                    return _cod_documento_ejecutante;
                }
                set
                {
                    _cod_documento_ejecutante = value;
                }
            }

            public string name_documento_ejecutante
            {
                get
                {
                    return _name_documento_ejecutante;
                }
                set
                {
                    _name_documento_ejecutante = value;
                }
            }

            public string num_documento_ejecutante
            {
                get
                {
                    return _num_documento_ejecutante;
                }
                set
                {
                    _num_documento_ejecutante = value;
                }
            }

            public string nombre_ejecutante
            {
                get
                {
                    return _nombre_ejecutante;
                }
                set
                {
                    _nombre_ejecutante = value;
                }
            }

            public string ape_paterno_ejecutante
            {
                get
                {
                    return _ape_paterno_ejecutante;
                }
                set
                {
                    _ape_paterno_ejecutante = value;
                }
            }

            public string ape_materno_ejecutante
            {
                get
                {
                    return _ape_materno_ejecutante;
                }
                set
                {
                    _ape_materno_ejecutante = value;
                }
            }

            public string direccion_ejecutante
            {
                get
                {
                    return _direccion_ejecutante;
                }
                set
                {
                    _direccion_ejecutante = value;
                }
            }

            public string cod_beneficiario
            {
                get
                {
                    return _cod_beneficiario;
                }
                set
                {
                    _cod_beneficiario = value;
                }
            }

            public string cod_documento_beneficiario
            {
                get
                {
                    return _cod_documento_beneficiario;
                }
                set
                {
                    _cod_documento_beneficiario = value;
                }
            }

            public string name_documento_beneficiario
            {
                get
                {
                    return _name_documento_beneficiario;
                }
                set
                {
                    _name_documento_beneficiario = value;
                }
            }

            public string num_documento_beneficiario
            {
                get
                {
                    return _num_documento_beneficiario;
                }
                set
                {
                    _num_documento_beneficiario = value;
                }
            }

            public string nombre_beneficiario
            {
                get
                {
                    return _nombre_beneficiario;
                }
                set
                {
                    _nombre_beneficiario = value;
                }
            }

            public string ape_paterno_beneficiario
            {
                get
                {
                    return _ape_paterno_beneficiario;
                }
                set
                {
                    _ape_paterno_beneficiario = value;
                }
            }

            public string ape_materno_beneficiario
            {
                get
                {
                    return _ape_materno_beneficiario;
                }
                set
                {
                    _ape_materno_beneficiario = value;
                }
            }

            public string direccion_beneficiario
            {
                get
                {
                    return _direccion_beneficiario;
                }
                set
                {
                    _direccion_beneficiario = value;
                }
            }

            public string cod_forma_pago
            {
                get
                {
                    return _cod_forma_pago;
                }
                set
                {
                    _cod_forma_pago = value;
                }
            }

            public string name_forma_pago
            {
                get
                {
                    return _name_forma_pago;
                }
                set
                {
                    _name_forma_pago = value;
                }
            }

            public int cod_entidad_bancaria
            {
                get
                {
                    return _cod_entidad_bancaria;
                }
                set
                {
                    _cod_entidad_bancaria = value;
                }
            }

            public string name_entidad_bancaria
            {
                get
                {
                    return _name_entidad_bancaria;
                }
                set
                {
                    _name_entidad_bancaria = value;
                }
            }

            public string num_ticket_forma_pago
            {
                get
                {
                    return _num_ticket_forma_pago;
                }
                set
                {
                    _num_ticket_forma_pago = value;
                }
            }

            public string cod_documento_operacion
            {
                get
                {
                    return _cod_documento_operacion;
                }
                set
                {
                    _cod_documento_operacion = value;
                }
            }

            public string name_documento_operacion
            {
                get
                {
                    return _name_documento_operacion;
                }
                set
                {
                    _name_documento_operacion = value;
                }
            }

            public string num_documento_correlativo
            {
                get
                {
                    return _num_documento_correlativo;
                }
                set
                {
                    _num_documento_correlativo = value;
                }
            }

            public string num_documento_operacion
            {
                get
                {
                    return _num_documento_operacion;
                }
                set
                {
                    _num_documento_operacion = value;
                }
            }

            public string serie_impresora
            {
                get
                {
                    return _serie_impresora;
                }
                set
                {
                    _serie_impresora = value;
                }
            }

            public DateTime fecha_operacion
            {
                get
                {
                    return _fecha_operacion;
                }
                set
                {
                    _fecha_operacion = value;
                }
            }

            public bool flag_correlativo
            {
                get
                {
                    return _flag_correlativo;
                }
                set
                {
                    _flag_correlativo = value;
                }
            }

            public string correlativo_string
            {
                get
                {
                    return _correlativo_string;
                }
                set
                {
                    _correlativo_string = value;
                }
            }

            public double importe_entregado
            {
                get
                {
                    return _importe_entregado;
                }
                set
                {
                    _importe_entregado = value;
                }
            }

            public double vuelto
            {
                get
                {
                    return _vuelto;
                }
                set
                {
                    _vuelto = value;
                }
            }

            public bool flag_declaracion_jurada
            {
                get
                {
                    return _flag_declaracion_jurada;
                }
                set
                {
                    _flag_declaracion_jurada = value;
                }
            }

            public string cod_moneda_cambio
            {
                get
                {
                    return _cod_moneda_cambio;
                }
                set
                {
                    _cod_moneda_cambio = value;
                }
            }

            public string name_moneda_cambio
            {
                get
                {
                    return _name_moneda_cambio;
                }
                set
                {
                    _name_moneda_cambio = value;
                }
            }

            public string data
            {
                get
                {
                    _data = " name_documento_beneficiario  = " + _name_documento_beneficiario;
                    ref string data = ref _data;
                    data = data + " cod_empresa  = " + _cod_empresa;
                    ref string data2 = ref _data;
                    data2 = data2 + " name_empresa  = " + _name_empresa;
                    ref string data3 = ref _data;
                    data3 = data3 + " name_documento_ejecutante  = " + _name_documento_ejecutante;
                    ref string data4 = ref _data;
                    data4 = data4 + " name_documento_operacion  = " + _name_documento_operacion;
                    ref string data5 = ref _data;
                    data5 = data5 + " name_entidad_bancaria  = " + _name_entidad_bancaria;
                    ref string data6 = ref _data;
                    data6 = data6 + " name_forma_pago  = " + _name_forma_pago;
                    ref string data7 = ref _data;
                    data7 = data7 + " name_moneda  = " + _name_moneda;
                    ref string data8 = ref _data;
                    data8 = data8 + " name_sucursal  = " + _name_sucursal;
                    ref string data9 = ref _data;
                    data9 = data9 + " name_usuario  = " + _name_usuario;
                    ref string data10 = ref _data;
                    data10 = data10 + " nombre_beneficiario  = " + _nombre_beneficiario;
                    ref string data11 = ref _data;
                    data11 = data11 + " nombre_ejecutante  = " + _nombre_ejecutante;
                    ref string data12 = ref _data;
                    data12 = data12 + " ape_paterno_beneficiario  = " + _ape_paterno_beneficiario;
                    ref string data13 = ref _data;
                    data13 = data13 + " ape_materno_beneficiario  = " + _ape_materno_beneficiario;
                    ref string data14 = ref _data;
                    data14 = data14 + " ape_paterno_ejecutante  = " + _ape_paterno_ejecutante;
                    ref string data15 = ref _data;
                    data15 = data15 + " ape_materno_ejecutante  = " + _ape_materno_ejecutante;
                    ref string data16 = ref _data;
                    data16 = data16 + " monto  = " + _monto;
                    ref string data17 = ref _data;
                    data17 = data17 + " tipo  = " + _tipo;
                    ref string data18 = ref _data;
                    data18 = data18 + " cod_tipo_cambio  = " + _cod_tipo_cambio;
                    ref string data19 = ref _data;
                    data19 = data19 + " monto_tipo_cambio  = " + _monto_tipo_cambio;
                    ref string data20 = ref _data;
                    data20 = data20 + " cod_detalle_corte  = " + _cod_detalle_corte;
                    ref string data21 = ref _data;
                    data21 = data21 + " cot_cierre  = " + _cot_cierre;
                    ref string data22 = ref _data;
                    data22 = data22 + " cot_apertura  = " + _cot_apertura;
                    return _data;
                }
                set
                {
                    _data = value;
                }
            }
        }
        public class _TIPO_CAMBIODTO
        {
            private int _cod_tipo;

            private string _cod_moneda;

            private string _cod_moneda_default;

            private DateTime _fecha;

            private decimal _p_compra;

            private decimal _p_venta;

            private string _cod_usuario;

            private string _name_usuario;

            private int _cod_sucursal;

            private string _name_sucursal;

            private string _cod_empresa;

            private string _name_empresa;

            private string _tipo_cambio_operativa;
            private string _data;

            public int cod_tipo
            {
                get
                {
                    return _cod_tipo;
                }
                set
                {
                    _cod_tipo = value;
                }
            }

            public string cod_moneda
            {
                get
                {
                    return _cod_moneda;
                }
                set
                {
                    _cod_moneda = value;
                }
            }

            public string cod_moneda_default
            {
                get
                {
                    return _cod_moneda_default;
                }
                set
                {
                    _cod_moneda_default = value;
                }
            }

            public DateTime fecha
            {
                get
                {
                    return _fecha;
                }
                set
                {
                    _fecha = value;
                }
            }

            public decimal p_compra
            {
                get
                {
                    return _p_compra;
                }
                set
                {
                    _p_compra = value;
                }
            }

            public decimal p_venta
            {
                get
                {
                    return _p_venta;
                }
                set
                {
                    _p_venta = value;
                }
            }

            public string cod_usuario
            {
                get
                {
                    return _cod_usuario;
                }
                set
                {
                    _cod_usuario = value;
                }
            }

            public string name_usuario
            {
                get
                {
                    return _name_usuario;
                }
                set
                {
                    _name_usuario = value;
                }
            }

            public int cod_sucursal
            {
                get
                {
                    return _cod_sucursal;
                }
                set
                {
                    _cod_sucursal = value;
                }
            }

            public string name_sucursal
            {
                get
                {
                    return _name_sucursal;
                }
                set
                {
                    _name_sucursal = value;
                }
            }

            public string cod_empresa
            {
                get
                {
                    return _cod_empresa;
                }
                set
                {
                    _cod_empresa = value;
                }
            }

            public string name_empresa
            {
                get
                {
                    return _name_empresa;
                }
                set
                {
                    _name_empresa = value;
                }
            }
            public string tipo_cambio_operativa
            {
                get
                {
                    return _tipo_cambio_operativa;
                }
                set
                {
                    _tipo_cambio_operativa = value;
                }
            }

        }
        public class _TIPO_CAMBIO_DTO
        {
            private string _Moneda;
            private string _Simbolo;
            private DateTime _Fecha;
            private decimal _Compra;
            private decimal _Venta;

            private string cod_moneda;
            public string Cod_moneda
            {
                get
                {
                    return cod_moneda;
                }
                set
                {
                    cod_moneda = value;
                }
            }
            public string Moneda
            {
                get
                {
                    return _Moneda;
                }
                set
                {
                    _Moneda = value;
                }
            }
            public string Simbolo
            {
                get
                {
                    return _Simbolo;
                }
                set
                {
                    _Simbolo = value;
                }
            }
            public DateTime Fecha
            {
                get
                {
                    return _Fecha;
                }
                set
                {
                    _Fecha = value;
                }
            }
            public decimal Compra
            {
                get
                {
                    return _Compra;
                }
                set
                {
                    _Compra = value;
                }
            }
            public decimal Venta
            {
                get
                {
                    return _Venta;
                }
                set
                {
                    _Venta = value;
                }
            }
        }
    }
}

