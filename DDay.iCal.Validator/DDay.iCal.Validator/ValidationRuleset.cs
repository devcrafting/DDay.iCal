﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DDay.iCal.Validator
{
    public class ValidationRuleset : 
        IValidationRuleset
    {
        #region IValidationRuleset Members

        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public IValidationRule[] Rules { get; protected set; }

        #endregion
    }
}
