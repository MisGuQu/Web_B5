using System.ComponentModel.DataAnnotations;

namespace Web_B5.Models
{
    public class Book
    {
        public int? BookId { get; set; }

        [Required(ErrorMessage = "Title không được bỏ trống")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Author không được bỏ trống")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Price không được bỏ trống")]
        [Range(1, 99999, ErrorMessage = "Giá trị từ 1 đến 99999")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Description không được bỏ trống")]
        public string Description { get; set; }

        public string? Image { get; set; }
        [Required(ErrorMessage = "Vui lòng trả về thể loại sách")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
