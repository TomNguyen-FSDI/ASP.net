// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function navbar(){
    var title=document.title;
    var syntax=`
    <div class="container-fluid">
        <div class="navbar-expand-sm navbar-collapse" id="navbarNavAltMarkup">
            <div class="navbar-nav">
                <a class="nav-link" aria-current="page" href="../Home/Index" id="homePage">Home</a>
                <a class="nav-link" href="../Home/About" id="aboutPage">About Me</a>
                <a class="nav-link" href="../Home/Tasks" id="todoPage">Task Manager</a>
                <a class="nav-link" href="../Home/Privacy" id="privacyPage">Privacy</a>
            </div>
        </div>
    </div>
    `;
    $(".navbar").append(syntax);
    if(title=="Home Page"){
        $("#homePage").addClass("active");
    }else if(title =="About Me"){
        $("#aboutPage").addClass("active");
    }else if(title =="Todo List"){
    $("#todoPage").addClass("active");
    }else if(title =="Privacy Policy"){
        $("#privacyPage").addClass("active");
    }
}

navbar();