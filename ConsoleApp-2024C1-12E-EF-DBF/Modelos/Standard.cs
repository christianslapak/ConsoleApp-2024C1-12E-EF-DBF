﻿using System;
using System.Collections.Generic;

namespace ConsoleApp_2024C1_12E_EF_DBF.Modelos;

public partial class Standard
{
    public int StandardId { get; set; }

    public string? StandardName { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
}
