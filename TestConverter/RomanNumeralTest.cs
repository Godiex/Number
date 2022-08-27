using System;
using Converter.Domain;
using Converter.Exception;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1;

[TestClass]
public class RomanNumeralTest
{
    private NumberConverter RomanNumeralConverter { get; set; } = null!;

    [TestMethod]
    public void GivenThatTheyEnterASingleRomanNumeral(string value)
    {
        RomanNumeralConverter = new RomanNumeralConverter();
        var valueConverted = RomanNumeralConverter.Convert("V");
        Assert.AreEqual("5", valueConverted);
    }
    
    [TestMethod]
    public void GivenThatANumberIsEnteredToTheRightOfAnotherAndItsValueIsLessThanOrEqualToTheirValuesMustBeAdded()
    {
        RomanNumeralConverter = new RomanNumeralConverter();
        var valueConverted = RomanNumeralConverter.Convert("CLXVIII");
        Assert.AreEqual("168", valueConverted);
    }
    
    [TestMethod]
    public void GivenThatANumberIsEnteredToTheLeftOfAnotherAndItsValueIsLessThanTheValueThatPrecedesItMustBeSubtracted()
    {
        RomanNumeralConverter = new RomanNumeralConverter();
        var valueConverted = RomanNumeralConverter.Convert("LIX");
        Assert.AreNotEqual("59", valueConverted);
    }
    
    [TestMethod]
    public void FailedWhenNumberThatIsEnteredNotIsRomanNumeral()
    {
        try
        {
            RomanNumeralConverter = new RomanNumeralConverter(); 
            RomanNumeralConverter.Convert("XB");
        }
        catch (Exception ex)
        {
            Assert.IsTrue(ex is NotNumeralRomanException);
        }
    }
    
    [TestMethod]
    public void FailedWhenNumberThatIsEnteredNotIsValid()
    {
        try
        {
            RomanNumeralConverter = new RomanNumeralConverter(); 
            RomanNumeralConverter.Convert("XLL");
        }
        catch (Exception ex)
        {
            Assert.IsTrue(ex is InvalidNumeralRomanException);
        }
    }
}