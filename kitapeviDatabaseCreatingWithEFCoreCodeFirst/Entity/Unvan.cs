
using kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity.Common;

namespace kitabeviDatabaseCreatingWithEFCoreCodeFirst.Entity
{
    public class Unvan : Baseclass
    {
        public Unvan()
        {
            Personeller = new HashSet<Personel>();
        }
        public ICollection<Personel> Personeller { get; set; }
    }

}
