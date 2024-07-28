using EF_DietaryProject.DAL;
using EF_DietaryProject.Entities.Entities;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EF_DietaryProject.UI
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (CheckTexts())
            {
                MessageBox.Show("Please fill out all the texts");
            }
            else
            {
                string password = txtRegPassword.Text;
                string username = txtRegUsername.Text;
                string retypePassword = txtRegRetypePassword.Text;

                if (CheckUsername(username))
                {
                    if (password.Equals(retypePassword))
                    {
                        if (CheckPassword(password))
                        {

                            AppUser user = new AppUser()
                            {
                                Username = txtRegUsername.Text,
                                Password = HashMethod.SHA256_hash(txtRegPassword.Text),
                                AppUserDetail = new AppUserDetail
                                {
                                    Firstname = txtRegName.Text,
                                    Lastname = txtRegSurname.Text,
                                }
                            };

                            UnitOfWork.Instance.AppUserRepository.Add(user);

                            MessageBox.Show("The registration is successfull");

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("The password does not fulfill the desired requirements." +
                                " Please choose a different password.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The passwords does not match. Please retry.");
                    }
                }
                else
                {
                    MessageBox.Show("The username was already taken or not valid. " +
                        "Please choose a different username");
                }
            } 
        }

        private bool CheckTexts() 
        {
            return (string.IsNullOrWhiteSpace(txtRegName.Text) ||
                string.IsNullOrWhiteSpace(txtRegSurname.Text)  ||
                string.IsNullOrWhiteSpace(txtRegUsername.Text) || 
                string.IsNullOrWhiteSpace(txtRegPassword.Text) || 
                string.IsNullOrWhiteSpace(txtRegRetypePassword.Text));
        }

        private bool CheckUsername(string username)
        {
            if (IsValidEmail(username))
            {
                var result = UnitOfWork.Instance.AppUserRepository.GetAll().
                    FirstOrDefault(x => x.Username == username);

                if (result == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool IsValidEmail(string email)
        {
            string pattern = @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private bool CheckPassword(string password)
        {
            if (password.Length < 8)
                return false;

            if (password.Count(char.IsUpper) < 2)
                return false;

            if (password.Count(char.IsLower) < 3)
                return false;

            char[] specialChars = { '!', ':', '+', '*' };
            int specialCharCount = password.Count(c => specialChars.Contains(c));
            if (specialCharCount < 2)
                return false;

            return true;
        }

    }
}

