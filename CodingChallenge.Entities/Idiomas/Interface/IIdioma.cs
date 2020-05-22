using CCodingChallenge.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingChallenge.Entities.Utils;

namespace CodingChallenge.Entities.Idiomas.Interface
{
    public interface IIdioma
    {
        int Tipo { get; }
        bool Es(IIdioma idioma);

        string TituloVacio();
        string Titulo();
        string Pie();
        string PieResumenNumeroFormas(int total);
        string PieResumenPerimetros(decimal perimero);
        string PieResumenArea(decimal area);
        string ObtenerLinea(int numeroCuadrados, decimal areaCuadrados, decimal perimetroCuadrados, Utils.Formas v);
    }
}
