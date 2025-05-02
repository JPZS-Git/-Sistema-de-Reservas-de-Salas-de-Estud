// See https://aka.ms/new-console-template for more information
﻿using System.Globalization;
using _ReservaSalaEstudo.Modelos;

CultureInfo culturaBrasileira = new("pt-BR");

DateTime? dataMaxima = null,dataMinima = null;
TimeSpan? horaMaxima = null,horaMinima = null;

 while(dataMinima == null)
 {
        Console.Write("Informe a data mínima permitida para as reservas (dd/MM/yyyy): ");
        var dataDigitada = Console.ReadLine();

        try
        {
            dataMinima = DateTime.ParseExact(dataDigitada, "dd/MM/yyyy", culturaBrasileira);
        }
        catch (FormatException)
        {
            Console.WriteLine($"{dataDigitada} não é uma data válida");
        }
 }

while(dataMaxima==null)
{
        Console.Write("Informe a data máxima permitida para as reservas (dd/MM/yyyy): ");
        var dataDigitada = Console.ReadLine();

        try
        {
            dataMaxima = DateTime.ParseExact(dataDigitada, "dd/MM/yyyy", culturaBrasileira);
        }
        catch (FormatException)
        {
            Console.WriteLine($"{dataDigitada} não é uma data válida");
        }
}

while(horaMinima==null)
{
        Console.Write("Informe a hora mínima permitida para as reservas (HH:mm): ");
        var horaDigitada = Console.ReadLine();

        try
        {
            horaMinima = TimeSpan.ParseExact(horaDigitada, "hh\\:mm", culturaBrasileira);
        }
        catch (FormatException)
        {
            Console.WriteLine($"{horaDigitada} não é uma hora válida");
        }
}
while(horaMaxima==null)
{
        Console.Write("Informe a hora máxima permitida para as reservas (HH:mm): ");
        var horaDigitada = Console.ReadLine();

        try
        {
            horaMaxima = TimeSpan.ParseExact(horaDigitada, "hh\\:mm", culturaBrasileira);
        }
        catch (FormatException)
        {
            Console.WriteLine($"{horaDigitada} não é uma hora válida");
        }
}

try {
    var configuracaoReserva = new ConfiguracaoReserva((DateTime)dataMinima,(DateTime)dataMaxima,
    (TimeSpan)horaMinima,(TimeSpan)horaMaxima);
    Console.WriteLine("Configuração Armazenada com Sucesso");
    Console.WriteLine(configuracaoReserva);

} catch (ArgumentException e) {
    Console.WriteLine(e.Message);
}
