using System;
namespace Laboratorio01
{
    public class Persona
    {
        private string firstName;
        private string lastName;

        public Persona(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public string GetFirstName()
        {
            return firstName;
        }
        public string GetLastName()
        { 
            return lastName;
        }
        public int Lanzar()
        {
            Random aleatorio = new Random();
            int resultado = aleatorio.Next(0, 3);
            return resultado;

        }
    }
}
