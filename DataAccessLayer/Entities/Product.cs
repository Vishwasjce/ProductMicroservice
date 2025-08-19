﻿using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.DataAccessLayer.Entities;

public class Product
{
  [Key]
  public Guid ProductID { get; set; }
  public string ProductName { get; set; }
  public string Category { get; set; }
  public double? UnitPrice { get; set; }
  public int? QuantityInStock { get; set; }
}
