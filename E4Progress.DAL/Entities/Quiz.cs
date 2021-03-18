using System;

namespace E4Progress.DAL.Entities
{
    public class Quiz
    {
        public int Id   { get; set; }
        public int Office_Application_Id { get; set; }
        public int Instruction_Language_Id { get; set; }
        public int Userinterface_Language_Id { get; set; }
        public string Title { get; set; }
        public string Short_Intro { get; set; }
        public string Intro { get; set; }
        public TimeSpan Default_Time_Limit  { get; set; }
        public decimal Default_Minimum_Score { get; set; }
        public string Identification_Code { get; set; }
        public DateTime Creation_Timestamp { get; set; }
        public Guid ReplicationKey { get; set; }
    }
}
