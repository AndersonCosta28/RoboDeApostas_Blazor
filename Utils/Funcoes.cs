namespace RoboDeApostas.Utils;
public static class Funcoes
{
    public static void RecriarPasta(string nomeDaPasta)
    {
        if (Directory.Exists(nomeDaPasta))
            Directory.Delete(nomeDaPasta, true);
        Directory.CreateDirectory(nomeDaPasta);
    }
}