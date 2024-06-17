@extends("layouts.master")


@section("content")
    <h1>Hier is een lijst met alle playlists</h1>
    <ul class="container">
        @foreach($playlists as $playlist)
            <p>{{$playlist->name}}</p>
        @endforeach
    </ul>
@endsection