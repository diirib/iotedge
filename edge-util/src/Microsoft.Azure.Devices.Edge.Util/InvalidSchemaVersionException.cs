// Copyright (c) Microsoft. All rights reserved.
namespace Microsoft.Azure.Devices.Edge.Util
{
    using System;

    [Serializable]
    public class InvalidSchemaVersionException : Exception
    {
        public InvalidSchemaVersionException(string message)
            : base(message)
        {
        }

        public InvalidSchemaVersionException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
