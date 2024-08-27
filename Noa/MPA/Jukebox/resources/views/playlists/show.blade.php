@extends("layouts.master")

@section("content")
    <div class="info_block">
        <h1>Name: {{$playlist->name}}</h1>
        <p>Description: {{$playlist->description}}</p>
        <p>Playlist songs:</p>
        @foreach($playlist->songs as $song)
            -{{$song->name}}
            <br>
        @endforeach

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