using System;
namespace Eplayers_AspNETcore.Models
{
    public class Partida
    {
        public int IdPartida {get;set;}

        public int IdJogador {get; set;}

        public int IdJogador2 {get;set;}

        public DateTime HorarioInicio {get;set;}

        public DateTime HorarioTermino {get;set;}

    }
}