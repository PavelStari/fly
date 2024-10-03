let swatter = document.querySelector('.swatter')
let fly = document.querySelector('.fly')
let result = document.querySelector('.result')
let count = 0

document.addEventListener('mousemove', function (e) {
   swatter.style.left = `${+e.pageX - parseFloat(getComputedStyle(swatter).width) / 3}px`
   swatter.style.top = `${+e.pageY - parseFloat(getComputedStyle(swatter).width) / 3}px`
})

document.addEventListener('click', function(e) {
    count++
    result.innerHTML = count
    anime({
        targets: '.swatter',
        scale: [
            {value: 0.7},
            {value: 1},
        ],
        easing: 'linear',
        duration: 200,
        

    })
    anime({
        targets: '.fly',
        rotate:  1 + Math.random() * (360 - 1),
        left: 1 + Math.random() * (window.innerWidth - 50 - 1),
        top: 1 + Math.random() * (window.innerHeight - 50 - 1),

    })
})
