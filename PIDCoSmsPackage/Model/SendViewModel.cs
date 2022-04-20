using System.Collections.Generic;

namespace PIDCoSmsPackage.Model
{
    public class SendViewModel
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Number { get; set; }
        public string SmsText { get; set; }
        public string Folder { get; set; }

        public List<string> ReceiverPhoneNumbers { get; set; }

    }
}
