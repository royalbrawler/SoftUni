function solve(args) {
    let studentData = args
        .map(studensString => studensString.split(' -> '));

    let student = {};
    studentData.forEach(tokens => {
        let key = tokens[0];
        let value = tokens[1];

        //if (key === 'age' || key === 'grade') {
        if (['age', 'grade'].includes(key)) {
            value = Number(value)
        }

        student[key] = value
    });

    //console.log(student)
    console.log(JSON.stringify(student))
}

solve('name -> Angel\nsurname -> Georgiev\nage -> 20\ngrade -> 6.00\ndate -> 23/05/1995\ntown -> Sofia'.split('\n'));