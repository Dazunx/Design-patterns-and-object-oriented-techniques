using System;

namespace DesignPatterns
{
    // Class for Printer
    // TODO#1: Convert to use Singleton pattern
    public class Printer
    {
        private Printer() { }
        private static Printer _instance = null;
        public static Printer Instance
        {
            get
            {
                if (_instance == null) _instance = new Printer();
                return _instance;
            }
        }
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }

    // Class template for Exam classes
    // TODO#2: Convert to use Abstract Factory pattern
    // Create an Exam interface and an Abstract Factory to manage the creation of different exam types.
    public interface IAbstractExamFactory {
        public IabstractMathExam createMathExam();
        public IabstractScienceExam createScienceExam();
        public IabstractFinnishExam createFinnishExam();
    }

    class ConcreteExamFactory : IAbstractExamFactory
    {
        public IabstractMathExam createMathExam()
        {
            return new MathExam();
        }
        public IabstractScienceExam createScienceExam()
        {
            return new ScienceExam();
        }
        public IabstractFinnishExam createFinnishExam()
        {
            return new FinnishExam();
        }
    }

    public interface IabstractMathExam
    {
        void Conduct();
        void Evaluate();
        void PublishResults();
    }
    class MathExam : IabstractMathExam
    {
        public void Conduct()
        {
            // Output: "Conducting Math Exam", should use Printer class to print the message
            Printer printer = Printer.Instance;
            printer.Print("Conducting Math Exam");
        }

        public void Evaluate()
        {
            // Output: "Evaluating Math Exam", should use Printer class to print the message
            Printer printer = Printer.Instance;
            printer.Print("Evaluating Math Exam");
        }

        public void PublishResults()
        {
            // Output: "Publishing Math Exam Results", should use Printer class to print the message
            Printer printer = Printer.Instance;
            printer.Print("Publishing Math Exam Results");
        }
    }

    // TODO#5: Add new ScienceExam class
    public interface IabstractScienceExam
    {
        void Conduct();
        void Evaluate();
        void PublishResults();
    }
    class ScienceExam : IabstractScienceExam
    {
        public void Conduct()
        {
            // Output: "Conducting Science Exam", should use Printer class to print the message
            Printer printer = Printer.Instance;
            printer.Print("Conducting Science Exam");
        }

        public void Evaluate()
        {
            // Output: "Evaluating Science Exam", should use Printer class to print the message
            Printer printer = Printer.Instance;
            printer.Print("Evaluating Science Exam");
        }

        public void PublishResults()
        {
            // Output: "Publishing Science Exam Results", should use Printer class to print the message
            Printer printer = Printer.Instance;
            printer.Print("Publishing Science Exam Results");
        }
    }


    // TODO#6: Add another ProgrammingExam class
    public interface IabstractFinnishExam
    {
        void Conduct();
        void Evaluate();
        void PublishResults();
    }
    class FinnishExam : IabstractFinnishExam
    {
        public void Conduct()
        {
            // Output: "Conducting Finnish Exam", should use Printer class to print the message
            Printer printer = Printer.Instance;
            printer.Print("Conducting Finnish Exam");
        }

        public void Evaluate()
        {
            // Output: "Evaluating Finnish Exam", should use Printer class to print the message
            Printer printer = Printer.Instance;
            printer.Print("Evaluating Finnish Exam");
        }

        public void PublishResults()
        {
            // Output: "Publishing Finnish Exam Results", should use Printer class to print the message
            Printer printer = Printer.Instance;
            printer.Print("Publishing Finnish Exam Results");
        }
    }


    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            // TODO#7: Initialize Printer that uses Singleton pattern
            Printer printer = Printer.Instance;

            // TODO#8: Test that the created Printer works, by calling the Print method
            printer.Print("Hello World");

            // TODO#9: Ensure that only one Printer instance is used throughout the application.
            //         Try to create new Printer object and compare the two objects to check,
            //         that the new printer object is the same instance
            MakeExam(new ConcreteExamFactory());

            // TODO#10: Use Abstract Factory to create different types of exams.
            static void MakeExam(IAbstractExamFactory factory)
            {
                var mathExam = factory.createMathExam();
                mathExam.Conduct();
                mathExam.Evaluate();
                mathExam.PublishResults();

                var scienceExam = factory.createScienceExam();
                scienceExam.Conduct();
                scienceExam.Evaluate();
                scienceExam.PublishResults();

                var finnishExam = factory.createFinnishExam();
                finnishExam.Conduct();
                finnishExam.Evaluate();
                finnishExam.PublishResults();
                
                Console.WriteLine();
            }
            
        }
    }
}