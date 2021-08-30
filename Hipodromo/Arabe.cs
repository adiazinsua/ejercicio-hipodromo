using System;
using System.Collections.Generic;
using System.Text;

namespace Hipodromo
{
    class Arabe : Caballo

    {
        const string ColorPelo = "Negro";
        const double VelocidadTope = 15;
        const double Aceleracion = 1;

        public Arabe(int numero, string sexo, int resistencia, double pPuraSangre) : base(numero, sexo, ColorPelo, VelocidadTope, resistencia, Aceleracion, pPuraSangre)
        {

        }

        // Tipo de galope: Fachero: X(t) = Xi + Vi * t + (a * t^2) / 2
        public override double calcularGalope(double distancia)
        {
            double t;
            double tiempoVTope;
            double tiempoTotal;
            double bonus = getBonusVelocidad();
            double velocidadFinal = VelocidadTope + bonus;

            //calcula cuánto tiempo demora en llegar a la velocidad tope + bonus por porcentaje de pura sangre.
            t = velocidadFinal / Aceleracion;

            //calcula cuántos metros recorrió en el tiempo que tardó en llegar a la velocidad tope.
            double posicion = (Aceleracion * Math.Pow(t, 2)) / 2;

            //calcula cuánto tiempo tarda desde la distancia recorrida hasta la meta corriendo en velocidad tope constante.
            tiempoVTope = (distancia - posicion) / velocidadFinal;

            //suma los dos tiempos
            tiempoTotal = t + tiempoVTope;

            tiempoTotal = Math.Round(tiempoTotal, 2);

            return tiempoTotal;
        }
    }
}
