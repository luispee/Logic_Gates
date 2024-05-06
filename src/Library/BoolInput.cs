namespace Library
{
    public class BoolInput : IInput
    {
        public bool Input { get; set; }
        public BoolInput (bool input)
        {
            this.Input = input;
        }

        public bool GetResult()
        {
            return this.Input;
        }

        public void AddInput()
        {

        }

    }
}