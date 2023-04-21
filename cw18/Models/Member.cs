using System;
using System.Collections.Generic;

namespace cw18.Models;

public partial class Member
{
    public int Id { get; set; }

    public string Name { get; set; } 

    public int Age { get; set; }

    public  Address? Address { get; set; }
    public List<BookMember> bookMembers { get; set; }

}
