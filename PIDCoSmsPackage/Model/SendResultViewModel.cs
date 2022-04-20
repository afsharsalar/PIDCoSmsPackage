namespace PIDCoSmsPackage.Model
{
    public class SendResultViewModel
    {
        public Contacts[] Contacts { get; set; }
    }

    public class Contacts
    {
        public Receiversnumbersstatu[] receiversNumbersStatus { get; set; }
        public string message { get; set; }
    }

    public class Receiversnumbersstatu
    {
        public string phoneNumber { get; set; }
        public int status { get; set; }
    }
}
