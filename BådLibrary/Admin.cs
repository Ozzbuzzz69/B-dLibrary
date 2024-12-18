﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BådLibrary
{
    public class Admin : Person
    {
        public int Id { get; set; }
        public string TelefonNummer { get; set; }

        public Admin(int id, string name, string telefonNummer, string address, string email) : base(name, address, email)
        {
            id = Id;
            telefonNummer = TelefonNummer;
        }
    }
}
