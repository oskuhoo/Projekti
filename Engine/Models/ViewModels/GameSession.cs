using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Engine.Factories;
using System.ComponentModel;

namespace Engine.Models.ViewModels
{
    public class GameSession : INotifyPropertyChanged
    {
        private Location currentLocation;

        public Player CurrentPlayer { get; set; }
        public World CurrentWorld { get; set; }

        public Location CurrentLocation
        {
            get { return currentLocation; }
            set
            {
                currentLocation = value;
                OnPropertyChanged("CurrentLocation");

                OnPropertyChanged("CanMoveUp");
                OnPropertyChanged("CanMoveRight");
                OnPropertyChanged("CanMoveDown");
                OnPropertyChanged("CanMoveLeft");
            }
        }

        public bool CanMoveUp
        {
            get { return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1) != null; }
        }

        public bool CanMoveRight
        {
            get { return CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate) != null; }
        }

        public bool CanMoveDown
        {
            get { return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1) != null; }
        }

        public bool CanMoveLeft
        {
            get { return CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate) != null; }
        }

        public GameSession()
        {
            CurrentPlayer = new Player
            {
                Name = "Osku",
                CharacterClass = "Mage",
                HitPoints = 1000,
                ExperiencePoints = 0,
                Level = 1,
                Gold = 1000000
            };

            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(0, -1);
        }

        public void MoveUp()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);
        }

        public void MoveRight()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate);
        }

        public void MoveDown()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1);
        }

        public void MoveLeft()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
   
}