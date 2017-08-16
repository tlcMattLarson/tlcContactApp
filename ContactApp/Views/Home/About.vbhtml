@Code
    ViewData("Title") = "About"
End Code

<div class="row">
    <h1>@ViewData("Title")</h1>
    <p>
        Overall, I enjoyed myself while working on this project. Any time I can start my day with something I don't fully understand and end it having 
        learned a great deal I consider it a success. Not only is it a success but it's also very satisfying. Below I outline my general process while working 
        on this project - I look forward to hearing what you have to say.
    </p>
</div>

<div class="row">
    <h3>Configuring My Environment</h3>
    <p>
        I cloned the repository to my local machine. I confirmed that the project was last modified by Visual Studio 2015 and so that is the version I installed. 
        My version was out of date and I wanted to make sure to minimize any risk of compatibility issues.
    </p>
</div>

<div class="row">
    <h3>Connecting the Model</h3>
    <p>
        After examining the project and all of the files that came with it I decided to start by adding "Email" to the model as a scalar property.
        The reason I started with that is because I discovered that there is an option to generate the database from the model definition so 
        I figured it would be easier to start with completing the model.
    </p>
    <p>
        Next I searched for a way to add the database connection. I determined that it is done by adding a connection string into the 
        Web.config file. I was able to successfully connect to the database. However, when I generated the database from the model it ended 
        up creating another connection string so I opted to keep the new one, as it also seemed to work just fine. After this I ran a quick 
        insert statement to add a single test row and I had my database setup.
    </p>
</div>

<div class="row">
    <h3>Creating the Contact Controller</h3>
    <p>
        Initially, I started using the HomeController to build my solution. I created Actions for the "Contact" and "About" pages so that I
        could successfully browse out to them. Then I started researching how to utilize the model to populate my view with data. I came 
        across a tutorial which showed how to generate a controller and views to edit/add/delete records from the model. That is when I 
        created the ContactController using Visual Studio's built-in functionality to generate it from scaffolding. That was all that was 
        required to get the core functionality working.
    </p>
    <p>
        After that, I studied the code that was generated so that I could understand how it all worked together. I learned how the model 
        was manipulated through the controller and then ultimately passed to the view.
    </p>
</div>

<div class="row">
    <h3>Finishing Up</h3>
    <p>
        With the core functionality implemented I looked towards making the project the best it could be. I updated the home page to 
        include a working navigation menu and modified the main content to fit the project.
    </p>
    <p>
        I noticed that the project included the jQuery validate library so I decided to implement the validation bonus features. I 
        figured it would be easy as I have used that library before. After my initial implementation I noticed that the validation was 
        behaving differently on the create and edit pages. I believe this was because one of the pages was using the built-in 
        unobtrusive validation. After learning how that worked, I removed my code in favor of adding the validation into the model.
    </p>
    <p>
        Finally, I wanted to change how the app worked if you tried to edit/delete an item that did not exist (i.e. an id that was out 
        of range). I changed it to simply redirect back to the list in these situation to avoid the error message.
    </p>
    
</div>