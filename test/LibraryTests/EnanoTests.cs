using Library.Characters;
using NUnit.Framework;

namespace LibraryTests;

public class EnanoTests
{
    [Test]
    public void TestProperties()
    {
        const string name = "Nombre";
        Enano nico = new Enano(name);
        
        Assert.Equals(name, nico.Nombre);

        const string anothername = "OtroNombre";
        nico.Nombre = anothername;
        
        Assert.Equals(anothername, nico.Nombre);
    }

    [Test]
    public void TestLife()
    {
        Enano enano = new Enano();
        int initialLife = enano.Vida();
        Assert.Equals(100, initialLife);
    }
}