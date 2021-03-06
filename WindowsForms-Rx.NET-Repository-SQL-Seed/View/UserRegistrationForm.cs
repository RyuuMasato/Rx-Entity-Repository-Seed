﻿using RxRepoSeed.Controller;
using RxRepoSeed.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RxRepoSeed.View
{
    public partial class RegisterUserForm : Form
    {
        private readonly UserController _userController;
        public RegisterUserForm()
        {
            InitializeComponent();
            _userController = new UserController();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RegisterUser(object sender, EventArgs e)
        {
            _userController.Create(UsernameInput.Text);
            UserList.Items.Clear();
            foreach(User user in _userController.UpdateUserList())
            {
                UserList.Items.Add(user.Username);
            }
        }
    }
}
