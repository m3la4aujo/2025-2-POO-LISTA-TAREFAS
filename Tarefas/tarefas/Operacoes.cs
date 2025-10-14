public class Operacoes
{
    private string connectionString = @"server=phpmyadmin.uni9.marize.us;User ID=user_poo;passsword=S3nh4!F0rt3;database=user_poo;";
    public int Criar(Tarefa tarefa)
    {
        using(var conexao = new MySqlConnection(connectionString))
        {
            conexao.Open();
            string sql = @"INSERT INTO tarefa (nome, descricao, dataCriacao, status, dataExecucao)
                           VALUES (@nome, @descricao, @dataCriacao, @status, @dataExeucao);
                           SELECT LAST_INSERT_ID();";
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@nome", tarefa.Nome);
                cmd.Parameters.AddWithValue("@descricao", tarefa.Descricao);
                cmd.Parameters.AddWithValue("@dataCriacao", tarefa.DataCriacao);
                cmd.Parameters.AddWithValue("@status", tarefa.Status);
                cmd.Parameters.AddWithValue("@dataExecucao", tarefa.DataExecucao);

                return convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }

    public Tarefa Buscar(int id)
    {
        return null;
    }

    public List<Tarefa> Listar()
    {
        return Array.Empty<Tarefa>():
    {

    public void Alterar(Tarefa tarefa)
    {

    }
    public void Excluir(int id)
}
}
}