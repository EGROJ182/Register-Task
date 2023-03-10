
function Start() {
    let btnCreate = document.getElementById("BtnCreate");
    let btnDelete = document.getElementById("BtnDelete");

    btnCreate.addEventListener("click", CreateTask());
    btnDelete.addEventListener("click", DeleteTask());
}

function CreateTask() {
    let timerInterval
    Swal.fire({
        title: 'Loading!',
        html: 'I will close in <b></b> milliseconds.',
        timer: 2000,
        timerProgressBar: true,
        didOpen: () => {
            Swal.showLoading()
            const b = Swal.getHtmlContainer().querySelector('b')
            timerInterval = setInterval(() => {
                b.textContent = Swal.getTimerLeft()
            }, 100)
        },
        willClose: () => {
            clearInterval(timerInterval)
        }
    }).then((result) => {
        /* Read more about handling dismissals below */
        if (result.dismiss === Swal.DismissReason.timer) {
            console.log('I was closed by the timer')
        }
    })
}

function DeleteTask() {
    Swal.fire({
        position: 'top-center',
        icon: 'success',
        title: 'Your work has been Delete',
        showConfirmButton: false,
        timer: 500
    })
}


window.addEventListener("load", Start)
