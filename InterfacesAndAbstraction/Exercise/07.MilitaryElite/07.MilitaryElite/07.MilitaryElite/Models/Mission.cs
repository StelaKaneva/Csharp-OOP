using _07.MilitaryElite.Enumerations;
using _07.MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.Models
{
    public class Mission : IMission
    {
        public Mission(string codeName, MissionStateEnum missionStateEnum)
        {
            CodeName = codeName;
            MissionStateEnum = missionStateEnum;
        }

        public string CodeName { get; }
        public MissionStateEnum MissionStateEnum { get; }

        public void CompleteMission(string missionName)
        {
            
        }
    }
}
