<?php

namespace App\Http\Controllers;

use App\Models\Song;
use App\Models\playlist;
use Illuminate\Http\Request;

class PlaylistController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index(Request $request)
    {
        $playlists = Playlist::all();
        return view("playlists.index", ["playlists"=>$playlists]);
    }

    /**
     * Show the form for creating a new resource.
     */
    public function create()
    {
        return view("playlists.create");
    }

    /**
     * Store a newly created resource in storage.
     */
    public function store(Request $request)
    {
        $validated = $request->validate([
            "playlistName" => "required|string",
        ]);
        $validated = $request->validate([
            "playlistDescription" => "required|string",
        ]);
        Playlist::create([
            "name" => $request->playlistName,
            "description" => $request->playlistDescription,
        ]);
    }

    /**
     * Display the specified resource.
     */
    public function show(playlist $playlist)
    {
        $songs = Song::all();
        return view("playlists.show", ["playlist" => $playlist, "songs" => $songs]);
    }

    /**
     * Show the form for editing the specified resource.
     */
    public function edit(playlist $playlist)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     */
    public function update(Request $request, playlist $playlist)
    {
        //
    }

    /**
     * Remove the specified resource from storage.
     */
    public function destroy(playlist $playlist)
    {
        //
    }

    public function addSongToPlaylist(Request $request, playlist $playlist){
        $song = $request->selectedSong;
        $playlist->songs()->attach($song);
        return redirect()->back();
    }
}
