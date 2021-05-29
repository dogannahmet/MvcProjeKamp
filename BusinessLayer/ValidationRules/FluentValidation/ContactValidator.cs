using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(c => c.UserEMail).NotEmpty().WithMessage("Mail adresi boş bırakılamaz.");
            RuleFor(c => c.Subject).NotEmpty().WithMessage("Konu alanı boş bırakılamaz.");
            RuleFor(c => c.Subject).MinimumLength(3).WithMessage("Lüfen en az üç karakter girişi yapın.");
            RuleFor(c => c.UserName).MaximumLength(3).WithMessage("Lüfen en az üç karakter girişi yapın.");
            RuleFor(c => c.UserName).NotEmpty().WithMessage("Kullanıcı adı boş bırakılamaz");
            RuleFor(c => c.Subject).MaximumLength(50).WithMessage("Lüfen en fazla elli karakter girişi yapın.");
        }
    }
}
