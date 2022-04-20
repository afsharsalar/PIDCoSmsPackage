#PIDCoSmsPackage
=======
<div dir="rtl">



PIDCoSmsPackage کتابخانه ای است برای ارسال اس ام اس.


</div>

[![Nuget](https://img.shields.io/nuget/v/PIDCoSmsPackage)](https://www.nuget.org/packages/PIDCoSmsPackage/)
```
PM> Install-Package PIDCoSmsPackage
```
<div dir="rtl">
  <h2>نحوه کار 
</h2>
  
</div>



```csharp
var smsService =new SmsService();
await smsService.Send(new SendViewModel
            {
                Password = "****",
                Username = "*****",
                Folder = "web",
                Number = "500010****",
                ReceiverPhoneNumbers = new List<string>{"091********"},
                SmsText = "تست وب"
            });
```


