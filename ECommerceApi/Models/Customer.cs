using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApi.Models;

[Table("Customer")]
public partial class Customer
{
    [Key]
    [Column("customer_id")]
    public int CustomerId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MiddleName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Email { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    [Column("phone")]
    public int? Phone { get; set; }

    [Column("age")]
    public int? Age { get; set; }
}
