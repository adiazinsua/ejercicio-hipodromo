using System;
using System.Collections.Generic;
using System.Text;

namespace Hipodromo
{
    abstract class Caballo
    {
        #region properties

        private int _numero;
        private string _sexo;
        private string _colorDePelo;
        private double _velocidadTope;
        private int _resistencia;
        private double _aceleracion;
        private double _porcentajePuraSangre;

        #endregion

        public int Numero { get => _numero; }

        public Caballo(int numero, string sexo, string color, double vTope,int resistencia, double aceleracion, double pPuraSangre)
        {
            _numero = numero;
            _sexo = sexo;
            _colorDePelo = color;
            _velocidadTope = vTope;
            _resistencia = resistencia;
            _aceleracion = aceleracion;
            _porcentajePuraSangre = pPuraSangre;
        }

        public override string ToString()
        {
            return $"Caballo N°{_numero}, sexo: {_sexo}, color de pelo: {_colorDePelo}, velocidad tope: {_velocidadTope}m/s, resistencia: {_resistencia}, aceleración: {_aceleracion}m/s2, porcentaje de pura sangre: {_porcentajePuraSangre} ";
        }

        public abstract double calcularGalope(double distancia);

        public double getBonusVelocidad()
        {
            double bonus;
            bonus = (_velocidadTope * (_porcentajePuraSangre / 10)) / 100;
            return bonus;
        }
    }
}
