// Escreva um programa que inverta os caracteres de um string.
//IMPORTANTE:
//a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
//b) Evite usar funções prontas, como, por exemplo, reverse;

using System;

class Program {
    static void Main(string[] args) {
        // Definindo a string a ser invertida
        string str = "Hello, world!";

        // Convertendo a string para um array de caracteres
        char[] chars = str.ToCharArray();

        // Invertendo os caracteres do array
        for (int i = 0, j = chars.Length - 1; i < j; i++, j--) {
            char temp = chars[i];
            chars[i] = chars[j];
            chars[j] = temp;
        }

        // Convertendo o array de volta para uma string
        string reversedStr = new string(chars);

        Console.WriteLine(reversedStr); // Output: !dlrow ,olleH
    }
}
