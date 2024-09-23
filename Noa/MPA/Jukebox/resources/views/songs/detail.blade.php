@extends("layouts.master")

@section("content")
    <div class="info_block">
        <h1>Name: {{$song->name}}</h1>
        <p>Duration: {{$song->duration}}</p>
        <p>Artist: {{$song->artist}}</p>
        
        @if(Auth::check())
            <!-- Form to add song to a permanent playlist -->
            <form action="/song/addplaylist/{{$song->id}}" method="POST">
                @csrf
                <select name="selectedPlaylist">
                    <!-- Loop through the authenticated user's playlists -->
                    @foreach($playlists as $playlist)
                        <option value="{{$playlist->id}}">{{$playlist->name}}</option>
                    @endforeach
                </select>
                <input type="submit" value="Add to playlist">
            </form>
        @else
            <!-- If there are temporary playlists stored in the session -->
            @if(session('temporary_playlists'))
                <form action="/song/addplaylist/{{$song->id}}" method="POST">
                    @csrf
                    <select name="selectedPlaylist">
                        <!-- Loop through the temporary playlists stored in session -->
                        @foreach(session('temporary_playlists') as $temporaryPlaylist)
                            <option value="{{$temporaryPlaylist['name']}}">{{$temporaryPlaylist['name']}}</option>
                        @endforeach
                    </select>
                    <input type="submit" value="Add to temporary playlist">
                </form>
            @endif
        @endif
    </div>
@endsection
