using Questoes;

Console.WriteLine("Programa elaborado para a questão técnica da Target Sistemas.");
Console.WriteLine("Digite de 1 a 5 para verificar as questões, caso queira encerrar digite 0.");

bool loop = true;

while(loop)
{
    Console.Write("\nSelecione a questão que gostaria de verificar: ");
    int choose = int.Parse(Console.ReadLine());

    switch (choose)
    {
        case 1:
            Questoes.Questoes.Questao1();
            break;
        case 2:
            Questoes.Questoes.Questao2();
            break;
        case 3:
            Questoes.Questoes.Questao3();
            break;
        case 4:
            Questoes.Questoes.Questao4();
            break;
        case 5:
            Questoes.Questoes.Questao5();
            break;
        case 0:
            loop = false;
            break;
        default:
            Console.WriteLine("Selecione uma opção válida.");
            break;
    }
}