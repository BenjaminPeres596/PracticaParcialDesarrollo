using System.ComponentModel.DataAnnotations;

namespace ParcialAPI
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
