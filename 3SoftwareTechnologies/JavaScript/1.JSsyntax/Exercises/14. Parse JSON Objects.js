function solve(args) {
    let students = [];
    args.forEach(jsonString => {
        let student = JSON.parse(jsonString);
        students.push(student)
    });

    //let student = JSON.parse(args[0])
    console.log(students)
    // TODO: print in correct format but i am lazy
}

solve('{"name":"Gosho","age":10,"date":"19/06/2005"}\n{"name":"Tosho","age":11,"date":"04/04/2005"}'.split('\n'));