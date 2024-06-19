@extends("layouts.master")


@section("content")
    <h1>Hier is een lijst met alle playlists</h1>
    <ul class="container">
        @foreach($playlists as $playlist)
            <p>{{$playlist->name}}</p> 
            @foreach($playlist->songs as $song) <p>- {{$song->name}}</p> @endforeach
        @endforeach
    </ul>
@endsection