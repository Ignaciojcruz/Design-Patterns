﻿using StateExample.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateExample.Context;


namespace StateExample.ConcreteState
{
    internal class Medium : Doneness
    {
        public Medium(Doneness state) : this(state.CurrentTemp, state.Steak) { }

        public Medium(double currentTemp, Steak steak)
        {
            this.currentTemp = currentTemp;
            this.steak = steak;
            canEat = true;
            Initialize();
        }

        private void Initialize()
        {
            lowerTemp = 155;
            upperTemp = 169.9999999999;
        }

        public override void AddTemp(double amount)
        {
            currentTemp += amount;
            DonenessCheck();
        }

        public override void RemoveTemp(double amount)
        {
            currentTemp -= amount;
            DonenessCheck();
        }

        public override void DonenessCheck()
        {
            if (currentTemp < 130)
            {
                steak.State = new Uncooked(this);
            }
            else if (currentTemp < lowerTemp)
            {
                steak.State = new MediumRare(this);
            }
            else if (currentTemp > upperTemp)
            {
                steak.State = new WellDone(this);
            }
        }
    }
}
