<?php
if (isset($_GET['num1']) && isset($_GET['num2'])) {
    $n = intval($_GET['num1']);
    $n2 = intval($_GET['num2']);
    echo $n * $n2;
}else {
    ?>
    <form>
        N: <input type="text" name="num1"/>
        M: <input type="text" name="num2"/>
        <input type="submit"/>
    </form>
    <?php
}
?>