using System;
using System.ComponentModel.DataAnnotations;
using Desafio25.Models.Types;

namespace Desafio25.Models.Users{
        public abstract class Pessoa
    {
        [Required]
        [StringLength(100, MinimumLength = 10)]
        public string Nome { get; }
        [Required(ErrorMessage = "Informe o seu email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido")]
        public string Email { get; }
        [Required]
        [Range(18, 150, ErrorMessage = "Menor de 18 anos")]
        public int Idade { get; set; }
        [Required]
        public DateTime DtNascimento { get; set; }
        [Required]
        public GeneroType Genero { get; }
        [Required]
        public string CPF { get; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public RoleType Role { get; set; }
        public Pessoa()
        { }
        public Pessoa(string nome, string email, GeneroType genero, string cPF, string login, string password, RoleType role)
        {
            Nome = nome;
            Email = email;
            Genero = genero;
            CPF = cPF;
            Login = login;
            Password = password;
            Role = role;
        }
    }
}