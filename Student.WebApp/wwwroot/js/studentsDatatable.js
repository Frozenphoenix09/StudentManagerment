$(document).ready(function () {
	$('#studentTable').dataTable({
		"processing": true,
		"serverSide": true,
		"filter": true,
		"ajax": {
			"url": "/student/getstudents",
			"type": "POST",
			"datatype": "json"
		},
		"columnDefs": [{
			"targets": [0],
			"visible": false,
			"searchable": false
		}],
		"columns": [
			{ "data": "studentId" },
			{ "data": "name", "name": "Name" },
			{
				"render": function (data, type, row) { return '<span>' + row.dateOfBirth.split('T')[0] + '</span>' },
				"name": "DateOfBirth"
			},
			{ "data": "address", "name": "Address" },
			{ "data": "studentClasses[</br>]" },
			{
				"render": function (data, type, row) { return '<a href=# class="btn btn-primary" onclick=AddToClass("' + row.studentId + '");>Add To Class</a>' + " " + '<a href=# class="btn btn-danger" onclick=Delete("' + row.studentId + '");>Delete</a>' },
				"orderable": false,
				"autowidth": true
			}
		]
	});
});
function PopupForm(url) {
	var formDiv = $('<div/>');
	$.get(url)
		.done(function (response) {
			formDiv.html(response);
			var Popup = formDiv.dialog({
				autoOpen: true,
				resizable: false,
				title: 'Fill Employee Details',
				height: 500,
				width: 700,
				close: function () {
					Popup.dialog('destroy').remove();
				}
			});
		});
}