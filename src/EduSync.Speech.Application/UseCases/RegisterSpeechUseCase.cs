using System;
using System.Threading.Tasks;
using EduSync.Speech.Application.Exceptions;
using EduSync.Speech.Application.Interfaces;
using EduSync.Speech.Domain.Repository;
using EduSync.Speech.Domain.SpeechAggregate;

namespace EduSync.Speech.Application.UseCases
{
    public class RegisterSpeechUseCase : IRegisterSpeechUseCase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISpeechRepository _speechRepository;

        public RegisterSpeechUseCase(IUnitOfWork unitOfWork, ISpeechRepository speechRepository)
        {
            _unitOfWork = unitOfWork;
            _speechRepository = speechRepository;
        }

        public async Task Handle(RegisterSpeechCommandMessage message)
        {
            if (message == null)
            {
                throw new ArgumentNullApplicationException(nameof(message));
            }

            var title = message.Titile;
            var url = message.Url;
            var description = message.Description;
            var type = message.Type;

            var speech = new Domain.SpeechAggregate.Speech(title, url, description, type);
            await _speechRepository.CreateAsync(speech);
            _unitOfWork.Commit();
        }
    }

    public interface IRegisterSpeechUseCase : ICommandHandler<RegisterSpeechCommandMessage>
    {
    }
}