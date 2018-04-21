using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EscolaColetorWeb.Entity;

namespace EscolaColetorWeb.Models
{
    public class RealizarChamadaModel
    {
        public List<AlunoChamada> alunos { get; set; }
        public DateTime data { get; set; }
        public turma turma { get; set; }
    }

    public class AlunoChamada
    {
        public int cd_aluno { get; set; }
        public string nm_aluno { get; set; }
        public int? cd_chamada { get; set; }
        public DateTime? dt_chamada { get; set; }
        public bool? in_presente { get; set; }
    }
}