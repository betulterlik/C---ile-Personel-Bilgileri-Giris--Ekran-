using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Personelwcf.WCF
{
    [DataContract]
   public class Persons
    {
        [DataMember]
        public int PerId { get; set; }
        [DataMember]
        public string perAdi { get; set; }
        [DataMember]
        public string PerSoyadi { get; set; }
        [DataMember]
        public DateTime? DogTarihi { get; set; }
        [DataMember]
        public string ili { get; set; }
        [DataMember]
        public string ilcesi { get; set; }
        [DataMember]
        public string DepartmanAdi { get; set; }
        [DataMember]
        public decimal? Maasi { get; set; }
        [DataMember]
        public string resimyolu { get; set; }
        [DataMember]
        public byte[] resimImage { get; set; }

    }
}
