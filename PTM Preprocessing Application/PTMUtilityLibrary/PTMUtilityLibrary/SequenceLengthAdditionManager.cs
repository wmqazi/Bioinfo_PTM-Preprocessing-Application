using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PTMUtilityLibrary
{
    
    public class SequenceLengthAdditionManager
    {
        public event RowUnderEvaluationHandler RowUnderEvaluation;

        private DataTable dataTable;
        private string nameOfSequenceField;
        private RowUnderEvaluationEventArgs eventArgs;
        private bool cancel;

        public SequenceLengthAdditionManager(DataTable dataTable, string nameOfSequenceField)
        {
            this.dataTable = dataTable;
            this.nameOfSequenceField = nameOfSequenceField;
            eventArgs = new RowUnderEvaluationEventArgs();
        }

        public void Cancel()
        {
            cancel = true;
        }
        
        public void Run()
        {
            if (dataTable.Columns.Contains("SequenceLength") == false)
                dataTable.Columns.Add("SequenceLength");
            else
                throw new Exception("SequenceLength feild already exist in data table");
            
            
            int totalRows = dataTable.Rows.Count;
            int index;
            
            DataRow row;
            
            for (index = 0; index < totalRows; index++)
            {
                if (cancel == true)
                    index = totalRows;
                else
                {
                    row = dataTable.Rows[index];
                    eventArgs.rowIndex = index;
                    eventArgs.rowUnderEvaluation = row;
                    eventArgs.progressStatusMessage = "Inserting sequence length information...";
                    RowUnderEvaluation(this, eventArgs);

                    row["SequenceLength"] = row[nameOfSequenceField].ToString().Length;
                }

            }
        }
    }
}
