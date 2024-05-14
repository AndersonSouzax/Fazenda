using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFazendaFrame.Models
{
    public class Fruta
    {
        public string NomeFruta { get; set; }
        public decimal DiasParaAmadurecer { get; set; }
        public decimal Peso { get; set; }
        public decimal PesoSemCasca { get; set; }
        public string HorarioColheita { get; set; }
        public string Cor { get; set; }
        public decimal Acidez { get; set; }
        public decimal Docura { get; set; }
        public decimal ResistenciaCasca { get; set; }
        public string PaisOrigem { get; set; }
        public decimal TemperaturaManter { get; set; }
        public decimal DiasValidadeAposAberto { get; set; }
        // public bool ContemSementes { get; set; }
        // public bool Organica { get; set; }
        public decimal PrecoPorQuilograma { get; set; }
        // public bool VendaUnidadePermitida { get; set; }
        public decimal PrecoPorUnidade { get; set; }
        public string DataImportacao { get; set; }
    }
}
