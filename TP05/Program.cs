using System;
using System.Collections.Generic;
using System.Linq;

namespace TP05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Materia> materias = new List<Materia>();
            Materia materia1 = new Materia();
            materia1.Anio = 2016;
            materia1.Cuatrimestre = 1;
            materia1.Nombre = "Matematica";
            materia1.Notas = new List<Nota>();

            Nota nota1m1 = new Nota();
            nota1m1.Fecha = DateTime.Now;
            nota1m1.Tipo = "TP";
            nota1m1.Valor = 9;
            materia1.Notas.Add(nota1m1);

            Nota nota2m1 = new Nota();
            nota2m1.Fecha = DateTime.Now;
            nota2m1.Tipo = "P1";
            nota2m1.Valor = 9;
            materia1.Notas.Add(nota2m1);

            Materia materia2 = new Materia();
            materia2.Anio = 2017;
            materia2.Cuatrimestre = 2;
            materia2.Nombre = "POO";
            materia2.Notas = new List<Nota>();

            Nota nota1m2 = new Nota();
            nota1m2.Fecha = DateTime.Now;
            nota1m2.Tipo = "TP";
            nota1m2.Valor = 7;
            materia2.Notas.Add(nota1m2);

            Nota nota2m2 = new Nota();
            nota2m2.Fecha = DateTime.Now;
            nota2m2.Tipo = "P1";
            nota2m2.Valor = 8;
            materia2.Notas.Add(nota2m2);
            materias.Add(materia1);


            //Armar una consulta para obtener todas las materias que cursaron en el primer cuatrimestre:
            List<Materia> filtro = materias.FindAll(x => x.Cuatrimestre == 1);

            //Aarmar una consulta donde el resultado este ordenado alfabeticamente por nombre:
            IEnumerable<Materia> filtro2 = materias.FindAll(x => x.Cuatrimestre == 1).OrderBy(y => y.Nombre);

            //Armar una consulta donde se devuelva una lista de todas las notas del tipo TP:
            var notas = materias
                .SelectMany(i => i.Notas)
                .Where(i => i.Tipo == "TP")
                .ToList();
            
            Console.WriteLine(materia1.CalcularPromedio());
            Console.Read();
        }
    }
}
