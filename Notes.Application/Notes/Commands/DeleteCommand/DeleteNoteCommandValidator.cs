using System;
using FluentValidation;

namespace Notes.Application.Notes.DeleteCommand
{
    public class DeleteNoteCommandValidator
        : AbstractValidator<DeleteNoteCommand>
    {
        public DeleteNoteCommandValidator()
        {
            RuleFor(deleteNoteCommand => 
                deleteNoteCommand.Id).NotEqual(Guid.Empty);
            RuleFor(deleteNoteCommand => 
                deleteNoteCommand.UserId).NotEqual(Guid.Empty);
        }
    }
}
