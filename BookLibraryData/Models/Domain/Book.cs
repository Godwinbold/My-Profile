using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookLibraryData.Models.Domain
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }

        public string Author { get; set; }

        [DisplayName("Category Name")]
        public string CategoryId { get; set; }
        
       [DisplayName("Genre Name")]
		public string GenreId { get; set; }

		[DisplayName("Image Link")]
		public string ImageLink { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }
        public string Language { get; set; }

		[DisplayName("Published Date")]
		public DateTime PublishedDate { get; set; }
		public string Description { get; set; }

        [DisplayName("Page Number")]
		public int NumberofPages{ get; set; }

		[DisplayName("Library Add Date")]

		public DateTime LibraryAddDate { get; set; } = DateTime.Now;

		[DisplayName("Available Copies")]
		public string CopiesInLibrary { get; set; }
        public string CopiesOutLibrary { get; set; }

		[DisplayName("Available Copies")]

		public string AvailableCopies { get; set; }
        public bool E_Version { get; set; }

        [ForeignKey("GenreId")]
        [ValidateNever]
        public Genre? Genre { get; set; }

        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category? Category { get; set; }





    }
}
