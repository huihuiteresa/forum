﻿using ECommon.Components;
using ENode.Commanding;
using Forum.Commands.Replies;
using Forum.Domain.Replies;

namespace Forum.CommandHandlers
{
    [Component(LifeStyle.Singleton)]
    public class ReplyCommandHandler :
        ICommandHandler<CreateReplyCommand>,
        ICommandHandler<UpdateReplyBodyCommand>
    {
        private readonly ReplyFactory _factory;

        public ReplyCommandHandler(ReplyFactory factory)
        {
            _factory = factory;
        }

        public void Handle(ICommandContext context, CreateReplyCommand command)
        {
            context.Add(_factory.CreateReply(command.PostId, command.ParentId, command.AuthorId, command.Body));
        }
        public void Handle(ICommandContext context, UpdateReplyBodyCommand command)
        {
            context.Get<Reply>(command.AggregateRootId).UpdateBody(command.Body);
        }
    }
}
