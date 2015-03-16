using System;

namespace DefiningClasses1
{
    public enum BatteryType
    { Li_Ion, NiMH, NiCd, LiPo, unknown }

    public class Battery
    {
        // battery characteristics (model, hours idle and hours talk)
        private string model;
        private byte hoursIdle;
        private byte hoursTalk;
        private BatteryType typeBattery;

        // constructors
        public Battery()
        { }

        public Battery(BatteryType typeBattery, string model)
        {
            this.model = model;
            this.TypeBattery = typeBattery;
        }

        // properties
        public BatteryType TypeBattery
        {
            get { return this.typeBattery; }
            set { this.typeBattery = value; }
        }

        public string Model
        {
            get;
            set;
        }

        // methods
        public override string ToString()
        {
            return String.Format(@"Type: {0}", this.TypeBattery);
        }
    }
}
