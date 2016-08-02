accountButtonPress("#btn-login", ".login-div");
accountButtonPress("#btn-signup", ".signup-div");
gobackButtonPress("#btn-goback-login", ".login-div");
gobackButtonPress("#btn-goback-signup", ".signup-div");

function accountButtonPress(button, showDiv) {
    $(button).click(function () {
        $(".account-info-div").fadeOut("fast", function () {
            $(".header").css("padding-top", "1em");
            $(showDiv).fadeIn(350);
        });
    });
}

function gobackButtonPress(button, hideDiv) {
    $(button).click(function () {
        $(".header").css("padding-top", "10em");
        $(hideDiv).fadeOut("fast", function () {
            $(".account-info-div").fadeIn("fast");
        });
    });
}

$("[name='my-checkbox']").bootstrapSwitch();