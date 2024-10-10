using System;
using System.ComponentModel.DataAnnotations;

namespace WebsiteDeneme.Entity
{
	public class Category
	{
		[Key]
		public int CategoryID { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
    }
}

