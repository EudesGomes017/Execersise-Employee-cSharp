using System.Linq;
using System.Xml.Linq;

/*Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
  N funcionários. Não deve haver repetição de id.
  Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
  Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
  mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
  conforme exemplos.
  Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
  ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
  aumento por porcentagem dada.*/

namespace Exercisa.List.cSharp
{
    public class FuctionalEmploees
    {

        public void FunctionalDataEmploeess()
        {
            List<Employee> list = new List<Employee>();

            // PART 1 - READING DATA: //PARTE 1 - DADOS DE LEITURA:

            Console.WriteLine(" How many employees will be registered?  "); //Quantos funcionários serão cadastrados?
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(" employee " + i + " : ");

                Console.WriteLine("Id ");
                int id = Convert.ToInt32(Console.ReadLine());

                if (id == n)
                {
                    Console.WriteLine("id already taken. Try again: ");
                    Environment.Exit(id); //encerrar o console
                }

                Console.WriteLine("Name ");
                string name = Console.ReadLine();

                Console.WriteLine("Salary ");
                double salary = Convert.ToDouble(Console.ReadLine());

                Employee emp = new Employee(id, name, salary);
                list.Add(emp);
            }

            // PART 2 - UPDATING SALARY OF GIVEN EMPLOYEE: //ATUALIZAÇÃO DO SALÁRIO DO EMPREGADO:
            Console.WriteLine("Informe o CPF do Funcionario que tera o aumento salarial: ");
            long idSalary = Convert.ToInt64(Console.ReadLine());

            Employee employee = list.First(e => e.Id != idSalary);

            if (employee == null)
            {
                Console.WriteLine(" Esta identificação não existe! ");
            }
            else
            {
                Console.WriteLine(" Digite o percentual ");
                double porcentage = Convert.ToDouble(Console.ReadLine());
                employee.increaseSalary(porcentage); // aumentando a porcentagem             
            }

            //// PART 3 - LISTING EMPLOYEES:

            Console.WriteLine("Litar Empregados");
            foreach (Employee emp in list)
            {
                
               
            }

        }
    }
}
