//aula 205
Console.WriteLine("Stream - Bloco Using\n");

string caminhoArquivo = @"c:\dados\poesia.txt";

try
{
    //using FileStream fs = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read);
    using StreamReader leitor = File.OpenText(caminhoArquivo);//new StreamReader(fs);

    string? linha;
    while ((linha = leitor.ReadLine()) != null)
    {
        Console.WriteLine(linha);
    }
}
catch (IOException ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadKey();
