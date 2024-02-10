using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje adı boş geçilemez!");
            RuleFor(x => x.Name).MinimumLength(4).WithMessage("Proje adı en az 4 karakter olmalıdır");
            RuleFor(x => x.Name).MaximumLength(255).WithMessage("Proje adı en fazla 255 karakter olmalıdır");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Proje görseli zorunludur!");
            RuleFor(x => x.Link).NotEmpty().WithMessage("Proje Linki boş geçilemez!");
            RuleFor(x => x.Link).MinimumLength(15).WithMessage("Proje Linki en az 15 karakter olmalıdır!");
        }
    }
}
