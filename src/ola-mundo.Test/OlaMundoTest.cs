using ola_mundo;
using System.IO;
using System;
using FluentAssertions;
using Xunit;

namespace ola_mundo.Test;

public class OlaMundoTest
{
    [Theory(DisplayName = "Deve exibir Olá, Mundo!")]
    [InlineData("Olá, Mundo!")]
    public void TestOlaMundo(string Expected)
    {
    var newOutput = new StringWriter();
    
    Console.SetOut(newOutput);

    HelloWorld.Main();

    string result = newOutput.ToString().Trim();

    result.Should().Be(Expected);
  }
}