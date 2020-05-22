using CodingChallenge.Entities.Idiomas.Interface;
using CodingChallenge.Entities.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Entities.Idiomas
{
    public class Ingles : Idioma, IIdioma
    {
        #region Properties
        private const int _tipo = 2;

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
            return total + " " + "shapes" + " ";
        }

        public string PieResumenPerimetros(decimal perimero)
        {
            return "Perimeter " + (perimero).ToString("#.##") + " ";
        }

        public string TituloVacio()
        {
            return "<h1>Empty list of shapes!</h1>";
        }

        public string Titulo()
        {
            return "<h1>Shapes report</h1>";
        }

        public string ObtenerLinea(int cantidad, decimal area, decimal perimetro, Utils.Formas tipo)
        {
            if (cantidad > 0)
            {
                /*
               * No es la mejor solucione pero se uso para facilitar la implementacion por tiempo.
               * Seria interesante buscar una solucion con archivos de recursos; Como se maneja los idiomas con la cultura
               */
                string _tipo = TraducirForma(tipo, cantidad);

                return $"{cantidad} { ( _tipo )} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";
            }
            return string.Empty;
        }

        #endregion

        #region Private Methods

        private string TraducirForma(Utils.Formas tipo, int cantidad)
        {
            switch (tipo)
            {
                case Utils.Formas.Circulo: return cantidad == 1 ? "Circle" : "Circles";
                case Utils.Formas.Cuadrado: return cantidad == 1 ? "Square" : "Squares";
                case Utils.Formas.Trapecio: return cantidad == 1 ? "Trapeze" : "Trapezies"; 
                case Utils.Formas.TrianguloEquilatero: return cantidad == 1 ? "Triangle" : "Triangles";
                default: return String.Empty;

            }
        }

        #endregion
    }
}
