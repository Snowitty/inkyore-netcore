﻿namespace inkyore_netcore.DAL.Models
{
    public class Category : BaseEntity
    {
      public string Name { get; set; }
      public string Description { get; set; }
      public string Slug { get; set; }
      public string CategoryImage { get; set; }

    }
}
