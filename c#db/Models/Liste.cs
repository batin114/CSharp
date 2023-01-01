using System;
using System.Collections.Generic;

namespace Yeni_klasör__2_.Models;

public partial class Liste
{
    public string Adi { get; set; } = null!;

    public string Soyadi { get; set; } = null!;

    public DateOnly Tarih { get; set; }
}
