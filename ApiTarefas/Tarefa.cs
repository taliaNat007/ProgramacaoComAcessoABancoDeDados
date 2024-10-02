namespace ApiTarefas
{
    public class Tarefa
    {
        // id, descricao, dataCriacao, finalizado= false, dataFinalizado; 
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public Boolean Finalizado { get; set; } = false;
        public DateTime? DataFinalizado { get; set; }

       
    }
}
