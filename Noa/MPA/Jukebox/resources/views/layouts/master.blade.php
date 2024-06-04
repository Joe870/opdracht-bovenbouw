<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="css/master.css">
    @stack("styles")
</head>
<body>
{{--   navigatiemenu--}}
<nav>
    <ul>
        <li><a href="/hello">Welkom</a></li>
        <li><a href="/genres">Genres</a></li>
        <li><a href="/songs">Songs</a></li>
    </ul>
</nav>

{{--Content--}}
@yield("content")

{{-- Footer --}} 
<footer>Jukebox 2024</footer>

{{--Js--}}
@stack("js")
</body>
</html>