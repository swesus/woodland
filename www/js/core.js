

$(document).ready(function () {
    core.initJS();
    core.initHomePage();
    core.initMissionPage();
    core.initFormFocus();
    core.initTwitterFeed();
});

var core = {

    initJS: function () {
        $("body").removeClass("no-js").addClass("js");
    },

    initHomePage: function () {

        if ($("#default_aspx").length > 0) {

            $("body").mouseover(function () {
                $("body").unbind();
                core._showHomePageLinks();
            });
        }
    },

    _showHomePageLinks: function () {

        // Show the acorn:
        $("#HomePageLinks div.acorn div").fadeOut(7000);

        // Show the links one at a time:
        var iGap = 700;
        var iWait = 500;

        core._showSingleHomePageLink("nav_gallery", iWait);
        iWait += iGap;
        core._showSingleHomePageLink("nav_courses", iWait);
        iWait += iGap;
        core._showSingleHomePageLink("nav_who", iWait);
        iWait += iGap;
        core._showSingleHomePageLink("nav_contact", iWait);
        iWait += iGap;
        core._showSingleHomePageLink("nav_thinktank", iWait);
        iWait += iGap;
        core._showSingleHomePageLink("nav_how", iWait);
        iWait += iGap;
        core._showSingleHomePageLink("nav_about", iWait);
        iWait += iGap;
        core._showSingleHomePageLink("nav_events", iWait);
        iWait += iGap;
        core._showSingleHomePageLink("nav_gallery", iWait);
        
    },

    _showSingleHomePageLink: function (sClassName, iWait) {
        setTimeout("$('#HomePageLinks a." + sClassName + "').fadeIn(1000);", iWait);
    },

    initMissionPage: function () {

        if ($("#mission_aspx").length > 0) {

            $("div#jSlide_bottom").hide();
            $("div#jSlide_top").append("<p><em>Click anywhere on the page to veiw our Vision Statement</em></p>");

            $(document.body).click(function () {
                if ($("div#jSlide_top").is(":hidden")) {

                    $("div#jSlide_top").slideDown("slow");
                    $("div#jSlide_bottom").slideUp("slow");

                } else {

                    $("div#jSlide_bottom").slideDown("slow");
                    $("div#jSlide_top").slideUp("slow");
                }
            });
        }
    },

    initFormFocus: function () {
    
        $("input.text, textarea")
        .focus(function(){
            $(this).addClass("focused");
        })
        .blur(function(){
            $(this).removeClass("focused");
        });
    },

    initTwitterFeed: function () {

        $(".tweets").tweet({
            username: "woodlandshev",
            join_text: "auto",
            count: 3,
            auto_join_text_default: "",
            auto_join_text_ed: "",
            auto_join_text_ing: "",
            auto_join_text_reply: "",
            auto_join_text_url: "",
            loading_text: "loading tweets..."
        });
    }
}
