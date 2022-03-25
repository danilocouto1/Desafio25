using System.Collections.Generic;
using Desafio25.Models.Types;

namespace Desafio25.Models {
    public class Trilha
    {
        public string IdTrilha { get; set; }
        public string Descricao { get; set; }
        public List<string> Topicos { get; set; }
        public TrilhaTypes TrilhaTypes { get; set; }
        public Trilha()
        { }
        public Trilha(string idTrilha, string descricao, List<string> topicos, TrilhaTypes trilhaTypes)
        {
            IdTrilha = idTrilha;
            Descricao = descricao;
            Topicos = new List<string>();
            TrilhaTypes = trilhaTypes;

        }

    }
}