﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SP
{
    public static class Extension
    {
        public static string InformarNovedad(this CartucheraLlenaException ex)
        {
            return ex.Message;
        }
    }
}
