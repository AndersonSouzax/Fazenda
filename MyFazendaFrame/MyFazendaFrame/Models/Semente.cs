using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFazendaFrame.Models
{
    public class Semente
    {
        public int FrutaId { get; set; }
        public double Largura { get; set; }
        public double Altura { get; set; }
        public double VolumeTotal { get; set; }
        public double HorasValidade { get; set; }
        public double Acidez { get; set; }
        public double PorcentagemAcaoAntiOxidante { get; set; }
        public double PorcentagemAcaoAntiInflamatoria { get; set; }
        public double PorcentagemAcaoAntiMicrobiana { get; set; }
        public double TemperaturaIdealConserva { get; set; }
        public double HumidadeIdealConserva { get; set; }
        public double TemperaturaMaximaConserva { get; set; }
        public double HumidadeMaximaConserva { get; set; }
        public int QuantidadeEstoque { get; set; }
        public double HorasIdeaisNoArmazem { get; set; }
        public double HorasReaisNoArmazem { get; set; }
        public int QuantidadePorEmbalagem { get; set; }
        public int QuantidadeIdealPlantio { get; set; }
        public double HorasAteColheita { get; set; }
        public double HorasAteGerminacao { get; set; }
        public double HorasFrequenciaIrrigacao { get; set; }
        public decimal Preco { get; set; }
        public double PesoUnitario { get; set; }
        public double PurezaFisicaMinimaAceitavel { get; set; }
    }
}
