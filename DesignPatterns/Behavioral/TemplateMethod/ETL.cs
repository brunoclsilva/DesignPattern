namespace DesignPatterns.Behavioral.TemplateMethod
{
    public abstract class ETL
    {
        public void ImportData(string filename)
        {
            var data = Extract(filename);

            var transformedData = Transform(data);

            Load(transformedData);
        }

        protected abstract string[] Extract(string filename);

        protected virtual string[] Transform(string[] data)
        {
            return data;
        }

        protected abstract void Load(string[] data);
    }
}
