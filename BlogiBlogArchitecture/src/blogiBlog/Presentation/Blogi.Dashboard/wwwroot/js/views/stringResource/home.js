﻿(function () {
    $("#stringResourceTable").DataTable({
        "ajax": {
            "type": "GET",
            "url": "/StringResource/DataTable"
        },       
        "pageLength": 20,
        "bInfo": true,
        "responsive": true,
        "scrollY": false,
        "bPaginate": true,
        "dom": 'Bfrtip',
        "buttons": [
            'copy', 'csv', 'excel', 'pdf', 'print'
        ],
        "columns": [
            {
                "data": "language", "autoWidth": true
            },
            {
                "data": "key", "autoWidth": true
            },
            {
                "data": "value", "autoWidth": true
            },
            {
                "data": "id",
                "autoWidth": true,
                "render": function (val) {
                    return '<a href="/StringResource/Edit?id=' + val + '"  class="btn btn-rounded btn-warning">Update <i class="mdi mdi-upload ml-2"></i></a>';

                }
            },
            {
                "data": "id",
                "autoWidth": true,
                "render": function (val) {
                    return '<button data-model-id="' + val + '" onclick="Delete(this)" class="btn btn-rounded btn-danger">Delete <i class="mdi mdi-delete-sweep ml-2"></i></button>';

                }
            }
        ]
    });
})();


function Delete(obj) {
    var ele = $(obj);
    var Id = ele.data("model-id");

    Swal.fire({
        title: 'Are sure wants to delete?',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: '/StringResource/Delete',
                type: "POST",
                async: true,
                data: { id: Id },
                success: function (result) {

                    if (result.data.success)
                        toastr["success"](result.data.message, "BLOGI BLOG");
                    else
                        toastr["error"](result.data.errors, "BLOGI BLOG");

                    $('#stringResourceTable').DataTable().ajax.reload();

                }
            });
        }
    })
};
