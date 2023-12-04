using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookLibraryData.Models.Domain
{
	public class Review : BaseEntity
    {
		[DisplayName("BookName")]

		public string  BookId { get; set; }
		[DisplayName("Your Name")]

		public string ReviewName { get; set; }
		[DisplayName("Review Title")]

		public string Title { get; set; }
        public string Comment { get; set; }
		[ForeignKey(nameof(BookId))]
		[ValidateNever]

		public Book Book { get; set; }
	}
}
