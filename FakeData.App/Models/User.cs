using System;
using System.Collections.Generic;

namespace FakeData.App.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastLogin { get; set; }
        
        // Kullanıcının ürünlerle ilişkisi (örneğin, favori ürünler veya satın alınanlar)
        public virtual ICollection<Product> FavoriteProducts { get; set; }
    }
}