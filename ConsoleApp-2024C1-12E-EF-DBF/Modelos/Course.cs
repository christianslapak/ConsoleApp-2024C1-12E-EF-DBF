using System;
using System.Collections.Generic;

namespace ConsoleApp_2024C1_12E_EF_DBF.Modelos;

public partial class Course
{
    public int CourseId { get; set; }

    public string? CourseName { get; set; }

    public int? TeacherId { get; set; }

    public virtual Teacher? Teacher { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
