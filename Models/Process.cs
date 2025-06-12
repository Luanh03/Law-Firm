namespace Law_Firm.Models
{
    public class Process
    {
        public int Id { get; set; }
        public required string TRT { get; set; }
        public required string CNPJ { get; set; }
        public required string Rod { get; set; }
        public required string Processes { get; set; }
        public required string Year { get; set; }
    }
}
