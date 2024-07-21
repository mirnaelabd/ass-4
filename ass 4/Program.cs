using ass_4.Interface;

namespace ass_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MCQ
            //1-What is the primary purpose of an interface in C#? (A)
            //2- Which of the following is NOT a valid access modifier for interface members in C#? (A)
            //3-Can an interface contain fields in C#? (C)
            //4-In C#, can an interface inherit from another interface?(b)
            //5-Which keyword is used to implement an interface in a class in C#? (d)
            //6-Can an interface contain static methods in C#? (b) 
            //7-In C#, can an interface have explicit access modifiers for its members? (b)
            //8-What is the purpose of an explicit interface implementation in C#? (b) 
            //9-In C#, can an interface have a constructor?(b)
            //10-How can a C# class implement multiple interfaces? (c) 
            #endregion

            #region QUES 1

            /*        ICircle circle = new Circle(5.0);
                    IRectangle rectangle = new Rectangle(4.0, 6.0);
                    circle.DisplayShapeInfo();
                    rectangle.DisplayShapeInfo();
            */

            #endregion

            #region QUES 2
            /*         IAuthenticationService authService = new BasicAuthenticationService();
                     string username = "admin";
                     string password = "password";
                     string role = "admin";
                     bool isAuthenticated = authService.AuthenticateUser(username, password);
                     bool isAuthorized = authService.AuthorizeUser(username, role);
                     Console.WriteLine($"Authentication result: {isAuthenticated}");
                     Console.WriteLine($"Authorization result: {isAuthorized}");*/
            #endregion

            #region QUES 3 
      /*      INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();

            string recipient = "Mirna";
            string message = "Hello! This is a notification message.";

            emailService.SendNotification(recipient, message);
            smsService.SendNotification(recipient, message);
            pushService.SendNotification(recipient, message);*/
            #endregion




        }





    }
}
