using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PTMUtilityLibrary
{
    public class ProteinInfoExtractionManager
    {
        private DataTable dtPTM;
        private string pidFeildName;
        private string sequenceFeildName;
        private string sequenceLengthFeildName;

        private RowUnderEvaluationEventArgs eventArgs;
        private List<string> CollectionOfPIDs_WithInConsistentInfo;
        private DataTable dtProtein;
        private bool cancel;

        public event RowUnderEvaluationHandler RowUnderEvaluation;
        public ProteinInfoExtractionManager(DataTable dtPTM, string pidFeildName, string sequenceFeildName, string sequenceLengthFeildName)
        {
            this.dtPTM = dtPTM;
            this.pidFeildName = pidFeildName;
            this.sequenceFeildName = sequenceFeildName;
            this.sequenceLengthFeildName = sequenceLengthFeildName;
            CollectionOfPIDs_WithInConsistentInfo = new List<string>();
            dtProtein = new DataTable("ProteinDataTable");
            dtProtein.Columns.Add(pidFeildName);
            dtProtein.Columns.Add(sequenceFeildName);
            dtProtein.Columns.Add(sequenceLengthFeildName);

            eventArgs = new RowUnderEvaluationEventArgs();
            
        }

        public void Run()
        {
            cancel = false;
            List<string> ProcessedPID = new List<string>();

            int totalRows = dtPTM.Rows.Count;
            int index;

            DataRow row;
            DataRow[] rowArray;
            DataRow newRow;
            
            string sequence;
            //int sequenceLength;
            string pid;
            int j,k;

            string tempSequence;
            bool proteinWithThisPIDIsFaulty;

            eventArgs.progressStatusMessage = "Performing protein sequence information consistency check...";
            for (index = 0; index < totalRows; index++)
            {
                if (cancel == true)
                    index = totalRows;
                else
                {
                    row = dtPTM.Rows[index];
                    eventArgs.rowIndex = index;
                    eventArgs.rowUnderEvaluation = row;
                    RowUnderEvaluation(this, eventArgs);

                    pid = row[pidFeildName].ToString();
                    rowArray = dtPTM.Select(pidFeildName + " ='" + pid + "'");

                    proteinWithThisPIDIsFaulty = false;
                    if (ProcessedPID.Contains(pid) == false)
                    {
                        ProcessedPID.Add(pid);

                        for (j = 0; j < rowArray.GetLength(0); j++)
                        {
                            if (cancel == true)
                                j = rowArray.GetLength(0);
                            else
                            {
                                sequence = rowArray[j].ToString();
                                for (k = 0; k < rowArray.GetLength(0); k++)
                                {
                                    if (cancel == true)
                                        k = rowArray.GetLength(0);
                                    else
                                    {
                                        if (j != k)
                                        {
                                            tempSequence = rowArray[k].ToString();
                                            if (sequence.Equals(tempSequence) == false)
                                            {
                                                proteinWithThisPIDIsFaulty = true;
                                                CollectionOfPIDs_WithInConsistentInfo.Add(pid);
                                            }
                                        }
                                        if (proteinWithThisPIDIsFaulty == true)
                                        {
                                            //break internal loop
                                            k = rowArray.GetLength(0);
                                        }
                                    }
                                }
                                if (proteinWithThisPIDIsFaulty == true)
                                {
                                    //break external loop
                                    j = rowArray.GetLength(0);
                                }
                            }
                        }
                    }
                }
                
            }

            eventArgs.progressStatusMessage = "Generating protein data table...";
            ProcessedPID.Clear();
            ProcessedPID = null;
            ProcessedPID = new List<string>();
            
            for (index = 0; index < totalRows; index++)
            {
                if (cancel == true)
                    index = totalRows;
                else
                {
                    row = dtPTM.Rows[index];
                    eventArgs.rowIndex = index;
                    eventArgs.rowUnderEvaluation = row;
                    RowUnderEvaluation(this, eventArgs);

                    pid = row[pidFeildName].ToString();
                    if (ProcessedPID.Contains(pid) == false)
                    {
                        if (CollectionOfPIDs_WithInConsistentInfo.Contains(pid) == false)
                        {
                            newRow = dtProtein.NewRow();
                            newRow[pidFeildName] = pid;
                            newRow[sequenceFeildName] = row[sequenceFeildName].ToString();
                            newRow[sequenceLengthFeildName] = row[sequenceLengthFeildName].ToString();
                            dtProtein.Rows.Add(newRow);
                        }
                    }
                }
            }


        }
        
        public void Cancel()
        {
            cancel = true;
        }

        public DataTable ProteinDataTable
        {
            get {
                return dtProtein;
            }
        }

        public List<string> ProteinsWithInConsistencyInSequenceInformation
        {
            get {
                return CollectionOfPIDs_WithInConsistentInfo;
            }        
        }

    }
}
