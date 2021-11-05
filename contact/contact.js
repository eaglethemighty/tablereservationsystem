fetch("../header/header.html")
    .then(response => response.text())
    .then(data => document.getElementById('header').innerHTML = data);

fetch("../footer/footer.html")
    .then(response => response.text())
    .then(data => document.getElementById('footer').innerHTML = data);

function ClickLink(href) {
    location.href = href;
}