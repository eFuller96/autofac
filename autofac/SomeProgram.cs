namespace autofac
{
    public class SomeProgram
    {
        public void DoThings()
        {
            var writer = new DataWriter();
            var reader = new DataReader();
            
            writer.Write();
            reader.Read();
        }
    }
}
