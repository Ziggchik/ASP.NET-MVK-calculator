# User Manual
## Installation:
1) Follow the link: https://github.com/Ziggchik/ASP.NET-MVK-calculator
2) Press green button "Code"

      ![1](https://user-images.githubusercontent.com/70440445/131743929-bfce74eb-9d97-4c9e-bd12-e3189cac2aaa.png)      

3) In the drop-down list that opens, select how you want to install the project

      ![image](https://user-images.githubusercontent.com/70440445/131725753-8f39cd5f-c8f0-4043-9797-fd262e47fa1d.png)
### Download Zip:
1) Download Visual Studio. link for download: https://visualstudio.microsoft.com/ru/downloads
2) Press button "Download Zip"
3) The "download" folder will contain the downloaded archive, unzip it to any place on your computer
4) In Unzip files open  "Calculator.sln"

      ![image](https://user-images.githubusercontent.com/70440445/131748509-48fa3b07-4c9f-4c72-ac36-953ca8bc87ee.png)

6) Save open project (Ctrl+Shift+S) in any place on you computer
7) Press buttons combination "Shift+F5" to launch application
### Open with Visual Stido:
1) Download Visual Studio. link for download: https://visualstudio.microsoft.com/ru/downloads
2) Press button "Open with Visual Studio"
3) In Visual Studio click to button "Clone repository"
4) Solution will donwload from repository and you can save project (Ctrl+Shift+S) in any place on you computer
### Download with command:
1) Press button combination "Win+R" and write "cmd"
2) Write this commands:
* git clonehttps://github.com/Ziggchik/ASP.NET-MVK-calculator.git
* cd ASP.NET-MVK-calculator
* dotnet build
* dotnet run
3) After that application will start
## How to use:
* Short gif which help user with working in application

![Анимация](https://user-images.githubusercontent.com/70440445/131743902-2a519b39-2970-4dc8-9cf6-74b5962699d2.gif)

## Architecture:
1) The project create with ASP.NET Framework 4.7.2 MVK and using languages such as C# and JavaScript.
2) On screenshot below show which folders were used to form the project architecture
![image](https://user-images.githubusercontent.com/70440445/131744989-413a071d-345b-4a21-a7e3-ea3869d18358.png)
* Controllers/CalcController.cs-this class contain code which perform the operation of the calculator like: Addition, Subtraction, Multiplication, Division, Equal, Purification
* Models/calc.cs-this class contain variables, which forms arithmetic operations ((float type)number1  + or - or / or x number2=result,(string)exception-division by 0 exception warning)
* Views/Home/Index.cshtml-contain html code, which forms the appearance of a web resource.
3) And for bonus project have alternative web form with another more classic calculator.

      ![image](https://user-images.githubusercontent.com/70440445/131746930-156d2a66-2c51-49f6-acd2-912d6053446a.png)

![Анимация1](https://user-images.githubusercontent.com/70440445/131747518-dfaddb3e-5a34-4e1b-a471-3e27a939e22b.gif)

