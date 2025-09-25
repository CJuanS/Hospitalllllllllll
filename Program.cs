using HealthClinic.models;

class Program
{
    static void Main()
    {

        bool validator = false;
        while (!validator)
        {
            
            Console.WriteLine("Bienvenido usuario querido al menú interactivo, qué desea hacer?");
            Console.WriteLine("1 - Registrar paciente.");
            Console.WriteLine("2 - Listar paciente.");
            Console.WriteLine("3 - Buscar paciente.");
            Console.WriteLine("4 - Salir.");
            Console.Write("Elige una opción (1 - 4): ");

            char OptionUser = Console.ReadKey().KeyChar;
            Hospital MyHospital = new Hospital("Clínica Central");

            if (!char.IsWhiteSpace(OptionUser))
            {
                switch (OptionUser)
                {
                    case '1':
                        Console.WriteLine();
                        var p = CreatePatients();
                        MyHospital.AddPatient(p);
                        p.ShowInformation();
                        break;
                    case '2':
                        Console.WriteLine();
                        Console.WriteLine("Listar paciente");
                        break;
                    case '3':
                        Console.WriteLine();
                        Console.WriteLine("Buscar paciente");
                        break;
                    case '4':
                        Console.WriteLine();
                        Console.WriteLine("Saliendo........");
                        validator = true;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Elije una opción válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Por favor elije una opción válida.");
            }

        }
    }



    static Patient CreatePatients()
    {
        Console.Write("Escriba el nombre: ");
        string NamePatient = Console.ReadLine();
        Console.Write("Escriba la edad: ");
        int AgePatient = int.Parse(Console.ReadLine());
        Console.Write("Escriba el sintoma: ");
        string Symptom = Console.ReadLine();


        return new Patient(NamePatient, AgePatient, Symptom);
    }
}





// Patient patient1 = new()
// {
//     Id = 1,
//     Name = "Juan",
//     Age = 18,
//     Symptom = "Cáncer"
// };
// patient1.ShowInformation();