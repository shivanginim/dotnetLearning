using dotnetcorewithoutMVC.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dotnetcorewithoutMVC.Data
{
    public interface IAccommodationData
    {
        IEnumerable<Accommodation> GetAll();
    }

    public class InMemoryAccommodationData : IAccommodationData
    {
        readonly List<Accommodation> accommodations;
        public InMemoryAccommodationData()
        {
            accommodations = new List<Accommodation>()
            {
                new Accommodation {ID = 1, Name = "Accommodation 1", Location="Auckland", AccommodationType=AccommodationType.Premium },
                new Accommodation {ID = 2, Name = "Accommodation 2", Location="Auckland", AccommodationType=AccommodationType.Premium },
                new Accommodation {ID = 3, Name = "Accommodation 3", Location="Auckland", AccommodationType=AccommodationType.Premium },
                new Accommodation {ID = 4, Name = "Accommodation 4", Location="Auckland", AccommodationType=AccommodationType.Premium },
                new Accommodation {ID = 5, Name = "Accommodation 5", Location="Auckland", AccommodationType=AccommodationType.Premium }
            };
        }
        public IEnumerable<Accommodation> GetAll()
        {
            return from a in accommodations
                   orderby a.Name
                   select a;
        }
    }
}
