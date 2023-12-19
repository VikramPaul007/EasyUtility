// See https://aka.ms/new-console-template for more information

using Utility.Lib.Domains.FileManagement.Helper;

Console.WriteLine("Welcome to Utlity.Console.Test");

//SmtpClient smtpClient = new();
//EmailMessage emailMessage = new("", "", "", "");
//INotifierFactory emailFactory = new EmailNotifierFactory(smtpClient, emailMessage);
//INotifier notifier = emailFactory.CreateNotifier();
//notifier.Notify();

//var fileBytes = File.ReadAllBytes("C:\\Users\\Vikram.Paul\\Downloads\\BirshaMunda.jpg");

//IFileManagerStrategy fileSystemStrategy = new FileSystemStrategy();
//IFileManagerStrategy nasStrategy = new NetworkDriveStrategy("", "", "", "");

//FileManagerContext fileManagerContext = new(fileSystemStrategy);

//fileManagerContext.SetFileManagerStrategy(nasStrategy);


//Xss Validation in PDF file
ValidateFile();


//Console.WriteLine(content);
Console.ReadLine();


static void ValidateFile()
{

    var fileBytes = File.ReadAllBytes("C:\\Users\\Vikram.Paul\\Downloads\\xss.pdf");

    using MemoryStream memoryStream = new(fileBytes);

    IXssValidator xssValidator = new PdfXssValidator();
    var validator = xssValidator.Validate(memoryStream);

    //if(javascript.GetKeys().Count > 0 )

    //pdfDocument.Close();
}


