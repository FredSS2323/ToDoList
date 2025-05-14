namespace ToDoList
{
    public class Tarefa
    {
        public string NOME { get; set; }
        public bool STATUS { get; set; }

        public Tarefa(string nome)
        {
            NOME = nome;
            STATUS = false;
        }
    }
}
