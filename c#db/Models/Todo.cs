using System;
using System.Collections.Generic;

namespace Yeni_klasör__2_.Models;

public partial class Todo
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public ulong Iscomplated { get; set; }
}
