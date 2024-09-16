@extends("layouts.master")

@section("content")
    <h1>Hier zie je jouw playlists</h1>
    <ul class="container">
        @foreach($playlists as $playlist)
            <a href="/playlist/view/{{$playlist->id}}">{{$playlist->name}}</a><br> 
        @endforeach
    </ul>
@endsection