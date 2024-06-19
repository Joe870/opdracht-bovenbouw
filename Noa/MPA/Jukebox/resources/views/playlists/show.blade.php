@extends("layouts.master")

@section("content")
    <h1>{{$playlist->name}}</h1>
    <p>{{$playlist->description}}</p>
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
@endsection