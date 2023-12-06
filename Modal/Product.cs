using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreAPI2.Modal
{
    [Table("PersonalInfo")]
    public class Product
    {
        [Key]
        public Int64 Rec_Id { get; set; }
        public string Name { get; set; }
        public decimal MobileNo { get; set; }

    }
}
