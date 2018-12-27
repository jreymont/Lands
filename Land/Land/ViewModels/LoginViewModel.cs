using System;
using System.Windows.Input;

namespace Land.ViewModels
{
    class LoginViewModel
    {
        #region Properties
        public String Mail
        {
            get;
            set;
        }

        public String Password
        {
            get;
            set;
        }

        public bool IsRunning
        {
            get;
            set;
        }
        public bool IsRemember
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            this.IsRemember = true;
        }
        #endregion


        #region Commands
        public ICommand LoginCommand
        {
            get;
            set;
        }
        #endregion



    }
}
