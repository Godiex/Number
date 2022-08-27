using Converter.Exception;

namespace Converter.Domain;

public class RomanNumeralConverter : NumberConverter
{
    private const int MinimunValue = 1;
    private int AmountCharacteres { get; set; }
    private int ValueConverted { get; set; }
    private int CurrentValue { get; set; }
    private int NextValue { get; set; }
    private Dictionary<string, string> InvalidValues { get; set; }
    
    public RomanNumeralConverter()
    {
        InvalidValues = new Dictionary<string, string>()
        {
            { "VV", "VV" },
            { "LL", "LL" },
            { "DD", "DD" }
        };
    }
    
    public override string Convert(string value)
    {
        value = value.ToUpper();
        ValidateValue(value);
        AmountCharacteres = value.Length;
        GenerateConversion(value);
        return ValueConverted.ToString();
    }

    private void GenerateConversion(string value)
    {
        for (var i = 0; i < AmountCharacteres; i++)
        {
            var nextIndex = i + 1;
            CurrentValue = GetValueConverted(value[i]);
            NextValue = nextIndex < AmountCharacteres ? GetValueConverted(value[nextIndex]) : MinimunValue;

            if (CurrentValue >= NextValue)
            {
                ValueConverted += CurrentValue;
            }

            if (CurrentValue >= NextValue) continue;
            ValueConverted += NextValue - CurrentValue;
            i++;
        }
    }

    private static int GetValueConverted(char value)
    {
        var valueConverted = value switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => throw new NotNumeralRomanException($"El valor : {value} no es un numero romano valido")
        };
        return valueConverted;
    }

    private void ValidateValue(string value)
    {
        foreach (var entry in InvalidValues)
        {
            _ = value.Contains(entry.Value) ?
                throw new InvalidNumeralRomanException($"el numero romano {value} es invalido") : value.Contains(entry.Value);
        }
    }
}