using System;

namespace E4Progress.DAL.Entities
{
    public class Question_History
    {
        public string Question_ReplicationKey { get; set; }
        public string Action { get; set; }
        public DateTime Action_Timestamp { get; set; }
        public int Action_Done_By_User_Id { get; set; }
        public int Question_Type_Id { get; set; }
        public bool Is_Master_Question { get; set; }
        public int Master_Question_Id { get; set; }
        public int Instruction_Language_Id { get; set; }
        public int UserInterface_Language_Id { get; set; }
        public int Question_Formulation_Type_Id { get; set; }
        public int Office_Application_Id { get; set; }
        public string Title { get; set; }
        public string QuestionText { get; set; }
        public string Notes { get; set; }
        public int Version_Number { get; set; }
    }
}
