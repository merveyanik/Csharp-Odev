using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ogrenci
{
    [ZorunluAlan("Öğrenci adı boş bırakılamaz.")]
    public string Ad { get; set; }

    [ZorunluAlan("Öğrenci soyadı boş bırakılamaz.")]
    public string Soyad { get; set; }

    [ZorunluAlan("Öğrenci bölümü boş bırakılamaz.")]
    public string Bolum { get; set; }
}
