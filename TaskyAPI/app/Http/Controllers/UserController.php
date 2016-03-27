<?php
namespace App\Http\Controllers;

use App\User;
use App\Http\Controllers\Controller;
use DB;
//use Carbon\Carbon;

class UserController extends Controller{

    //User $users;
    public function index(){
        $Users = DB::table('users')->get();
        return $Users;
    }


}
