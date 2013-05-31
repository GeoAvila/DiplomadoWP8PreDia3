using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {

        static void Main(string[] args)
        {
            var violinista = new Violinista();
            var clarinetista = new Clarinetista();

            DirectorDeOrquesta director = new DirectorDeOrquesta(violinista, clarinetista);

            director.EmpezarSinfonia();
            director.TerminarSinfonia();

            Console.ReadKey();
        }
    }

    public abstract class Musico
    {
        public string Instrumento { get; private set; }

        public Musico(string instrumento)
        {
            Instrumento = instrumento;
        }

        public abstract void Afinar();

        public void Tocar()
        {
            Console.WriteLine(this.ToString() + " empieza a tocar");
        }

        public void Terminar()
        {
            Console.WriteLine(this.ToString() + " termina de tocar");
        }
    }

    public class DirectorDeOrquesta
    {
        private Musico[] musicos;
        public DirectorDeOrquesta(params Musico[] musicos)
        {
            this.musicos = musicos;

            musicos[0].Afinar();
            musicos[1].Afinar();
        }

        public void EmpezarSinfonia()
        {
            musicos[0].Tocar();
            musicos[1].Tocar();
        }

        public void TerminarSinfonia()
        {
            musicos[0].Terminar();
            musicos[1].Terminar();
        }


    }

    public class Violinista : Musico
    {
        public Violinista()
            : base("Violin")
        {

        }

        public override void Afinar()
        {
            Console.WriteLine("El violinista está afinando");
        }
    }

    public class Clarinetista : Musico
    {
        public Clarinetista()
            : base("Clarinete")
        {

        }

        public override void Afinar()
        {
            Console.WriteLine("El clarinetista está afinando");
        }
    }
}
