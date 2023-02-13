using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FinalPI.Models
{
    public class Publicacao
    {
        [Key]
        public int Id { get; set; }
        public string Conteudo { get; set; }
        public string Imagem { get; set; }
        public string TipoArquivo { get; set; }
        public string DataPostagem { get; set; }
    }
}