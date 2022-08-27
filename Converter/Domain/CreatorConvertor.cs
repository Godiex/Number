namespace Converter.Domain;

public class CreatorConvertor
{
    public static NumberConverter CreateStatusConvertor(NumberType numberType) => numberType switch
    {
        NumberType.Roman => new RomanNumeralConverter(),
        _ => throw new ArgumentOutOfRangeException(nameof(numberType), numberType, null)
    };
}
