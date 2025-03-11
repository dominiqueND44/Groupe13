using Twilio;
using Twilio.Rest.Api.V2010.Account;
using System;
using System.Collections.Generic;

public class A2FService
{
    private const string accountSid = "AC62bad8595cea899a67faf6c240ee9512";
    private const string authToken = "1fa0c48c5a5e2104676daa2466541ed4";
    private const string twilioPhoneNumber = "+1 878 788 8597"; 
    private static readonly Dictionary<string, Tuple<string, DateTime>> otpStorage = new Dictionary<string, Tuple<string, DateTime>>();

    // Envoi d'un OTP
    public static void SendOtp(string userPhoneNumber)
    {
        string otpCode = new Random().Next(100000, 999999).ToString();
        DateTime expirationTime = DateTime.UtcNow.AddMinutes(5);

     otpStorage[userPhoneNumber] = new Tuple<string, DateTime>(otpCode, expirationTime);

        /*   TwilioClient.Init(accountSid, authToken);
         MessageResource.Create(
             body: $"Votre code OTP est : {otpCode}. Il expire dans 5 minutes.",
             from: new Twilio.Types.PhoneNumber(twilioPhoneNumber),
             to: new Twilio.Types.PhoneNumber(userPhoneNumber)
         );
        */

        Console.WriteLine($"OTP envoyé : {otpCode} à {userPhoneNumber}");
    }

    // Vérification du code OTP
    public static bool VerifyOtp(string userPhoneNumber, string enteredOtp)
    {
        if (otpStorage.ContainsKey(userPhoneNumber))
        {
            var storedOtp = otpStorage[userPhoneNumber];

            if (DateTime.UtcNow > storedOtp.Item2)
            {
                Console.WriteLine("Code OTP expiré !");
                otpStorage.Remove(userPhoneNumber);
                return false;
            }

            if (enteredOtp == storedOtp.Item1)
            {
                Console.WriteLine("OTP valide !");
                otpStorage.Remove(userPhoneNumber);
                return true;
            }
        }

        Console.WriteLine("OTP invalide !");
        return false;
    }
}
