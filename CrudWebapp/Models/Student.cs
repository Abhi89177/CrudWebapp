using System;
using System.Collections.Generic;

namespace CrudWebapp.Models;

public partial class Student
{
    public int Id { get; set; }

    public string StudentName { get; set; } = null!;

    public string StudentBranch { get; set; } = null!;

    public string StudentSection { get; set; } = null!;

    public string StudentMobile { get; set; } = null!;
}
