$(document).ready(function(){
    alert("Working jQuery!");
    $("form").submit(function(event){
        console.log("form is submitted");
        console.log(event);
        console.log($(this).serialize());
        event.preventDefault();
        $.ajax({
            url: "/process",
            method: "POST",
            // this is the selector selected (the form in this case)
            data: $(this).serialize(),
            // return type exected - optional
            dataType: 'json',
            success: function(responseFromServer) {
                console.log('************************************************');
                console.log(responseFromServer);
                // update the html
                $('tbody').append(`<tr><td>${responseFromServer.name}</td><td>${responseFromServer.location}</td></tr>`);
                // reset the submitted form
                $('form')[0].reset();
                // log all forms
                console.log($('form'));
            },
            error: function(error) {
                console.log('^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^');
                console.log(error);
            },
            done: function(data) {
                console.log('++++++++++++++++++++++++++++++++++++++++++++++++++++');
                console.log('in done, ');
            }
        })
        // return false;
    })
})