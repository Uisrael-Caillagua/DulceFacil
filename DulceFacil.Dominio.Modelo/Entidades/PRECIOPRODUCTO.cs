﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DulceFacil.Infraestructura.AccesoDatos;

public partial class PRECIOPRODUCTO
{
    public int PRECIOID { get; set; }

    public int? PRODUCTID { get; set; }

    public DateTime? FECHAINICIO { get; set; }

    public DateTime? FECHAFIN { get; set; }

    public decimal? PRECIO { get; set; }

    public virtual PRODUCTO PRODUCT { get; set; }
}