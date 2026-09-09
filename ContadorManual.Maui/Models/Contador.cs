namespace ContadorManual.Maui.Models
{
    public class Contador
    {
        private int _Conteo;

        public int Conteo => _Conteo;

        public Contador() 
        {
            _Conteo = 0;

        }

        public void Contar()
        {
            _Conteo ++;
        }

        public void Reiniciar()
        {
            _Conteo = 0;
        }

       
    }
}
