function test(){
    let carousel_items = document.querySelectorAll('.carousel .carousel-item')
    
    carousel_items.forEach((el) => {
        const minPerSlide = 6;
        let next = el.nextElementSibling
        for (var i=1; i<minPerSlide; i++) {
            if (!next) {
                next = carousel_items[0]
              }
            let cloneChild = next.cloneNode(true)
            el.appendChild(cloneChild.children[0])
            next = next.nextElementSibling
        }
    })

};
