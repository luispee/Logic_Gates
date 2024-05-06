namespace Library
{
    public class Not : IInput
    {
        //public string Name { get; set; }
        public List<IInput> Entradas;

        public Not ()
        {
           this.Entradas = new List<IInput>(); 
        }

        public bool GetResult()
        {
            return !this.Entradas[0].GetResult();
        }
        public void AddInput(IInput input)
        {
            this.Entradas.Add(input);
        }
    }
}    