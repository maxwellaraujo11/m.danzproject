// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const form = document.getElementById('form')
const nome = document.getElementById('nome')
const email = document.getElementById('email')
const login = document.getElementById('login')
const senha = document.getElementById('senha')

//--------------------------------------------------------------------------------------//


form.addEventListener('submit', (e) => {
    e.preventDefault()

    checkInputs()
})

function checkInputs () {
    const nomeValue = nome.value.trim()
    const emailValue = email.value.trim()
    const telefoneValue = telefone.value.trim()

    if(nomeValue === "") {
        errorValidation(nome, ' *Campo obrigatorio!')
    } else {
       successValidation(nome)
    }

    if(emailValue === '') {
        errorValidation(email, '*Campo obrigatorio!')
    } else {
       successValidation(email)
    }

    if(telefoneValue === '') {
        errorValidation(login, '*Campo obrigatorio!')
    } else {
       successValidation(login)
    }
    
    if(telefoneValue === '') {
        errorValidation(senha, '*Campo obrigatorio!')
    } else {
       successValidation(senha)
    }
}

function errorValidation(input, message) {
    const formControl = input.parentElement;
    const small = formControl.querySelector('small')

    small.innerText = message

    formControl.className = 'form-control img-error'
}

function successValidation(input) {
    const formControl = input.parentElement;

    formControl.className = 'form-control img-success' 
}
