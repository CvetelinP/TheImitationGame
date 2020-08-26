using System;


namespace TheImitationGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            var commandLine = Console.ReadLine();
           
            string command;
            
            while ((command=Console.ReadLine())!="Decode")
            {
                string[] input = command.Split("|");

                var firstCommand = input[0];

                if (firstCommand == "ChangeAll")
                {
                    var substring = input[1];
                    var replacement = input[2];

                    commandLine = commandLine.Replace(substring, replacement); 
                }
                else if (firstCommand == "Insert")
                {
                    var index = int.Parse(input[1]);
                    var inserted = input[2];

                     commandLine= commandLine.Insert(index, inserted);
    
                }
                else if (firstCommand=="Move")
                {
                    var Index = int.Parse(input[1]);

                    string movedIndex = commandLine.Substring(0, Index);

                    commandLine=commandLine.Insert(commandLine.Length, movedIndex).Substring(3,5);

                    
       
                }

                Console.WriteLine($"The decrypted message is: {commandLine}");


            }
        }
    }
}
