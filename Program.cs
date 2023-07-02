using System.ComponentModel;
using System.Reflection;

namespace DZ5
{
    interface IRobot
    {
        public string GetInfo()
        {
            return ("Robot");
        }

        public List<string> GetComponent(List<string> list)
        {
            return list;
        }

        virtual string GetRobotType()
        {
            return "I am a simple robot.";
        }

    }

    interface IChargeable
    {
        void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
        }

        string GetInfo()
        {
            return ("Charge");
        }
    }

    interface IFlyingRobot : IRobot
    {
        public new string GetRobotType()
        {
            return "I am a flying robot.";
        }
    }

    class Quadcopter : IFlyingRobot, IChargeable
    {
        public List<string> List_components = new List<string> { "rotor1", "rotor2", "rotor3", "rotor4" };

        public List<string> GetComponent(List<string> List_components)
        {
            return List_components;
        }

        public string GetInfo()
        {
            return "Get Info";
        }

        public string GetRobotType()
        {
            return "I am a robot";
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Quadcopter quadcopter = new Quadcopter();

            var a = quadcopter.GetRobotType();
            Console.WriteLine(a);
            a = quadcopter.GetInfo();
            Console.WriteLine(a);

            IChargeable charge = new Quadcopter();
            charge.Charge();
        }
    }
}