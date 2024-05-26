<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "characters";

$conn = new mysqli($servername, $username, $password, $dbname);

if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}
if (isset($_GET['id'])){
    $id = $_GET['id'];
    $sql = "SELECT * FROM characters WHERE id = $id";
    $result = $conn->query($sql);
    $row = $result->fetch_assoc();
    if ($result->num_rows > 0){
    $id = $row['id'];
    $imagetype = $row['avatar'];
    $health = $row['health'];
    $attack = $row['attack'];
    $defense = $row['defense'];
    $color = $row['color'];
    $text = $row['bio'];
    $weapon = $row['weapon'];
    $armor = $row['armor'];
    $name = $row['name'];
    echo "<header><h1>$name</h1>";
    echo "<a class=backbutton href=index.php><i class=fas fa-long-arrow-alt-left></i> Terug</a></header>";
    echo "<div id=container>";
    echo "<div class=detail>";
    echo "<div class=left>";
    echo "<img class=avatar src=resources/images/$imagetype>";
    echo "<div class=stats style=background-color: yellowgreen>";
    echo "<ul class=fa-ul>";
    echo "<li><span class=fa-li><i class=fas fa-heart></i></span> 10000</li>";
    echo "<li><span class=fa-li><i class=fas fa-fist-raised></i></span> 400</li>";
    echo "<li><span class=fa-li><i class=fas fa-shield-alt></i></span> 100</li>";
    echo "</ul>";
    echo "<ul class=gear>";
    echo "<li><b>Weapon</b>: $weapon</li>";
    echo "<li><b>Armor</b>: $armor</li>";
    echo "</ul>";
    echo "</div>";
    echo "</div>";
    echo "<div class=right>";
    echo "<p>$text</p>";
    echo "</div>";
    echo "<div style=clear: both></div>";
    echo "</div>";
    echo "</div>";
    echo "<footer>&copy; [jenaam] 2023</footer>";
    } else {
        echo "Geen resultaten gevonden voor ID $id";
    }
} else {
    echo "Geen ID opgegeven";
}
//Need to use a get to know which character info you need to request
?>