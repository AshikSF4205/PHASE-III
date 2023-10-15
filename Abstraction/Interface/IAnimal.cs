namespace Interface
{
    public interface IAnimal
    {
     public string Name { get; set; }    
     public string Habitat { get; set; }
     public string EatingHabitat { get; set; }

     public void Display();
    }
}