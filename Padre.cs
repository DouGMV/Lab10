namespace Lab10
{
    public class Padre
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Direccion {  get; set; }
        public DateTime FechaNacimiento { get; set; }

        protected int Carne {  get; set; }
        protected int Notas { get; set; }

        public Padre()
        {

        }

        public int Edad()
        {
            TimeSpan edad = FechaNacimiento - DateTime.Now;
            return Convert.ToInt16(edad.TotalDays / 365);
        }
    }
}
