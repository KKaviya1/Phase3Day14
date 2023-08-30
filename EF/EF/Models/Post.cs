using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace EF.Models
{
    [Table("Post")]
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public String Title { get; set; }
        public String Content { get; set; }
        public String Author  { get; set; }
        public DateTime PublicationDateTime { get; set; }
        public virtual ICollection<Comment> Comments{ get; set; }


    }
}