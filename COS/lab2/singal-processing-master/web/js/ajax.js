/**
 * Created by Антон on 16.08.2016.
 */
$("#id-user-login").on("change",function() {
    var login = $(this).val();
    if(login.length > 3) {
        $(".status").html("Checking availability...");
        $.ajax({
            type: "POST",
            url: "jsoncontroller",
            data: "user-login=" + login + "&" +
            "command=" + "check_login_availability",
            success: function(msg) {
                Materialize.toast(msg, 4000);
            }
        });
    }
    else {
        Materialize.toast("Login must be longer than three characters", 4000);
    }
});