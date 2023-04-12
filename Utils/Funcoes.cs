namespace RoboDeApostas.Utils;
public static class Funcoes
{
    public static void RecriarPasta(string nomeDaPasta)
    {
        if (Directory.Exists(nomeDaPasta))
            Directory.Delete(nomeDaPasta, true);
        Directory.CreateDirectory(nomeDaPasta);
    }

    public static DateTimeOffset ConverterFusoHorario(DateTimeOffset data)
    {        
        TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
        return TimeZoneInfo.ConvertTime((DateTimeOffset)data, timeZone);
    }
}