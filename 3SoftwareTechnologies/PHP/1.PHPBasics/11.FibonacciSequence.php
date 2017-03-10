<?php
if (isset($_GET['num'])) {
    $n = intval($_GET['num']);

    $nums[0] = 1;
    $nums[1] = 1;
    for ($i = 0; $i < $n - 2; ) {
        $temp = $nums[$i];
        $i++;
        $temp2 = $nums[$i];
        $nums[$i + 1] = $temp + $temp2;
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