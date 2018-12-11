namespace NanoORM
{
    public interface IBinding
    {
        string id { get; set; }
        string dbField { get; set; }
        object value { get; set; }
        void SetBinding(string id, string dbField);
    }

    public class Binding : IBinding
    {
        public string id { get; set; }
        public string dbField { get; set; }
        public object value { get; set; }

        public Binding(string id)
        {
            this.id = id;
        }

        public Binding(string id, string dbField)
        {
            SetBinding(id, dbField);
        }

        public void SetBinding(string id, string dbField)
        {
            this.id = id;
            this.dbField = dbField;
        }

        public Binding(string id, string dbField, object value)
        {
            this.id = id;
            this.dbField = dbField;
            this.value = value;
        }
    }
}
