// See https://aka.ms/new-console-template for more information
namespace _ReservaSalaEstudo.Modelos;
using System.Reflection.Metadata;

public class Reserva
{
    public DateTime Data;
    public TimeSpan Hora;
    public string Descricao;
    public int CapacidadeSala;

    
       public List<string> ErrosDeValidacao = [];

    public Reserva(DateTime dataReserva, TimeSpan horaReserva, int capacidadeSala, string descricaoReserva, ConfiguracaoReserva configuracao) {
            Descricao = descricaoReserva;
            
            if (!ValidarReserva(dataReserva,horaReserva,capacidadeSala,configuracao)) {
                throw new ArgumentException(string.Join("\n", ErrosDeValidacao));
            }
            else
            {
              Data = dataReserva;
              Hora = horaReserva;
              CapacidadeSala = capacidadeSala;
              Descricao = descricaoReserva;
            }


            // if (ValidarCompromisso(dataCompromisso, horaCompromisso)) {
            //     RegistrarData(dataCompromisso);
            //     RegistrarHora(horaCompromisso);
            // } else {
            //     throw new ArgumentException($"Data e/ou Hora informadas, "+
            //      $"inválidas.\nData mínima: {_dataMinima}\nData máxima: "+
            //      $"{_dataMaxima}\nHora mínima {_horaMinima}\nHora máxima: {_horaMaxima}");
            // }
    }
    /*
    public void  RegistrarData (DateTime data) {
        if (data < _dataMinima) {
            throw new ArgumentException($"A data {data.ToString("dd/MM/yyyy")} precisa ser no mínimo {_dataMinima.ToString("dd/MM/yyyy")}\n");
        }
        if (data > _dataMaxima) {
            throw new ArgumentException($"A data {data.ToString("dd/MM/yyyy")} precisa ser no máximo {_dataMaxima.ToString("dd/MM/yyyy")}\n");
        }

        _data = data;
    }

    public void RegistrarHora(TimeSpan hora) {
        if (hora < _horaMinima) {
            throw new ArgumentException($"Hora {hora} deve ser no mínimo {_horaMinima}");
        }
        if (hora > _horaMaxima) {
            throw new ArgumentException($"Hora {hora} deve ser no máximo {_horaMaxima}");
        }

        _hora = hora;
    }
*/
    public bool ValidarReserva(DateTime Data, TimeSpan Hora, int CapacidadeSala, ConfiguracaoReserva configuracao) {
        if (Data < configuracao.DataMinima || Data > configuracao.DataMaxima) {
             ErrosDeValidacao.Add($"A data {Data.ToString("dd/MM/yyyy")} precisa ser entre {configuracao.DataMinima.ToString("dd/MM/yyyy")} e {configuracao.DataMaxima.ToString("dd/MM/yyyy")}");
        }
        if (Hora < configuracao.HoraMinima || Hora > configuracao.HoraMaxima ) {
             ErrosDeValidacao.Add($"A hora da reserva deve estar entre {configuracao.HoraMinima:hh\\:mm} e {configuracao.HoraMaxima:hh\\:mm}");
        }
        if (CapacidadeSala < 1 || CapacidadeSala > 39) {
             ErrosDeValidacao.Add($"A capacidade deve estar entre 1 a 39");
        }

        return ErrosDeValidacao.Count == 0;


        // bool dataValida = false;
        // bool horaValida = false;

        // if (data >= _dataMinima && data <= _dataMaxima) {
        //      dataValida = true;
        // }
        
        // if (hora >= _horaMinima && hora <= _horaMaxima) {
        //     horaValida = true;
        // }

        // return (dataValida && horaValida);
    }

    public override string ToString()
    {
        return $"Data da Reserva: {Data.ToString("dd/MM/yyyy")}\nHora: {Hora:hh\\:mm}\nCapacidade da Sala: {CapacidadeSala}\nDescrição: {Descricao}\n";
    }
}
