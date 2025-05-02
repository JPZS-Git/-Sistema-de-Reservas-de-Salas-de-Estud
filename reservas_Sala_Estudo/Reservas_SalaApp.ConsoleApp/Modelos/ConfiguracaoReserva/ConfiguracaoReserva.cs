// See https://aka.ms/new-console-template for more information
namespace _ReservaSalaEstudo.Modelos;
using System.Reflection.Metadata;

public class ConfiguracaoReserva
{
    private DateTime _dataMinima;
    private DateTime _dataMaxima;
    private TimeSpan _horaMinima;
    private TimeSpan _horaMaxima;
    private DateTime _dataAtual = DateTime.Today.AddDays(1);

    public DateTime DataMinima { get {
        return _dataMinima;
    }  }
    public DateTime DataMaxima { get {
        return _dataMaxima;
    }  }
    public TimeSpan HoraMinima { get {
        return _horaMinima;
    } }
    public TimeSpan HoraMaxima { get {
        return _horaMaxima;
    } }

    public List<string> ErrosDeValidacao = [];

    public ConfiguracaoReserva(DateTime dataMinima, DateTime dataMaxima,
        TimeSpan horaMinima, TimeSpan horaMaxima) {
           
          _horaMinima = horaMinima;
          if(ValidarConfiguracaoDataHora(dataMinima,dataMaxima,horaMinima,horaMaxima))
          {
            RegistrarDataMinima(dataMinima);
            RegistrarDataMaxima(dataMaxima);
            RegistrarHoraMaxima(horaMaxima);
          }
          else{
            RegistrarDataMinima(dataMinima);
            RegistrarDataMaxima(dataMaxima);
            RegistrarHoraMaxima(horaMaxima);
            //ValidarConfiguracaoDataHora(dataMinima,dataMaxima,horaMinima,horaMaxima);
             //throw new ArgumentException(string.Join("\n", ErrosDeValidacao));
         //throw new ArgumentException($"Data e/ou Hora informadas, "+
                 // $"inválidas.\nData mínima: {_dataMinima.ToString("dd/MM/yyyy")}\nData máxima: "+
                 //$"{_dataMaxima.ToString("dd/MM/yyyy")}\nHora mínima {_horaMinima}\nHora máxima: {_horaMaxima}");
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
    public void  RegistrarDataMinima(DateTime data) {

        if (data < _dataAtual) {
            throw new ArgumentException($"A data Minima {data.ToString("dd/MM/yyyy")}, precisa ser no mínimo {_dataAtual.ToString("dd/MM/yyyy")}\n");
    }
    _dataMinima = data;
    }

    public void  RegistrarDataMaxima(DateTime data) {

        if (data <= _dataMinima) {
            throw new ArgumentException($"A data Máxima {data.ToString("dd/MM/yyyy")}, precisa ser para depois de {_dataMinima.ToString("dd/MM/yyyy")}\n");
    }
    _dataMaxima = data;
    }


    public void  RegistrarHoraMaxima(TimeSpan hora) {

        if (hora <= _horaMinima) {
            throw new ArgumentException($"A Hora Máxima {hora:hh\\:mm}, deve ser acima de {_horaMinima:hh\\:mm}");
    }
    _horaMaxima = hora;
    }



    public bool ValidarConfiguracaoDataHora(DateTime _dataMinima,DateTime _dataMaxima,TimeSpan _horaMinima, TimeSpan _horaMaxima) {
        if (_dataMinima < _dataAtual ) {
             ErrosDeValidacao.Add($"A data {_dataMinima.ToString("dd/MM/yyyy")} precisa ser no mínimo {_dataAtual.ToString("dd/MM/yyyy")}");
        }
        if (_dataMinima > _dataMaxima ) {
             ErrosDeValidacao.Add($"A data {_dataMaxima.ToString("dd/MM/yyyy")} precisa ser no minimo {_dataMinima.ToString("dd/MM/yyyy")}");
        }
        if(_horaMaxima < _horaMinima){
             ErrosDeValidacao.Add($"A hora {_horaMaxima} precisa ser acima de  {_horaMinima}");
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
        return  $"Data Minima: {_dataMinima.ToString("dd/MM/yyyy")}\nData Maxima: {_dataMaxima.ToString("dd/MM/yyyy")}\nHora Minima: {_horaMinima}\nHora Maxima: {_horaMaxima}";
                
    }
}