using System;
using System.Collections.Generic;

namespace cw18.Models;

public  class Genre
{
    public int Id { get; set; }

    public string GenreName { get; set; }

    public  List<Book> Books { get; set; }
}
