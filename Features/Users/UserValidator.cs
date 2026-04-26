using FluentValidation;
using TaskFlowApi.Entities;

namespace TaskFlowApi.Features.Users
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Username).NotEmpty().MinimumLength(3);

        }
    }
}
