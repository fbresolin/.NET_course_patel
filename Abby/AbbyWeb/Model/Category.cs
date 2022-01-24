using System.ComponentModel.DataAnnotations;

namespace AbbyWeb.Model

{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required, Display(Name = "Category Name")]
        public string CategoryName { get; set; }
        [Display(Name = "Display Order"), Range(1,100)]
        public int DisplayOrder { get; set; }
    }
}
