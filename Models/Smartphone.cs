namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public string Numero { get; set; }

        private string _modelo;
        public string Modelo
        {
            get => _modelo;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Modelo não pode ser vazio ou nulo.");
                _modelo = value;
            }
        }

        private string _imei;
        public string IMEI
        {
            get => _imei;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("IMEI não pode ser vazio ou nulo.");
                _imei = value;
            }
        }

        private int _memoria;
        public int Memoria
        {
            get => _memoria;
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Memória deve ser maior que zero.");
                _memoria = value;
            }
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}