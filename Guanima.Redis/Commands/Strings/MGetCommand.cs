﻿using System;
using System.Collections.Generic;

namespace Guanima.Redis.Commands.Strings
{
    [Serializable]
    public sealed class MGetCommand : RedisCommand
    {
        public MGetCommand(IEnumerable<string> keys) 
        {
            Arguments = CommandUtils.ConstructParameters(Name, keys);
        }
    }
}
