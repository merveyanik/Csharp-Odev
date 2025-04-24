using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

[AttributeUsage(AttributeTargets.Property)]
public class ZorunluAlanAttribute : Attribute
{
    public string HataMesaji { get; }

    public ZorunluAlanAttribute(string hataMesaji)
    {
        HataMesaji = hataMesaji;

    }
}