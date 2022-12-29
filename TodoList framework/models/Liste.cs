using System;
using System.Collections.Generic;

namespace TodoList.Models;

public partial class Liste
{
    public int Sirano { get; set; }

    public string Adi { get; set; } = null!;

    public string Soyadi { get; set; } = null!;

    public DateOnly Tarih { get; set; }
}
