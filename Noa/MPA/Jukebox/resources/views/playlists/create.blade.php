@extends("layouts.master")

@section("content")

<form action="/playlist/store" method="POST">
    @csrf
    <label for="name">Vul hier de playlist naam in:</label>
    <input type="text" name="playlistName">
    @error("playlistName")
    <p>{{$message}}</p>
    @enderror
    <input type="submit">
</form>
@endsection