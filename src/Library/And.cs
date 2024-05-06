namespace Library
{
    public class And : IInput
    {
        //public string Name { get; set; }
        public List<IInput> Entradas;    

        public And ()
            {
                this.Entradas = new List<IInput>(); 
            }

        public bool GetResult()
        {
            return this.Entradas[0].GetResult() && this.Entradas[1].GetResult();
        }
        public void AddInput(IInput input)
        {
            this.Entradas.Add(input);
        }
    }   
}