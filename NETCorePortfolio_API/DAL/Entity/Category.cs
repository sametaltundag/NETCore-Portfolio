using System.ComponentModel.DataAnnotations;

namespace NETCorePortfolio_API.DAL.Entity
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
