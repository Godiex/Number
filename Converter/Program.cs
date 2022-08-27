using Converter.Domain;
using Converter.Exception;

try
{
    var numberConverter = CreatorConvertor.CreateStatusConvertor(NumberType.Roman);
    Console.WriteLine($"la conversion a numero arabigo es: {numberConverter.Convert("civ")}");
}
catch (AppException appException)
{
    Console.WriteLine(appException.Message);
}