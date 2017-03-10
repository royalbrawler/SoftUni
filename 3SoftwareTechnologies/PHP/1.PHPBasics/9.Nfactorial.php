<?php
if (isset($_GET['num'])) {
    $n = intval($_GET['num']);
    $result = 1;
    for ($i = 1; $i <= $n; $i++) {
        $result *= $i;
    }
    echo $result;

} else {
    ?>
    <form>
        N: <input type="text" name="num"/>
        <input type="submit"/>
    </form>
    <?php
}
?>