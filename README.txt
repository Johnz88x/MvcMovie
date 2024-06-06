2024-05-16
JOHNSON ROBERT
0146 EDT
0851061


1340
Created a new ASP.NET MVC Core Application
Using .NET 7 without using authenticatiom 'NONE'

1345
Ran the application 
The output was displayed in the Edge browser https://localhost:7072/
The page displayed 'WELCOME'
Thus completed the first task

1355
Created a new controller in 'Controllers'
The name given is 'HelloWorldController.cs'

1410
Modified the contents of the new controller with the below code

Added a new method Index
Inside the method added the comment in the return 'Welcome to HelloWorld'

Added another method named Welcome
Inside the method added the comment in the return 'Welcome to MyWorld'

1415
Then ran the application once again and the browser window opened and the output was a success..
In the browser URL, changed the URL to https://localhost:7072/helloworld/

The browser displayed 'Welcome to HelloWorld'

In the browser URL, changed the URL to https://localhost:7072/helloworld/welcome

The browser displayed 'Welcome to MyWorld'

1430
Edited the code to get the output by adding parameters in the method
Added the parameters name and numTimes.
name as string and numTimes as int

1445
Ran the application but was having built errors
Error was : HtmlEncoder does not exist in current context

Clicked on show potential fixes and the correction was 'using System.Text.Encodings.Web'
After adding the above the code showed 0 errors

1501
Ran the application again and it was a success
changed the URL to https://localhost:7072/helloworld/welcome?name=Johnson&numTimes=4

The browser output displayed 'Hello Johnson, NumTimes is 4'

1510
Changed the code as below to modify the parameters for the below method
Changed the parameters in the method Welcome as name and ID

Ran the application again and it was a success
changed the URL to https://localhost:7072/helloworld/welcome/0851061?name=Johnson

The browser output displayed 'Hello Johnson, ID : 0851061'
Tried changin the values in the URL to change the output
Sucess the output varied

<<<<<<<<<<<<<<<<<<<<<<End Part 2>>>>>>>>>>>>>>>>>>>>>>>>>>>>

-----------------------PART 3------------------------

1351
Opened the existing project MvcMovie to create views
Created a new by Right-clicking on the Views folder, and then Add > New Folder and name the folder HelloWorld
Right-click on the Views/HelloWorld folder, and then Add > New Item.
In the search box in the upper-right, enter view
Select Razor View - Empty
Keep the Name box value, Index.cshtml. Select Add

1355
Edited the HelloWorldController.cs file
Reverted the new editions we did to the previous version
The method IActionResult was changed from the commented option
Also made the existing codes to comment to remove from action

1400
Replaced the contents of the Views/HelloWorld/Index.cshtml with the new code given
The Index method in the HelloWorldController ran the statement return View()
This specifies that the method should use a view template file to render a response to the browser
A view template file name wasn't specified, so MVC defaulted to using the default view file. 
When the view file name isn't specified, the default view is returned.

1410
Select the menu links MvcMovie, Home, and Privacy. Each page shows the same menu layout. 
The menu layout is implemented in the Views/Shared/_Layout.cshtml file.
Opened the file but there are three instances of MvcMovie
Need to change the MvcMovie to 'Movie App'
Made the necessary changes in the layout.........there was no errors found
Ran the application to compile

1420
Edited the view index file
Made changes to 'ViewData' title to 'Movie List'
Also made the changes in the header to display on the webpage

1430
The ViewData dictionary is a dynamic object, which means any type can be used. 
The ViewData object has no defined properties until something is added.

1440
Created a new welcome.cshtml file 
Added the commands to get the dynamic values in the output

1445
Ran the output in the brower using the link https://localhost:7072/helloworld/welcome/Welcome?name=Johnson&numtimes=4
The command is to show the output 4 times

1450
Success....the ouput was exactly displayed

Step 4

1500
Started working on the model
Right-click the Models folder > Add > Class. Name the file Movie.cs
The added the code exactly as the code given

1510
Compiled the code to check for errors
It ran without any errors

1520
From the Tools menu, select NuGet Package Manager > Package Manager Console
Added the Package manager console which took sone time

1530
The migration file was created 
20240523195711_InitialCreate.cs
Wow...though it took long it worked fine

1540
Opened the Package Manager Console and copied the codes to intiate the migration

1550
In the PMC entered the commands commands given 
The command updated the database 

1555
Opened the browser to check the output
URl https://localhost:7072/Movies
Wow output worked successfully

1600
Then added new movies to the list of My movies
4 movies added with their generes included.
Succesfully completed the Part4 

