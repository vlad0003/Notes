using System;
using MediatR;

namespace Notes.Application.Notes.DeleteCommand
{
    public class DeleteNoteCommand : IRequest
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }   
    }
}
