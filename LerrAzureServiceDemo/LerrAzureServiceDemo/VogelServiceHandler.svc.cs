using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LerrAzureServiceDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class VogelServiceHandler : IVogel
    {
        VogelDataMapper _mapper;

        public VogelServiceHandler()
        {
            _mapper = new VogelDataMapper();
        }

        public VogelDTO[] GetBirds()
        {
            var vogels = _mapper.GetAllVogels();
            return vogels.Select(a => new VogelDTO { ID = a.ID, Naam = a.Naam }).ToArray();
        }
    }
}
