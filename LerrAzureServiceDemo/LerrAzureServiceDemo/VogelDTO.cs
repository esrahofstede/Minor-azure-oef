using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace LerrAzureServiceDemo
{
    [DataContract]
    public class VogelDTO
    {
        [DataMember]
        public long ID { get; set; }
        [DataMember]
        public string Naam { get; set; }
    }
}