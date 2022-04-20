using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using PIDCoSmsPackage.Model;

namespace PIDCoSmsPackage
{
    
    public class SmsService
    {
        private const string Uri = "https://api.smszone.ir/api/";
        public async Task<List<SendResultViewModel>> Send(SendViewModel model)
        {
            var token = await ServiceHttpClientExtension.PostAsync<LoginResultViewModel>( Uri+"/User/Login",
                new { UserName = model.Username, Password = model.Password });
            if (token.Status == HttpStatusCode.OK)
            {
                var result = await ServiceHttpClientExtension.PostAsync<List<SendResultViewModel>>( Uri+"/Send",
                    new { Number = model.Number, FolderTitle = model.Folder, SmsText = model.SmsText, ReceiverPhoneNumbers = model.ReceiverPhoneNumbers }, token.Data.access_token);


                return result.Data;
            }

            return null;
        }
    }
}
