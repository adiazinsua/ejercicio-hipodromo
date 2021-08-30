using System;

namespace Hipodromo
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo c1 = new Criollo(1, "hembra", 1, 100);
            Caballo c2 = new Arabe(10, "macho", 1, 25);
            Caballo c3 = new SPC(8, "macho", 1, 100);
            Caballo c4 = new Criollo(2, "hembra", 1, 50);
            Caballo c5 = new Arabe(5, "hembra", 1, 80);

            Carrera carrera = new Carrera(1200);

            carrera.agregarParticipante(c1);
            carrera.agregarParticipante(c2);
            carrera.agregarParticipante(c3);
            carrera.agregarParticipante(c4);
            carrera.agregarParticipante(c5);

            carrera.correr();


            
            




        }
    }
}