2024-05-29
<<<Step 5>>>

1300
Started doing the steps from Step5

1310
Removed all the list of movies added in the database
Then ran the program once again 
Sucess the output showed no movies in the list

1315
Added a new class to the Model named SeedData

1320
Added the code to seed movies to the list 
stopped the application

1325
Then opened the program.cs to add code
Added the code to add seed movies to the list

1330
Ran the application once again
Success the database has been updated with the new movies list

<<<STEP 6>>>
1340
Opened Movie.cs and started added new code for the change the display name
The display name was showing ReleaseDate in without space

1350
Added new code to the file Models/Movie.cs 
The code was added to show the view as 'Release Date'

1400
Started inspecting the code created after running the Seeddata

1405
The Edit, Details, and Delete links are generated by the Core MVC Anchor
Tag Helper in the Views/Movies/Index.cshtml file.

1410
Open the Movies controller and examine the two Edit action methods.

1415
The HttpPost attribute specifies that this Edit method can be invoked only for POST

1418
Checked with different values in the data field and tried to save 
It was unable to save....

1420
Tried to enter characters in the Price field
Then tried to save the file
I was unable to save the file and was getting error
It was show error 'The field price must be a number'

2024-05-30
<<<PART 7>>>

1420
Now need to add the search option in the list
Opened the file MoviesController.cs
Editted the Index method in the file with the new code
Saved the file

1425
Ran the code to see the output 
Succes the application ran withour any errors
Opened the link https://localhost:7072/Movies/?searchString=Ghost

1428
Success the search returned 2 movies
Ghostbusters and Ghostbusters2

1430
Changed the code in MoviesController.cs
The searchstring command is changed to 'id' in the index method
Then saved the file

1435
Then ran the application
Success..the application ran without any errors

1440
Then opened the broweser with the link given below
https://localhost:7072/movies/index/ghost
Success...the output showed 2 ghostbuster movies as per the code

1445
Changed the code in the MoviesController.cs from 'id' to 'searchString'
Then saved the file
Ran the browser and checked the output
The output was running successfully

1450
inorder to get the output in HTTPpost
made the changes to file Movies/index.cshtml

1455
Saved the files without errors
Ran the outputin the browsers and got the link when u try the search
https://localhost:7072/Movies?SearchString=ghost

1500
Moving to add search by genre option in the application

1505
Added a new class to the models folder
The name of the new class is MovieGenreViewModel 

1510
Opened the file and added the new code to the file
Then saved the file
The file saved without any errors

1515
Then opened MoviesController.cs 
Editted the index.cshtml file

1520
Then editted the file Views/Movies/Index.cshtml
Then added the code to show the view for the search 
Then editted the controller part
Also the class=table part in the header
Also made some changes in the body part

1525
Saved the file without any errors
Ran the application

1530
Success...output displayed without any errors
The search option was also working fine

<<<STEP 8>>>
1532
Need to add a Rating Field to the database

1535
Opened the file Models/Movie.cs
Then made changes to the class Movie
Added a line for Rating

1540
Then will Ctrl+Shift+B to build the program

1545
Open the MoviesController.cs to edit the file
Update the bind 

1550
The Database migration completed successfully
20240530194324_Rating.cs

1555
Then ran the application once again
The application executed successfully

1600
Then checked the values for ratings updated succesfully
The clicked on the edit option 
Edited the Ratings option
Success RAtings was cheanged successfully

2024-06-02
1100
<<<STEP 9>>>


1105
Need to add a validation to the project

1110
Updated the code in the model movie.cs
Added the validation for the attributes

1120
Add Required validation for the string length for the parameter Id

1125
Added the range for the currency 
Also added the datatype as currency

1130
Added string length for the genre as a validation

1135
Ran the program once again 
The application ran without any errors

1140
Started to test for the validation 
opened a create page in the application

1150
Then tried saving the page without providing any inputs 
Success...the validations were asked
Good...completed the editing for the output within 50 minutes

Total Time : 50 minutes

2024-06-06
1400

<<<Creating Github and Pushing the data Project to the Github Repository>>>

1430
Created an account on Github

1440
Opened the  Git option in Visual Studio
Clicked on create new repository
Added our Github account to the visual studio

1445
Made changes to the SeedData.cs file inorder to add new movie list

1450
Deleted all the contents in the DB manully

1455
Ran the application once again, executed successfully
The new movie list was updated in the DB and shown in Movies List

1500
After edit commited the file and then pushed the updates to Github.

TOTAL HOURS FOR COMPLETION OF PROJECT : 0710

<<<END>>>













