using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.Entity.Entities;

namespace Villa.Business.Validators
{
    public class QuestionValidator: AbstractValidator<Quest>
    {
        public QuestionValidator()
        {
                RuleFor(x => x.Question).NotEmpty().WithMessage("Soru metni boş olamaz.");
                RuleFor(x => x.Question).MinimumLength(10).WithMessage(" Soru metni 10 karakterden az olamaz.");
                RuleFor(x => x.Question).MaximumLength(200).WithMessage(" Soru metni 200 karakterden fazla olamaz.");
                RuleFor(x => x.Answer).NotEmpty().WithMessage("Cevap metni boş olamaz.");
            RuleFor(x => x.Answer).MinimumLength(10).WithMessage(" Minimum 10 karakterlik cevap giriniz.");
            RuleFor(x => x.Answer).MaximumLength(200).WithMessage(" Maksimum 200 karakterlik cevap giriniz.");
        }
    }
}
