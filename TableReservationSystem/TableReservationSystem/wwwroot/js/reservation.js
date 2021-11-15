let initialPanel = document.getElementById('initial-panel');
let tablePanel = document.getElementById('table-panel');
var first = true;

fetch("../header/header.html")
    .then(response => response.text())
    .then(data => document.getElementById('header').innerHTML = data);

fetch("../footer/footer.html")
    .then(response => response.text())
    .then(data => document.getElementById('footer').innerHTML = data);

fetch("initial-panel.html")
    .then(response => response.text())
    .then(data => initialPanel.innerHTML = data)
    .then(() => this.loadInitialPanel());

function renderTableList() {
    fetch("../reservation/table-list.html")
        .then(response => response.text())
        .then(data => tablePanel.innerHTML = data)
        .then(() => this.loadTableList());
}
function renderTableDetail() {
    fetch("../reservation/table-detail.html")
        .then(response => response.text())
        .then(data => tablePanel.innerHTML = data)
        .then(() => this.loadTableDetail());
}

function ClickLink(href) {
    location.href = href;
}

function loadInitialPanel() {
    let carousel_items = document.querySelectorAll('.carousel .carousel-item')

    carousel_items.forEach((el) => {
        const minPerSlide = 12;
        let next = el.nextElementSibling
        for (var i = 1; i < minPerSlide; i++) {
            if (!next) {
                next = carousel_items[0]
            }
            let cloneChild = next.cloneNode(true)
            el.appendChild(cloneChild.children[0])
            next = next.nextElementSibling
        }
    })
}

function loadTableList() {
    var margin = convertRemToPixels(1);
    window.scroll(0, getYPos(document.getElementById("table-list-start")) - getHeaderHeight() - margin);
}

function loadTableDetail() {
    'use strict'

    // Fetch all the forms we want to apply custom Bootstrap validation styles to
    var forms = document.querySelectorAll('.needs-validation')

    // Loop over them and prevent submission
    Array.prototype.slice.call(forms)
        .forEach(function (form) {
            form.addEventListener('submit', function (event) {
                if (!form.checkValidity()) {
                    event.preventDefault()
                    event.stopPropagation()
                }

                form.classList.add('was-validated')
            }, false)
        })

    var margin = convertRemToPixels(1);
    window.scroll(0, getYPos(document.getElementById("table-detail-start")) - getHeaderHeight() - margin);
}

function getYPos(obj) {
    var bodyRect = document.body.getBoundingClientRect(),
        elemRect = obj.getBoundingClientRect(),
        offset = elemRect.top - bodyRect.top;

    return [offset];
}

function getHeaderHeight() {
    return [document.getElementById('top-navbar').offsetHeight];
}

function convertRemToPixels(rem) {
    return rem * parseFloat(getComputedStyle(document.documentElement).fontSize);
}