using CCodingChallenge.Entities;
using CodingChallenge.Entities.Formas;
using CodingChallenge.Entities.Idiomas.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingChallenge.Entities.Utils;

namespace CodingChallenge.Entities.Idiomas
{
    public class Sueco : Idioma, IIdioma
    {
        #region Properties
        private const int _tipo = 3;
        #endregion

        #region Public Methods
        public string Pie()
        {
            return "TOTAL:<br/>";
        }

        public string PieResumenArea(decimal area)
        {
            return "Område " + (area).ToString("#.##");
        }

        public string PieResumenNumeroFormas(int total)
        {
            return total + " " + "former" + " ";
        }

        public string PieResumenPerimetros(decimal perimero)
        {
            return "Omkret " + (perimero).ToString("#.##") + " ";
        }

        public string TituloVacio()
        {
            return "<h1>Tom lista med former!</h1>";
        }

        public string Titulo()
        {
            return "<h1>formulär Rapport</h1>";
        }

        public string ObtenerLinea(int cantidad, decimal area, decimal perimetro, Utils.Formas tipo)
        {
            if (cantidad > 0)
            {
                string _tipo = TraducirForma(tipo, cantidad);

                return $"{cantidad} { _tipo } | Område {area:#.##} | Omkret {perimetro:#.##} <br/>";
            }
            return string.Empty;
        }
        #endregion

        #region Private Methods

        private string TraducirForma(Utils.Formas tipo, int cantidad)
        {
            switch (tipo)
            {
                case Utils.Formas.Circulo: return cantidad == 1 ? "Cirkel" : "cirklar";
                case Utils.Formas.Cuadrado: return cantidad == 1 ? "Fyrkant" : "Fyrkants";
                case Utils.Formas.Trapecio: return cantidad == 1 ? "Trapets" : "trapetser";
                case Utils.Formas.TrianguloEquilatero: return cantidad == 1 ? "Triangel" : "Trianglar";
                default: return String.Empty;

            }
        }

        #endregion
    }
}
