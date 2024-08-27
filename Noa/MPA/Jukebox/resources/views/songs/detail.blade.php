@extends("layouts.master")

@section("content")
    <div class="info_block">
        <h1>Name: {{$song->name}}</h1>
        <p>Duration: {{$song->duration}}</p>
        <p>Artist: {{$song->artist}}</p>
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
    </div>
@endsection