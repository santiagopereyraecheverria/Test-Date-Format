namespace Library.Tests
{
    public class DateFormatterTests
    {
        [SetUp]
        public void Setup()
        {
            // Configuración común para los casos de prueba
        }

        [Test]
        // Una fecha en formato correcto
        public void ChangeFormat_CorrectFormat_ReturnsExpectedFormat()
        {
            // Arrange
            string inputDate = "17/04/2024";
            string expectedOutput = "2024-04-17";

            // Act
            string actualOutput = Ucu.Poo.TestDateFormat.DateFormatter.ChangeFormat(inputDate);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        //Una fecha que no tenga el formato correcto
        public void ChangeFormat_IncorrectFormat_ReturnsInvalidOutput()
        {
            // Arrange
            string inputDate = "2024-04-17"; // Formato incorrecto

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => Ucu.Poo.TestDateFormat.DateFormatter.ChangeFormat(inputDate));
        }

        [Test]
        // Una Fecha en Blanco
        public void ChangeFormat_BlankInput_ReturnsEmptyString()
        {
            // Arrange
            string inputDate = "";

            // Act
            string actualOutput = Ucu.Poo.TestDateFormat.DateFormatter.ChangeFormat(inputDate);

            // Assert
            Assert.AreEqual(string.Empty, actualOutput);
        }
    }
}