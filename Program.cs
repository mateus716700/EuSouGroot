Console.Clear();
bool groot = true;
string resposta;
 Console.WriteLine("--- Groot Chatbot ---");
 Console.WriteLine(" caso queira parar o chatbot digite "tchau"");
 
while (groot)
{

    Console.Write($"Pergunta: ");
    resposta = Console.ReadLine()!;


    if (resposta != "tchau")
    {
        Console.WriteLine("Resposta: Eu sou Groot");

    }
    else if (resposta == "tchau")
    {
        Console.WriteLine("Resposta: Eu sou Groot!");

        break;
   }
}