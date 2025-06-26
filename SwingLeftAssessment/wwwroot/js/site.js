// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.addEventListener("DOMContentLoaded", InitializeDatatable);

function InitializeDatatable() {
  const target = document.getElementById('greeting');
  target.innerHTML = "I just loaded";
  let table = new DataTable('#deadlinesTable', {
    paging: false,
    searching: false,
    ordering: true
  });

  
}
function HelloWorld() {
  const target = document.getElementById('greeting');
  target.innerHTML = "Hello World!"   
}