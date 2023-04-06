﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstEntityCore.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string FirstName  { get; set; }
        public string LastName  { get; set; }
        public int Age { get; set; }

    }
}
