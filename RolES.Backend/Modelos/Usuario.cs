namespace RolES.Backend.Modelos;

public class Usuario
{
    public int Id { get; init; }
    public string Nome { get; set; } = string.Empty;
    public string Senha { get; set; }
}