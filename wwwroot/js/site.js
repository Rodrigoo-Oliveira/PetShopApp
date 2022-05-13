// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var formulario = document.querySelector("#animal_formulario")
var dataNascimentoAnimal = document.querySelector("#data_nascimento_animal")


function formatDate(date) {
    var d = new Date(date),
        month = '' + (d.getMonth() + 1),
        day = '' + d.getDate(),
        year = d.getFullYear();

    if (month.length < 2)
        month = '0' + month;
    if (day.length < 2)
        day = '0' + day;

    return [year, month, day].join('-');
}


formulario.addEventListener("submit", (e) => {
    e.preventDefault();
    var dataAtual = formatDate(new Date());
    if (dataNascimentoAnimal.value <= dataAtual ) {
        formulario.submit()
    } else {
        alert("Data de nascimento invalida!");
    }
})

