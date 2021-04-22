using System;

namespace BinaryTreeUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imagen 1
            Position rectorPosition = new Position();
            rectorPosition.Name = "Rector";
            rectorPosition.Salary = 1000;

            Position vicFinPosition = new Position();
            vicFinPosition.Name = "Vicerrector Financiero";
            vicFinPosition.Salary = 750;

            Position contadorPosition = new Position();
            contadorPosition.Name = "Contador";
            contadorPosition.Salary = 500;

            Position jefeFinPosition = new Position();
            jefeFinPosition.Name = "Jefe Financiero";
            jefeFinPosition.Salary = 610;

            Position secFin1Position = new Position();
            secFin1Position.Name = "Secretaria financiera 1";
            secFin1Position.Salary = 350;

            Position secFin2Position = new Position();
            secFin2Position.Name = "Secretaria financiera 2";
            secFin2Position.Salary = 310;

            Position vicAcadPosition = new Position();
            vicAcadPosition.Name = "Vicerrector Academico";
            vicAcadPosition.Salary = 780;

            Position jefeRegPosition = new Position();
            jefeRegPosition.Name = "Jefe Registro Academico";
            jefeRegPosition.Salary = 640;

            //Imagen 2
            Position secReg2Position = new Position();
            secReg2Position.Name = "Secretaria Registro academico 2";
            secReg2Position.Salary = 360;

            Position secReg1Position = new Position();
            secReg1Position.Name = "Secretaria Registro academico 1";
            secReg1Position.Salary = 400;

            Position asist2Position = new Position();
            asist2Position.Name = "Asistente 2";
            asist2Position.Salary = 170;

            Position asist1Position = new Position();
            asist1Position.Name = "Asistente 1";
            asist1Position.Salary = 250;

            Position mensajPosition = new Position();
            mensajPosition.Name = "Mensajero";
            mensajPosition.Salary = 90;

            UniversityTree universityTree = new UniversityTree();
            universityTree.CreatePosition(null, rectorPosition, null);
            universityTree.CreatePosition(universityTree.Root, vicFinPosition,rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeFinPosition, vicFinPosition.Name);
            universityTree.CreatePosition(universityTree.Root, contadorPosition, vicFinPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin1Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin2Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, vicAcadPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeRegPosition, vicAcadPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secReg2Position, jefeRegPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secReg1Position, jefeRegPosition.Name);
            universityTree.CreatePosition(universityTree.Root, asist2Position, secReg1Position.Name);
            universityTree.CreatePosition(universityTree.Root, mensajPosition, asist2Position.Name);
            universityTree.CreatePosition(universityTree.Root, asist1Position, secReg1Position.Name);



            universityTree.PrintTree(universityTree.Root);
            

            float totalSalary = universityTree.AddSalaries(universityTree.Root);
            Console.WriteLine($"Total salaries: {totalSalary}");
            Console.ReadLine();
        }
    }
}
