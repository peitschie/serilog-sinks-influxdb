﻿using System.Runtime.Serialization;

namespace Serilog.Sinks.InfluxDB;

public class InfluxDbClientCreateBucketException : Exception
{
    public InfluxDbClientCreateBucketException()
    {
    }

    public InfluxDbClientCreateBucketException(string message) : base(message)
    {
    }

    public InfluxDbClientCreateBucketException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected InfluxDbClientCreateBucketException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}