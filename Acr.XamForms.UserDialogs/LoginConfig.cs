using System;


namespace Acr.XamForms.UserDialogs {
    
    public class LoginConfig {

        public string Title { get; set; }
        public string Message { get; set; }
        public string OkText { get; set; }
        public string CancelText { get; set; }
        public string LoginValue { get; set; }
        public string LoginPlaceholder { get; set; }
        public string PasswordPlaceholder { get; set; }
		public Action<LoginResult> OnResult { get; set; }
		public bool isPassword { get; set; }
		public bool isPhone { get; set; }


        public LoginConfig() {
            this.Title = "Login";
            this.OkText = "OK";
            this.CancelText = "Cancel";
            this.LoginPlaceholder = "User Name";
			this.PasswordPlaceholder = "Password";
			this.isPassword = true;
			this.isPhone = false;
        }
    }
}
