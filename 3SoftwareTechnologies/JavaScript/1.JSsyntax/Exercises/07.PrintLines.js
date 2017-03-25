function solve(input) {
    for (let a = 0; a < input.length; a++) {
        if (input[a] == "Stop"){
            break
        }else {
            console.log(input[a])
        }
    }
}
solve(['asd', 'asda', 'Stop'])