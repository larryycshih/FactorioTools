using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fatorio_Tool.Models
{
    public class Item
    {
        //Primary Key
        [Key]
        public int ID { get; set; }

        
        public String Name { get; set; }

        public int craftingDuration { get; set; }

        

        public virtual ICollection<RequiredItem> requiredItems { get; set; }


    }

    public class RequiredItem
    {
        public int ID { get; set; }
        public virtual int ItemID { get; set; }
        public int count { get; set; }
    }
}