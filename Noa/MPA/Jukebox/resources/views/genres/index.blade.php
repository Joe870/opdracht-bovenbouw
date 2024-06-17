@extends("layouts.master")

@section("content")
    <h1>Hier is een lijst met de genres</h1>
    <ul class="container">
        @foreach($genres as $genre)
            <p>{{$genre->name}} - {{$genre->songs->count()}}</p>
        @endforeach
    </ul>
@endsection