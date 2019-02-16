using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PTMUtilityLibrary
{
    public class DuplicateSearchManager
    {
        public event RowUnderEvaluationHandler RowUnderEvaluation;

        private DataTable dt;
        private List<string> columnNames;

        private RowUnderEvaluationEventArgs eventArgs;
        private bool cancel;
        private Dictionary<DataRow, int> DuplicateEntriesInfo;

        public DuplicateSearchManager(DataTable dt, List<string> columnList)
        {
            this.dt = dt;
            columnNames = columnList;
            eventArgs = new RowUnderEvaluationEventArgs();
        }

        public void Cancel()
        {
            cancel = true;
        }

        public Dictionary<DataRow, int> DuplicateEntriesList
        {
            get {
                return this.DuplicateEntriesInfo;
            }
        }

        public void Run()
        {
            int totalRows = dt.Rows.Count;
            int index;

            DataRow row;
            string criteria;
            int noOfDuplicateRows;
            DuplicateEntriesInfo = new Dictionary<DataRow,int>();
            eventArgs.progressStatusMessage = "Searching duplicate entries...";
            for (index = 0; index < totalRows; index++)
            {
                criteria = null;
                if (cancel == true)
                    index = totalRows;
                else
                {
                    row = dt.Rows[index];
                    eventArgs.rowIndex = index;
                    eventArgs.rowUnderEvaluation = row;
                    RowUnderEvaluation(this, eventArgs);
                    criteria = GetCriteria(row);
                    noOfDuplicateRows = dt.Select(criteria).GetLength(0);
                    if (noOfDuplicateRows > 1)
                        DuplicateEntriesInfo.Add(row, noOfDuplicateRows);
                }

            }
        }
        private string GetCriteria(DataRow row)
        {
            string c = "";
            int index;
            string col = "";
            for(index = 0; index < columnNames.Count; index++)
            {
                col = columnNames[index];
                c = c + col + "='" + row[col].ToString() + "'";
                if (index < columnNames.Count-1)
                    c = c + " And ";
            }
            return c;
        }

    }
}
