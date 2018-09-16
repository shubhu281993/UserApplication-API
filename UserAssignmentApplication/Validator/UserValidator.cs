using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAssignmentApplication.Model;

namespace UserAssignmentApplication.Validator
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Password).NotEmpty().MinimumLength(8).WithMessage("Password length must be greater than 8").Matches("[A-Z]").WithMessage("Password must include a Capital letter").Matches("[a-b]").WithMessage("Password must include a Small letter")
            .Matches("[0-9]").WithMessage("Password must include a digit")
            .Matches("[^a-zA-Z0-9]").WithMessage("Password must include a Special Character") ;
            RuleFor(x => x.Name).Length(0, 20);
            RuleFor(x => x.Email).NotEmpty()
            .WithMessage("Email is required.")
            .EmailAddress()
            .WithMessage("Invalid email format.");
            RuleFor(x => x.Skill).NotEmpty().MinimumLength(8);
        }
    }
}
