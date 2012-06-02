﻿using System;
using System.Collections.Generic;

namespace DomainEvents.Specs
{
    public class Location
    {
        public string Address { get; private set; }

        public Account Account { get; set; }

        public Account Account2 { get; set; }

        public List<Account> ListOfAccounts { get; set; }
        public ICollection<Account> CollectionOfAccounts { get; set; }

        public event DomainEvent RaiseEvent;

        public void ChangeLocation(string address)
        {
            Address = address;
            RaiseEvent(new LocationChanged(address));
        }
    }
}