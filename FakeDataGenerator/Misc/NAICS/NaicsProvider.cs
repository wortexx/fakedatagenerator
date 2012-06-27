using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Fake.Data.Misc.NAICS
{
    public class NaicsProvider : IEnumerable<Naics>
    {
        private readonly Random _rnd;

        public NaicsProvider(Random rnd)
        {
            _rnd = rnd;
        }

        public Naics GetRandom()
        {
            var naics = this.ToArray();
            return naics[_rnd.Next(0, naics.Length - 1)];
        }
        public IEnumerator<Naics> GetEnumerator()
        {
            var dictionary = new Dictionary<int, string>
                             {
                                 {11, "Agriculture, Forestry, Fishing and Hunting"},
                                 {21, "Mining"},
                                 {22, "Utilities"},
                                 {23, "Construction"},
                                 {31, "Manufacturing"},
                                 {32, "Manufacturing"},
                                 {33, "Manufacturing"},
                                 {42, "Wholesale Trade"},
                                 {44, "Retail Trade"},
                                 {45, "Retail Trade"},
                                 {48, "Transportation and Warehousing"},
                                 {49, "Transportation and Warehousing"},
                                 {51, "Information"},
                                 {52, "Finance and Insurance"},
                                 {53, "Real Estate and Rental and Leasing"},
                                 {54, "Professional, Scientific, and Technical Services"},
                                 {55, "Management of Companies and Enterprises"},
                                 {56, "Administrative and Support and Waste Management and Remediation Services"},
                                 {61, "Education Services"},
                                 {62, "Health Care and Social Assistance"},
                                 {71, "Arts, Entertainment, and Recreation"},
                                 {72, "Accommodation and Food Services"},
                                 {81, "Other Services (except Public Administration)"},
                                 {92, "Public Administration"}
                             };
            return dictionary.Select(keyValue => new Naics
                                                     {
                                                         Code = keyValue.Key,
                                                         Desctription = keyValue.Value
                                                     }).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}