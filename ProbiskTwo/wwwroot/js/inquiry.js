var dataTable;

$(document).ready(function () {
    loadDataTable("GetInquiryList") // name of action method GetInquiryList
});



function loadDataTable(url) { // id is in the index view
    dataTable = $("#tblData").DataTable({
        "ajax": {
            "url": "/inquiry/" + url
        },
        "columns": [
            { "data": "id", "width": "5%" },
            { "data": "fullName", "width": "10%" },
            { "data": "phoneNumber", "width": "10%" },
            { "data": "email", "width": "15%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                        <div class="text-center">
                            <a href="/Inquiry/Details/${data}" class="btn text-success" style="cursor:pointer">
                                <i class="fas fa-edit"></i>
                            </a>
                        </div>
                    `;
                }, "width": "5%"
            }
        ]
    });
}