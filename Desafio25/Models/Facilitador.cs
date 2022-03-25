using System;
using System.ComponentModel.DataAnnotations;
using Desafio25.Models.Types;
using Desafio25.Models.Users;

namespace Desafio25.Models {
    public class Facilitador : Pessoa
    {
        public Facilitador()
        { }
        public Facilitador(int ano, int mes, int dia, string nome, string email, GeneroType genero, string cPF, string login, string password, RoleType role) : base(nome, email, genero, cPF, login, password, role)
        {
            DtNascimento = new DateTime(ano, mes, dia);
            Idade = DateTime.Now.Year - DtNascimento.Year;
            IdFacilitador = Guid.NewGuid();
        }
        [Required]
        public Guid IdFacilitador { get; }
    }
}