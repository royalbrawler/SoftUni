function solve(nums) {
    let count = 0;
    for (var a = 0; a < 3; a++) {
        if (nums[a] == 0) {
            return console.log('Negative')
        }
        if (nums[a] < 0) {
            count += 1;
        }
    }

    if (count % 2 == 0 || count == 0) {
        console.log('Positive')
    } else {
        console.log('Negative')
    }
}
solve(['5', '4', '3'])