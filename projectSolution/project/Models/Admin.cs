using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;



namespace project.Models
{
    [DataContract]
    public class Admin
    {
        [DataMember]
        public int adminId { get; set; }
        [DataMember]
        public string adminName { get; set; }
        [DataMember]
        public string password { get; set; }
    }
}