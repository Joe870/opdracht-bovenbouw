@extends("layouts.master")
@section("content")
<form action="/song/store" method="POST">
    @csrf
    <label for="name">Vul hier de song naam in:</label>
    <input type="text" name="songName"><br>
    <label for="duration">Vul hier de duratie in seconden in:</label>
    <input type="int" name="songDuration"><br>
    <label for="genre_id">Vul hier de genre_id in:</label>
    <input type="int" name="songGenreId"><br>
    <input type="submit">
</form>
@endsection