﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Forms__DelegateInAction
{
    class Alice
    {
        public GetSecretInfo MySecret => new GetSecretInfo(this.SecretInfo);

        private string SecretInfo(int value)
        {
            return $"{value}dag oregano. {GetType().Name}.";
        }
    }
}
