
//Initialize datatable after content load, or it doesn't work
document.addEventListener("DOMContentLoaded", InitializeDatatable);

function InitializeDatatable() {

    //set up filtering row
  $('#deadlinesTable thead tr.filterRow td').each(function (i) {
    let title = $('#deadlinesTable thead tr.filterRow td').eq($(this).index()).text();
    $(this).html('<input type=text placeholder="' + title + '" data-index="' + i + '" />');
  });
  
  //add datatable funcitonality to deadlinesTable
  //paging is false because this data only has 50 rows,
  //otherwise, the paging feature of datatables is pretty nice
  let table = new DataTable('#deadlinesTable', {
    processing: true,
    paging: false,
    layout: {
      topEnd: null
    },
    autoWidth: true,
    ordering: {
      indicators: false,
      handler: false
    },
    order: [[0, 'asc']],
    //columnControl sets the options for what kind of sorting is allowed
    //'orderAddAsc and orderAddDesc allow for sorting by one column
    //then doing a secondary sort with another column
    columnControl: ['order', ['orderAsc', 'orderDesc', 'orderAddAsc', 'orderAddDesc']]
  });

  //Filter event handler
  //Note: this could be change to a dropdown list. I chose a searchable
  //filter because it also allowed nice filtering on the content of description.
  $(table.table().container()).on('keyup', 'thead input', function () {
    table
      .column($(this).data('index'))
      .search(this.value)
      .draw();
  });
}
