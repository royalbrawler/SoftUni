<?php
if (isset($_GET['num'])) {
    $n = intval($_GET['num']);

    $nums[0] = 1;
    $nums[1] = 1;
    $nums[2] = 2;
    for ($i = 0; $i < $n - 3; $i++) {
        $temp = $nums[$i];
        $temp2 = $nums[$i + 1];
        $temp3 = $nums[$i + 2];
        $nums[$i + 3] = $temp + $temp2 + $temp3;
    }
    echo implode(" ", $nums);

} else {
    ?>
    <form>
        N: <input type="text" name="num"/>
        <input type="submit"/>
    </form>
    <?php
}
?>