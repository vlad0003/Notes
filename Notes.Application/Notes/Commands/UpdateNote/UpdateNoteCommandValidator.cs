using System;
using FluentValidation;

namespace Notes.Application.Notes.Commands.UpdateNote
{
    public class UpdateNoteCommandValidator
        : AbstractValidator<UpdateNoteCommand>
    {
        public UpdateNoteCommandValidator()
        {
            RuleFor(UpdateNoteCommand =>
                UpdateNoteCommand.UserId).NotEqual(Guid.Empty);
            RuleFor(UpdateNoteCommand =>
                UpdateNoteCommand.Id).NotEqual(Guid.Empty);
            RuleFor(UpdateNoteCommand =>
                UpdateNoteCommand.Title).NotEmpty().MaximumLength(250);
        }
    }
}
