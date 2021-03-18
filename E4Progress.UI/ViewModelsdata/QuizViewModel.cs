namespace E4Progress.UI.ViewModelsdata
{
    public class QuizViewModel
    {
        public int Id { get; set; }
        public string Office_Application { get; }
        public string Instruction_Language { get; }
        public string Userinterface_Language { get; }
        public string Identification_Code { get; }
        public string Title { get; }
        public int NumberOfQuestions { get; }

        public QuizViewModel(int id, string office_Application, string instruction_Language, string userinterface_Language, string identification_Code, string title, int numberOfQuestions)
        {
            Id = id;
            Office_Application = office_Application;
            Instruction_Language = instruction_Language;
            Userinterface_Language = userinterface_Language;
            Identification_Code = identification_Code;
            Title = title;
            NumberOfQuestions = numberOfQuestions;
        }
    }
}