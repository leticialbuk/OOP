namespace TestesOOP
{
    //Quarto pilar de OOP
    //Vemos que a classe pai mantém um método em comum, mas todos os filhos tem sua prórpia especificicade 
    public class Garrafas
    {
        public virtual void Finalidade()
        {
            Console.WriteLine("Garrafas genéricas");
        }
    }

    public class GarrafaTermica : Garrafas
    {
        public override void Finalidade()
        {
            Console.WriteLine("Manter a temperatura");
        }
    }

    public class GarrafaVidro : Garrafas
    {
        public override void Finalidade()
        {
            Console.WriteLine("Manter o sabor");
        }
    }

    public class Barril : Garrafas
    {
        public override void Finalidade()
        {
            Console.WriteLine("Armazenar grandes quantidades");
        }
    }
}