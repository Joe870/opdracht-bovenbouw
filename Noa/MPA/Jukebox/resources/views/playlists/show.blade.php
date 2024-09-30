@extends("layouts.master")

<?php
$playlistDuration = 0;
foreach($playlist->songs as $song)
{
    $playlistDuration += $song->duration;
}
?>
@section("content")
    <div class="info_block">
        <h1>Name: {{$playlist->name}}</h1>
        <p>Description: {{$playlist->description}}</p>
        <p>Playlist songs:</p>
        @foreach($playlist->songs as $song)
            -{{$song->name}}
            <br>
        @endforeach
        <p>Playlist Duration: {{$playlistDuration}}</p>

        <form action="/playlist/addsong/{{$playlist->id}}" method="POST">
            @csrf
            <select name="selectedSong">
                @foreach($songs as $song)
                    <option value="{{$song->id}}">{{$song->name}}</option>
                @endforeach
            </select>
            <input type="submit" value="Add to playlist">
        </form>
    </div>
@endsection