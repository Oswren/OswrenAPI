﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace OswrenAPI.Domain.Interfaces
{
    public interface ITcgReader
    {
        public Task<IEnumerable<Domain.Models.TcgSet>> GetSetlist();
    }
}
