namespace foglietta.alice._5i.signup.Models;

public class Prenotazione
{
    public string? Nome { get; set; } required
    public string? Cognome { get; set; } required

    public string? Email { get; set; } required
    public DateTime DataDiNascita { get; set; } required
    public Sesso _Sesso { get; set; } required
    public Ruolo _Ruolo { get; set; }

    //public string? Stampa(){
        //var data = DataDiNascita.ToShortDateString();
        //return "Nome" + Nome + "Cognome" + Cognome + "Email" + Email + "Data di nascita" + data + "Sesso" + Sesso + "Ruolo" + Ruolo; 
    //}
    
    public enum Sesso{
        Maschio,
        Femmina,
        Non_specificato,
    }
        public enum Ruolo{
        Docente,
        Studente,
        Genitore,
    }
}