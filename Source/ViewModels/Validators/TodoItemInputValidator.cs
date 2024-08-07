using Data;
using FluentValidation;
using ViewModels.Items;
using Microsoft.EntityFrameworkCore;

namespace ViewModels.Validators;
public class TodoItemInputValidator : AbstractValidator<TodoItemInput>
{
    private readonly DatabaseContext _todoDbContext;
    public TodoItemInputValidator(IDbContextFactory<DatabaseContext> dbContextFactory)
    {
        _todoDbContext = dbContextFactory.CreateDbContext();

        RuleFor(t => t.Title).NotEmpty().MaximumLength(100).MinimumLength(3)
            .Must(IsUnique).WithMessage("Title should be unique.");
    }

    private bool IsUnique(string title)
    {
        return !_todoDbContext.TodoItems.Any(t => t.Title == title);
    }
}
