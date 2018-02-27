using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Domain
{
    public class Computador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCompuatador { get; set; }
        [Required]
        public string Processador { get; set; }
        public string PlacaDeVideo { get; set; }
        [Required]
        public int QtdMemoriaRam { get; set; }
        [Required]
        public int QtdEspacoHd { get; set; }
        [Required]
        public bool Disponivel { get; set; }

        public void AutoAtualizar(Computador computador)
        {
            this.Processador = computador.Processador;
            this.PlacaDeVideo = computador.PlacaDeVideo;
            this.QtdMemoriaRam = computador.QtdMemoriaRam;
            this.QtdEspacoHd = computador.QtdEspacoHd;
            this.Disponivel = computador.Disponivel;
        }
    }
}
