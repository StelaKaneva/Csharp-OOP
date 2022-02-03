using _07.MilitaryElite.Enumerations;
using _07.MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstName, string lastName, decimal salary, SoldierCorpEnum soldierCorpEnum, List<IMission> missions) : base(id, firstName, lastName, salary, soldierCorpEnum)
        {
            this.Missions = missions;
        }

        public ICollection<IMission> Missions { get; }
    }
}
