<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
    <style>
        div {
            display: inline-block;
            margin: 5px;
            width: 20px;
            height: 20px;
        }
        
        @keyframes shadesOfGray {
            from {opacity: 0;}
            to {opacity: 1;}
        }
    </style>
</head>
<body>
<?php
$shade = 0;
for ($row = 0; $row < 5; $row++) {
    for ($col = 0; $col < 10; $col++) {

        echo "<div style='background-color: rgb($shade,$shade,$shade); animation: shadesOfGray 1s'></div>";
        $shade+= 5;
    }
    $shade++;
    echo "<br>";
}

?>
</body>
</html>