using CodingChallenge.Entities.Idiomas.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Entities.Idiomas
{
    public abstract class Idioma
    {
        public int Tipo { get; }

        #region Public Methods
        public virtual bool Es(IIdioma idioma)
        {
            return this.Tipo == idioma.Tipo;
        }
        #endregion

        #region Private Methods

        #endregion
    }
}
