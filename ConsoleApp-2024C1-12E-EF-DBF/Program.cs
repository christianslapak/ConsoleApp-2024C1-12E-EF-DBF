using ConsoleApp_2024C1_12E_EF_DBF.Modelos;

namespace ConsoleApp_2024C1_12E_EF_DBF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio");

            var miContexto = new _12e2024c1Context();

            //var listaEstudiantes = miContexto.Students

            var miConsulta = from estu in miContexto.Students where estu.StudentId >=3 && estu.StudentId <=6 select estu;

            foreach (var item in miConsulta)
            {
                Console.WriteLine("Nombre " + item.StudentName + " " + "Edad " + item.StudentId);
            }

            Console.WriteLine("Fin");
        }
    }
}
