using CodingChallenge.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Entities.Formas
{
    public class Trapecio : Forma, IFormas
    {
        #region Constructors
        public Trapecio()
        {
        }

        public Trapecio(decimal ladoA, decimal ladoB, decimal ladoC, decimal ladod, decimal altura)
        {
            _ladoA = ladoA;
            _ladoB = ladoB;
            _ladoC = ladoC;
            _ladoD = ladod;
            _altura = altura;
        }
        #endregion

        #region Properties
        private int _tipo = 4;

        private decimal _ladoA;
        private decimal _ladoB;
        private decimal _ladoC;
        private decimal _ladoD;
        private decimal _altura; 
        #endregion

        #region Getters Setters
        public decimal LadoA
        {
            get { return _ladoA; }
            set => _ladoA = value;
        }
        public decimal LadoB
        {
            get { return _ladoB; }
            set => _ladoB = value;
        }
        public decimal LadoC
        {
            get { return _ladoC; }
            set => _ladoC = value;
        }
        public decimal LadoD
        {
            get { return _ladoD; }
            set => _ladoD = value;
        }
        public decimal Altura
        {
            get { return _altura; }
            set => _altura = value;
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
            return _ladoA + _ladoB + _ladoC + _ladoD;
        }

        public decimal CalcularPerimetro()
        {
            return (_ladoA + _ladoB) * _altura;
        }

        #endregion

        #region Private Methods

        #endregion
    }
}