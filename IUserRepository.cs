﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Login
{
   public interface IUserRepository
    {
      
        Task<bool> Insert(User LoginDB);
    }



    
}
