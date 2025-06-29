// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.addEventListener("DOMContentLoaded", InitializeDatatable);

function InitializeDatatable() {
  const target = document.getElementById('greeting');
  target.innerHTML = "I just loaded";

  $('#deadlinesTable thead td').each(function (i) {
    //add a text om[it tp each footer cell]
    let title = $('#deadlinesTable thead td').eq($(this).index()).text();
    $(this).html('<input id="input' + i + '" "type="text" placeholder="' + title + '" data-index="' + i + '" />');
  });
  
  //Datatable
  let table = new DataTable('#deadlinesTable', {
    processing: true,
    paging: false,
    searching: false,
    autoWidth: true,
    fixedColumns: true,
    ordering: {
      indicators: false,
      handler: false
    },
    order: [[0, 'asc']],
    columnControl: ['order', ['orderAsc', 'orderDesc', 'orderAddAsc', 'orderAddDesc']]
  });

  //Filter event handler
  $(table.table().container()).on('keyup', 'thead input', function () {
    table
      .column($(this).data('index'))
      .search(this.value)
      .draw();
  });
}

function HelloWorld() {
  const target = document.getElementById('greeting');
  target.innerHTML = "Hello World!";

}