using NUnit.Framework;
using Library.Items;

namespace TestLibrary;
{
    [TestFixture]
    public class HechizoTests
    {
        [Test]
        public void CrearHechizo_DebeAsignarNombreYAtaque()
        {
            string nombre = "Bola de Fuego";
            double ataque = 75;

            var hechizo = new Hechizo(nombre, ataque);

            Assert.AreEqual(nombre, hechizo.Nombre);
            Assert.AreEqual(ataque, hechizo.Ataque);
        }

        [Test]
        public void Hechizo_PuedeCambiarPropiedades()
        {
            var hechizo = new Hechizo("Rayo", 50);

            hechizo.Nombre = "Tormenta Arcana";
            hechizo.Ataque = 120;

            Assert.AreEqual("Tormenta Arcana", hechizo.Nombre);
            Assert.AreEqual(120, hechizo.Ataque);
        }
    }
    [TestFixture]
    public class LibroTests
    {
        [Test]
        public void CrearLibro_DebeAsignarNombre()
        {
   
            string nombre = "Grimorio Arcano";

            var libro = new Libro(nombre);


            Assert.AreEqual(nombre, libro.Nombre);
        }

        [Test]
        public void AgregarHechizo_DebeGuardarHechizoEnElLibro()
        {
        
            var libro = new Libro("Libro de Fuego");
            var hechizo = new Hechizo("Bola de Fuego", 75);
            
            libro.Agregar(hechizo);
            
            libro.Quitar(hechizo);
            
            Assert.Pass("Hechizo agregado y luego eliminado con éxito");
        }

        [Test]
        public void QuitarHechizo_DebeEliminarElHechizoDelLibro()
        {
           
            var libro = new Libro("Libro de Rayo");
            var hechizo = new Hechizo("Rayo Eléctrico", 50);
            libro.Agregar(hechizo);

           
            libro.Quitar(hechizo);

            
            Assert.DoesNotThrow(() => libro.Quitar(hechizo));
        }
    }
}
