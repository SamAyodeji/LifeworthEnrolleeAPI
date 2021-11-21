using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Mailconnection
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Pwd { get; set; }
        public int? Capdays { get; set; }
        public string DeactivateSms { get; set; }
        public string NewRegSms { get; set; }
        public string ChgprovSms { get; set; }
        public string Enrolleenocode { get; set; }
        public string Rejectsms { get; set; }
        public string Deprejectsms { get; set; }
        public int? Retailage { get; set; }
        public int? Groupage { get; set; }
        public int? Retaildepage { get; set; }
        public int? Groupdepage { get; set; }
        public int? Maxempage { get; set; }
        public int? Maxdepage { get; set; }
        public string Smsname { get; set; }
        public string Smsusr { get; set; }
        public string Smspwd { get; set; }
        public int? Billmth { get; set; }
        public int? Capcond { get; set; }
        public string SenderName { get; set; }
        public string Prefix { get; set; }
        public string DomainName { get; set; }
        public string Sender { get; set; }
        public string SenderPassword { get; set; }
        public string SmtpClientHost { get; set; }
        public int? Port { get; set; }
    }
}
