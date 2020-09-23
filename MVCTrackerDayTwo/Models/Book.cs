using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MVCDAYTWO.Models
{
    [Table("Book")]
    public partial class Book
    {

        [Key]
        // Specifies AUTO_INCREMENT.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id", TypeName = "int(10)")]
        public int ID { get; set; }

        [Required]
        [Column("title", TypeName = "varchar(30)")]
        public string Title { get; set; }

        [Column("publicationdate", TypeName = "date")]
        [Required]
        public DateTime PublicationDate { get; set; }

        [Column("checkedoutdate", TypeName = "date")]
        [Required]
        public DateTime CheckedOutDate { get; set; }

        [Column("duedate", TypeName = "date")]
        [Required]
        public DateTime DueDate { get; set; }

        [Column("returnedate", TypeName = "date")]

        public DateTime? ReturnedDate { get; set; }

        [Column("author_id", TypeName = "int(10)")]
        public int AuthorID { get; set; }

        [ForeignKey(nameof(AuthorID))]
        [InverseProperty(nameof(Models.Author.Books))]
        public virtual Author Author { get; set; }
    }
}

