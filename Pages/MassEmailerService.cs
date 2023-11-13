using System.Net;
using System.Net.Mail;
using System.Text;
using CodeMechanic.Extensions;
using CodeMechanic.Types;

namespace RazorHAT_Template.Pages;

public interface ICommentService
{
    Task SendEmail(string from, string subject, string email, string comments);
}

public class MassEmailerService : ICommentService
{
    private static StringBuilder error_messages = new StringBuilder();
    public string Errors => error_messages.ToString();

    public async Task SendEmail(string from, string subject, string email, string comments)
    {
        try
        {
            // using SmtpClient mail_client = new SmtpClient();
            // using MailMessage mail_message = new MailMessage();
            //
            // string gmail_passphrase = Environment.GetEnvironmentVariable("GMAIL_PASSPHRASE");
            //
            // mail_client.Host = email.Host;
            // mail_client.Port = 587;
            // mail_client.EnableSsl = true;
            // mail_client.DeliveryMethod = SmtpDeliveryMethod.Network;
            // mail_client.Credentials = new NetworkCredential(
            //     SampleEmails.MyEmail
            //     , gmail_passphrase);
            //
            // mail_client.Send(mail_message);
        }
        catch (Exception ex)
        {
            ex.Message.Dump("Uh oh! Something went wrong!");
            error_messages.AppendLine(ex.Message);
            throw;
        }

        // return this;
    }
}