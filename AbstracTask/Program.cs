using AbstracTask.Models;

namespace AbstracTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Car masin=new Car( 3 ,false,"MerBMW","niva","qirmizi",2,200);
            
           
            masin.GetInfo();

            Bicycle velsiped = new Bicycle("aftos","Trek","Ab106","red",1,30);

            velsiped.GetInfo();
            velsiped.DefineNatureHarmness();
        }
    }
}
