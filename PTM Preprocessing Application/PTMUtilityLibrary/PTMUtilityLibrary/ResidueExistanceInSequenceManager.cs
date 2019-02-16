using System;
using System.Collections.Generic;
using System.Text;
using System.Data;


namespace PTMUtilityLibrary
{
    public class ResidueExistanceInSequenceManager
    {
        private DataTable dataTable;
        private string nameOfSequenceField;
        private string positionFeildName;
        private string aminoAcidFeildName;
        private string sequenceLengthFeildName;
        private string pidFeildName;

        private List<DataRow> CollectionOfRowsWith_PositionNotMemeberOfSequenceLengthSpace;
        private List<string> CollectionOfPIDsWith_PositionNotMemeberOfSequenceLengthSpace;

        private List<DataRow> CollectionOfRowsWith_WrongAminoAcidInfo;
        private List<string> CollectionOfPIDsWith_WrongAminoAcidInfo;
        private RowUnderEvaluationEventArgs eventArgs;

        private bool cancel;
        public event RowUnderEvaluationHandler RowUnderEvaluation;
        

        public ResidueExistanceInSequenceManager(DataTable dataTable, string pidFeildName, string sequenceFeildName, string positionFeildName, string aminoAcidFeildName, string sequenceLengthFeildName)
        {
            this.dataTable = dataTable;
            this.nameOfSequenceField = sequenceFeildName;
            this.positionFeildName = positionFeildName;
            this.aminoAcidFeildName = aminoAcidFeildName;
            this.sequenceLengthFeildName = sequenceLengthFeildName;
            this.pidFeildName = pidFeildName;
            
            CollectionOfPIDsWith_PositionNotMemeberOfSequenceLengthSpace = new List<string>();
            CollectionOfPIDsWith_WrongAminoAcidInfo = new List<string>();
            CollectionOfRowsWith_PositionNotMemeberOfSequenceLengthSpace = new List<DataRow>();
            CollectionOfRowsWith_WrongAminoAcidInfo = new List<DataRow>();

            eventArgs = new RowUnderEvaluationEventArgs();

        }

        public void Cancel()
        {
            cancel = true;
        }

        public void Run()
        {
            cancel = false;
            int totalRows = dataTable.Rows.Count;
            int index;

            DataRow row;
            string aminoacid;
            string sequence;
            int position;
            int sequenceLength;
            string pid;
            string aminoAcidInSequence;

            for (index = 0; index < totalRows; index++)
            {
                if (cancel == true)
                    index = totalRows;
                else
                {
                    row = dataTable.Rows[index];
                    eventArgs.rowIndex = index;
                    eventArgs.rowUnderEvaluation = row;
                    eventArgs.progressStatusMessage = "Performing modified amino acid information consistency check...";
                    RowUnderEvaluation(this, eventArgs);

                    position = int.Parse(row[positionFeildName].ToString());
                    sequenceLength = int.Parse(row[sequenceLengthFeildName].ToString());
                    sequence = row[nameOfSequenceField].ToString();
                    aminoacid = row[aminoAcidFeildName].ToString();
                    pid = row[pidFeildName].ToString();

                    if (position > sequenceLength)
                    {
                        //check wether position is the member of sequence length space
                        CollectionOfPIDsWith_PositionNotMemeberOfSequenceLengthSpace.Add(pid);
                        CollectionOfRowsWith_PositionNotMemeberOfSequenceLengthSpace.Add(row);
                    }
                    else
                    {
                        //check that modified residue mentioned in the data table exist in the sequence at the given position
                        aminoAcidInSequence = sequence[position - 1].ToString();

                        if (aminoAcidInSequence.Equals(aminoacid) == false)
                        {
                            CollectionOfPIDsWith_WrongAminoAcidInfo.Add(pid);
                            CollectionOfRowsWith_WrongAminoAcidInfo.Add(row);
                        }

                    }
                }
            }
        }

        public List<DataRow> RowsWithInconsistencyInPositionInfo
        {
            get
            {
                return CollectionOfRowsWith_PositionNotMemeberOfSequenceLengthSpace;
            }        
        }
        public List<string> ListOfProteinIDWithInconsistencyInPositionInfo
        {
            get
            {
                return CollectionOfPIDsWith_PositionNotMemeberOfSequenceLengthSpace;
            }
        }
        public List<DataRow> RowsWithInconsistencyInAminoAcidInfo
        {
            get
            {
                return CollectionOfRowsWith_WrongAminoAcidInfo;
            }
        }
        public List<string> ListOfProteinIDWithInconsistencyInAminoAcidInfo
        {
            get
            {
                return CollectionOfPIDsWith_WrongAminoAcidInfo;
            }
        }
    }
}
