namespace foglietta.alice._5i.signup.Models;

public class Prodotto
{
    public NomeP? _NomeP { get; set; }
    public int? quantita { get; set; }
    
    public enum NomeP{
        Raspberry_Pi_Pico,
        Raspberry_Pi_Pico_W,
        Raspberry_RP2040_Zero,
        MacroPad_RP2040
    }

}