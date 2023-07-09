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

        //public virtual string GetInfo() => "Get Info";

        public string GetRobotType() => "I am a robot";

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Quadcopter quadcopter = new Quadcopter();

            var a = quadcopter.GetRobotType();
            Console.WriteLine(a);

            IRobot robot = new Quadcopter();
            var a1 = robot.GetInfo();
            Console.WriteLine(a1);

            IChargeable robot2 = new Quadcopter();
            var a2 = robot2.GetInfo();
            Console.WriteLine(a2);


            IChargeable charge = new Quadcopter();
            charge.Charge();
        }
    }
}