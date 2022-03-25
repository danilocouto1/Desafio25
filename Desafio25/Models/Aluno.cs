using Desafio25.Models.Types;
using Desafio25.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Desafio25.Models
{
    public class Aluno : Pessoa
    {
        [Required]
        public Guid IdAluno { get; }
        public List<Desafio> Desafio = new List<Desafio>();
        public  Aluno()
        { }
        public Aluno(int ano, int mes, int dia, string nome, string email, GeneroType genero, string cPF, string login, string password, RoleType role) :
            base(nome, email, genero, cPF, login, password, role)
        {

            DtNascimento = new DateTime(ano, mes, dia);
            Idade = DateTime.Now.Year - DtNascimento.Year;
            IdAluno = Guid.NewGuid();
        }

    }
}