//aula 200
Console.WriteLine("Directory e DirectoryInfo I");
var caminhoDiretorio = @"c:\dados\MeuDiretorio";
//var caminhoDiretorio = @"c:\dados"; //mostra os diretórios existentes
string caminhoDestino = @"c:\dados\MeuDiretorioNovo";

Console.WriteLine("\nRenomeando um diretório");
//Console.WriteLine("\nCriando diretório");
try
{
    Directory.CreateDirectory(caminhoDiretorio);

    if (Directory.Exists(caminhoDiretorio))
    {
        Directory.Move(caminhoDiretorio, caminhoDestino);
        Console.WriteLine("Diretório renomeado com sucesso!");
        Console.WriteLine($"Diretório {caminhoDiretorio} já existe");
    }
    //Forma de excluir um diretório
    //if (Directory.Exists(caminhoDiretorio))
    //{
    //    Directory.Delete(caminhoDiretorio, true);
    //    Console.WriteLine($"Diretório {caminhoDiretorio} excluido com sucesso");
    //}

    //obtendo subdiretórios de um diretório
    //if (Directory.Exists(caminhoDiretorio))
    //{
    //    string[] subdiretorios = Directory.GetDirectories(caminhoDiretorio);
    //    foreach (var subdr in subdiretorios)
    //        Console.WriteLine(subdr);
    //}

    //obtendo arqs de um diretório
    //if (Directory.Exists(caminhoDiretorio))
    //{
    //    string[] arquivos = Directory.GetFiles(caminhoDiretorio, "p*");
    //    foreach (var subdr in arquivos)
    //        Console.WriteLine(subdr);
    //}
    else
    {
        Console.WriteLine($"O diretório {caminhoDiretorio} não existe!");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    //Console.WriteLine(ex.StackTrace);
}

Console.ReadKey();