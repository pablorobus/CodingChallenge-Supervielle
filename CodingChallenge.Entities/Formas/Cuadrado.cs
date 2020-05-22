using CodingChallenge.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Entities.Formas
{
    public class Cuadrado : Forma, IFormas
    {
        #region Constructors
        public Cuadrado(decimal ancho)
        {
            _lado = ancho;
        }
        #endregion

        #region Properties
        private int _tipo = 1;

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
            return _lado * _lado;
        }

        public decimal CalcularPerimetro()
        {
            return _lado * 4;
        }

        #endregion

        #region Private Methods

        #endregion
    }
}
