using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VogelDataMapper
    {
        public IEnumerable<Vogel> GetAllVogels()
        {
            using (var context = new Vogelcontext())
            {
                return context.Vogels.ToList();
            }
        }
    }
}
