using System.Collections.Generic;
using System.Threading.Tasks;

namespace OswrenAPI.Domain.Interfaces
{
    public interface ITcgReader
    {
        public Task<IEnumerable<Models.TcgSet>> GetSetlist();
        public Task<IEnumerable<Models.TcgCard>> GetMTGCardList(string set);
    }
}
