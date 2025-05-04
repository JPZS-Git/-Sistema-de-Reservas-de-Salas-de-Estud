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

ConfiguracaoReserva configuracaoReserva = null!;
try {
    configuracaoReserva = new ConfiguracaoReserva((DateTime)dataMinima,(DateTime)dataMaxima,
    (TimeSpan)horaMinima,(TimeSpan)horaMaxima);
    Console.WriteLine("Configuração Armazenada com Sucesso\n");
    Console.WriteLine(configuracaoReserva);

} catch (ArgumentException e) {
    Console.WriteLine(e.Message);
}

if(configuracaoReserva!=null)
{

DateTime? dataReserva = null;
TimeSpan? horaReserva = null;
string descricaoReserva; 
int capacidadeSala;


while(dataReserva == null)
 {
        Console.Write("Informe a Data para a Reserva (dd/MM/yyyy): ");
        var dataDigitada = Console.ReadLine();
        try
        {
            dataReserva = DateTime.ParseExact(dataDigitada, "dd/MM/yyyy", culturaBrasileira);
        }
        catch (FormatException)
        {
            Console.WriteLine($"{dataDigitada} não é uma data válida");
        }
 }

 while(horaReserva==null)
{
        Console.Write("Informe a hora para a reserva (HH:mm): ");
        var horaDigitada = Console.ReadLine();

        try
        {
            horaReserva = TimeSpan.ParseExact(horaDigitada, "hh\\:mm", culturaBrasileira);
        }
        catch (FormatException)
        {
            Console.WriteLine($"{horaDigitada} não é uma hora válida");
        }
}

Console.Write("Informe a Descrição da Reserva: ");
        descricaoReserva = Console.ReadLine();

while(true)
{
string entrada;
Console.Write("Informe a Capacidade da sala: ");
        entrada = Console.ReadLine();
        if(int.TryParse(entrada, out capacidadeSala))
        {      break;     }
        else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro .");
            }
}


try {
    var reserva = new Reserva((DateTime)dataReserva,(TimeSpan)horaReserva, capacidadeSala, descricaoReserva, configuracaoReserva);
    Console.WriteLine("\nReserva feita com Sucesso\n");
    Console.WriteLine(reserva);

} catch (ArgumentException e) {
    Console.WriteLine(e.Message);
}

}