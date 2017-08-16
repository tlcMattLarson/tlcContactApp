@Code
    ViewData("Title") = "Home Page"
End Code

<div class="jumbotron">
    <h1>TLC Companies - Contact App</h1>
    <p class="lead">Please use the navigation bar at the top or the buttons below to browse the project.</p>
</div>

<div class="row">
    <div class="col-md-6">
        <h2>Contacts</h2>
        <p>
            This page demonstrates the core requirements of the project. Namely:
            <ul>
                <li>Connect the app model to the database</li>
                <li>Add email addresses to the model/database</li>
                <li>A page to add/view/delete/edit contacts</li>
            </ul>
            Bonus features include:
            <ul>
                <li>Responsive Design</li>
                <li>All validation requirements</li>
            </ul>
        </p>
        @Html.ActionLink("Contacts", "Index", "Contacts", New With {.area = ""}, New With {.class = "btn btn-default"})
    </div>
    <div class="col-md-6">
        <h2>About</h2>
        <p>This page describes my methodology working through the project and outlines what I've learned along the way.</p>
        @Html.ActionLink("About", "About", "Home", New With {.area = ""}, New With {.class = "btn btn-default"})
    </div>
</div>
