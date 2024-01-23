using System;

namespace notas_alunos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //
            //     Você recebe uma pequena lista de quatro alunos com as notas das cinco tarefas que eles realizaram.
            //     Cada nota é expressa como um valor inteiro de 0 a 100, em que 100 representa 100% de acerto.
            //     A pontuação final é calculada pela média das cinco notas de tarefas.
            //     O aplicativo precisa executar operações matemáticas básicas para calcular as notas finais de cada aluno.
            //     Seu aplicativo precisa gerar como resultado/exibir o nome e a pontuação final de cada aluno.
            //
            // Sophia: 93, 87, 98, 95, 100
            //
            // Nicolas: 80, 83, 82, 88, 85
            //
            // Zahirah:   84, 96, 73, 85, 79
            //
            // Jeong:  90, 92, 98, 100, 97

            //     Student     Grade
            //     Sophia      94.6  A
            //     Nicolas     83.6  B
            //     Zahirah     83.4  B
            //     Jeong       95.4  A

            //Tarefas
            // initialize variables - graded assignments
            int currentAssignments = 5;

            int sophia1 = 93;
            int sophia2 = 87;
            int sophia3 = 98;
            int sophia4 = 95;
            int sophia5 = 100;

            int nicolas1 = 80;
            int nicolas2 = 83;
            int nicolas3 = 82;
            int nicolas4 = 88;
            int nicolas5 = 85;

            int zahirah1 = 84;
            int zahirah2 = 96;
            int zahirah3 = 73;
            int zahirah4 = 85;
            int zahirah5 = 79;

            int jeong1 = 90;
            int jeong2 = 92;
            int jeong3 = 98;
            int jeong4 = 100;
            int jeong5 = 97;


            // calculate the sum of each student
            int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
            int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
            int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
            int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

            // Console.WriteLine($"Sophia: {sophiaSum}");
            // Console.WriteLine($"Nicolas: {nicolasSum}");
            // Console.WriteLine($"Zahirah: {zahirahSum}");
            // Console.WriteLine($"Jeong: {jeongSum}");
            // Console.WriteLine("---------------------------------");


            // Calculate the avarage
            decimal sophiaAverage = (decimal)sophiaSum / currentAssignments;
            decimal nicolasAverage = (decimal)nicolasSum / currentAssignments;
            decimal zahirahAverage = (decimal)zahirahSum / currentAssignments;
            decimal jeongAverage = (decimal)jeongSum / currentAssignments;

            // Console.WriteLine($"Sophia: {sophiaAverage}");
            // Console.WriteLine($"Nicolas: {nicolasAverage}");
            // Console.WriteLine($"Zahirah: {zahirahAverage}");
            // Console.WriteLine($"Jeong: {jeongAverage}");

            //Make the final result
            //     97 - 100    A+
            //     93 - 96     A
            //     90 - 92     A-
            //     87 - 89     B+
            //     83 - 86     B

            //     Student     Grade
            //     Sophia      94.6  A
            //     Nicolas     83.6  B
            //     Zahirah     83.4  B
            //     Jeong       95.4

            //Final result
            Console.WriteLine("Student     Grade");
            Console.WriteLine($"Sophia:     {sophiaAverage} {finalNote(sophiaAverage)}");
            Console.WriteLine($"Nicolas:    {nicolasAverage} {finalNote(nicolasAverage)}");
            Console.WriteLine($"Zahirah:    {zahirahAverage} {finalNote(zahirahAverage)}");
            Console.WriteLine($"Jeong:      {jeongAverage} {finalNote(jeongAverage)}");
        }

        private static string finalNote(decimal note)
        {
            string result = "";

            if (note >= 97)
            {
                result = "A+";
            }
            else if (note >= 93 && note <= 96)
            {
                result = "A";
            }
            else if (note >= 90 && note <= 92)
            {
                result = "A-";
            }
            else if (note >= 87 && note <= 89)
            {
                result = "B+";
            }
            else if (note >= 83 && note <= 86)
            {
                result = "B";
            }
            else
            {
                throw new Exception("Invalid grade");
            }

            return result;
        }
    }
}