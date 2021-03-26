using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler_Task
{
    class Animal
    {
        public event EventHandler<EventArgs> Feed;
        public string NamePet { get; set; }
        public readonly byte MaxHitPoint = 100;
        public readonly byte MinHitPoint = 10;
        public  byte CurrentEnergy
        {
            get => CurrentEnergy;
            set
            {
                this.CurrentEnergy = value;
                if(value < MinHitPoint)
                {
                    Feed?.Invoke(this,EventArgs.Empty);
                }
            }
        }
        public void Run()
        {
            if(CurrentEnergy < MaxHitPoint
                && CurrentEnergy > MinHitPoint)
            {
                CurrentEnergy -= 10;
            }
            else
            {
                
            }
        }
        public override string ToString()
        {
            return $"Name pet {NamePet}";
        }
    }
}
