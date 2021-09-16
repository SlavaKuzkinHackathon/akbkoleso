
const slides = document.querySelectorAll('.slide')

for (const slide of slides) {
    slide.addEventListener('click', () => {
        clearActiveClasses()
        slide.classList.add('active')
    })
}

function clearActiveClasses() {
    slides.forEach((slide) => {
        slide.classList.remove('active')
    })
}



$(function () {
    $("#buttonA").click(function () {
        sessionStorage.clear();
    });
    $("#buttonB").click(function () {
        sessionStorage.clear();
    });
    $("#buttonC").click(function () {
        sessionStorage.clear();
    });
})


