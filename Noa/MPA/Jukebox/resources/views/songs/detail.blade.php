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

        @if(Auth::check())
            <form action="/song/addplaylist/{{$song->id}}" method="POST">
                @csrf
                <select name="selectedPlaylist">
                    <option value="{{$playlist->id}}">{{$playlist->name}}</option>
                </select>
                <input type="submit" value="Add to playlist">
            </form>
        @else
            @if(session('temporary_playlists'))
                <form action="/song/addtemporaryPlaylist/{{$song->id}}" method="POST">
                    @csrf
                    <select name="selectedPlaylist">
                        <option value="{{$playlist->name}}">{{$temporaryPlaylist->name}}</option>
                    </select>
                    <input type="submit" value="Add to temporary playlist">
                </form>
            @endif
        @endif
    </div>
@endsection