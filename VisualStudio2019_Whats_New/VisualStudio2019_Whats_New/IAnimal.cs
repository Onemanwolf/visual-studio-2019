namespace VisualStudio2019_Whats_New
{
    internal interface IAnimal
    {

        int Legs { get; set;}

        bool Eat(IFood food, System.DateTime time);
    }
}