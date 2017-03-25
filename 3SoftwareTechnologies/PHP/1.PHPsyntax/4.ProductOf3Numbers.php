<?php
if (isset($_GET['num1']) && isset($_GET['num2']) && isset($_GET['num3'])) {
    $n = intval($_GET['num1']);
    $n2 = intval($_GET['num2']);
    $n3 = intval($_GET['num3']);
    if ($n * $n2 * $n3 >= 0 ){
        echo 'Positive';
    }else{
        echo 'Negative';
    }

} else {
    ?>
    <form>
        N: <input type="text" name="num1"/>
        M: <input type="text" name="num2"/>
        M2: <input type="text" name="num3"/>
        <input type="submit"/>
    </form>
    <?php
}
?>