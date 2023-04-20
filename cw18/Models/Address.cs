using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace cw18.Models;

public partial class Address
{
    [ForeignKey("Member")]
    public int Id { get; set; }

    public string Description { get; set; } 

    public string Address1 { get; set; } 

    public int CityId { get; set; }

    public  City City { get; set; } 

    public  Member Member { get; set; } 
}
