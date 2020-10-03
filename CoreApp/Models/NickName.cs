using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models
{
    public class NickName
    {
        [Key]
        public int Id { get; set; }
        public string Nick { get; set; }
    }
}
