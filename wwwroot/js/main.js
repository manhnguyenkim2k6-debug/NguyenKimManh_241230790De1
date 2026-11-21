// AssetHub - hiệu ứng giao diện cơ bản (nút "lên đầu trang")
$(function () {
    $(window).on('scroll', function () {
        $('.to-top').toggle($(this).scrollTop() > 200);
    });
    $('.to-top').on('click', function () {
        $('html, body').animate({ scrollTop: 0 }, 400);
    });
    $('.search-box input').on('focus', function () { $(this).select(); });
});
$(document).on("click", ".menu-loai", function (e) {
    e.preventDefault();
    var maLoai = $(this).data("maloai");
    $.ajax({
        url: "Home/LocTheoLoai", type: "GET", data: { maLoai },
        success: function (result) {
            $("#dsTaiSan").html(result);
        },
        Error: function () {
            alert("Loi tai");
        }
    });
});
