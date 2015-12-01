﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.AppController;

namespace UI.LoginUI
{
    public partial class LoginForm : Form, ILoginView
    {
        private readonly ApplicationContext _context;
        public LoginForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();

            submitButton.Click += (sender, args) => Invoke(SubmitPressed);
        }

        //IView interface
        //
        void IView.Show()
        {
            _context.MainForm = this;
            Application.Run(_context);
        }

        public string Password
        {
            get
            {
                return passwordLine.Text;
            }
        }

        public string Login
        {
            get
            {
                return loginLine.Text;
            }
        }

        public event Action SubmitPressed;

        //TODO  
        public void ShowError(string errorMessage)
        {
            MessageBox.Show(this, errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Invoke(Action action)
        {
            if (action != null)
            {
                action();
            }
        }
    }
}