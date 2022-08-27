namespace Converter.Domain;

public class CreatorConvertor
{
    public static NumberConverter CreateStatusConvertor(NumberType numberType) => numberType switch
    {
        NumberType.Arabic => new RomanNumeralConverter(),
        _ => throw new ArgumentOutOfRangeException(nameof(numberType), numberType, null)
    };
}
