namespace Ucu.Poo.TestDateFormat
{
    /// <summary>
    /// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
    /// </summary>
    public class DateFormatter
    {

        /// <summary>
        /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
        /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
        /// asumido.
        /// </summary>
        /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
        /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
        public static string ChangeFormat(string date)
        {
            if (string.IsNullOrEmpty(date))
                return string.Empty;

            if (!IsValidDateFormat(date))
                throw new ArgumentOutOfRangeException(nameof(date), "Formato de fecha incorrecto");

            return date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
        }

        // Método auxiliar para verificar si el formato de fecha es válido
        private static bool IsValidDateFormat(string date)
        {
            // Se asume que el formato válido es "dd/mm/yyyy"
            if (date.Length != 10)
                return false;

            if (date[2] != '/' || date[5] != '/')
                return false;

            if (!int.TryParse(date.Substring(0, 2), out int day) ||
                !int.TryParse(date.Substring(3, 2), out int month) ||
                !int.TryParse(date.Substring(6, 4), out int year))
                return false;

            if (day < 1 || day > 31 || month < 1 || month > 12)
                return false;

            // Puedes agregar más validaciones si lo deseas, como verificar años bisiestos, etc.

            return true;
        }
    }
}