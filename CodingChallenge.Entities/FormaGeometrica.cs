using CodingChallenge.Entities.Idiomas.Interface;
using CodingChallenge.Entities.Interfaces;
using CodingChallenge.Entities.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCodingChallenge.Entities
{
    public class FormaGeometrica
    {
        private IFormas _forma;
        public IFormas Forma
        {
            get { return _forma; }
            set => _forma = value;
        }

        public FormaGeometrica(IFormas forma)
        {
            _forma = forma;
        }

        public string Imprimir(List<FormaGeometrica> formas, IIdioma idioma)
        {
            return ManejadorDeImpresion.Imprimir(formas, idioma);
        }

     }

}
