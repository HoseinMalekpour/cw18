using System;
using System.Collections.Generic;

namespace cw18.Models;

public partial class BookMember
{
    public int BooksId { get; set; }

    public int MembersId { get; set; }

    public  Book Books { get; set; } 

    public  Member Members { get; set; } 
}
