using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalvarArquivo;
internal class Init {
        
    public void Render() {
        Console.WriteLine("Renderizando...");

        string file = @"C:\Users\Develop\Desktop\estudo\.NET\Curso\SalvarArquivoTeste\SalvarArquivoTeste\src\arquivo\arquivo.txt";
        string directory = @"C:\Users\Develop\Desktop\estudo\.NET\Curso\SalvarArquivoTeste\SalvarArquivoTeste\src\";

        try {
            SaveFileToServer(file, directory);
            Console.WriteLine("Arquivo salvo com sucesso.");
        } catch (Exception ex) {
            Console.WriteLine($"Erro ao salvar o arquivo: {ex.Message}");
        }
    }

    public static void SaveFileToServer(string filePath, string destinationDirectory) {
        if (!File.Exists(filePath)) {
            throw new FileNotFoundException("O arquivo especificado não foi encontrado.");
        }

        if (!Directory.Exists(destinationDirectory)) {
            Directory.CreateDirectory(destinationDirectory);
        }

        string fileName = Path.GetFileName(filePath);
        string destinationPath = Path.Combine(destinationDirectory, fileName);

        File.Copy(filePath, destinationPath, overwrite: true);
    }


}

