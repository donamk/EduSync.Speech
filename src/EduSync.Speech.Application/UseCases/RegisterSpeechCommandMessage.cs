using EduSync.Speech.Application.Interfaces;

namespace EduSync.Speech.Application.UseCases
{
    public class RegisterSpeechCommandMessage : ICommand
    {
        public string Titile { get; }
        public string Description { get; }
        public string Url { get; }
        public string Type { get; }

        public RegisterSpeechCommandMessage(string titile, string description, string url, string type)
        {
            Titile = titile;
            Description = description;
            Url = url;
            Type = type;
        }
    }
}