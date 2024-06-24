@extends("layouts.master")

@section("content")
    <h1>{{$song->name}}</h1>
    <p>{{$song->duration}}</p>
    <p>{{$song->artist}}</p>
    @foreach($playlists as $playlist)
        -{{$playlist->name}}
        <br>
    @endforeach

    <form action="/song/addplaylist/{{$song->id}}" method="POST">
        @csrf
        <select name="selectedPlaylist">
            @foreach($playlists as $playlist)
                <option value="{{$playlist->id}}">{{$playlist->name}}</option>
            @endforeach
        </select>
        <input type="submit" value="Add to playlist">
    </form>
@endsection