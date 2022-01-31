﻿using _05.FootballTeamGenerator.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace _05.FootballTeamGenerator.Models
{
    public class Player
    {
        private string name;

        public Player(string name, Stats stats)
        {
            this.Name = name;
            this.Stats = stats;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.INVALID_NAME_EXC_MSG);
                }

                this.name = value;
            }
        }

        public Stats Stats { get; set; }

        public double OverallSkill => this.Stats.AverageStat;
    }
}
