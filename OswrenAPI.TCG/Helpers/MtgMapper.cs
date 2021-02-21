using OswrenAPI.TCG.Models;
using System.Collections.Generic;

namespace OswrenAPI.TCG.Helpers
{
    public static class MtgMapper
    {
        public static List<Domain.Models.TcgSet> MapSetLists(List<MtgSet> setList)
        {
            List<Domain.Models.TcgSet> resultSet = new List<Domain.Models.TcgSet>();
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

            return resultSet;
        }
    }
}
