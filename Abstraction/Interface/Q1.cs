namespace Interface
{
    public class Q1
    {
        
    }
    class Dog : IAnimal
    {
        public Dog(string name, string habitat, string eatingHabitat)
        {
            Name = name;
            Habitat = habitat;
            EatingHabitat = eatingHabitat;
        }


        public string Name { get ; set ; }
        public string Habitat { get ; set ; }
        public string EatingHabitat { get ; set ; }

        public void Display()
        {
                System.Console.WriteLine("I am Dog");
        }
    }
    class Duck : IAnimal
    {
        public Duck(string name, string habitat, string eatingHabitat)
        {
            Name = name;
            Habitat = habitat;
            EatingHabitat = eatingHabitat;
        }


        public string Name { get ; set ; }
        public string Habitat { get ; set ; }
        public string EatingHabitat { get ; set ; }

        public void Display()
        {
            System.Console.WriteLine("I am Duck");
        }

    }
}