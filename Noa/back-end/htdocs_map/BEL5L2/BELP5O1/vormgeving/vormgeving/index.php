<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "characters";

$conn = new mysqli($servername, $username, $password, $dbname);

if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

$sql = "SELECT COUNT(*)as count FROM characters";
$result = $conn->query($sql);

$count = 0;

if ($result->num_rows > 0) {
    $row = $result->fetch_assoc();
    $count = $row['count'];
} else {
    echo "0 results";
}

?>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>All characters</title>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.2/css/all.css" integrity="sha384-fnmOCqbTlWIlj8LyTjo7mOUStjsKC4pOpQbqyi7RrhN7udi9RwhKkMHpvLbHG9Sr" crossorigin="anonymous">
    <link href="resources/css/style.css" rel="stylesheet"/>
</head>
<body>
    <header>
        <?php echo "<h1>Alle {$count} characters uit de database.</h1>"; ?>
    </header>
    <?php

    $sql = "SELECT * FROM characters ORDER BY name asc";
    $result = $conn->query($sql);

    if ($result->num_rows > 0) {
        while ($row = $result->fetch_assoc()) {
            $imagetype = $row['avatar'];
            $id = $row['id'];
            $name = $row['name'];
            $health = $row['health'];
            $attack = $row['attack'];
            $defense = $row['defense'];
            $link = "";
            echo "<div id=container>";
            echo "<a class=item href= character.php?id=$id>";
            echo "<div class=left>";
            echo "<img class=avatar src=resources/images/$imagetype>";
            echo "</div>";
            echo "<div class=right>";
            echo "<h2>$name</h2>";
            echo "<div class=stats>";
            echo "<ul class=fa-ul>";
            echo "<li><span class=fa-li><i class=fas fa-heart></i></span> $health</li>";
            echo "<li><span class=fa-li><i class=fas fa-fist-raised></i></span> $attack</li>";
            echo "<li><span class=fa-li><i class=fas fa-shield-alt></i></span> $defense</li>";
            echo "</ul>";
            echo "</div>";
            echo "</div>";
            echo "<div class=detailButton><i class=fas fa-search></i> bekijk</div>";
            echo "</a>";
            echo "</div>";
        }
    }
    ?>
    <footer>&copy; [jenaam] 2023</footer>
</body>
</html>