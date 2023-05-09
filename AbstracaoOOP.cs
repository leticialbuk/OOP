namespace TestesOOP
{
    public class Garrafa
    {
        //Segundo pilar de OOP
        //Aqui oucultamos o Total com o 'private'
        private int Total = 0;

        public int Altura { get; set; }
        public int Largura { get; set; }
        public int Capacidade { get; set; }

        public void Abrir() { }
        public void Fechar() { }

        private void Encher()
        {
            while (Total < Capacidade)
                Total++;
        }
    }
}