using RoboDeApostas.Models.CasasDeAposta.BetanoAPI;
using System.Text;
namespace RoboDeApostas.Utils;
public static class Extensao
{
    public static string RemoverAcentuacao(this string text)
    {
        return new string(text
            .Normalize(NormalizationForm.FormD)
            .Where(ch => char.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
            .ToArray());
    }
}
