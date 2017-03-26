function solve(args) {
    let obj = {};

    for (let arg of args.slice(0, args.length - 1)) { // slice - dont get last index element
        let tokens = arg.split(' ');

        let key = tokens[0];
        let value = tokens[1];

        if (obj[key]) {
            obj[key].push(value);
        } else {
            obj[key] = [value];
        }
    }
    let resultKey = args[args.length - 1];

    console.log(obj[resultKey] ? obj[resultKey].join('\n') : "None");
}