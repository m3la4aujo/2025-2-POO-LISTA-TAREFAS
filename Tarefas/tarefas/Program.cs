// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Preenchendo dados tarefa 01");
var tarefa01 = new Tarefa();
tarefa01.Nome = "A fazer";
tarefa01.Descricao  = "estudar, trabalhar, viver";
tarefa01.DataCriacao = DateTime.Now;
tarefa01.Status = 1;
tarefa01.DataExecucao = null;

Console.WriteLine("Dados tarefa 01 preenchidos");

Console.WriteLine("Inserindo dados no banco de dados");

var operacoes = new Operacoes();
int idInserido = operacoes.Criar(tarefa01);

Console.WriteLine($"Dados inseridos no banco de dados com sucesso. Id: {idInserido}");

// ---------------- ALTERAR ----------------
Console.Write("\nDigite o ID da tarefa que deseja ALTERAR: ");
int idAlterar = int.Parse(Console.ReadLine());

var tarefaAlterada = new Tarefa();
tarefaAlterada.Id = idAlterar;
Console.Write("Novo nome da tarefa: ");
tarefaAlterada.Nome = Console.ReadLine();
Console.Write("Nova descrição: ");
tarefaAlterada.Descricao = Console.ReadLine();
tarefaAlterada.DataCriacao = DateTime.Now;
Console.Write("Novo status: ");
tarefaAlterada.Status = int.Parse(Console.ReadLine());
tarefaAlterada.DataExecucao = DateTime.Now;

operacoes.Alterar(tarefaAlterada);
Console.WriteLine("Tarefa alterada!");

// ---------------- EXCLUIR ----------------
Console.Write("\nDigite o ID da tarefa que deseja EXCLUIR: ");
int idExcluir = int.Parse(Console.ReadLine());

operacoes.Excluir(idExcluir);
Console.WriteLine("Tarefa excluída!");
