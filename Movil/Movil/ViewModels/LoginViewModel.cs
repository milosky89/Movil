using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Movil.ViewModels
{
    class LoginViewModel : BaseViewModel
    {
        #region Attributes
        private string email;
        private string password;
        #endregion

        #region Properties
        public string EmailTxt
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }

        public string PasswordTxt
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }

        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(login);
            }
            set
            {

            }
        }


        #endregion

        #region Methods
        private void login()
        {
            if(EmailTxt.ToString()== "camilo@gmail.com" && PasswordTxt.ToString() == "123456")
            {
                Application.Current.MainPage.DisplayAlert("Correcto", "Bienvenido", "ok");
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Incorrecto", "Usario y/o contraseña no valido", "ok");
            }
        }
        #endregion

        #region Constructor

        #endregion
    }
}
