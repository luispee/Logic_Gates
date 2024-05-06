namespace Library
{
    public class GarageGate
    {
        private BoolInput A;
        private BoolInput B;
        private BoolInput C;
        public GarageGate(bool a, bool b, bool c)
        {
            this.A = new BoolInput(a);
            this.B = new BoolInput(b);
            this.C = new BoolInput(c);
        }
        private bool DoorLogic()
        {
            And a1 = new And();

        a1.AddInput(this.C);
        Or or1 = new Or();

        And a2 = new And();
        a2.AddInput(this.A);
        a2.AddInput(this.B);

        or1.AddInput(a2);
        
        And a3 = new And();
        Not n1 = new Not();
        n1.AddInput(this.A);
        Not n2 = new Not();
        n2.AddInput(this.B);
        a3.AddInput(n1);
        a3.AddInput(n2);

        or1.AddInput(a3);
        a1.AddInput(or1);
        return a1.GetResult();
        }
        public string OpenDoor()
        {
            if (DoorLogic())
            {
                return "Opening door";
            }
            else
            {
                return "Door closed";
            }
        }
    }
}