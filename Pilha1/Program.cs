using Pilha1;

const int quantidade = 5;
const int intervalo = 600;
var pilhaDinheiro = new Pilha();

for (int i = 0; i < quantidade; i++)
{
    var dinheiro = new Dinheiro(Random.Shared.Next(1, 100));
    pilhaDinheiro.AddElement(dinheiro);
    AtualizarTela();
    Thread.Sleep(intervalo);
}

while (!pilhaDinheiro.IsEmpty())
{
    Thread.Sleep(intervalo);
    pilhaDinheiro.RemoveElement();
    AtualizarTela();
}

Console.ReadLine();

void AtualizarTela()
{
    if (!Console.IsOutputRedirected)
        Console.Clear();

    pilhaDinheiro.ShowPilha();
}
