using Hospital;

FilaAtendimento atendimento = new FilaAtendimento();
int opcao;

do
{
    Console.Clear();
    Console.WriteLine("Hospital So Falta Voce\n");
    Console.WriteLine("1 - Retirar senha prioritaria");
    Console.WriteLine("2 - Retirar senha normal");
    Console.WriteLine("3 - Chamar proxima senha");
    Console.WriteLine("4 - Mostrar filas");
    Console.WriteLine("0 - Sair");
    Console.Write("Opcao: ");

    if (!int.TryParse(Console.ReadLine(), out opcao))
    {
        opcao = -1;
    }

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Senha gerada: " + atendimento.Prioritaria.GerarSenha().Codigo);
            break;
        case 2:
            Console.WriteLine("Senha gerada: " + atendimento.Normal.GerarSenha().Codigo);
            break;
        case 3:
            Senha? chamada = atendimento.ChamarProximo();
            if (chamada == null)
                Console.WriteLine("Nenhuma senha aguardando");
            else
                Console.WriteLine("Chamando senha: " + chamada.Codigo);
            break;
        case 4:
            Console.WriteLine("Prioritaria (" + atendimento.Prioritaria.GetContador() + "):");
            atendimento.Prioritaria.MostrarFila();
            Console.WriteLine("Normal (" + atendimento.Normal.GetContador() + "):");
            atendimento.Normal.MostrarFila();
            Console.WriteLine("Ordem de atendimento (" + atendimento.GetContador() + "):");
            atendimento.MostrarFila();
            break;
        case 0:
            break;
        default:
            Console.WriteLine("Opcao invalida");
            break;
    }

    if (opcao != 0)
    {
        Console.WriteLine("\nPressione Enter para continuar...");
        Console.ReadLine();
    }
} while (opcao != 0);
