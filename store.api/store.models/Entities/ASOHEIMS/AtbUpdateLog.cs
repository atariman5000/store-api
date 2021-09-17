using System;
using System.Collections.Generic;

namespace store.models.Entities.ASOHEIMS
{
    public partial class AtbUpdateLog
    {
        public int LogId { get; set; }
        public DateTime? DownLoadDate { get; set; }
        public string DatabaseName { get; set; }
        public string ProcessName { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public int RowCount { get; set; }
        public string UpdateLogDescription { get; set; }
        public string UpdateUser { get; set; }
        public string UpdateInitiative { get; set; }
        public string Source { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
