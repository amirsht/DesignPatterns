﻿namespace PrototypePattern
{
    public interface IEmployee
    {
        IEmployee Clone();
        string GetDetails();
    }
}
