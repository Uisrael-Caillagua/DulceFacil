﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DulceFacil.Infraestructura.AccesoDatos;

public partial class COTIZACION_DETALLE
{
    public int CODETALLEID { get; set; }

    public int? COTZID { get; set; }

    public int? PRODUCTID { get; set; }

    public int? VENTAID { get; set; }

    public int? CANTIDAD { get; set; }

    public decimal? PRECIO { get; set; }

    public virtual COTIZACION COTZ { get; set; }

    public virtual INVENTARIO PRODUCT { get; set; }

    public virtual VENTA VENTA { get; set; }
}