namespace D_GOOD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISwitchable bulb = new LightBulb();
            Switch wallSwitch = new Switch(bulb);

            Console.WriteLine("Tryck på strömbrytaren:");
            wallSwitch.Toggle();
            wallSwitch.Toggle();
            wallSwitch.Toggle();

            // En spotlight!
            ISwitchable spotLight = new SpotLight();
            Switch spotLightSwitch = new Switch(spotLight);
            spotLightSwitch.Toggle();
            spotLightSwitch.Toggle();
            spotLightSwitch.Toggle();

            Console.ReadLine();
        }
    }
}