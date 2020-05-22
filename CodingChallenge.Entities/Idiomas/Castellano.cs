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
    public class Castellano : Idioma, IIdioma
    {
        #region Properties
        private const int _tipo = 1;
        #endregion

        #region Public Methods
        public string Pie()
        {
            return "TOTAL:<br/>";
        }

        public string PieResumenArea(decimal area)
        {
            return "Area " + (area).ToString("#.##");
        }

        public string PieResumenNumeroFormas(int total)
        {
            return total + " " + "formas" + " ";
        }

        public string PieResumenPerimetros(decimal perimero)
        {
            return "Perimetro " + (perimero).ToString("#.##") + " ";
        }

        public string TituloVacio()
        {
            return "<h1>Lista vacía de formas!</h1>";
        }

        public string Titulo()
        {
            return "<h1>Reporte de Formas</h1>";
        }

        public string ObtenerLinea(int cantidad, decimal area, decimal perimetro, Utils.Formas tipo)
        {
            if (cantidad > 0)
            {
                string _tipo = TraducirForma(tipo, cantidad);

                return $"{cantidad} { _tipo } | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";
            }
            return string.Empty;
        }
        #endregion

        #region Private Methods

        private string TraducirForma(Utils.Formas tipo, int cantidad)
        {
            switch (tipo)
            {
                case Utils.Formas.Circulo: return cantidad == 1 ? "Círculo" : "Círculos";
                case Utils.Formas.Cuadrado: return cantidad == 1 ? "Cuadrado" : "Cuadrados";
                case Utils.Formas.Trapecio: return cantidad == 1 ? "Trapecio" : "Trapecios";
                case Utils.Formas.TrianguloEquilatero: return cantidad == 1 ? "Triángulo" : "Triángulos";
                default: return String.Empty;

            }
        }

        #endregion
    }
}
