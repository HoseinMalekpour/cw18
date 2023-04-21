using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace cw18.Models;

public  class BookMember
{
    public int Id { get; set; }     

    [ForeignKey("Books")]
    public int BooksId { get; set; }
    [ForeignKey("Members")]

    public int MembersId { get; set; }

    public  Book Books { get; set; } 

    public  Member Members { get; set; } 
}
