using System.ComponentModel.DataAnnotations;

namespace netcore_admin.Domain
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
