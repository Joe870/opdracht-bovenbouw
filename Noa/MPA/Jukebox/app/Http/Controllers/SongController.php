<?php

namespace App\Http\Controllers;

use App\Models\Song;
use Illuminate\Http\Request;

class SongController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index()
    {
        //view
        $songs = Song::all();
        return view("songs.index", ["songs"=>$songs]);
    }

    /**
     * Show the form for creating a new resource.
     */
    public function create()
    {
        return view("songs.create");
    }

    /**
     * Store a newly created resource in storage.
     */
    public function store(Request $request)
    {
        $validated = $request->validate([
            "songName" => "required|string",
            "songDuration" => "required|integer|min:0",
            "songGenreId" => "required|integer|min:1|exists:genres,id",
            "songArtist" => "required|string|min:1"
        ]);
        Song::create([
            "name" => $request->songName,
            "duration" => $request->songDuration,
            "genre_id" => $request->songGenreId,
            "artist" => $request->songArtist
        ]);
    }

    /**
     * Display the specified resource.
     */
    public function show(Song $song)
    {
        return view("songs.detail");
    }

    /**
     * Show the form for editing the specified resource.
     */
    public function edit(Song $song)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(Request $request, Song $song)
    {
        //
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(Song $song)
    {
        //
    }
}
