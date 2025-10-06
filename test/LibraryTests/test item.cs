using NUnit.Framework;
using Library.Items;

namespace TestLibrary;
// Aca se crean los items y compruba que funcione bien los indicadores de las estadisticas y nombre
{
    public class ItemTest
    {
        [SetUp]
        public void Setup()
        {
        }
         [Test]
            public void CrearAxe()
            {
                Axe axe = new Axe("Hacha del Guerrero", 50.0);
        
                Assert.AreEqual("Hacha del Guerrero", axe.Nombre);
                Assert.AreEqual(50.0, axe.ValorAtaque);
                Assert.IsInstanceOf<IIAtaqueNoMag>(axe);
            }
        
            [Test]
            public void CrarSword()
            {
                Sword sword = new Sword("Espada de Hierro", 15);
        
                Assert.AreEqual("Espada de Hierro", sword.Nombre);
                Assert.AreEqual(15, sword.ValorAtaque);
                Assert.IsInstanceOf<IIAtaqueNoMag>(sword);   
            }
        
            [Test]
            public void CrearShield()
            {
                Shield shield = new Shield("Escudo de Roble", 30);
        
                Assert.AreEqual("Escudo de Roble", shield.Nombre);
                Assert.AreEqual(30, shield.ValorDefensa);
                Assert.IsInstanceOf<IIDefensaNoMag>(shield);
            }
        
            [Test]
            public void CrearArmor()
            {
                Armor armor = new Armor("Armadura de Acero", 40);
        
                Assert.AreEqual("Armadura de Acero", armor.Nombre);
                Assert.AreEqual(40, armor.ValorDefensa);
                Assert.IsInstanceOf<IIDefensaNoMag>(armor);
            }
        
            [Test]
            public void CrarStaff()
            {
                Staff staff = new Staff("Bastón de Sabio", 25, 10);
        
                Assert.AreEqual("Bastón de Sabio", staff.Nombre);
                Assert.AreEqual(25, staff.ValorAtaque);
                Assert.AreEqual(10, staff.ValorDefensa);
                Assert.IsInstanceOf<IIAtaqueMag>(staff);
                Assert.IsInstanceOf<IIDefensaMag>(staff);
            }
    }
}
