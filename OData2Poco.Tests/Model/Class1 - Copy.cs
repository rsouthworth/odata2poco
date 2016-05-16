﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
//uncomment for spatial data type and run Install-Package System.Spatial
using System.Spatial;

//------------------------------------------------------------------------------

// <auto-generated>
//     This code was generated using  OData2Poco Class library.
//     Service Url: http://services.odata.org/V4/OData/OData.svc
//     MetaData Version: 4.0
// </auto-generated>
//------------------------------------------------------------------------------


namespace ODataDemo
{

        [Table("Products")]
        public class Product
        {
            [Key]
            [Required]
            public int ID  {get;set;} //PrimaryKey not null
            public string Name  {get;set;}
            public string Description  {get;set;}
            [Required]
            public DateTimeOffset ReleaseDate  {get;set;} // not null
            public DateTimeOffset DiscontinuedDate  {get;set;}
            [Required]
            public short Rating  {get;set;} // not null
            [Required]
            public double Price  {get;set;} // not null
            virtual public List<Category> Categories  {get;set;}
            virtual public Supplier Supplier  {get;set;}
            virtual public ProductDetail ProductDetail  {get;set;}
        }

        public class FeaturedProduct
        {
            [Required]
            public int ID  {get;set;} // not null
            public string Name  {get;set;}
            public string Description  {get;set;}
            [Required]
            public DateTimeOffset ReleaseDate  {get;set;} // not null
            public DateTimeOffset DiscontinuedDate  {get;set;}
            [Required]
            public short Rating  {get;set;} // not null
            [Required]
            public double Price  {get;set;} // not null
            public List<Category> Categories  {get;set;}
            public Supplier Supplier  {get;set;}
            public ProductDetail ProductDetail  {get;set;}
            virtual public Advertisement Advertisement  {get;set;}
        }

        [Table("ProductDetails")]
        public class ProductDetail
        {
            [Key]
            [Required]
            public int ProductID  {get;set;} //PrimaryKey not null
            public string Details  {get;set;}
            virtual public Product Product  {get;set;}
        }

        [Table("Categories")]
        public class Category
        {
            [Key]
            [Required]
            public int ID  {get;set;} //PrimaryKey not null
            public string Name  {get;set;}
            virtual public List<Product> Products  {get;set;}
        }

        [Table("Suppliers")]
        public class Supplier
        {
            [Key]
            [Required]
            public int ID  {get;set;} //PrimaryKey not null
            public string Name  {get;set;}
            public Address Address  {get;set;}
            public GeographyPoint Location  {get;set;}
            [Required]
            public int Concurrency  {get;set;} // not null
            virtual public List<Product> Products  {get;set;}
        }

        public class Address
        {
            public string Street  {get;set;}
            public string City  {get;set;}
            public string State  {get;set;}
            public string ZipCode  {get;set;}
            public string Country  {get;set;}
        }

        [Table("Persons")]
        public class Person
        {
            [Key]
            [Required]
            public int ID  {get;set;} //PrimaryKey not null
            public string Name  {get;set;}
            virtual public PersonDetail PersonDetail  {get;set;}
        }

        public class Customer
        {
            [Required]
            public int ID  {get;set;} // not null
            public string Name  {get;set;}
            public PersonDetail PersonDetail  {get;set;}
            [Required]
            public decimal TotalExpense  {get;set;} // not null
        }

        public class Employee
        {
            [Required]
            public int ID  {get;set;} // not null
            public string Name  {get;set;}
            public PersonDetail PersonDetail  {get;set;}
            [Required]
            public long EmployeeID  {get;set;} // not null
            [Required]
            public DateTimeOffset HireDate  {get;set;} // not null
            [Required]
            public float Salary  {get;set;} // not null
        }

        [Table("PersonDetails")]
        public class PersonDetail
        {
            [Key]
            [Required]
            public int PersonID  {get;set;} //PrimaryKey not null
            [Required]
            public byte Age  {get;set;} // not null
            [Required]
            public bool Gender  {get;set;} // not null
            public string Phone  {get;set;}
            public Address Address  {get;set;}
            [Required]
            public Stream Photo  {get;set;} // not null
            virtual public Person Person  {get;set;}
        }

        [Table("Advertisements")]
        public class Advertisement
        {
            [Key]
            [Required]
            public Guid ID  {get;set;} //PrimaryKey not null
            public string Name  {get;set;}
            [Required]
            public DateTimeOffset AirDate  {get;set;} // not null
            virtual public FeaturedProduct FeaturedProduct  {get;set;}
        }

}

 