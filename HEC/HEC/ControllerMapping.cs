﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEC
{
    public abstract class ControllerMapping
    {
        protected Dictionary<String, Macro> macros;

        public ControllerMapping()
        {
            macros = new Dictionary<string, Macro>();
            this.setMacros();
        }

        public virtual void setMacros()
        {
            // override
        }

        public virtual void performActionA()
        {
            // override
        }

        public virtual void performActionB()
        {
            // override
        }

        public virtual void performActionX()
        {
            // override
        }

        public virtual void performActionY()
        {
            // override
        }

        public virtual void performActionDPadUp()
        {
            // override
        }

        public virtual void performActionDPadRight()
        {
            // override
        }

        public virtual void performActionDPadDown()
        {
            // override
        }

        public virtual void performActionDPadLeft()
        {
            // override
        }

        public virtual void performActionStart()
        {
            // override
        }
    }
}