using System.Text.Json;

var persona = new Persona { Nombre = "Juan", Edad = 30 };

//Serializar a JSON
string json = JsonSerializer.Serialize(persona);
Console.WriteLine(json); // {"Nombre":"Juan","Edad":30}

//De-Serializar desde JSON
Persona deserializada = JsonSerializer.Deserialize<Persona>(json);
Console.WriteLine(deserializada.Nombre + "\n" + deserializada.Edad); // Juan

public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
}