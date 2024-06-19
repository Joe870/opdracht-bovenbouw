@extends("layouts.master")

@section("content")
    <h1>Hier is een lijst met alle leidjes</h1>
    <ul class="container">
        @foreach($songs as $song)
            <p>{{$song->name}} - {{$song->genre->name}}</p>
            <a href="/song/show">details</a>
        @endforeach
    </ul>
@endsection

@push("js")

@endpush
