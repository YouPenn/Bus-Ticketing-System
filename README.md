# Bus-Ticketing-System

Client site Login:

Email: youpenn2003@gmail.com
Password: abcd1234
Security Answer: Meow

Email: sooyk-jm21@student.tarc.edu.my
Password: 1234abcd
Security Answer: SJKCJementah

====================

Admin site Login:

ID: A001 
Password: A123456


ID: A002 
Password: B123456


====================

Installation Steps:

Download and Unzip:
-Download: Get the "Assignment.zip" file onto your computer.
-Unzip: Extract the contents of "Assignment.zip" to a folder anywhere on your computer.

Open in Visual Studio 2019:
-Launch Visual Studio 2019: Open the Visual Studio program.
-Open Project: Use the "Open" or "Open Project/Solution" option in Visual Studio.
-Select File: Browse to the folder where you unzipped the files and choose the .sin file to open the project in Visual Studio 2019.

Start the Program:
-Within Visual Studio 2019: Look for and click on the "IIS Express" button (usually looks like a play button) to begin the program.
-Running the Program: This action will start the server and launch the program, making it accessible via a web browser.

====================

Troubleshooting Database:
-If the database encounters issues:

Solution 1:

-Open Visual Studio 2019.
-Navigate to "Server Explorer" and find "Data Connections."
-Within "Data Connections," locate "ConnectionString(Assignment)" and "ConnectionString2(Assignment)."
-Right-click on "ConnectionString(Assignment)" and choose "Modify Connection..."
-Click on "Browse" to search for the "App_Data" folder within the "Assignment" folder.
-Select the "BusDB.mdf" file and click "OK."
-Repeat the above steps to find and select the "UserDB.mdf" file.


Solution 2:

-Restart your computer.
-Locate and delete the "App_Data" folder from the project directory.
-Use a backup "App_Data" folder (found in "App_Data_Backup.zip") to replace the deleted one.
-After replacing the folder, reopen the program in Visual Studio 2019.
-Go to "Server Explorer," right-click on "Data Connections," and select "Add Connection..."
-Choose "Microsoft SQL Database File" and click "Browse" to locate the replaced "App_Data" folder.
-Select the "BusDB.mdf" file and click "OK."
-Repeat the same process to find and select the "UserDB.mdf" file.

=======================



