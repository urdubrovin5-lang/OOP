namespace Interface
{
    public abstract class Device
    {
        protected string model;
        protected int powerConsumption;

        public string Model
        {
            get { return model; }
            protected set { model = value; }
        }

        public int PowerConsumption
        {
            get { return powerConsumption; }
            protected set { powerConsumption = value; }
        }

        public Device(string model, int powerConsumption)
        {
            this.model = model;
            this.powerConsumption = powerConsumption;
        }

        public abstract void DisplayInfo();
    }
}