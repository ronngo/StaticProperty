namespace StaticProperty
{
    public class Car
    {
        private string name;
        private string engine;

        public static int numberOfCars;

        public Car(string name, string engine){
            this.name = name;
            this.engine = engine;
            numberOfCars ++;
        }
         public string GetName()
         {
               return name;
         }

        public void setName(string Name2)
        {
            this.name = Name2;
        }

        public string GetEngine()
         {
               return engine;
         }

        public void setEngine(string Engine2)
        {
            this.engine = Engine2;
        }
       
    }
}