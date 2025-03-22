String textoDigitado;
String respostaDigitada;

Console.WriteLine("Texto a ser traduzido...");
textoDigitado = Console.ReadLine();
textoDigitado = textoDigitado.Replace("A", "4")
                             .Replace("E","3")
                             .Replace("I", "1")
                             .Replace("O", "0")
                             .Replace("T", "7")
                             .Replace("S", "5")
                             .Replace("a", "4")
                             .Replace("e","3")
                             .Replace("i", "1")
                             .Replace("o", "0")
                             .Replace("t", "7")
                             .Replace("s", "5");
 Console.WriteLine($"{textoDigitado}!");

