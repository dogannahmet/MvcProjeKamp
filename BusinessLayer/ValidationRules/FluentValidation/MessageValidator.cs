using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(m => m.Receiver).NotEmpty().WithMessage("Alıcı adresi adresi boş bırakılamaz.");
            RuleFor(m => m.Subject).NotEmpty().WithMessage("Konu boş bırakılamaz.");
            RuleFor(m => m.MessageContent).NotEmpty().WithMessage("Mesaj boş bırakılamaz.");
            RuleFor(m => m.Subject).MinimumLength(3).WithMessage("En az üç karakter girişi yapınız.");
        }
    }
}
