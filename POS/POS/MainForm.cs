﻿using System;
using System.Windows.Forms;

namespace POS
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        public MainForm()
        {
            InitializeComponent();
            
#if !DEBUG
            Cursor.Hide();
#endif
        }
    }
}