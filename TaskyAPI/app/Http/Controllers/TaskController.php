<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

use App\Http\Requests;

class TaskController extends Controller
{

    public function get(){
        $Users = DB::table('tasks')->get();
        return $Users;
    }

    public function create($tasks){
        DB::table('tasks')->insert([
           $tasks
        ]);
    }

    
}
