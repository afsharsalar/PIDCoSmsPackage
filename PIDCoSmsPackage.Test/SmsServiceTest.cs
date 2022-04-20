using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;
using PIDCoSmsPackage.Model;

namespace PIDCoSmsPackage.Test
{
    [TestClass]
    public class SmsServiceTest
    {
        [TestMethod]
        public async Task Test_Send()
        {
            //arrange
            var model = new SendViewModel
            {
                Username = "***",
                Password = "****",
                Folder = "web",
                Number = "5000***",
                SmsText = "تست",
                ReceiverPhoneNumbers = new List<string> { "091*******" }
            };

            //act
            var service = new SmsService();
            var result=await service.Send(model);
            
            
            //assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);

        }
    }
}
