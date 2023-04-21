using System;
using System.Collections.Generic;

namespace cw18.Models;

public  class City
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int ProvinceId { get; set; }

    public  List<Address> Addresses { get; set; }

    public  Province Province { get; set; }
}
