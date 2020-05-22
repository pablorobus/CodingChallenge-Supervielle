using CodingChallenge.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Entities.Formas
{
    public class Circulo : Forma, IFormas
    {
        #region Constructors
        public Circulo(decimal ancho)
        {
            _lado = ancho;
        }
        #endregion

        #region Properties
        private int _tipo = 3;

        private decimal _lado;
        #endregion

        #region Getters Setters
        public decimal Lado
        {
            get { return _lado; }
            set => _lado = value;
        }

        public int Tipo { get { return _tipo; } }
        #endregion

        #region Public Methods

        public bool Es(IFormas forma)
        {
            return this.Tipo == forma.Tipo;
        }

        public decimal CalcularArea()
        {
            return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
        }

        public decimal CalcularPerimetro()
        {
              return (decimal)Math.PI * _lado;
        }

        #endregion

        #region Private Methods

        #endregion
    }
}
