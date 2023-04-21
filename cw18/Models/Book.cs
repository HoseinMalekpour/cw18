using System;
using System.Collections.Generic;

namespace cw18.Models;

public  class Book
{
    public int Id { get; set; }

    public string BookTitle { get; set; } 

    public int GenreId { get; set; }

    public  Genre Genre { get; set; } 
    public List<BookMember> bookMembers { get; set; }   
}
