﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DulceFacil.Infraestructura.AccesoDatos;

public partial class CLIENTE
{
    public string IDENTIFICACION { get; set; }

    public string NOMBRE { get; set; }

    public string APELLIDO { get; set; }

    public string EMAIL { get; set; }

    public string DIRECCION { get; set; }

    public string TELEFONO { get; set; }

    public virtual ICollection<COTIZACION> COTIZACION { get; set; } = new List<COTIZACION>();
}