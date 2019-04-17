using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;



namespace C0732121_a4
{
    class Program
    {
        ArrayList Beowulf;
        int linecount = 0;
        ArrayList lineNumbers2 = new ArrayList();
        int linenumber = 1;


        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.Run();
            p.lineCount();
            p.countWords();
            p.Foundnumber();






        }

        public void Run()
        {
            this.ReadTextFiles();
        }
        public void ReadTextFiles()
        {
            using (StreamReader file = new StreamReader("U:/Users/732121/C0732121-a4/Beowulf.txt"))
            {

                int counter = 0;
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);

                }
                file.Close();
                Console.WriteLine($"File has{counter} lines");





            }

        }
       