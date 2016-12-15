$(function () {
    var array1 = ["zore", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
    var timer = null;
    var count = 10;
    $("#div2").hide();
    // $("#div1").hide();
    $("#start").click(function () {
        //    alert("hello");
        //   $(this).css("background","#000033");
        //   $("#div1").toggle(300);
        //   $("#div2").fadeOut(300);
        count = 10;
        timer = setInterval(countNo, 1000);
    });

    $("#stop").click(function () {
        $("#result").html("");
        $("#div1").html("");
        $("#div2").hide();
        clearInterval(timer);
    });

    function countNo() {
        if (count != 0) {
            count -= 1;
            $("#result").html(count + "->" + array1[count]);
            var rad = Math.floor(Math.random() * 10) + 1
            $("#div1").html("<h2>" + rad + "</h2>");
            if (count == rad) {
                $("#div2").fadeIn(300);
                clearInterval(timer);
                alertify.confirm('這是確認框，你有兩個選擇：', function (e) {
                    if (e) {
                        alertify.log('你按下了 ok');
                        $("#result").html("");
                        $("#div1").html("");
                        $("#div2").hide();
                        console.log('你按下了 ok')
                    } else {
                        alertify.log('你按下了 cancel');
                        console.log('你按下了 cancel')
                    }
                });

            }
        } else {
            clearInterval(timer);
            // alert("Over");
            $("#result").html("Over");
        }
    }
});