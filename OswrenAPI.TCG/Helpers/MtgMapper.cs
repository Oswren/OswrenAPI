using OswrenAPI.TCG.Models;
using System.Collections.Generic;
using System.Linq;

namespace OswrenAPI.TCG.Helpers
{
    public static class MtgMapper
    {
        public static List<Domain.Models.TcgSet> MapSetLists(List<MtgSet> setList)
        {
            var resultSet = new List<Domain.Models.TcgSet>();
            foreach (var set in setList)
            {
                resultSet.Add
                (
                    new Domain.Models.TcgSet
                    {
                        Code = set.Code,
                        Name = set.Name,
                        Type = set.Type,
                        ReleaseDate = set.ReleaseDate
                    }
                );
            }

            return resultSet.OrderBy(result => result.ReleaseDate).ToList();
        }
    }
}
