namespace rabbit
{
    public class ColumnInfo
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string DataType { get; set; }
        public int MaxLength { get; set; }
        public bool IsNullable { get; set; }
        public bool IsRowGuidCol { get; set; }
        public bool IsIdentity { get; set; }
        public bool IsComputed { get; set; }
    }
}
