<?php
if (isset($_GET['num'])) {
    $n = intval($_GET['num']);
    for ($i = 1; $i <= $n; $i++) {
        if ($i % 2 == 0){
            $nums[] = $i;
        }
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