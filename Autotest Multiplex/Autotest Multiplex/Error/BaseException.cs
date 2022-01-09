using System;
using System.Collections.Generic;
using System.Text;

namespace Autotest_Multiplex.Error
{
    public class BaseException : Exception
    {
        private string _logo = "//a[contains(@class,'logolink')]";
        public string logo { get; set; }
        public string _Logo
        {
            get { return _logo; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Error");
                }
                else
                {
                    _logo = value;
                }
            }
        }

        private string _login = "//a[contains(@class,'lk_link')]";
        public string login { get; set; }
        public string _Login
        {
            get { return _login; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Error");
                }
                else
                {
                    _login = value;
                }
            }
        }
        public BaseException(string message) : base(message)
        {
        }
    }
}
