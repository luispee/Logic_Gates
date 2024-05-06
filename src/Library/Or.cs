namespace Library
{
    public class Or : IInput
    {
        //public string Name { get; set; }
        public List<IInput> Entradas;

        public Or ()
        {
            this.Entradas = new List<IInput>(); 
        }
        public bool GetResult()
        {
            return this.Entradas[0].GetResult() || this.Entradas[1].GetResult();
        }
        public void AddInput(IInput input)
        {
            this.Entradas.Add(input);
        }
    }
}