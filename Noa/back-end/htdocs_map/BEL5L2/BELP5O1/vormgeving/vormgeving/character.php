<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "characters";

$conn = new mysqli($servername, $username, $password, $dbname);

if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

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
    }
}
//Need to use a get to know which character info you need to request
?>