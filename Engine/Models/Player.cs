using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Engine.Models
{
    public class Player : INotifyPropertyChanged
    {
        private string name;
        private string characterClass;
        private int hitPoints;
        private int experiencePoints;
        private int level;
        private int gold;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }


        public string CharacterClass
        {
            get { return characterClass; }
            set { characterClass = value; OnPropertyChanged("CharacterClass"); }
        }


        public int HitPoints
        {
            get { return hitPoints; }
            set { hitPoints = value; OnPropertyChanged("HitPoints"); }
        }

        public int ExperiencePoints
        {
            get { return experiencePoints; }
            set { experiencePoints = value; OnPropertyChanged("ExperiencePoints"); }
        }


        public int Level
        {
            get { return level; }
            set { level = value; OnPropertyChanged("Level"); }
        }


        public int Gold
        {
            get { return gold; }
            set { gold = value; OnPropertyChanged("Gold"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
