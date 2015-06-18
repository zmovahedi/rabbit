using System.Collections.Generic;

namespace rabbit
{
    public class TableInfo
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int MaxLength { get; set; }
        public string Schema { get; set; }
        public List<ColumnInfo> Columns { get; set; }
    }
}
