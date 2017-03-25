function solve(nums) {
    let num = Number(nums[0]);
    let x = Number(nums[1]);

    let result;
    if (x >= num) {
        result = num * x;
    } else {
        result = num / x;
    }
    console.log(result)
}