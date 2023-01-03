﻿using StateExample.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateExample.Context;

namespace StateExample.ConcreteState
{
    internal class WellDone : Doneness
    {
        public WellDone(Doneness state) : this(state.CurrentTemp, state.Steak) { }

        public WellDone(double currentTemp, Steak steak)
        {
            this.currentTemp = currentTemp;
            this.steak = steak;
            canEat = true;
            Initialize();
        }

        private void Initialize()
        {
            lowerTemp = 170;
            upperTemp = 230;
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
            if (currentTemp < 0)
            {
                steak.State = new Uncooked(this);
            }
            else if (currentTemp < lowerTemp)
            {
                steak.State = new Medium(this);
            }
        }
    }
}
