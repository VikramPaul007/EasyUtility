<div align="center">
  <img src=".\Utility.Lib\Utility.jpeg" alt="EasyUtility">
</div>

# EasyUtility

'EasyUtility' is a comprehensive .NET library designed to streamline daily development tasks by providing essential features. Its primary aim is to support developers globally by eliminating the necessity to repeatedly build common functionalities for every application.

## Functions

- XSS Validation
- File Operation
- Notification

## Usage

### XSS Validation

This function validates PDF files to ensure they do not contain any malicious scripts that could lead to Cross-Site Scripting (XSS) attacks. The current implementation only checks for PDF files, but it can be expanded to include other file types in the future.

#### Example:

```csharp
string filepath = @$"wwwroot\xss.pdf";
var fileBytes = File.ReadAllBytes(filepath);

using MemoryStream stream = new(fileBytes);
IXssValidator xssValidator = new PdfXssValidator();

bool isValidFile = xssValidator.Validate(stream);
```

This code snippet tests the Validate function with an example PDF file. If the file is safe and doesn't contain any scripts, it returns true. Otherwise, it returns false. By using this function, developers can ensure that their PDF files do not pose a security risk to their users.

### File Operation

The 'File Operation' module is a versatile and comprehensive solution for managing file operations in modern web applications. With the increasing prevalence of file operations in various applications, developers often find themselves repeating the same code for each project. This module streamlines the process by providing a simple interface for managing file uploads and downloads.

Moreover, the module addresses the common challenge of changing project requirements for file storage. Whether it's transitioning from a database to a network drive, cloud storage, or another platform, the module implements the strategy pattern to enable seamless changes at runtime. This means that developers can switch storage platforms without requiring additional code or deployment, making the process quick and efficient. By using this module, developers can save time and effort while ensuring that their applications are flexible and adaptable to changing requirements.

#### Example:

```csharp
var fileBytes = File.ReadAllBytes("test.jpg");
 
IFileManagerStrategy fileSystemStrategy = new FileSystemStrategy();
IFileManagerStrategy nasStrategy = new NetworkDriveStrategy("NAS LOCATION", "USERNAME", "PASSWORD", "DOMAIN");

FileManagerContext fileManagerContext = new(fileSystemStrategy);
fileManagerContext.Upload("UPLOAD PATH", fileBytes);

fileManagerContext.SetFileManagerStrategy(nasStrategy);
fileManagerContext.Upload("NAS PATH", fileBytes);
```

This code snippet creates a strategy to upload to a file system at first. Then it changes the strategy to upload to a Network Drive at runtime.

More functionalities will be added in near future. If anyone has any suggestions, kindly share them with me or raise an issue. I will be grateful if you join me in this mission and contribute in any way.
