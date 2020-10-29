using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WritePatientRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            //stream writter
            using (StreamWriter sw = new StreamWriter("PatientRecords.txt"))
            {
                //creating a patient object
                patient patient = new patient();
                //Get patient ID
                Console.WriteLine("Enter patient ID (0 to exit): ");
                patient.num = Convert.ToInt32(Console.ReadLine());
                //While ID not 0
                while (patient.num != 0)
                {
                    //Write to file
                    sw.Write(patient.num + " ");
                    //take and write patient name
                    Console.WriteLine("Enter patient name: ");
                    patient.name = Console.ReadLine();
                    sw.Write(patient.name + " ");
                    //take and write patient balance
                    Console.WriteLine("Enter patient balance: ");
                    patient.balance = Convert.ToInt32(Console.ReadLine());
                    sw.WriteLine(patient.balance);
                    //take next ID
                    Console.WriteLine("Enter patient ID (0 to exit): ");
                    patient.num = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.ReadKey();
        }
    }
    class patient
    {
        //patient varibles
        public int num;
        public string name;
        public int balance;
    }
}
