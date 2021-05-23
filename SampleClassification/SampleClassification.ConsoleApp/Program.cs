using System;
using SampleClassification.Model;

namespace SampleClassification.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool analyze = true;
            while (analyze)
            {
                string val;
                Console.Write("Enter Text: ");
                val = Console.ReadLine();
                var input = new ModelInput()
                {
                    Col0 = val
                };

                ModelOutput result = ConsumeModel.Predict(input);
                string sentiment = result.Prediction == "1" ? "Positive" : "Negative";
                Console.WriteLine($"Text: {input.Col0}\nSentiment: {sentiment}");
                Console.WriteLine("----------------------------------------");
            }
        }
    }
}
