@extends("layouts.master")


@section("content")
    <h1>Hier is een lijst met alle leidjes</h1>
    <ul class="container">
        @foreach($songs as $song)
            <li>{{$song->name}} - {{$song->genre->name}}</li>
        @endforeach
    </ul>
@endsection

@push("js")

@endpush
