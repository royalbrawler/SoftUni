<?php
if (isset($_GET['num'])) {
    $n = intval($_GET['num']);
    for ($i = $n; $i >= 0; $i--) {
        $nums[] = $i;
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