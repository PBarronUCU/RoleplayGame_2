using Library.Characters;
using Library.Items;
using NUnit.Framework;

/// <summary>
/// Tests para la clase <see cref="Elfo"/>.
/// </summary>
namespace LibraryTests
{
    public class ElfoTest
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Prueba que un Elfo atacando a otro reduzca correctamente la vida del enemigo
        /// teniendo en cuenta el ataque del arma y la defensa de la armadura.
        /// </summary>
        [Test]
        public void ElfoAtacaAOtro_ConSwordYArmor()
        {
            // Arrange
            Elfo atacante = new Elfo("Legolas");
            Elfo defensor = new Elfo("Thranduil");

            // El atacante tiene una espada con ataque = 40
            Item sword = new Item("Sword", 40, 0);
            atacante.AgregarItem(sword);

            // El defensor tiene una armadura con defensa = 20
            Item armor = new Item("Armor", 0, 20);
            defensor.AgregarItem(armor);

            double vidaInicial = defensor.Vida;

            // Act
            atacante.Atacar(defensor);

            // Daño esperado = 40 (ataque) - 20 (defensa) = 20
            double vidaEsperada = vidaInicial - 20;

            // Assert
            Assert.AreEqual(vidaEsperada, defensor.Vida,
                $"La vida del defensor debería ser {vidaEsperada} luego del ataque.");
        }

        /// <summary>
        /// Prueba que un Elfo pueda curar a otro y restaurar su vida a 100.
        /// </summary>
        [Test]
        public void ElfoCuraAOtro_RecuperaVidaCompleta()
        {
            // Arrange
            Elfo curador = new Elfo("Elrond");
            Elfo herido = new Elfo("Galadriel");
            herido.Vida = 45;

            // Act
            curador.Curar(herido);

            // Assert
            Assert.AreEqual(100, herido.Vida,
                "El Elfo curado debería tener la vida completamente restaurada a 100.");
        }

        /// <summary>
        /// Prueba que un Elfo pueda curarse a sí mismo correctamente.
        /// </summary>
        [Test]
        public void ElfoSeCuraASiMismo()
        {
            // Arrange
            Elfo elfo = new Elfo("Legolas");
            elfo.Vida = 30;

            // Act
            elfo.Curar(elfo);

            // Assert
            Assert.AreEqual(100, elfo.Vida,
                "El Elfo debería recuperar toda su vida al curarse a sí mismo.");
        }
    }
}
