﻿namespace FSD.Core;

public abstract class Message
{
    public string MessageType { get; private set; }
    public Guid AggregateId { get; set; }

    protected Message()
    {
        MessageType = GetType().Name;
    }
}