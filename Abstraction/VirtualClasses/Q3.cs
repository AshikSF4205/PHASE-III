namespace VirtualClasses1
{
    public class Draw
    {
       public Draw(){}
        public virtual void draw(){
            System.Console.WriteLine("Print Line");
        }
    }
    public class DrawPyramid :  Draw{
        DrawPyramid(){}
        public override void draw()
        {
                System.Console.WriteLine("Print Pyramid");
        }

    }
    public class DrawStar :  Draw{
        DrawStar(){}
        public override void draw()
        {
                System.Console.WriteLine("Print Star");
        }
    }
}