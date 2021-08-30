using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hipodromo
{
    class Carrera
    {
        const int CantidadCaballos = 5;
        private double _distanciaEnMetros;

        private List <Caballo> caballos;

        public Carrera(double distancia) {
            _distanciaEnMetros = distancia;
            caballos = new List<Caballo>();

        }

        public void agregarParticipante(Caballo caballo) {
            if(caballos.Count < CantidadCaballos)
            {
                caballos.Add(caballo);
            }
            else
            {
                Console.WriteLine("No se pueden agregar más caballos.");
            }
        }

        public void correr()
        {
            List<Caballo> caballosOrdenados = caballos.OrderBy(c => c.calcularGalope(_distanciaEnMetros)).ToList();

            for (int index = 1; index < caballosOrdenados.Count +1; index++)
            {
                
                Console.WriteLine("Posición " + index+ ": Caballo N°"+caballosOrdenados[index-1].Numero+" - tiempo "+ caballosOrdenados[index - 1].calcularGalope(_distanciaEnMetros)+ " segundos.");
               
            }

        }

    }
}
