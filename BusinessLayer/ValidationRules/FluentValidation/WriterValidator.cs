using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(w => w.WriterName).NotEmpty().WithMessage("İsim alanı boş bırakılamaz.");
            RuleFor(w => w.WriterSurname).NotEmpty().WithMessage("İsim alanı boş bırakılamaz.");
            RuleFor(w => w.WriterAbout).NotEmpty().WithMessage("Hakkında alanı boş bırakılamaz.");
            RuleFor(w => w.WriterTitle).NotEmpty().WithMessage("Ünvan alanı boş bırakılamaz.");
            RuleFor(w => w.WriterSurname).MinimumLength(2).WithMessage("İsim alanı en az iki karakterden oluşmalıdır.");
            RuleFor(w => w.WriterSurname).MaximumLength(50).WithMessage("İsim alanı en fazla elli karakterden oluşmalıdır.");
        }
    }
}
