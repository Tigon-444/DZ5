using System.ComponentModel;

namespace DZ5
{
    interface IRobot
    {
        public string GetInfo()
        {
             throw new NotImplementedException();
        }

        public List<string> GetComponent(List<string> list)
        {
            return list;
        }

        public string GetRobotType()
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
            throw new NotImplementedException();
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
        public List<string> List_components = new List <string> { "rotor1", "rotor2", "rotor3", "rotor4" };
        
    }


}