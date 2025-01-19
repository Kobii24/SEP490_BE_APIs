using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks.Exceptions;

public class InternalServerException : Exception
{
    public InternalServerException(string message) : base(message) { }

    public InternalServerException(string message, string Details) : base(message)
    {
        this.Details = Details;
    }

    public string? Details { get; }
}
