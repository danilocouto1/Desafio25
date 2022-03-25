using System;
using Desafio25.Models.Types;

namespace Desafio25.Models{
    public class Desafio
    {
        public Guid IdDesafio { get; }
        public string NameDesafio { get; }
        public TrilhaTypes TrilhaType { get; set; }
        public Trilha Trilha { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFinal { get; set; }
        public Facilitador Facilitador { get; set; }
        public Desafio(string nameDesafio, TrilhaTypes trilhaType, Trilha trilha, DateTime dtInicio, DateTime dtFinal, Facilitador facilitador)
        {
            NameDesafio = nameDesafio;
            TrilhaType = trilhaType;
            Trilha = trilha;
            DtInicio = dtInicio;
            DtFinal = dtFinal;
            Facilitador = facilitador;
            IdDesafio = Guid.NewGuid();
        }
    }
}