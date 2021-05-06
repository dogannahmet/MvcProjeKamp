using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.CategoryName).NotEmpty().WithMessage("İsim alanı boş bırakılamaz.");
            RuleFor(c => c.CategoryName).MinimumLength(3).WithMessage("İsim alanı en az üç karakterden oluşmalıdır.");
            RuleFor(c => c.CategoryName).MaximumLength(10).WithMessage("İsim alanı en fazla on karakterden oluşmalıdır.");
            RuleFor(c => c.CategoryDescription).NotEmpty().WithMessage("Açıklama alanı boş bırakılamaz");
        }
    }
}
