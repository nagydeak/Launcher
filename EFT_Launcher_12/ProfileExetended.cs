﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFT_Launcher_12
{
    //FILE AUTOGENERATED FROM http://json2csharp.com/ 
    public class Settings
    {
        public string Role { get; set; }
        public string BotDifficulty { get; set; }
        public int Experience { get; set; }
    }

    public class Info
    {
        public string Nickname { get; set; }
        public string LowerNickname { get; set; }
        public string Side { get; set; }
        public string Voice { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int RegistrationDate { get; set; }
        public string GameVersion { get; set; }
        public int AccountType { get; set; }
        public string MemberCategory { get; set; }
        public bool lockedMoveCommands { get; set; }
        public int SavageLockTime { get; set; }
        public int LastTimePlayedAsSavage { get; set; }
        public Settings Settings { get; set; }
        public bool NeedWipe { get; set; }
        public bool GlobalWipe { get; set; }
        public int NicknameChangeDate { get; set; }
        public List<object> Bans { get; set; }
    }

    public class Customization
    {
        public string Head { get; set; }
        public string Body { get; set; }
        public string Feet { get; set; }
        public string Hands { get; set; }
    }

    public class Hydration
    {
        public int Current { get; set; }
        public int Maximum { get; set; }
    }

    public class Energy
    {
        public int Current { get; set; }
        public int Maximum { get; set; }
    }

    public class Health2
    {
        public int Current { get; set; }
        public int Maximum { get; set; }
    }

    public class Head
    {
        public Health2 Health { get; set; }
    }

    public class Health3
    {
        public int Current { get; set; }
        public int Maximum { get; set; }
    }

    public class Chest
    {
        public Health3 Health { get; set; }
    }

    public class Health4
    {
        public int Current { get; set; }
        public int Maximum { get; set; }
    }

    public class Stomach
    {
        public Health4 Health { get; set; }
    }

    public class Health5
    {
        public int Current { get; set; }
        public int Maximum { get; set; }
    }

    public class LeftArm
    {
        public Health5 Health { get; set; }
    }

    public class Health6
    {
        public int Current { get; set; }
        public int Maximum { get; set; }
    }

    public class RightArm
    {
        public Health6 Health { get; set; }
    }

    public class Health7
    {
        public int Current { get; set; }
        public int Maximum { get; set; }
    }

    public class LeftLeg
    {
        public Health7 Health { get; set; }
    }

    public class Health8
    {
        public int Current { get; set; }
        public int Maximum { get; set; }
    }

    public class RightLeg
    {
        public Health8 Health { get; set; }
    }

    public class BodyParts
    {
        public Head Head { get; set; }
        public Chest Chest { get; set; }
        public Stomach Stomach { get; set; }
        public LeftArm LeftArm { get; set; }
        public RightArm RightArm { get; set; }
        public LeftLeg LeftLeg { get; set; }
        public RightLeg RightLeg { get; set; }
    }

    public class Health
    {
        public Hydration Hydration { get; set; }
        public Energy Energy { get; set; }
        public BodyParts BodyParts { get; set; }
        public int UpdateTime { get; set; }
    }

    public class Foldable
    {
        public bool Folded { get; set; }
    }

    public class Tag
    {
        public int Color { get; set; }
        public string Name { get; set; }
    }

    public class Upd
    {
        public int StackObjectsCount { get; set; }
        public Foldable Foldable { get; set; }
        public Tag Tag { get; set; }
    }

    public class Item
    {
        public string _id { get; set; }
        public string _tpl { get; set; }
        public string parentId { get; set; }
        public string slotId { get; set; }
        public Upd upd { get; set; }
        public object location { get; set; }
    }

    public class FastPanel
    {
    }

    public class Inventory
    {
        public List<Item> items { get; set; }
        public string equipment { get; set; }
        public string stash { get; set; }
        public string questRaidItems { get; set; }
        public string questStashItems { get; set; }
        public FastPanel fastPanel { get; set; }
    }

    public class Common
    {
        public string Id { get; set; }
        public decimal Progress { get; set; }
        public decimal MaxAchieved { get; set; }
        public int LastAccess { get; set; }
    }

    public class Skills
    {
        public List<Common> Common { get; set; }
        public List<object> Mastering { get; set; }
        public int Points { get; set; }
    }

    public class OverallCounters
    {
       public List<object> Items { get; set; }
    }

    public class Stats
    {
        public object SessionCounters { get; set; }
        public OverallCounters OverallCounters { get; set; }
        public double SessionExperienceMult { get; set; }
        public double TotalSessionExperience { get; set; }
        public int LastSessionDate { get; set; }
        public object Aggressor { get; set; }
        public List<object> DroppedItems { get; set; }
        public List<object> FoundInRaidItems { get; set; }
        public List<object> Victims { get; set; }
        public List<object> CarriedQuestItems { get; set; }
        public int TotalInGameTime { get; set; }
        public string SurvivorClass { get; set; }
    }

    public class Encyclopedia
    {
    }

    public class ConditionCounters
    {
        public List<object> Counters { get; set; }
    }

    public class BackendCounters
    {
    }

    public class Production
    {
        public int Progress { get; set; }
        public bool inProgress { get; set; }
        public string RecipeId { get; set; }
        public List<object> Products { get; set; }
        public int StartTime { get; set; }
    }

    public class Area
    {
        public int type { get; set; }
        public int level { get; set; }
        public bool active { get; set; }
        public bool passiveBonusesEnabled { get; set; }
        public int completeTime { get; set; }
        public bool constructing { get; set; }
        public List<object> slots { get; set; }
    }

    public class Hideout
    {
        public Production Production { get; set; }
        public List<Area> Areas { get; set; }
    }

    public class Bonus
    {
        public string type { get; set; }
        public string templateId { get; set; }
    }

    public class Notes
    {
        private List<object> notes;

        public List<object> GetNotes()
        {
            return notes;
        }

        public void SetNotes(List<object> value)
        {
            notes = value;
        }
    }

    public class TraderStandings
    {
    }

    public class RagfairInfo
    {
        public double rating { get; set; }
        public bool isRatingGrowing { get; set; }
        public List<object> offers { get; set; }
    }

    public class ProfileExtended
    {
        public string _id { get; set; }
        public int aid { get; set; }
        public string savage { get; set; }
        public Info Info { get; set; }
        public Customization Customization { get; set; }
        public Health Health { get; set; }
        public Inventory Inventory { get; set; }
        public Skills Skills { get; set; }
        public Stats Stats { get; set; }
        public Encyclopedia Encyclopedia { get; set; }
        public ConditionCounters ConditionCounters { get; set; }
        public BackendCounters BackendCounters { get; set; }
        public List<object> InsuredItems { get; set; }
        public Hideout Hideout { get; set; }
        public List<Bonus> Bonuses { get; set; }
        public Notes Notes { get; set; }
        public List<object> Quests { get; set; }
        public TraderStandings TraderStandings { get; set; }
        public RagfairInfo RagfairInfo { get; set; }
        public List<object> WishList { get; set; }
    }
}