<?php

use App\Http\Controllers\PlaylistController;
use App\Http\Controllers\GenreController;
use App\Http\Controllers\SongController;
use App\Http\Controllers\Welcome;
use Illuminate\Support\Facades\Route;

Route::get('/', function () {
    return view('welcome');
});

Route::get("/hello", [Welcome::class, "hello"]);

Route::get("/songs", [SongController::class, "index"]);
Route::get("/song/create", [SongController::class, "create"]);
Route::post("/song/store", [SongController::class, "store"]);
Route::get("/song/show", [SongController::class, "show"]);

Route::get("/genres", [GenreController::class, "index"]);
Route::get("/genre/create", [GenreController::class, "create"]);
Route::post("/genre/store", [GenreController::class, "store"])->name("genre.store");

Route::get("/playlists", [PlaylistController::class, "index"]);
Route::get("/playlist/create", [PlaylistController::class, "create"]);
Route::post("/playlist/store", [PlaylistController::class, "store"]);
Route::get("/playlist/view/{playlist}", [PlaylistController::class, "show"]);
Route::post("/playlist/addsong/{playlist}", [PlaylistController::class, "addSongToPlaylist"]);