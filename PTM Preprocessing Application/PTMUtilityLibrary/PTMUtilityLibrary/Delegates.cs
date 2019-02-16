
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PTMUtilityLibrary
{

    public delegate void RowUnderEvaluationHandler(object sender, RowUnderEvaluationEventArgs e);

    public class RowUnderEvaluationEventArgs : EventArgs
    {
        internal DataRow rowUnderEvaluation;
        internal int rowIndex;
        internal string progressStatusMessage;

        public DataRow RowUnderEvaluation
        {
            get
            {
                return rowUnderEvaluation;
            }
        }

        public int RowIndex
        {
            get
            {
                return rowIndex;
            }
        }

        public string ProgressStatusMessage
        {
            get {
                return progressStatusMessage;
            }
        }
    }

}