using System;
using System.Collections.Generic;

namespace TodoList.Models;

public partial class Todo
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public ulong? İsComplated { get; set; }
}
