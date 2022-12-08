using NpgsqlTypes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_ASP.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public int Usia { get; set; }
        public string? Jenis { get; set; }
        public string? Tanggal { get; set; }
       
    }
}
