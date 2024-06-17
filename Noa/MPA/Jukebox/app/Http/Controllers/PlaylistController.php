<?php

namespace App\Http\Controllers;

use App\Models\playlist;
use Illuminate\Http\Request;

class PlaylistController extends Controller
{
    /**
     * Display a listing of the resource.
     */
    public function index()
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
        Playlist::create([
            "name" => $request->playlistName,
        ]);
    }

    /**
     * Display the specified resource.
     */
    public function show(playlist $playlist)
    {
        //
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
}
