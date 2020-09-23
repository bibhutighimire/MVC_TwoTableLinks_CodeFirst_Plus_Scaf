using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MVCDAYTWO.Models
{
    [Table("Author")]
    public partial class Author
    {
      
        public Author()
        {
            Books = new HashSet<Book>();
        }

        [Key]
        [Column("id", TypeName = "int(10)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [Column("name", TypeName = "varchar(30)")]
        public string Name { get; set; }
          
        [InverseProperty(nameof(Models.Book.AuthorID))]
        public virtual ICollection<Book> Books { get; set; }
    }
}
