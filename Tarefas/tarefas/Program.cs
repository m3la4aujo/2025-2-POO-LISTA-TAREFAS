// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var tarefa01 = new Tarefa();
tarefa01.Nome = "Fazer Compras";
tarefa01.Descricao = "Compra arroz, feijão e frutas";
tarefa01.DataCricao = DateTime.Now;
tarefa01.Status = 1;
tarefa01.DataExecucao = null;

Console.WriteLine("Dados tarefas 01 preenchidos");
Console.WriteLine("Inserindo dados no bando de dados");

var operacoes = new operacoes();
int idinserido = operacoes.criar(tarefa01);

Console.WriteLine($"Dados inseridos no banco de dados com sucesso. Id: (idInserido)");