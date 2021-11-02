fetch("../header/header.html")
    .then(response => response.text())
    .then(data => document.querySelector("header").innerHTML = data);

function ClickLink(href) {
    location.href = href;
}