using CCodingChallenge.Entities;
using CodingChallenge.Entities.Formas;
using CodingChallenge.Entities.Idiomas.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Entities.Utils
{
    /// <summary>
    /// Imprime la Forma Geometrica segun el idioma que se le pase por parametro
    /// </summary>
    public static class ManejadorDeImpresion
    {
       public static string Imprimir(List<FormaGeometrica> formas, IIdioma idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(idioma.TituloVacio());
            }
            else
            {
                sb.Append(idioma.Titulo());

                var numeroCuadrados = 0;
                var numeroCirculos = 0;
                var numeroTriangulos = 0;
                var numeroTrapecio = 0;

                var areaCuadrados = 0m;
                var areaCirculos = 0m;
                var areaTriangulos = 0m;
                var areaTrapecio = 0m;

                var perimetroCuadrados = 0m;
                var perimetroCirculos = 0m;
                var perimetroTriangulos = 0m;
                var perimetroTrapecio = 0m;
                          
                foreach (var forma in formas)
                {
                    if (forma.Forma.GetType().Equals(new Cuadrado(0).GetType()))
                    {
                        numeroCuadrados++;
                        areaCuadrados += forma.Forma.CalcularArea();
                        perimetroCuadrados += forma.Forma.CalcularPerimetro();
                    }
                    if (forma.Forma.Es(new Circulo(0)))
                    {
                        numeroCirculos++;
                        areaCirculos += forma.Forma.CalcularArea();
                        perimetroCirculos += forma.Forma.CalcularPerimetro();
                    }
                    if (forma.Forma.Es(new TrianguloEquilatero(0)))
                    {
                        numeroTriangulos++;
                        areaTriangulos += forma.Forma.CalcularArea();
                        perimetroTriangulos += forma.Forma.CalcularPerimetro();
                    }
                    if (forma.Forma.Es(new Trapecio()))
                    {
                        numeroTrapecio++;
                        areaTrapecio += forma.Forma.CalcularArea();
                        perimetroTrapecio += forma.Forma.CalcularPerimetro();
                    }
                }

                sb.Append(idioma.ObtenerLinea(numeroCuadrados, areaCuadrados, perimetroCuadrados, Formas.Cuadrado));
                sb.Append(idioma.ObtenerLinea(numeroCirculos, areaCirculos, perimetroCirculos, Formas.Circulo));
                sb.Append(idioma.ObtenerLinea(numeroTriangulos, areaTriangulos, perimetroTriangulos, Formas.TrianguloEquilatero));
                sb.Append(idioma.ObtenerLinea(numeroTrapecio, areaTrapecio, perimetroTrapecio, Formas.Trapecio));

                // FOOTER
                sb.Append(idioma.Pie());

                sb.Append(idioma.PieResumenNumeroFormas(numeroCuadrados + numeroCirculos + numeroTriangulos + numeroTrapecio));
                sb.Append(idioma.PieResumenPerimetros(perimetroCuadrados + perimetroTriangulos + perimetroCirculos + perimetroTrapecio));

                sb.Append(idioma.PieResumenArea(areaCuadrados + areaCirculos + areaTriangulos+ areaTrapecio));
            }

            return sb.ToString();
        }
    }
}
