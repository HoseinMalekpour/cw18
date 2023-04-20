using System;
using System.Collections.Generic;

namespace cw18.Models;

public partial class Province
{
    public int Id { get; set; }
    public string Name { get; set; }
    public  List<City> Cities { get; set; }
}
