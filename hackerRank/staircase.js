

function staircase(n) {
    // Write your code here
    let output = "#";
    for(let i = n; i > 0; i--){
        let step = output.padStart(n);
        console.log(step);
        output += "#";
    }
}

staircase(4);