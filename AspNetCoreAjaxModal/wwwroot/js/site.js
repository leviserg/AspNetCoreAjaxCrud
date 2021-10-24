// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification

$(document).ready(function () {

    $('[data-toggle="tooltip"]').tooltip();

    $(window).scroll(function () {
        if ($(this).scrollTop() > 200) {
            $('.scrollup').fadeIn();
        }
        else {
            $('.scrollup').fadeOut();
        }
    });

    $('.scrollup').click(function () {
        $("html, body").animate({ scrollTop: 0 }, 500);
        return false;
    });

    $('.modal').on('hidden.bs.modal', function (event) {
        $(this).removeClass('fv-modal-stack');
        $('body').data('fv_open_modals', $('body').data('fv_open_modals') - 1);
    });

    $(document).on('show.bs.modal', '.modal', function () {
        var zIndex = 1040 + (10 * $('.modal:visible').length);
        $(this).css('z-index', zIndex);
        setTimeout(function () {
            $('.modal-backdrop').not('.modal-stack').css('z-index', zIndex - 1).addClass('modal-stack');
        }, 0);
    });
});

$(function () {
    $("#loaderbody").css("display", "none");
    $(document).bind('ajaxStart', function () {
        $("#loaderbody").css("display", "initial");
    }).bind('ajaxStop', function () {
        $("#loaderbody").css("display", "none");
        });
    $("#filtered").css("display", "none");
});

function OpenModal(url, title) {
    $.ajax({
        type: "GET",
        url: url,
        contentType: false,
        cache: false,
        success: function (response) {
            $("#form-modal .modal-body").html(response);
            $("#form-modal .modal-title").html(title);
            $('#form-modal').modal("show");
            $("#dt_picker").datetimepicker({
                format: 'yyyy-MM-DD HH:mm:ss'
            });
        },
        error: function (err) {
            console.log(err);
        }
    })
}

function ajaxSave(form) {
    try {
        $.ajax({
            type: 'POST',
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (response) {
                if (response.isValid) {
                    $("#view-all").html(response.html);
                    $("#filtered").css("display", "initial");
                    $("#form-modal .modal-body").html('');
                    $("#form-modal .modal-title").html('');
                    $('#form-modal').modal("hide");
                    $.notify('submitted successfully', { globalPosition: 'top center', className: 'success', autoHideDelay: 1000 });
                }
                else {
                    $("#form-modal .modal-body").html(response.html);
                }
            },
            error: function (error) {
                console.log(error);
            }
        });
    } catch (e) {
        console.log(e);
    }
    return false;
}

function ajaxDelete(form) {
    swal({
        title: "Are you sure?",
        text: "Once deleted, you will not be able to recover this record!",
        icon: "warning",
        buttons: true,
        dangerMode: true,
    })
    .then((willDelete) => {
        if (willDelete) {
            try {
                $.ajax({
                    type: 'POST',
                    url: form.action,
                    data: new FormData(form),
                    contentType: false,
                    processData: false,
                    success: function (response) {
                        $("#view-all").html(response.html);
                        $("#filtered").css("display", "initial");
                        $.notify('deleted successfully', { globalPosition: 'top center', className: 'success', autoHideDelay: 1000 });
                    },
                    error: function (error) {
                        console.log(error);
                    }
                });
            } catch (e) {
                console.log(e);
            }
        }
    });
    return false;
}

function ajaxSearch(form) {
    try {
        $.ajax({
            type: 'POST',
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (response) {
                $("#view-all").html(response.html);
                $("#filtered").css("display", "initial");
            },
            error: function (error) {
                console.log(error);
            }
        });
    } catch (e) {
        console.log(e);
    }
    return false;
}

$(function () {
    /*
    $.fn.datepicker.dates['ru'] = {
        days: ["Воскресенье", "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота"],
        daysShort: ["Суб", "Пон", "Втр", "Срд", "Чет", "Пят", "Суб"],
        daysMin: ["Вс", "Пн", "Вт", "Ср", "TЧтh", "Пт", "Су"],
        months: ["Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"],
        monthsShort: ["Янв", "Фев", "Мар", "Апр", "Май", "Ин", "Ил", "Авг", "Сен", "Окт", "Ноя", "Дек"],
        today: "Сегодня",
        clear: "Сброс",
        format: "yyyy-mm-DD HH:ii:ss",
        titleFormat: "MM yyyy",
        weekStart: 1
    };
    */

});