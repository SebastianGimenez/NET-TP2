﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace UI.Desktop
{
    public class ErrorManager
    {
        public static void showError(IWin32Window hwnd,String error,String codigoError)
        {   
            MessageBox.Show(hwnd,error, codigoError,MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
