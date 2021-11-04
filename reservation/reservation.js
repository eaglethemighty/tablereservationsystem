let initialPanel = document.getElementById('initial-panel');
let tablePanel = document.getElementById('table-panel');

fetch("../header/header.html")
    .then(response => response.text())
    .then(data => document.querySelector("header").innerHTML = data);

fetch("../footer/footer.html")
    .then(response => response.text())
    .then(data => document.querySelector("footer").innerHTML = data);

fetch("../reservation/initial-panel.html")
    .then(response => response.text())
    .then(data => initialPanel.innerHTML = data);

function renderTableList() {
    fetch("../reservation/table-list.html")
        .then(response => response.text())
        .then(data => tablePanel.innerHTML = data);
}

function renderTableDetail() {
    fetch("../reservation/table-detail.html")
        .then(response => response.text())
        .then(data => tablePanel.innerHTML = data);
    document.getElementById("back-btn").object.addEventListener("click", renderTableList);
}

function ClickLink(href) {
    location.href = href;
}