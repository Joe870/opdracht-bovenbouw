<?php

namespace App\Listeners;

use Illuminate\Auth\Events\Login;
use Illuminate\Contracts\Queue\ShouldQueue;
use Illuminate\Queue\InteractsWithQueue;
use App\Models\Playlist;

class HandleUserLogin
{
    /**
     * Handle the event.
     *
     * @param  \Illuminate\Auth\Events\Login  $event
     * @return void
     */
    public function handle(Login $event)
    {
        // Get the user who just logged in
        $user = $event->user;

        // Retrieve temporary playlists stored in the session
        $temporaryPlaylists = session()->get('temporary_playlists', []);

        // If there are temporary playlists, move them to the database
        if (!empty($temporaryPlaylists)) {
            foreach ($temporaryPlaylists as $tempPlaylist) {
                // Save each temporary playlist into the 'playlists' table, associating it with the logged-in user
                Playlist::create([
                    'name' => $tempPlaylist['name'],
                    'description' => $tempPlaylist['description'],
                    'user_id' => $user->id,  // Associate the playlist with the logged-in user
                ]);
            }

            // Clear the temporary playlists from the session after saving them
            session()->forget('temporary_playlists');
        }
    }
}